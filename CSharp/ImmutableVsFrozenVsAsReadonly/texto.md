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

Diferente das imutaveis, que focam na segurança e integridade dos dados, as coleções congeladas (frozen) são otimizadas para desempenho de leitura. Temos um overhead inicial para congelar a coleção, mas depois disso, as operações de leitura são extremamente rápidas, já que a estrutura de dados é otimizada para acesso rápido e baixo overhead de memória. Na chamada do método, é feito um hashing eficiente para garantir uma busca rápida, diferente de um dictionary padrão que usa chaining para colisões.

## FrozenDictionary<TKey, TValue>

O `FrozenDictionary<TKey, TValue>` é uma coleção que implementa a interface `IDictionary<TKey, TValue>`, mas é otimizada para leitura. Ele é criado a partir de um dicionário mutável usando o método `ToFrozenDictionary()`. Depois de congelado, o dicionário não pode ser modificado, e as operações de leitura são extremamente rápidas.

```csharp
var mutableDict = new Dictionary<string, int>
{    { "one", 1 },
    { "two", 2 },
    { "three", 3 }
};

var frozenDict = mutableDict.ToFrozenDictionary();
```

## FrozenSet<T>

O `FrozenSet<T>` é uma coleção que implementa a interface `ISet<T>`, mas é otimizada para leitura. Ele é criado a partir de um conjunto mutável usando o método `ToFrozenSet()`. Depois de congelado, o conjunto não pode ser modificado, e as operações de leitura são extremamente rápidas.

```csharp
var mutableSet = new HashSet<int> { 1, 2, 3 };
var frozenSet = mutableSet.ToFrozenSet();
```


# AsReadOnly

O método `AsReadOnly()` é uma extensão que pode ser chamada em qualquer coleção que implemente `IEnumerable<T>`. Ele retorna uma nova instância de `ReadOnlyCollection<T>`, que é uma coleção de leitura somente. No entanto, ao contrário das coleções imutáveis, a coleção original ainda pode ser modificada, e as alterações serão refletidas na coleção de leitura somente. Portanto, o `AsReadOnly()` não garante a imutabilidade dos dados, mas apenas fornece uma visão de leitura somente da coleção original.

```csharp
var mutableList = new List<int> { 1, 2, 3 };
var readOnlyList = mutableList.AsReadOnly();
mutableList.Add(4);
Console.WriteLine(readOnlyList.Count); // Output: 4
```