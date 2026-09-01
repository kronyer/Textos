# Pensando em DDD

Pelo que tenho compreendido, o jeito mais correto de se fazer um projeto que segue o DDD com Clean Architecture é:

## Cenário A - Services

Usando services, é simples de compreender o projeto.

### Domain

Aqui ficam as entidades, com o domínio rico, a entidade tem seus métodos (sempre no passado, nao executa de fato uma ação). Também ficam os Domain Services, que são métodos iguais aos das entidades, mas que nao dizem respeito a especifcamente uma entidade, como transferencia bancaria entre contas, que nao é uma responsabilidade da Conta, portanto exige um Domain Service para isso.

Geralmente Domain Services nao precisam de interface.

Aqui também ficam as interfaces de repository

Por fim, domain events, que exige uma seção separada, mas permite que "eventos" registrados em domínio sejam publicados (por um handler, ou pelo service), e que seja consumido por quem se interessa. Isso evita um código completamente declarativo:

#### **Exemplo 1:**

- Obter cliente
- Criar pedido
- Reservar itens
- Enviar o email

#### **Exemplo 2 - Com events**

- Obter Cliente
- Criar pedido (publica evento de reservar itens, publica evento de enviar email)
- Publicar eventos
- Agora é o listener que faz

#### Exemplo

```cs
public class PedidoAppService
{
    private readonly IPedidoRepository _pedidoRepository;
    private readonly IEventDispatcher _eventDispatcher; // só isso muda

    public async Task<PedidoDTO> Criar(CriarPedidoCommand cmd)
    {
        var cliente = await _clienteRepository.ObterPorId(cmd.ClienteId);
        var pedido = Pedido.Criar(cliente, cmd.Itens); // registra PedidoCriadoEvent internamente

        await _pedidoRepository.Adicionar(pedido);
        await _eventDispatcher.Publicar(pedido.Eventos); // dispara aqui

        return PedidoMapper.ParaDTO(pedido);
    }

    public async Task Cancelar(Guid pedidoId)
    {
        var pedido = await _pedidoRepository.ObterPorId(pedidoId);
        pedido.Cancelar(); // registra PedidoCanceladoEvent

        await _pedidoRepository.Atualizar(pedido);
        await _eventDispatcher.Publicar(pedido.Eventos);
    }
}
```

#### Listener

```cs
public class EstoqueListener : IEventListener<PedidoCriadoEvent>
{
    public async Task Reagir(PedidoCriadoEvent evento)
    {
        await _estoqueService.Reservar(evento.PedidoId);
    }
}

public class EmailListener : IEventListener<PedidoCriadoEvent>
{
    public async Task Reagir(PedidoCriadoEvent evento)
    {
        await _emailService.EnviarConfirmacao(evento.ClienteId);
    }
}
```

#### O ponto central

"Handler" é só o nome que o MediatR dá pra "coisa que reage a algo". A ideia de Domain Event — desacoplar quem causa o fato de quem reage a ele — existe independente de você usar Command/Handler, Application Service, MediatR, eventos nativos do C#, ou uma fila externa (RabbitMQ/Kafka).

Quando realmente vale a pena, mesmo em cenário de Service
Você tem múltiplas reações a uma mesma ação (email + estoque + auditoria) e não quer que PedidoAppService.Criar cresça toda vez que alguém precisa adicionar mais uma reação.
Você quer que o Pedido (entidade) permaneça dono da decisão de quando algo relevante aconteceu, mesmo que o mecanismo de publicação seja simples.

Se seu caso de uso tem só uma consequência, direta e simples (ex: Criar() só precisa salvar, nada mais), aí Domain Event é over-engineering — só chama o método direto no service e segue a vida. Event só compensa quando tem desacoplamento real a ganhar.

### Application

Em application ficam os application services, os que são responsaveis por, geralmente, a partir de um controller, orquestrar repository e dominio para realizar uma acao (tendem a crescer muito).

Aqui também ficam os EventHandlers (listeners do domínio)

### Infrastructrure

Aqui ficam as implementações das interfaces de repositório (que estão em domain). Entre outras classes e serviços de infraestrutura - enviar email, etc

### Cenário B - CQRS

### Estrutura de pastas

```bash
src/
├── Domain/
│   ├── Entities/
│   │   └── Pedido.cs
│   ├── ValueObjects/
│   ├── Services/                    ← Domain Services aqui
│   │   └── TransferenciaService.cs
│   ├── Events/                      ← Domain Events aqui
│   │   └── PedidoCriadoEvent.cs
│   ├── Interfaces/
│   │   ├── IPedidoRepository.cs     ← interface de repositório (contrato)
│   │   └── ITransferenciaService.cs ← se decidir usar interface
│   └── Exceptions/
│
├── Application/
│   ├── Pedidos/
│   │   ├── CriarPedido/
│   │   │   ├── CriarPedidoCommand.cs   ← Command aqui
│   │   │   └── CriarPedidoHandler.cs   ← Handler aqui
│   │   ├── CancelarPedido/
│   │   │   ├── CancelarPedidoCommand.cs
│   │   │   └── CancelarPedidoHandler.cs
│   │   └── Queries/
│   │       ├── ObterPedidoPorIdQuery.cs   ← Query aqui
│   │       └── ObterPedidoPorIdHandler.cs
│   └── EventHandlers/               ← handlers que reagem a Domain Events
│       ├── EnviarEmailConfirmacaoHandler.cs
│       └── ReservarEstoqueHandler.cs
│
├── Infrastructure/
│   ├── Repositories/
│   │   └── PedidoRepository.cs      ← implementação do IPedidoRepository
│   └── ...
│
└── API/ (ou Presentation)
    └── Controllers/
```

- Nao temos services (pelo menos não application services), que tendem a virarem god classes. Usamos CQRS, onde cada método é Command ou Query (que ficam)

### Domain

Mesma coisa

### Application

Aqui é o coração da diferença.

Ao invés de services, seguimos vertical slice architecture. Isso é, temos uma pasta, e dentro dela, commands e queries.

Commands são ações de escrita, queries são de leitura. Na verdade, esses são apenas assinaturas do método, um DTO.

Junto com eles, ficam os handlers, que são os responsaveis por executar esse Command ou Query.

### Ponto importante

Nas queries do CQRS, muitas vezes é mais interessante fazer um acesso direto ao banco com dapper, para que a entidade nao tenha que ser carregada na memória. Isso é, mapeamos direto do SQL para o DTO:

```cs
public class ListarPedidosDoClienteHandler : IRequestHandler<ListarPedidosDoClienteQuery, List<PedidoResumoDTO>>
{
    private readonly IDbConnection _connection; // acesso direto, sem passar pelo agregado

    public async Task<List<PedidoResumoDTO>> Handle(ListarPedidosDoClienteQuery query, CancellationToken ct)
    {
        return (await _connection.QueryAsync<PedidoResumoDTO>(
            "SELECT Id, Status, Total FROM Pedidos WHERE ClienteId = @ClienteId",
            new { query.ClienteId })).ToList();
    }
}
```