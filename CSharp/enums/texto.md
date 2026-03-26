# Enums
Enums em c# são tipos de dados que servem para pré definir um conjunto de valores constantes. Eles nativamente herdam de int, mas podem ser definidos para herdar de outros tipos inteiros.

Enums são muito úteis para type-safety, evitando o uso de magic numbers e melhorando a legibilidade do código. 

Exemplos de enum:

```csharp
public enum DiasDaSemana
{    Domingo,
    Segunda,
    Terca,
    Quarta,
    Quinta,
    Sexta,
    Sabado
}
```

Por usarem o tipo inteiro, os enums ocupam 4 bytes por padrão. No entanto, é possível definir um enum para herdar de byte, reduzindo seu tamanho para 1 byte. 

Como consequência, os valores do enum devem estar dentro do intervalo de 0 a 255.

```csharp
public enum DiasDaSemana : byte
{    Domingo,
    Segunda,
    Terca,
    Quarta,
    Quinta,
    Sexta,
    Sabado
}

```

Um outro uso interessante de enums é a possibilidade de criar flags, ou seja, um enum que pode representar uma combinação de valores. Para isso, utilizamos a annotation [Flags].

```csharp
[Flags]
public enum Permissoes : byte
{    Nenhuma = 0,
    Leitura = 1,
    Escrita = 2,
}
```

Com o enum de flags, podemos combinar as permissões usando o operador bitwise OR (|):

```csharp
Permissoes minhasPermissoes = Permissoes.Leitura | Permissoes.Escrita;
```
Isso permite que `minhasPermissoes` represente tanto a permissão de leitura quanto a de escrita ao mesmo tempo.


Também podemos usar `[Flags]` para valores com `int`, mas é importante garantir que os valores sejam potências de 2 para evitar sobreposição:

```csharp
[Flags]
public enum Permissoes : int
{    Nenhuma = 0,
    Leitura = 1,
    Escrita = 2,
    Executar = 4,
    Administrador = 8
}
```

A potencia de dois também pode ser feita usando shift:

```csharp
[Flags]
public enum Permissoes : int
{    Nenhuma = 0,
    Leitura = 1 << 0, // 1
    Escrita = 1 << 1, // 2
    Executar = 1 << 2, // 4
    Administrador = 1 << 3 // 8
}
```

p.s: o operador `<<` é o operador de shift left, que desloca os bits para a esquerda. Por exemplo, `1 << 2` desloca o bit 1 para a esquerda 2 vezes, resultando em 4 (0001 se torna 0100).