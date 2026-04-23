# Partials
## Partial Classes
Partial classes permitem que a definição de uma classe seja dividida em múltiplos arquivos. Isso é útil para organizar o código, especialmente quando a classe é grande ou quando partes dela são geradas automaticamente (como em scaffolding). Para usar partial classes, basta usar a palavra-chave `partial` na definição da classe em cada arquivo. Por exemplo:

```csharp
// Arquivo Jogador.cs
public partial class Jogador
{
    public string Nome { get; set; }
}

// Arquivo JogadorSaude.cs
public partial class Jogador
{
    public int Saude { get; set; }
}
```
Nesse exemplo, a classe `Jogador` é dividida em dois arquivos, mas quando o código é compilado, eles são combinados em uma única classe `Jogador` com ambas as propriedades `Nome` e `Saude`.


## Partial Methods
Partial methods são métodos que podem ser declarados em uma parte de uma classe parcial, mas só podem ser implementados em outra parte da mesma classe parcial. Eles são úteis para fornecer pontos de extensão em código gerado automaticamente, permitindo que os desenvolvedores adicionem lógica personalizada sem modificar o código gerado. A declaração de um método parcial inclui a palavra-chave `partial`, e a implementação do método é opcional. Se um método parcial for declarado, mas não implementado, o compilador irá remover a declaração do método e todas as chamadas para ele, resultando em código mais limpo. Por exemplo:

Antigamente, métodos parciais eram muito restritos (tinham que ser void e private). Atualmente, se você adicionar um modificador de acesso (como public), a implementação torna-se obrigatória.

* Sem modificador de acesso: É privado por padrão. Se não for implementado, a chamada é ignorada.

* Com modificador (public, internal): Requer uma implementação definida em outra parte do código.

```csharp
public partial class GeradorRelatorio {
    // Definição
    partial void OnRelatorioIniciado();

    public void Gerar() {
        OnRelatorioIniciado(); // Se não houver corpo, esta linha "some" na compilação.
        // Lógica de geração...
    }
}

// Em outro arquivo
public partial class GeradorRelatorio {
    // Implementação
    partial void OnRelatorioIniciado() {
        Console.WriteLine("Relatório iniciado!");
    }
}
```

## Partial Properties
Partial properties são uma extensão dos métodos parciais, permitindo que as propriedades também sejam divididas em múltiplas partes. Assim como os métodos parciais, as propriedades parciais podem ser declaradas em uma parte de uma classe parcial e implementadas em outra parte. Isso é útil para adicionar lógica personalizada a propriedades em código gerado automaticamente. A declaração de uma propriedade parcial inclui a palavra-chave `partial`, e a implementação da propriedade é opcional. Se uma propriedade parcial for declarada, mas não implementada, o compilador irá remover a declaração da propriedade e todas as referências a ela, resultando em código mais limpo. Por exemplo:

```csharp
public partial class Configuracao {
    // Definição
    public partial string CaminhoArquivo { get; set; }

    public void Carregar() {
        Console.WriteLine($"Carregando configuração do arquivo: {CaminhoArquivo}");
    }
}
// Em outro arquivo
public partial class Configuracao {
    // Implementação
    public partial string CaminhoArquivo {
        get { return _caminhoArquivo; }
        set { _caminhoArquivo = value; }
    }
    private string _caminhoArquivo;
}
```