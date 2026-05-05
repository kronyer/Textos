#!/usr/bin/env dotnet-script


using System.Collections.Frozen;
using System.Collections.Immutable;

var mutableList = new List<int> { 1, 2, 3 };
var immutableList = mutableList.ToImmutableList();

// Tentando modificar a lista imutável 
immutableList.Add(4); 
immutableList.Add(5);

var novaListaImutavel = immutableList.Add(4).Add(5); 

Console.WriteLine("Lista Imutável: " + string.Join(", ", immutableList)); // Imprime: 1, 2, 3

Console.WriteLine("Nova Lista Imutável: " + string.Join(", ", novaListaImutavel)); // Imprime: 1, 2, 3, 4, 5

//ImmutableArray

var immutableArray = ImmutableArray.Create(1, 2, 3);
// Tentando modificar o array imutável
//immutableArray[0] = 10; // Isso não é permitido e causará um erro


//frozenCollections
ImmutableDictionary<string, int> frozenDictionary = ImmutableDictionary.CreateRange(new Dictionary<string, int>
{
    { "A", 1 },
    { "B", 2 },
    { "C", 3 }
});

Dictionary<string, int> mutableDictionary = new Dictionary<string, int>
{
    { "A", 1 },
    { "B", 2 },
    { "C", 3 }
};

mutableDictionary.ToFrozenDictionary();

FrozenSet<string> frozenSet = FrozenSet.Create("A", "B", "C");

var mutableSet = new HashSet<int> { 1, 2, 3 };
var newFrozenSet = mutableSet.ToFrozenSet();

var mutableList1 = new List<int> { 1, 2, 3 };
var readOnlyList = mutableList.AsReadOnly();
mutableList.Add(4);
Console.WriteLine(readOnlyList.Count); // Output: 4