# Pattern matching com objetos
O pattern matching em C# é uma funcionalidade poderosa que permite verificar se um objeto corresponde a um determinado padrão. 

## Property patterns
Podemos usar o pattern matching para verificar se um objeto possui certas propriedades com valores específicos:

```csharp
public record Colaborador(string Nome, string Cargo, int AnosDeEmpresa);

object pessoa = new Colaborador("Ana", "Dev", 5);

if (pessoa is Colaborador { Cargo: "Dev", AnosDeEmpresa: >= 5 } devSenior)
{
    Console.WriteLine($"{devSenior.Nome} é um desenvolvedor experiente.");
}
```

## Switch expressions com objetos
Também podemos usar switch expressions para realizar diferentes ações com base no tipo e nas propriedades de um objeto:

```csharp
decimal desconto = pessoa switch
{
    Colaborador { Cargo: "Gerente" } => 0.20m,
    Colaborador { AnosDeEmpresa: > 10 } => 0.15m,
    Colaborador { Cargo: "Estagiario" } => 0.05m,
    _ => 0.02m // O "discard" funciona como o default
};
```

## Padroes Relacionais e lógicos
Podemos combinar padrões usando operadores lógicos:
```csharp
if (pessoa is Colaborador { AnosDeEmpresa: > 1 and < 5 })
{
    Console.WriteLine("Está na fase de crescimento.");
}

if (pessoa is not Colaborador)
{
    Console.WriteLine("Não é um funcionário.");
}
```

## Padrões posicionais
Podemos usar padrões posicionais para verificar os valores de um objeto com base na ordem dos parâmetros:
```csharp
// Usando a posição das propriedades do Record definido acima:
if (pessoa is Colaborador("Ana", _, var anos))
{
    Console.WriteLine($"A Ana tem {anos} anos de casa.");
}
```