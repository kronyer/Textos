# Documentando funções com xml

Documentar funções é uma boa prática para tornar o código mais legível e fácil de entender. Em C#, podemos usar comentários XML para documentar nossas funções, classes, propriedades, etc. Esses comentários são usados por ferramentas como o IntelliSense do Visual Studio para fornecer informações sobre o código enquanto estamos escrevendo.

Vamos pensar com exemplos:

## Definindo a função que calcula a média ponderada

```csharp
public double CalcularMediaPonderada(double v1, double v2, double v3, double p1, double p2, double p3)
{
    if (p1 + p2 + p3 == 0)
    {
        throw new ArgumentException("A soma dos pesos não pode ser zero.");
    }

    return (v1 * p1 + v2 * p2 + v3 * p3) / (p1 + p2 + p3);
}
```

## Documentando a função
```csharp
/// <summary>
/// Calcula a média ponderada de três valores com seus respectivos pesos.
/// </summary>
/// <param name="v1">O primeiro valor.</param>
/// <param name="v2">O segundo valor.</param>
/// <param name="v3">O terceiro valor.</param>
/// <param name="p1">O peso do primeiro valor.</param>
/// <param name="p2">O peso do segundo valor.</param>
/// <param name="p3">O peso do terceiro valor.</param>
/// /// <returns>O resultado da média ponderada como um <see cref="double"/>.</returns>
/// <exception cref="ArgumentException">Lançada quando a soma dos pesos é zero.</exception>
/// A fórmula aplicada é:
/// <![CDATA[valor1 * peso1 + valor2 * peso2 + valor3 * peso3] / [peso1 + peso2 + peso3]]>
/// Exemplo de uso:
/// <code>
/// double media = CalcularMediaPonderada(7.5, 8.0, 9.0, 0.2, 0.3, 0.5);
/// Console.WriteLine(media); // Saída: 8.25
/// </code>
public double CalcularMediaPonderada(double v1, double v2, double v3, double p1, double p2, double p3)
{
    if (p1 + p2 + p3 == 0)
    {
        throw new ArgumentException("A soma dos pesos não pode ser zero.");
    }

    return (v1 * p1 + v2 * p2 + v3 * p3) / (p1 + p2 + p3);
}
```