# Break Continue Return


## Break
O comando `break` é utilizado para sair de um loop ou bloco de código. Quando é encontrado, o controle é transferido para a próxima linha de código após o loop ou bloco.

```csharp
for (int i = 0; i < 10; i++)
{
    if (i == 5)
    {
        break; // Sai do loop quando i é igual a 5
    }
    Console.WriteLine(i);
}
```

## Continue
O comando `continue` é utilizado para pular a iteração atual de um loop e passar para a próxima iteração. Quando é encontrado, o controle é transferido para a próxima iteração do loop, ignorando o restante do código dentro do loop para a iteração atual.

```csharp
for (int i = 0; i < 10; i++)
{
    if (i % 2 == 0)
    {
        continue; // Pula a iteração atual se i for par
    }
    Console.WriteLine(i);
}
```

Diferente do break, que sairia completamente do loop, o continue apenas pula a iteração atual, permitindo que o loop continue executando as próximas iterações.

## Return
O comando `return` é utilizado para sair de um método e retornar um valor (se o método for do tipo não void) ou simplesmente sair do método (se o método for do tipo void). Quando é encontrado, o controle é transferido de volta para o ponto onde o método foi chamado, e o valor especificado (se houver) é retornado.

```csharp
public int Somar(int a, int b)
{
    return a + b; // Retorna a soma de a e b
}
