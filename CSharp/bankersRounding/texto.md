# Bankers Rounding em C#

Em c#, o comportamento padrão da função de arredondamento é o "Bankers Rounding", também conhecido "Round Half To Even". Esse método de arredondamento é usado para evitar o viés de arredondamento que pode ocorrer quando se arredonda sempre para cima ou para baixo.

A regra fundamental é, caso a parte decimal seja exatamente 0.5, o número é arredondado para o número par mais próximo. Isso significa que:
- Se a parte inteira for impar, arredonda para o número par mais próximo.
- Se a parte inteira for par, arredonda para baixo, mantendo o número par.


## Controlando o comportamento de arredondamento do Math.Round
A função `Math.Round` em C# tem uma sobrecarga que permite especificar o tipo de arredondamento a ser usado. Você pode usar o enum `MidpointRounding` para controlar o comportamento de arredondamento. Por exemplo:
```csharp
double valor1 = 2.5;
double valor2 = 3.5;

double arredondado1 = Math.Round(valor1, MidpointRounding.AwayFromZero); // Arredonda para 3
double arredondado2 = Math.Round(valor2, MidpointRounding.AwayFromZero); // Arredonda para 4
``` 

Existem também outros, como `MidpointRounding.ToEven` (o padrão), `MidpointRounding.ToZero`, e `MidpointRounding.ToNegativeInfinity` e `MidpointRounding.ToPositiveInfinity` para controle total sobre o arredondamento.