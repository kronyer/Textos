# Estrutura de dados - Sets

Sets são coleções inspiradas na teoria dos conjuntos, onde cada elemento é único e a ordem dos elementos não é garantida.

## Sets comuns

### HashSet

O `HashSet<T>` é uma implementação de set que utiliza uma tabela hash para armazenar os elementos. Ele oferece operações de inserção, remoção e verificação de existência em tempo constante, O(1), na média.

Para caso de colisões, o `HashSet<T>` utiliza uma lista encadeada para armazenar os elementos que possuem o mesmo hash. Isso pode levar a um desempenho degradado em casos extremos, mas geralmente é eficiente para a maioria dos casos.

```csharp
var set = new HashSet<int>();
set.Add(1);
set.Add(2);
set.Add(2); // Não será adicionado, pois já existe
Console.WriteLine(set.Contains(1)); // True
Console.WriteLine(set.Contains(3)); // False
set.Remove(1);
Console.WriteLine(set.Contains(1)); // False
```

HashSet também é útil para a checagem da existencia de elementos ao adicionar, já que `Add` retorna um booleano indicando se o elemento foi adicionado ou não.

```csharp
var set = new HashSet<int>();
if (set.Add(1))
{
    Console.WriteLine("Elemento adicionado");
}
else
{    Console.WriteLine("Elemento já existe");
}
```

#### HashSet ou Dictionary?

Por baixo dos panos, o "motor" de um `HashSet<T>` é o mesmo de um `Dictionary<TKey, TValue>`, permitindo consultas O(1), no entanto, usamos `HashSet<T>` quando queremos apenas armazenar elementos únicos sem a necessidade de associar um valor a cada chave, enquanto `Dictionary<TKey, TValue>` é usado quando precisamos mapear chaves para valores.

HashSet é um dictionary que so se importa com a key. Recebe "Hash" pelo motor HashTable:

* No Dictionary: O Hash é calculado a partir de um dado (a Chave), para descobrir em qual gaveta guardar outro dado (o Valor).

* No HashSet: O Hash é calculado a partir do próprio elemento, para descobrir em qual gaveta guardar o próprio elemento.

p.s: Não confundir com HashMap, que é uma sinônimo de Dictionary em outras linguagens, como Java.

### SortedSet

O `SortedSet<T>` é uma implementação de set que mantém os elementos em ordem crescente. Ele utiliza uma árvore binária balanceada para armazenar os elementos, o que permite operações de inserção, remoção e verificação de existência em tempo logarítmico, O(log n).

```csharp
var sortedSet = new SortedSet<int>();
sortedSet.Add(3);
sortedSet.Add(1);
sortedSet.Add(2);
foreach (var item in sortedSet)
{
    Console.WriteLine(item); // Imprime 1, 2, 3 em ordem
}
```

## Operações de conjunto

### União

Combina os elementos de dois sets, resultando em um novo set que contém todos os elementos de ambos os sets.

$$A \cup B = \{ x | x \in A  \lor  x \in B \}\}$$

```csharp
var setA = new HashSet<int> { 1, 2, 3 };
var setB = new HashSet<int> { 3, 4, 5 };
var unionSet = new HashSet<int>(setA);
unionSet.UnionWith(setB);
// unionSet agora contém { 1, 2, 3, 4, 5 }
```

### Interseção

Retorna um novo set que contém apenas os elementos que estão presentes em ambos os sets.

$$A \cap B = \{ x | x \in A  \land  x \in B \}\}$$

```csharp
var setA = new HashSet<int> { 1, 2, 3 };
var setB = new HashSet<int> { 3, 4, 5 };

var intersectionSet = new HashSet<int>(setA);
intersectionSet.IntersectWith(setB);
// intersectionSet agora contém { 3 }
```

### Diferença

Retorna um novo set que contém os elementos que estão presentes em um set, mas não no outro.

$$A - B = \{ x | x \in A  \land  x \notin B \}\}$$

```csharp
var setA = new HashSet<int> { 1, 2, 3 };
var setB = new HashSet<int> { 3, 4, 5 };

var differenceSet = new HashSet<int>(setA);
differenceSet.ExceptWith(setB);
// differenceSet agora contém { 1, 2 }
```

### Diferença simétrica ou exclusiva (XOR)

Retorna um novo set que contém os elementos que estão presentes em um set ou no outro, mas não em ambos.

$$A \Delta B = \{ x | (x \in A  \lor  x \in B)  \land  x \notin (A \cap B) \}\}$$

```csharp
var setA = new HashSet<int> { 1, 2, 3 };
var setB = new HashSet<int> { 3, 4, 5 };

var symmetricDifferenceSet = new HashSet<int>(setA);
symmetricDifferenceSet.SymmetricExceptWith(setB);
// symmetricDifferenceSet agora contém { 1, 2, 4, 5 }
```

### Outros métodos úteis

- `IsSubsetOf`: Verifica se um set é um subconjunto de outro.
- `IsSupersetOf`: Verifica se um set é um superconjunto de outro.
- `Overlaps`: Verifica se dois sets têm elementos em comum.
- `SetEquals`: Verifica se dois sets contêm os mesmos elementos.

## Por que usar sets?

- **Unicidade**: Sets garantem que cada elemento seja único, o que é útil para evitar duplicatas.
- **Operações de conjunto**: Sets suportam operações como união, interseção e diferença de forma eficiente.
- **Verificação de existência**: Sets permitem verificar rapidamente se um elemento existe, especialmente com `HashSet<T>`, que tem tempo constante para essa operação.
- **Ordenação**: `SortedSet<T>` mantém os elementos em ordem, o que pode ser útil para certas aplicações.

## Interface ISet<T>

A interface `ISet<T>` define os métodos e propriedades que uma coleção de set deve implementar. Ela inclui métodos para adicionar, remover e verificar a existência de elementos, bem como operações de conjunto como união, interseção e diferença.

```csharp
public interface ISet<T> : ICollection<T>
{
    bool Add(T item);
    void UnionWith(IEnumerable<T> other);
    void IntersectWith(IEnumerable<T> other);
    void ExceptWith(IEnumerable<T> other);
    void SymmetricExceptWith(IEnumerable<T> other);
    bool IsSubsetOf(IEnumerable<T> other);
    bool IsSupersetOf(IEnumerable<T> other);
    bool Overlaps(IEnumerable<T> other);
    bool SetEquals(IEnumerable<T> other);
}
``` 
