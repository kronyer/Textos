# Boxing e unboxing

Boxing é o processo de converter um tipo de valor (como int, double, etc) em um tipo de referência (object). Unboxing é o processo inverso, onde um tipo de referência é convertido de volta para um tipo de valor.

Isso impacta a perfomance do código, pois diz respeito à memória.

Quando um tipo de valor é boxed, ele é alocado na heap e uma referência para ele é retornada. Já no unboxing, a referência é convertida de volta para um tipo de valor, e seu valor é alocado na stack.


# Exemplo de boxing e unboxing

```csharp
int x = 10; // x é um tipo de valor
object obj = x; // Boxing: x é convertido para object e alocado na heap
int y = (int)obj; // Unboxing: obj é convertido de volta para int e alocado na stack
```

Hoje em dia, é recomendado evitar, uma vez que podemos usar generics ao invés de object, o que evita a necessidade de boxing e unboxing, melhorando a performance do código.

## Checando o IL
```cs
int i = 10;
object o = i;
```

No IL temos:
```
.locals init (
    [0] int32 i,   // Reserva espaço na stack para um inteiro (Value Type)
    [1] object o   // Reserva espaço na stack para uma referência (Reference Type)
)

IL_0000: ldc.i4.s 10    // 1. Carrega o valor constante 10 para a stack de avaliação
IL_0002: stloc.0        // 2. Tira o 10 da stack e armazena na variável local [0] (i)
IL_0003: ldloc.0        // 3. Carrega o valor de 'i' (10) de volta para a stack
IL_0004: box [System.Runtime]System.Int32 // 4. O BOXING ACONTECE AQUI
IL_0009: stloc.1        // 5. Armazena o endereço do novo objeto na variável [1] (o)
```