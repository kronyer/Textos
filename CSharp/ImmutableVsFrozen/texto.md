# ToImmutable - Coleções imutáveis

As coleções imutáveis são aquelas que, uma vez criadas, não podem ser modificadas. Em C#, a biblioteca `System.Collections.Immutable` oferece uma variedade de classes para trabalhar com coleções imutáveis, como `ImmutableList<T>`, `ImmutableDictionary<TKey, TValue>`, `ImmutableHashSet<T>`, entre outras.

## ToImmutableList<T>

O método `ToImmutableList<T>()` é uma extensão que pode ser chamada em qualquer coleção que implemente `IEnumerable<T>`. Ele cria uma nova instância de `ImmutableList<T>` contendo os elementos da coleção original. Por exemplo:

```csharp
var mutableList = new List<int> { 1, 2, 3 };
var immutableList = mutableList.ToImmutableList();
```

Ao chamar .Add ou .Remove em `immutableList`, uma nova instância de `ImmutableList<T>` será criada, mantendo a imutabilidade da coleção original.

## ToImmutableArray<T>

As outras estruturas seguem o padrão da List, no entanto, o `ToImmutableArray<T>()` cria uma nova instância de `ImmutableArray<T>`, que é uma estrutura de dados otimizada para acesso rápido e baixo overhead de memória - é um struct que encapsula um array comum. Portanto, sendo ideal para coleções que não precisam de modificações frequentes, mas exigem acesso rápido aos elementos. 


# Frozen Collections

Diferente das imutaveis, que focam na segurança e integridade dos dados, as coleções congeladas (frozen) são otimizadas para desempenho de leitura. Temos um overhead inicial para congelar a coleção, mas depois disso, as operações de leitura são extremamente rápidas, já que a estrutura de dados é otimizada para acesso rápido e baixo overhead de memória. (como?) 

//TODO ver profundo o codigo e tal e implementar codigo