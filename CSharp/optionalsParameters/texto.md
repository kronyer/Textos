# Parametros opcionais
Em C#, podemos definir parâmetros opcionais em métodos, o que permite que os chamadores omitam esses parâmetros ao chamar. Para isso, basta atribuir um valor padrão ao parâmetro na definição do método. Por exemplo:

```csharp
public void ExibirMensagem(string mensagem, int vezes = 1)
{
    for (int i = 0; i < vezes; i++)
    {        Console.WriteLine(mensagem);
    }
}
```

Aqui, o parametro `vezes` é opcional, e se o chamador não fornecer um valor para ele, ele assumirá o valor padrão de `1`. Assim, podemos chamar o método de duas maneiras:

```csharp
ExibirMensagem("Olá, mundo!"); // Imprime "Olá, mundo!" uma vez
ExibirMensagem("Olá, mundo!", 3); // Imprime "Olá, mundo!" três vezes
```

## Regras para parâmetros opcionais
- Os parâmetros opcionais devem ser definidos após os parâmetros obrigatórios. Ou seja, não é permitido ter um parâmetro opcional seguido por um parâmetro obrigatório.
- Os parâmetros opcionais podem ser de qualquer tipo, incluindo tipos de valor e tipos de referência.
- O valor padrão para um parâmetro opcional deve ser uma constante, ou seja, um valor que pode ser avaliado em tempo de compilação. Isso significa que você não pode usar expressões ou variáveis como valores padrão para parâmetros opcionais.
- Se um método tiver vários parâmetros opcionais, os chamadores podem omitir qualquer combinação desses parâmetros, desde que os parâmetros obrigatórios sejam fornecidos. Por exemplo:
```csharp
public void ExibirMensagem(string mensagem, int vezes = 1, bool emMaiusculas = false)
{
    string msg = emMaiusculas ? mensagem.ToUpper() : mensagem;
    for (int i = 0; i < vezes; i++)
    {
        Console.WriteLine(msg);
    }
}
```
Neste exemplo, os parâmetros `vezes` e `emMaiusculas` são opcionais, e os chamadores podem omitir um ou ambos ao chamar o método:
```csharp
ExibirMensagem("Olá, mundo!"); // Imprime "Olá, mundo!" uma vez
ExibirMensagem("Olá, mundo!", 3); // Imprime "Olá, mundo!" três vezes
ExibirMensagem("Olá, mundo!", emMaiusculas: true); // Imprime "OLÁ, MUNDO!" uma vez
ExibirMensagem("Olá, mundo!", 3, true); // Imprime "OLÁ, MUNDO!" três vezes
```

## Confusões com parâmetros opcionais
É muito comum confundirem os parametros opcionais com `nullables`, são coisas diferentes, embora possam ser usados juntos.

- Parâmetros opcionais permitem que o chamador omita um argumento, e o método usará um valor padrão. Por exemplo, `int vezes = 1` significa que se o chamador não fornecer um valor para `vezes`, ele assumirá o valor de `1`.
- `Nullable` é um tipo que pode representar um valor ou a ausência de valor (null). Por exemplo, `int? vezes` significa que `vezes` pode ser um inteiro ou null. Se o chamador fornecer null para `vezes`, o método precisará lidar com essa possibilidade.

No entanto, o método
```csharp
public void ExibirMensagem(string mensagem, int? vezes)
{
    int vezesParaExibir = vezes ?? 1; // Se vezes for null, usa 1 como valor padrão
    for (int i = 0; i < vezesParaExibir; i++)
    {
        Console.WriteLine(mensagem);
    }
}
```

Não tira a necessidade de chamar o método passando um valor para `vezes`, mesmo que seja null, porque `vezes` não é um parâmetro opcional. O chamador precisaria fazer algo como:
```csharp
ExibirMensagem("Olá, mundo!", null); // Imprime "Olá, mundo!" uma vez
```

## Parametros vs argumentos
É apenas uma questão de nomenclatura, e na maioria das vezes não há nenhum impecilho na mensagem ao usar um ou outro, mas tecnicamente, parâmetros são as variáveis definidas na assinatura do método, enquanto argumentos são os valores passados para o método quando ele é chamado. Por exemplo:
```csharp
public void ExibirMensagem(string mensagem, int vezes = 1) // "mensagem" e "vezes" são parâmetros
{
    for (int i = 0; i < vezes; i++)
    {        Console.WriteLine(mensagem);
    }
}
ExibirMensagem("Olá, mundo!", 3); // "Olá, mundo!" e "3" são argumentos
```