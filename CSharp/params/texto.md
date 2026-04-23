# Params
Params é uma palavra chave em C# que permite que um método aceite um número variável de argumentos. Isso é útil quando você não sabe quantos argumentos serão passados para o método. O parâmetro marcado com `params` deve ser o último parâmetro do método e pode ser qualquer coleção (antigamente era só array).

Para que você possa usar params T, o tipo da coleção deve atender a um destes critérios:

* Tipos de Armazenamento Contínuo: T[], Span<T>, ou ReadOnlySpan<T>.

* Interfaces de Coleção Padronizadas: IEnumerable<T>, IReadOnlyCollection<T>, IReadOnlyList<T>, ICollection<T>, e IList<T>.

* Classes Concretas: Qualquer classe que implemente IEnumerable<T> e tenha um construtor vazio (ou um inicializador de coleção que o compilador reconheça).

## Exemplo de uso
```csharp
public void PrintNumbers(params int[] numbers)
{
    foreach (var number in numbers)    {
        Console.WriteLine(number);
    }
}

// Chamando o método com um número variável de argumentos
PrintNumbers(1, 2, 3); // Output: 1 2 3
PrintNumbers(4, 5);    // Output: 4 5
PrintNumbers();        // Output: (nada)
```

```cs
// Agora é perfeitamente válido no C# 13
public void Processar(params ICollection<int> numeros) 
{
    Console.WriteLine(numeros.Count);
}

// O compilador cria uma List<int> ou array por trás para você
Processar(1, 2, 3);
Processar(4, 5);
Processar(); // Output: 0
```


```cs
public void ProcessarCaracteres(params List<char> letras)
{
    foreach (var c in letras)
    {
        Console.Write(c + " ");
    }
}

// Chamadas válidas:
ProcessarCaracteres('a', 'b', 'c'); // O compilador cria a lista para você
ProcessarCaracteres(new List<char> { 'd', 'e' }); // Você passa a lista pronta
```