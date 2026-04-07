# Dividindo por zero

Em c# quando tentamos dividir um número inteiro por zero, ocorre uma exceção do tipo `DivideByZeroException`. Por exemplo:

```csharp
int a = 10;
int b = 0;

try
{
    int resultado = a / b; // Isso lançará uma DivideByZeroException
}
catch (DivideByZeroException ex)
{
    Console.WriteLine("Não é possível dividir por zero: " + ex.Message);
}
```

No entanto, quando tentamos dividir um número de ponto flutuante (como `double` ou `float`) por zero, o resultado é diferente. Em vez de lançar uma exceção, o resultado será `Infinity` (infinito) ou `NaN` (Not a Number), dependendo do contexto da operação. Por exemplo:

```csharp
double x = 10.0;
double y = 0.0;

double resultado = x / y; // Isso resultará em Infinity
Console.WriteLine(resultado); // Saída: Infinity

double z = 0.0 / 0.0; // Isso resultará em NaN
Console.WriteLine(z); // Saída: NaN
```