# Comparando valores numéricos c# 

Comparação de valores é uma tarefa que o programador muito provavelmente vai ter que executar infinitas vezes durante a vida.

Em C#, podemos comparar valores numéricos usando os operadores de comparação padrão, como `==`, `!=`, `<`, `>`, `<=` e `>=`.

O que nos interessa nessa postagem é a comparação de valores numéricos de ponto flutuante (com o perdão da palavra, valores que não são discretos), ou seja, valores que podem ter uma infinidade de possibilidades, como `float`, `double` e `decimal`.

Comparar valores de ponto flutuante (como `float` e `double`) pode ser problemático devido à precisão limitada desses tipos. Devido a isso, é recomendado usar uma abordagem de comparação com uma margem de erro (epsilon) para determinar se dois valores são "praticamente iguais".

```csharp
public bool CompararComEpsilon(double valor1, double valor2, double epsilon)
{    return Math.Abs(valor1 - valor2) < epsilon;
}
```

A origem desse erro se dá na incompatibilidade entre a teoria matemática e a representação binária dos números de ponto flutuante. Quando pensamos em numeros reais, imaginamos uma linha contínua onde qualquer valor é possível. No entanto, os computadores representam valores usando uma quantidade finita de bits, o que leva a uma representação aproximada dos números reais. Isso pode resultar em erros de arredondamento e imprecisão.


Exemplo de comparação usando `float`:

```csharp
float valor1 = 0.1f;
float valor2 = 0.2f;
float resultado = valor1 + valor2;
if (CompararComEpsilon(resultado, 0.3f, 0.0001f))
{    Console.WriteLine("Os valores são praticamente iguais.");
}
else
{    Console.WriteLine("Os valores são diferentes.");
}
```

Temos sempre que considerar essa margem de erro ao comparar valores de ponto flutuante para evitar resultados inesperados devido à imprecisão desses tipos.

Já o tipo `decimal` é projetado para ser mais preciso em cálculos financeiros e monetários, e geralmente não sofre dos mesmos problemas de precisão que os tipos de ponto flutuante. 

Portanto, para comparar valores `decimal`, você pode usar os operadores de comparação padrão sem se preocupar com a margem de erro:

```csharp
decimal valor1 = 0.1m;
decimal valor2 = 0.2m;
decimal resultado = valor1 + valor2;
if (resultado == 0.3m)
{    Console.WriteLine("Os valores são iguais.");
}
else
{    Console.WriteLine("Os valores são diferentes.");
}
```

