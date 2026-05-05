#!/usr/bin/env dotnet-script
using System;
using System.Collections.Generic;

// Para testar:
List<string>? minhaLista = null;
Console.WriteLine(minhaLista.IsNullOrEmpty()); // Retorna True sem dar erro de null!

//explicit




public static class ListExtensions 
{
    // Testa se a lista está vazia ou nula (evita crashes)
    public static bool IsNullOrEmpty<T>(this IEnumerable<T>? source) 
        => source == null || !source.GetEnumerator().MoveNext();
        
}



