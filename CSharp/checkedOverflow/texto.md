# Checked Overflow C#

A maioria dos números em C# tem um limite máximo e mínimo que podem armazenar. 

| Tipo | Tamanho (bits) | Intervalo |
|------|----------------|-----------|
| `sbyte` | 8 | -128 a 127 |
| `byte` | 8 | 0 a 255 |
| `short` | 16 | -32.768 a 32.767 |
| `ushort` | 16 | 0 a 65.535 |
| `int` | 32 | -2.147.483.648 a 2.147.483.647 |
| `uint` | 32 | 0 a 4.294.967.295 |
| `long` | 64 | -9.223.372.036.854.775.808 a 9.223.372.036.854.775.807 |
| `ulong` | 64 | 0 a 18.446.744.073.709.551.615 |


Quando escrevemos `int`, por baixo dos panos (nem tanto por baixo assim) estamos usando na verdade o `System.Int32`, que é um struct que representa um número inteiro de 32 bits. O mesmo vale para os outros tipos numéricos, como `long` (que é `System.Int64`), `short` (que é `System.Int16`), etc.

Existe também um tipo chamado `nint`, que é um inteiro com tamanho nativo, ou seja, o mesmo tamanho do ponteiro da plataforma. Em sistemas de 32 bits, `nint` tem 32 bits, e em sistemas de 64 bits, `nint` tem 64 bits. O mesmo vale para `nuint`, que é a versão sem sinal de `nint`.

De fora dessa lógica de tamanho fixo está o tipo `BigInteger`, que pode armazenar números inteiros de tamanho arbitrário, limitado apenas pela memória disponível. 

## Checked e unchecked
Dada essa introdução, a dúvida que surge é, e quando ultrapassamos esses limites? O que acontece se tentarmos armazenar um número maior do que o máximo permitido para um tipo?

## Unchecked

Em C#, por padrão, quando ocorre um estouro de valor (overflow) em operações aritméticas, o comportamento é padrão é "unchecked", ou seja, causando um resultado inesperado e silencioso.

Se em uma variável do tipo `byte` (que tem um intervalo de 0 a 255) com o valor já de 255, tentarmos adicionar 1 a ela, o resultado não será 256, mas sim 0, porque o valor "dá a volta" e começa novamente do início do intervalo.

Isso é explicado pela soma em base binária. O número 255 em binário é representado como `11111111` (8 bits). Quando adicionamos 1 a esse número, ele se torna `100000000`, que é um número de 9 bits. Como o tipo `byte` só pode armazenar 8 bits, ele "descarta" o bit mais significativo (o nono bit) e fica apenas com os 8 bits restantes, que são `00000000`, ou seja, 0.

Em um cenário de de `sbyte`, que tem um intervalo de -128 a 127, se tentarmos adicionar 1 ao valor 127, o resultado será -128, porque o número "dá a volta" para o início do intervalo negativo.

Pensando novamente em bits: 127 em binário é `01111111` (8 bits). Quando adicionamos 1 a esse número, ele se torna `10000000`, que é o valor mínimo de um `sbyte`, ou seja, -128.

Nesse cenário o MSB (Most Significant Bit) é o bit de sinal, onde 0 representa números positivos e 1 representa números negativos. Quando o resultado da operação ultrapassa o limite superior (127), ele "dá a volta" para o valor mínimo (-128) devido à forma como os números são representados em binário.

## Checked
Podemos configurar o comportamento de overflow para "checked", onde uma exceção do tipo `OverflowException` é lançada quando ocorre um estouro de valor.

Para ativar o comportamento "checked", podemos usar a palavra-chave `checked` em um bloco de código ou em uma expressão específica. Por exemplo:

```csharp
checked
{
    try{
        byte a = 255;
        a += 1; // Isso lançará uma OverflowException
    }
    catch (OverflowException ex)
    {
        Console.WriteLine("Ocorreu um estouro de valor: " + ex.Message);
    }
}
``` 

Teoricamente até aqui estaria tudo certo, para fins didáticos foi usado o byte, mas em um cenário real, ocorre uma "promoção numérica", uma vez que não ha operadores aritiméticos para tipos menores de 32 bits, o que significa que o `byte` é promovido para `int` antes da operação de adição, ou seja, nenhum erro de overflow será lançado, porque o resultado da operação é um `int` e não um `byte`.

Podemos também deixar o comportamento "checked" como padrão para todo o projeto, basta adicionar a seguinte linha no arquivo de configuração do projeto (.csproj):

```xml
<PropertyGroup>
  <CheckForOverflowUnderflow>true</CheckForOverflowUnderflow>
</PropertyGroup>
```