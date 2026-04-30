# Throw if null
O método `ThrowIfNull` é uma maneira conveniente de lançar uma exceção `ArgumentNullException` quando um argumento é nulo. Ele é parte da classe `System.ArgumentNullException` e pode ser usado para validar argumentos em métodos, garantindo que eles não sejam nulos antes de prosseguir com a execução do código.

Aqui está um exemplo de como usar `ThrowIfNull`:

```csharp
public void ProcessData(string data)
{
    // Valida se o argumento é nulo
    ArgumentNullException.ThrowIfNull(data, nameof(data));

    // Continuação do processamento dos dados
    Console.WriteLine($"Processando: {data}");
}
```