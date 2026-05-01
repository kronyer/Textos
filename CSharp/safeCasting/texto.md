# Safe casting c#

Em c#, podemos fazer casting de tipos usando o operador  `as` e a checagem de tipos com o operador `is`. O operador `is` verifica se um objeto é de um tipo específico, enquanto o operador `as` tenta fazer o cast e retorna null se falhar.

```csharp
object obj = "Hello, World!";
if (obj is string str)
{
    Console.WriteLine($"The string is: {str}");
}
string? str2 = obj as string;
if (str2 != null)
{
    Console.WriteLine($"The string is: {str2}");
}
```

Diferente do cast tradicional, o operador `as` não lança uma exceção se o cast falhar, ele simplesmente retorna null. Isso é útil para evitar exceções e lidar com casos onde o tipo pode não ser o esperado.

## COmparação:

```csharp
object obj = "Hello, World!";
// Usando cast tradicional
try
{    string str1 = (string)obj; // Funciona, obj é uma string
    Console.WriteLine($"The string is: {str1}");
}catch (InvalidCastException)
{    Console.WriteLine("Cast failed using traditional cast.");
}
// Usando operador 'as'
string? str2 = obj as string; // Funciona, obj é uma string
if (str2 != null){    Console.WriteLine($"The string is: {str2}");
}else   
{    Console.WriteLine("Cast failed using 'as' operator.");
}
```