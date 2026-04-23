# Ref return, trazendo referência para fora do método

Em C#, os métodos normalmente retornam uma cópia do valor. No entanto, com o recurso de "ref return", é possível retornar uma referência para um valor, permitindo que o chamador modifique diretamente o valor original. 

Normalmente, quando um método retorna algo, ele retorna uma cópia.

```cs
C#
int ObterValor(int[] numeros) {
    return numeros[0]; // Retorna uma CÓPIA do que está no índice 0
}

int x = ObterValor(meusNumeros);
x = 99; // Isso muda 'x', mas NÃO muda o array 'meusNumeros'
```

Utilizando `ref return`, podemos retornar uma referência para o valor, permitindo que o chamador modifique o valor original.

```cs
ref int ObterValorRef(int[] numeros) {
    return ref numeros[0]; // Retorna uma REFERÊNCIA para o que está no índice 0
}   

ref int x = ref ObterValorRef(meusNumeros); // ref aqui é obrigatório para indicar que estamos recebendo uma referência, caso contrário, será feita uma cópia
x = 99; // Isso muda 'x' E TAMBÉM muda o array 'meusNumeros'
```

## Algumas regras de segurança
O compilador não deixa simplesmente retornar uma referência para qualquer coisa. Ele impõe algumas regras para garantir que a referência seja válida e não cause problemas de segurança ou corrupção de memória.

```cs
public ref int MetodoErrado() {
    int x = 10;
    return ref x; // ERRO! 'x' morre quando o método acaba.
}
```

## Ref local
Além de usar o `ref return`, para manter a referência viva, precisamos usar `ref local` para armazenar a referência retornada.

Se omitirmos o `ref` ao declarar `x`, estaremos recebendo uma cópia do valor, e não uma referência, o que significa que modificar `x` não afetará o array original.

```cs
int[] estoque = { 10, 20, 30 };

// 1. Recebendo como Cópia (Sem ref local)
int valorCopia = ObterValorRef(estoque); 
valorCopia = 99; // 'estoque[0]' continua sendo 10

// 2. Recebendo como Referência (Com ref local)
ref int valorReal = ref ObterValorRef(estoque); 
valorReal = 99; // 'estoque[0]' AGORA É 99!
```

## Ref readonly
O modificador `ref readonly` armazena o retorno de um método assinado `ref readonly` como referência, mas somente leitura.

```cs
private MinhaStructGigante _configuracao;

public ref readonly MinhaStructGigante ObterConfig() {
    return ref _configuracao; // Retorna por referência, mas protege contra escrita
}

// No uso:
ref readonly var config = ref ObterConfig();
// config.Valor = 10; // ERRO DE COMPILAÇÃO: A referência é somente leitura.
```