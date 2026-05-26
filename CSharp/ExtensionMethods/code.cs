#!/usr/bin/env dotnet-script
using System;
using System.Collections.Generic;
using System.Text;

Console.WriteLine("=== Extension Methods clássicos ===\n");

// --- IsNullOrEmpty ---
List<string>? listaNula = null;
List<string> listaVazia = new();
List<string> listaCheia = new() { "a", "b", "c" };

Console.WriteLine($"listaNula.IsNullOrEmpty()  → {listaNula.IsNullOrEmpty()}");   // True
Console.WriteLine($"listaVazia.IsNullOrEmpty() → {listaVazia.IsNullOrEmpty()}");  // True
Console.WriteLine($"listaCheia.IsNullOrEmpty() → {listaCheia.IsNullOrEmpty()}");  // False

Console.WriteLine("\n=== Print em IEnumerable ===\n");
listaCheia.Print();

Console.WriteLine("\n=== Prioridade de chamada ===\n");
var obj = new MinhaClasse();
obj.Print(); // Chama o método da classe, não o extension method

Console.WriteLine("\n=== Fluent interface com StringBuilder ===\n");
var sb = new StringBuilder();
sb.AppendLineWithPrefix("INFO",  "Iniciando o processo")
  .AppendLineWithPrefix("DEBUG", "Processo em andamento")
  .AppendLineWithPrefix("ERROR", "Ocorreu um erro");
Console.WriteLine(sb.ToString());

// ─────────────────────────────────────────────────
// Extension methods clássicos
// ─────────────────────────────────────────────────

public static class ListExtensions
{
    // Testa se a coleção está vazia ou nula (evita crashes)
    public static bool IsNullOrEmpty<T>(this IEnumerable<T>? source)
        => source == null || !source.GetEnumerator().MoveNext();

    // Print para qualquer IEnumerable<T>
    public static void Print<T>(this IEnumerable<T> collection)
    {
        foreach (var item in collection)
            Console.WriteLine($"  → {item}");
    }
}

public static class StringBuilderExtensions
{
    public static StringBuilder AppendLineWithPrefix(this StringBuilder sb, string prefix, string line)
    {
        return sb.AppendLine($"[{prefix}] {line}");
    }
}

// ─────────────────────────────────────────────────
// Prioridade: método da classe vence o extension method
// ─────────────────────────────────────────────────

public class MinhaClasse
{
    public void Print()
        => Console.WriteLine("  → Método da própria classe MinhaClasse (tem prioridade!)");
}

public static class MinhaClasseExtensions
{
    public static void Print(this MinhaClasse obj)
        => Console.WriteLine("  → Extension method (nunca chamado quando a classe tem o mesmo método)");
}

// ─────────────────────────────────────────────────
// NOTA: Extension Members (C# 14 / .NET 10)
//
// A nova sintaxe com blocos extension() permite propriedades,
// indexadores e membros estáticos de extensão.
// Exemplo (requer C# 14):
//
// public static class ProductExtensions
// {
//     extension(Product p)
//     {
//         public decimal PrecoComImposto => p.Price * 1.2M;
//         public string this[int index] => $"Info extra {index}";
//     }
//
//     extension(Product) // membros estáticos
//     {
//         public static Product Default => new Product { Price = 0 };
//     }
// }
// ─────────────────────────────────────────────────
