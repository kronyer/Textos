using System.Diagnostics.CodeAnalysis;

var pessoa = new Pessoa("Pedro", 30);

public class Pessoa
{
    public required string Nome { get; set; }
    public required int Idade { get; set; }

[SetsRequiredMembers]
    public Pessoa(string nome, int idade)
    {
        Nome = nome;
    }
}