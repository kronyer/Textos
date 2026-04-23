# Tuplas
Em c#, atualemente, existem dois tipos de tuplas: as tuplas de valor, que são imutáveis e mais performáticas, e as tuplas de referência, que são mutáveis e menos performáticas. As tuplas de valor são representadas pela struct `ValueTuple`, enquanto as tuplas de referência são representadas pela classe `Tuple`.

## Value tuples

`ValueTuple` é uma struct, o que significa que é um tipo de valor. Isso traz algumas vantagens, como melhor desempenho e menor consumo de memória, por estarem na stack. `ValueTuple` é mutável.

As value tuples modernas permitem a inferência de nomes, ou seja, você pode criar uma tupla sem especificar os nomes dos campos, e o compilador irá inferi-los com base nas variáveis usadas para criar a tupla. Por exemplo:

```csharp
var name = "Alice";
var age = 30;
var person = (name, age); // O compilador infere os nomes dos campos como "name" e "age"

Console.WriteLine(person.GetType()); // Output: System.ValueTuple`2[System.String,System.Int32]


Console.WriteLine(person.name); // Output: Alice
Console.WriteLine(person.age);  // Output: 30
```

## Usando aliasing para renomear campos
Você também pode usar aliasing para criar um alias do tipo da tupla, o que pode ser útil para melhorar a legibilidade do código. Por exemplo:

```csharp
using Person = (string Name, int Age);

Person person = ("Alice", 30);
Console.WriteLine(person.Name); // Output: Alice
Console.WriteLine(person.Age);  // Output: 30
```

## Deconstruction
As tuplas também suportam deconstruction, que é uma forma de extrair os valores dos campos da tupla em variáveis separadas. Por exemplo:
```csharp
var person = (Name: "Alice", Age: 30);
var (name, age) = person; // Deconstruction
Console.WriteLine(name); // Output: Alice
Console.WriteLine(age);  // Output: 30
```

Também podemos descartar campos que não queremos usando o caractere de sublinhado `_`:
```csharp
var person = (Name: "Alice", Age: 30, City: "New York");
var (name, age, _) = person; // Descartando o campo "City"
Console.WriteLine(name); // Output: Alice
Console.WriteLine(age);  // Output: 30
```

Também podemos usar variáveis ja existentes para receber os valores da tupla:
```csharp
var person = (Name: "Alice", Age: 30);
string name;
int age;
(name, age) = person; // Deconstruction em variáveis existentes
Console.WriteLine(name); // Output: Alice
Console.WriteLine(age);  // Output: 30
```

# Tuple de referência
As tuplas de referência são representadas pela classe `Tuple`. Elas são consideradas legado. São imutáveis e menos performáticas, por estarem no heap. Elas não suportam inferência de nomes, ou seja, os campos são nomeados como `Item1`, `Item2`, etc. Por exemplo:

```csharp
var person = Tuple.Create("Alice", 30);
Console.WriteLine(person.GetType()); // Output: System.Tuple`2[System.String,System.Int32]
Console.WriteLine(person.Item1); // Output: Alice
Console.WriteLine(person.Item2); // Output: 30
```
