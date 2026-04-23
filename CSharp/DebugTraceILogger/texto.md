# Debug vs Trace

Ambas as classes pertencem a `System.Diagnostics`.

## Debug
Usado para monitorar a saúde do código durante o desenvolvimento, é executada apenas em Debug, ou seja, em release é ignorado pelo compilador.

## Trace
Executada em Debug e Release, é usada para monitorar a saúde.

Pode ser "escutado" por listeners:

```csharp
using System.Diagnostics;

// 1. Criar o ouvinte (o destino do log)
TextWriterTraceListener meuLog = new TextWriterTraceListener("meu_arquivo_log.txt");

// 2. Adicionar à coleção de ouvintes do sistema
Trace.Listeners.Add(meuLog);

// 3. Escrever a mensagem
Trace.WriteLine($"{DateTime.Now}: Sistema iniciado.");
Trace.Flush(); // Força a escrita no arquivo físico
```

# ILogger, o jeito moderno
ILogger faz parte do pacote `Microsoft.Extensions.Logging`. Pode ser injetado via DI.

```csharp
public class PedidoService
{
    private readonly ILogger<PedidoService> _logger;

    public PedidoService(ILogger<PedidoService> logger)
    {
        _logger = logger;
    }

    public void Processar(int pedidoId)
    {
        // Log Estruturado: O .NET entende que 'pedidoId' é uma propriedade
        _logger.LogInformation("Processando pedido {PedidoId} às {Horario}", pedidoId, DateTime.UtcNow);
    }
}
```