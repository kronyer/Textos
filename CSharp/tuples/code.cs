var name = "Alice";
var age = 30;
var person = (name, age); // O compilador infere os nomes dos campos como
//  "name" e "age"
Console.WriteLine(person.GetType()); // Output: System.ValueTuple`2[System.String,System.Int32]

Console.WriteLine(person.name); // Output: Alice
Console.WriteLine(person.age);  // Output: 30


var person2 = Tuple.Create("Alice", 30);
Console.WriteLine(person2.GetType()); // Output: System.Tuple`2[System.String,System.Int32]
Console.WriteLine(person2.Item1); // Output: Alice
Console.WriteLine(person2.Item2); // Output: 30
// person2.Item1 = "Bob"; // Erro de compilação: System.Tuple é imutável