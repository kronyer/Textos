# `[SetRequiredMembers]` e `required` properties
Essa tag surge para resolver o problema de como garantir que um objeto seja criado com os dados necessarios sem ter que fazer um construtor gigante?

## Utilizando `required` properties
A partir do C# 11, podemos usar a palavra-chave `required` para indicar que uma propriedade deve ser inicializada durante a criação do objeto. Isso é especialmente útil para classes que possuem muitas propriedades, evitando a necessidade de construtores com muitos parâmetros.

```cs
public class Pessoa
{
    public required string Nome { get; set; }
    public required int Idade { get; set; }
}

var pessoa = new Pessoa { Nome = "João", Idade = 30 }; // Correto
var pessoaIncompleta = new Pessoa { Nome = "Maria" }; // Erro de compilação, Idade é required
```

## O problema
O problema é que, mesmo com `required`, se criarmos um objeto através de um construtor, o compilador ira reclamar, achando que as propriedades obrigatorias nao foram inicializadas, mesmo que o construtor as inicialize.

```cs
public class Pessoa
{
    public required string Nome { get; set; }
    public required int Idade { get; set; }

    public Pessoa(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }
}

var pessoa = new Pessoa("Pedro", 30); // Erro de compilação, propriedades required não foram inicializadas
```

Para corrigir isso, precisamos usar a anotação `[SetRequiredMembers]` na classe, indicando que o construtor irá garantir a inicialização das propriedades obrigatórias.

```cs
public class Pessoa
{
    public required string Nome { get; set; }
    public required int Idade { get; set; }

    [SetRequiredMembers]
    public Pessoa(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }
}
```
No entanto, eh importante saber que o compilador agora confia que o construtor irá inicializar as propriedades required, e nao ira mais reclamar, mesmo que o construtor nao as inicialize, entao é importante garantir que o construtor realmente faça isso.