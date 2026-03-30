# Try, catch, finally e catch when

Em c#, o bloco `try` é usado para envolver código que pode lançar exceções. O bloco `catch` é usado para capturar e tratar essas exceções, enquanto o bloco `finally` é executado independentemente de uma exceção ter sido lançada ou não, geralmente para liberar recursos.

````csharp
try
{
    // Código que pode lançar uma exceção
}
catch (Exception ex)
{
    // Código para tratar a exceção
}
finally
{
    // Código que será executado sempre, mesmo se uma exceção for lançada
}
````

## Ordem de captura de exceções
As exceções são capturadas na ordem em que são lançadas. Se uma exceção for lançada dentro do bloco `try`, o controle é transferido para o primeiro bloco `catch` que corresponda ao tipo da exceção. Se não houver um bloco `catch` correspondente, a exceção será propagada para o nível superior.

## Catch when
O `catch when` é uma extensão do bloco `catch` que permite adicionar uma condição para capturar a exceção. Ele é útil para filtrar exceções com base em critérios específicos. Por exemplo:
```csharp
try
{
    // Código que pode lançar uma exceção
}
catch (Exception ex) when (ex.Message.Contains("specific error"))
{
    // Código para tratar a exceção apenas se a mensagem contiver "specific error"
}
```