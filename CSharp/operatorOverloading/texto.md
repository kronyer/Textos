# Sobrecarga de operadores C#, modelando o amor

Imagine que nosso codigo tem a intecao de modelar um relacionamento simples. Pessoas podem se casar, e Pessoas podem procriar Criancas.

Em um codigo orientado a objetos, isso poderia ser modelado assim:

## Implementacao base
Primeiro teriamos uma classe abstrata Pessoa, com propriedades Nome e Idade, comuns entre Adultos e Criancas.

```cs
public abstract class Pessoa
{
    public string Nome { get; set; }
    public int Idade { get; set; }

    protected Pessoa(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }
}
```

Agora, especializamos a classe Pessoa em Adulto e Crianca, onde Adulto tem a capacidade de casar e procriar.

```cs
public class Crianca : Pessoa
{
    public Crianca(string nome) : base(nome, 0) { }

}

public class Adulto : Pessoa
{
    public Adulto(string nome, int idade) : base(nome, idade) { }

    public Adulto? Conjuge { get; set; }
    public ICollection<Crianca> Filhos { get; set; } = new List<Crianca>();

    public Adulto Casar(Adulto outraPessoa)
    {
        this.Conjuge = outraPessoa;
        outraPessoa.Conjuge = this;
        return this;
    }

    public Crianca Procriar(Adulto outraPessoa)
    {
        var filho = new Crianca("Filho de " + this.Nome + " e " + outraPessoa.Nome);
        this.Filhos.Add(filho);
        outraPessoa.Filhos.Add(filho);
        return filho;
    }

    public override ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine($"Adulto: {Nome}, Idade: {Idade}");
        if (Conjuge != null)        {
            sb.AppendLine($"  Conjuge: {Conjuge.Nome}");

        if (Filhos.Any())
        {
            sb.AppendLine("  Filhos:");
            foreach (var filho in Filhos)
            {
                sb.AppendLine($"    - {filho.Nome}");
            }
        }
        return sb.ToString();
    }
    }
}

```
## Sobrecarga de operadores
Agora, para tornar o código mais fluido e expressivo, podemos sobrecarregar os operadores `+` e `*` para representar casamento e procriação, respectivamente.

```cs
public static Adulto operator +(Adulto a, Adulto b)
{
    return a.Casar(b);
}

public static Crianca operator *(Adulto a, Adulto b)
{
    return a.Procriar(b);
}
```
Com isso, podemos criar um relacionamento de forma mais natural:

```cs
var joao = new Adulto("João", 30);
var maria = new Adulto("Maria", 28);
var casal = joao + maria; // João e Maria se casam
var filho = joao * maria; // João e Maria procriam um filho
Console.WriteLine(casal);
Console.WriteLine(filho);
```