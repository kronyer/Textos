# Nullable types
Em c#, os tipos de valor (como `int`, `double`, `bool`, etc.) não podem ser nulos por padrão. No entanto, às vezes é necessário representar a ausência de um valor. Para isso, C# introduziu os tipos anuláveis (nullable types).

## Sintaxe
Para declarar um tipo anulável, você pode usar a sintaxe `Nullable<T>` ou a forma abreviada `T?`, onde `T` é um tipo de valor. Por exemplo:
```csharp
int? nullableInt = null; // Usando a forma abreviada (syntax sugar)
Nullable<double> nullableDouble = null; // Usando a sintaxe completa
```

Essa struct eh definida como:
```csharp
public struct Nullable<T> where T : struct
{
    private bool hasValue;
    private T value;

    public Nullable(T value)
    {
        this.value = value;
        this.hasValue = true;
    }

    public bool HasValue => hasValue;

    public T Value
    {
        get
        {
            if (!hasValue)
                throw new InvalidOperationException("Nullable object must have a value.");
            return value;
        }
    }

    public override string ToString()
    {
        return hasValue ? value.ToString() : "";
    }
}
```

## Origem
A origem remonta a programaçao funcional, inspirada no Monad Maybe, que é usada para representar valores que podem estar presentes ou ausentes.

Em haskell, por exemplo, o null nao existe, mas o tipo Maybe é usado para representar a possibilidade de ausência de valor:
```haskell
idade:: Maybe Int
idade = Just 30
idade = Nothing
```