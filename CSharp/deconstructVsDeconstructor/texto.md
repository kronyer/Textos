# Deconstructor vs Deconstruct
Embora sejam nomes parecidos, eles pouco tem a ver.

## Deconstructor

O Deconstructor é um método definido na classe que é executado imediatamente antes de ser destruída, ou seja, quando o objeto é coletado pelo garbage collector. Ele é usado para liberar recursos não gerenciados, como conexões de banco de dados ou arquivos abertos.


Também é comum o uso da interface `IDisposable` para definir um contrato de que a classe tem um método `Dispose()` que deve ser chamado para liberar recursos, e o `using` statement pode ser usado para garantir que o `Dispose()` seja chamado mesmo em caso de exceção.

```csharp
public class MyClass : IDisposable
{
    public void Dispose()
    {        // Liberar recursos aqui
    }
}

using (var myObject = new MyClass())
{
    // Usar myObject aqui
} // O Dispose() é chamado automaticamente aqui
```

### Uso do Deconstructor
No entanto, se quisermos definir um Deconstructor explícito, podemos usar a sintaxe de finalizador:

```csharp
public class MyClass
{    ~MyClass()
    {        // Código de limpeza aqui
    }
}
```

## Deconstruct
O Deconstruct é um método que permite a desestruturação de objetos em variáveis individuais, facilitando a extração de dados de objetos complexos. Ele é definido usando a sintaxe `Deconstruct` e é comumente usado em tuplas e records.

```csharp
public class Point
{
    public int X { get; }
    public int Y { get; }
    public Point(int x, int y)
    {        X = x;
        Y = y;
    }
    public void Deconstruct(out int x, out int y)
    {        x = X;
        y = Y;
    }
}

var point = new Point(3, 4);
var (x, y) = point; // x = 3, y = 4
``` 