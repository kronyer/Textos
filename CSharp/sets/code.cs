#!/usr/bin/env dotnet-script


var setA = new HashSet<int> { 1, 2, 3 };
var setB = new HashSet<int> { 3, 4, 5 };

var symmetricDifferenceSet = new HashSet<int>(setA);
symmetricDifferenceSet.SymmetricExceptWith(setB);
// symmetricDifferenceSet agora contém { 1, 2, 4, 5 }

var equals = setA.SetEquals(setB);