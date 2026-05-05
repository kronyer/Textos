# Sorted Collections

São coleções que mantem os dados ordenados a medida em que sao inseridos, sem que um método de sort precise ser chamado. Em C# são duas princuipais classes: `SortedList<TKey, TValue>` e `SortedDictionary<TKey, TValue>`, ambas implementando a interface `IDictionary<TKey, TValue>`.


## SortedList<TKey, TValue>

Essa classe funciona como um dictionary, mas utiliza dois arrays internos para armazenar as chaves e os valores.

É util quando as coleções nao mudam, ou quando precisamos acessar os elementos por índice. Como ponto negativo temos que as inserções e remoções tem tempo de O(n), já que existe a necessidade de deslocar os elementos do array para manter a ordenação.


## SortedDictionary<TKey, TValue>

Também mapeia chaves para valores, mas internamente utiliza uma árvore binária de busca balanceada. Permitindo inserções e remoções em tempo O(log n), o que a torna mais eficiente para coleções que sofrem muitas modificações. No entanto, não suporta acesso por índice, já que os elementos nao sao armazenados em arrays.


## SortedSet<T>

Funcionando como um conjunto (matemático) de elementos únicos, a classe `SortedSet<T>` é implementada como uma árvore binária de busca balanceada. Ela mantém os elementos ordenados e oferece operações eficientes para inserção, remoção e busca, todas em tempo O(log n). Além disso, suporta operações de conjunto como união, interseção e diferença.


//todo implementar codigo