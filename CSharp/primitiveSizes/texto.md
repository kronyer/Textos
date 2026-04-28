# Tipos primitivos e seus Wrappers

| Tipo primitivo | Wrapper | IL Type |
| --- | --- | --- |
| `sbyte` | `System.SByte` | `int8` |
| `byte` | `System.Byte` | `uint8` |
| `short` | `System.Int16` | `int16` |
| `ushort` | `System.UInt16` | `uint16` |
| `int` | `System.Int32` | `int32` |
| `long` | `System.Int64` | `int64` |
| `ulong` | `System.UInt64` | `uint64` |
| `float` | `System.Single` | `float32` |
| `double` | `System.Double` | `float64` |
| `char` | `System.Char` | `char` |
| `bool` | `System.Boolean` | `bool` |
| `nint` | `System.IntPtr` | `native int` |
| `nuint` | `System.UIntPtr` | `native uint` |


# Sobre os Native Sized Ints
Os tipos `nint` e `nuint` são tipos de inteiros que têm o mesmo tamanho da palavra do processador. Isso significa que em um sistema de 32 bits, `nint` e `nuint` terão 32 bits, enquanto em um sistema de 64 bits, eles terão 64 bits. 


# Sobre o decimal
O tipo `decimal` não é um tipo primitivo, mas é uma struct.

# Sobre o big-integer
O tipo `BigInteger` é uma struct que representa um número inteiro de precisão arbitrária. Ele é útil para trabalhar com números inteiros muito grandes que não podem ser representados pelos tipos primitivos como `int` ou `long`. O `BigInteger` é parte do namespace `System.Numerics` e pode ser usado para realizar operações matemáticas em números inteiros de qualquer tamanho, sem se preocupar com estouros de capacidade.

# Checando o código IL