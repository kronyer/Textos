void ProcessarCaracteres(params List<char> letras)
{
    foreach (var c in letras)
    {
        Console.Write(c + " ");
    }
}

 void Processar(params ICollection<int> numeros) 
{
    Console.WriteLine(numeros.Count);
}

// Chamadas válidas:
ProcessarCaracteres('a', 'b', 'c'); // O compilador cria a lista para você
ProcessarCaracteres(new List<char> { 'd', 'e' }); // Você passa a lista pronta



// O compilador cria uma List<int> ou array por trás para você
Processar(1, 2, 3);
Processar(4, 5);
Processar(); // Output: 0