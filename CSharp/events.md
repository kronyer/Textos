# Delegates, Function Pointers, Currying e Events em C#

## Delegates

Delegate é um tipo que representa uma referência a um método, um ponteiro de função. Com ele, podemos tratar métodos como valores, isso é, armazenar, passar como parametro, etc.

```cs
public delegate int Op(int a, int b);

public class Calculadora
{
    public static int Somar(int a, int b) => a + b;
    public static int Multiplicar(int a, int b) => a * b;
}

//podemos usar>
Op op = Calculadora.Somar;
Console.WriteLine(op(2,3));// 5
```

### Delegates genéricos prontos

Geralmente, no dia a dia, nao criamos nossos pŕoprios delegates, usamos os built in do próprio c#:

```cs
Func<int, int, int> soma = (a, b) => a + b;   // retorna valor
Action<string> log = msg => Console.WriteLine(msg); // não retorna nada
Predicate<int> ehPar = n => n % 2 == 0;       // retorna bool
```

No func, todos os items dentro de <> exceto o último são parametros, e o último é seu retorno.

O Action nao retorna nada, portanto todos itens dentro de <> são parametros.

Já predicate é um func que retorna bool.

### Multicast em delegates

Um delegate pode apontar para N métodos ao mesmo tempo, encadeados com `+=`

```cs
Action acao = () => Console.WriteLine("Passo 1");
acao += () => Console.WriteLine("Passo 2");
acao(); // executa os dois em sequência
```

## Function pointer

Podemos usar, no baixo nivel, isso é, usando unsafe, um recurso chamado function pointer. Ele nao é gerenciado, nao é alocado no heap, portanto é muito útil em cenários de extrema perfomance.

```cs
unsafe
{
    delegate*<int, int, int> ptr = &Calculadora.Somar;
    int resultado = ptr(2, 3); // chamada direta, sem alocação
}
```

## Currying

Para quem tem contato com linguagens funcionais, isso talvez seja mais intuitivo. No entanto, podemos definir currying como uma sequencia de funcoes, onde cada uma recebe um argumento. Em haskell por exemplo, o máximo de argumentos de uma função é um, e o multiplo argumentos são feitos a partir de currying.

### Sacada do haskell

Em Haskell não existe função de "2 parâmetros". O que parece ter 2 parâmetros é, por baixo dos panos, uma função que recebe 1 e devolve outra função que recebe 1. Sempre.

```hs
haskell
somar :: Int -> Int -> Int
somar a b = a + b
```

Repare na assinatura: Int -> Int -> Int. Isso se lê como:

`Int -> (Int -> Int)`

Ou seja: recebe um Int, devolve uma função Int -> Int.

### Diferença no C#

Em C#, uma função "normal" **não** funciona como no Haskell — ela recebe todos os parâmetros de uma vez, de verdade:

```csharp
int Somar(int a, int b) => a + b;
Somar(2, 3); // 5
```

Não existe essa "sacada" por baixo dos panos aqui. `Somar(2, 3)` é uma chamada só, com 2 argumentos — não uma cadeia de funções de 1 parâmetro cada.

Pra ter o comportamento do Haskell, você precisa **construir isso manualmente**, usando um `Func` que devolve outro `Func`:

```csharp
Func<int, Func<int, int>> somarCurried = a => b => a + b;
```

Repare que o tipo é bem parecido com a assinatura do Haskell:

```
Func<int, Func<int, int>>
```

Isso se lê como:

```
int -> (int -> int)
```

Ou seja: recebe um `int`, devolve uma função `Func<int, int>`.

E a chamada `somarCurried(1)(2)` é a versão em C# de `soma 1 2` — cada parêntese é uma aplicação de um único argumento:

```csharp
somarCurried(1)(2); // 3

// passo a passo:
Func<int, int> somar1 = somarCurried(1); // guardou a = 1, falta o b
int resultado = somar1(2);               // 3
```

A diferença é que em Haskell todas as funções já nascem assim, automaticamente. Em C#, uma função com `(int a, int b)` são dois parâmetros de verdade — currying é um padrão que você escolhe construir, não o comportamento padrão da linguagem.

## Events vs delegates

Um event é construito em cima de um delegate, mas encapsulado em uma classe (e provavelmente em uma regra de domínio).

```cs
public class Botao
{
    //delegate puro, qualquer codigo externo pode invocar
    public Action Clicado;

    //aqui, apenas a classe dona pode invocar
    public event Action Pressionado;

    public void SimularClique()
    {
        Clicado?.Invoke();
        Pressionado?.Invoke();
    }
}
```

Note que, nao teriamos o mesmo efeito usando private no Action. Caso façamos isso, nenhum interessado poderia se inscrever no nosso Action.

Resumindo a diferença de private vs event

* private: ninguém de fora enxerga nem interage. Bom quando o delegate é só uso interno da classe.
* event: quem é de fora enxerga e pode se inscrever/desinscrever, mas não pode disparar nem sobrescrever. É o meio-termo certo para notificações do tipo "avise-me quando algo acontecer", que é exatamente o caso de uso de eventos (UI, padrão observer, etc).
