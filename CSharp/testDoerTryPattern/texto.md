# Test-Doer e Try Pattern

Em C# há duas maneiras clássicas para lidar com operações que podem falhar: o padrão Try e o padrão Test-Doer.

## Test-Doer Pattern
Nesse padrão, a operação é dividida em duas partes: um método de teste (Test) que verifica se a operação pode ser realizada, e um método de execução (Doer) que realiza a operação se o teste for bem-sucedido.

```csharp
public class Operation
{
    private bool CanExecute()
    {
        // Lógica para verificar se a operação pode ser executada
        return true; // ou false dependendo da lógica
    }
    public void Execute()
    {
        if (!CanExecute())
        {
            throw new InvalidOperationException("A operação não pode ser executada.");
        }
        
        // Lógica para executar a operação
    }
}
```

Ou em um cenário mais simples:

```csharp
public class Repository
{
    private bool ItemExists(int id)
    {
        // Lógica para verificar se o item existe
        return true; // ou false dependendo da lógica
    }

    public bool Delete(int id)
    {
        // Lógica para deletar o item
        return true; // Operação bem-sucedida
    }
}
```
Que seria usado assim:

```csharp
var repository = new Repository();
if (repository.ItemExists(1)) //test
{
    repository.Delete(1); //doer
}
```

## Try Pattern
O padrão Try é uma abordagem onde um método tenta realizar uma operação e encapsula o teste e a execução em uma única chamada atômica para o chamador. Ele retorna um valor (geralmente bool) indicando o sucesso, evitando o uso de exceções para controle de fluxo.


```csharp
public class Repository
{

   public void Delete(int id)
    {
        var item = _db.Find(id);
        if (item == null) throw new KeyNotFoundException(); // Explode se falhar
        _db.Remove(item);
    }

    // O padrão Try foca na resiliência e fluidez
    public bool TryDelete(int id)
    {
        var item = _db.Find(id);
        if (item == null) return false; // Falha silenciosa e esperada

        _db.Remove(item);
        return true;
    }
}
```

# Diferenças e Considerações
- O padrão Test-Doer é mais explícito, separando claramente a verificação da execução.
- O padrão Try é mais fluido e pode ser mais eficiente, evitando a necessidade de chamadas separadas para teste e execução.
- O padrão Try é mais adequado para cenários onde a falha é comum e esperada, enquanto o padrão Test-Doer pode ser mais apropriado para operações críticas onde a falha deve ser tratada de forma explícita.