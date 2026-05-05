# Stack, Queue e Priority Queue

Presentes no namespace `System.Collections.Generic`, as classes `Stack<T>`, `Queue<T>` e `PriorityQueue<TElement, TPriority>` são implementações de estruturas de dados fundamentais.

## Stack<T>

A classe `Stack<T>` representa uma coleção de objetos do tipo `T` que segue a ordem LIFO (Last In, First Out). Os principais métodos incluem:
- `Push(T item)`: Adiciona um item ao topo da pilha.
- `Pop()`: Remove e retorna o item do topo da pilha.
- `Peek()`: Retorna o item do topo da pilha sem removê-lo.


## Queue<T>
A classe `Queue<T>` representa uma coleção de objetos do tipo `T` que segue a ordem FIFO (First In, First Out). Os principais métodos incluem:
- `Enqueue(T item)`: Adiciona um item ao final da fila.
- `Dequeue()`: Remove e retorna o item do início da fila.
- `Peek()`: Retorna o item do início da fila sem removê-lo.

## PriorityQueue<TElement, TPriority>
A classe `PriorityQueue<TElement, TPriority>` representa uma coleção de objetos do tipo `TElement` que são organizados com base em uma prioridade do tipo `TPriority`. Os principais métodos incluem:
- `Enqueue(TElement element, TPriority priority)`: Adiciona um elemento à fila com uma prioridade associada.
- `Dequeue()`: Remove e retorna o elemento com a maior prioridade (menor valor de `TPriority`).
- `Peek()`: Retorna o elemento com a maior prioridade sem removê-lo.


//TODO implementar codigo