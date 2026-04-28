# Records

Primeiro, precisamos definir o que eh um record. Podemos dizer que ele eh o meio do caminho entre uma classe e uma struct. Isso se da pois, emboram sejam classes - tipos de referencia - eles foram desenvolvidos para se comportarem por valores. Podemos dizer que sao Value Objects.

## Tres pilares

### Comparacao por valor
Diferente de uma classe, onde a comparacao por padrao eh por referencia, ou seja, dois objetos sao iguais se apontarem para o mesmo endereco de memoria, em um record a comparacao eh por valor (como fazer isso na classe).

### Imutabilidade
Dependendo da sintaxe, as propriedades de um record podem ser imutaveis, e na verdade eh encorajado que sejam.

### Concisao
A sintaxe de um record eh mais concisa do que a de uma classe, pois ele gera automaticamente os metodos de comparacao, hash code e to string, entre outros. (Explicar esses metodos)

## Record como syntax-sugar para classes
Um record pode ser visto como uma classe com algumas funcionalidades pre-configuradas, como a comparacao por valor e a geracao de metodos de comparacao, hash code e to string.

Para entedermos melhor, vamos comparar a sintaxe de um record com a de uma classe. 

### Record
```cs
public record Pessoa(string Nome, int Idade);
```
Aqui, por padrao, as propriedades Nome e Idade sao imutaveis, ou seja, nao podem ser alteradas depois de serem definidas. O construtor e o deconstructor sao gerados automaticamente, assim como os metodos de comparacao, hash code e to string.

### Classe
```cs
public class Pessoa : IEquatable<Pessoa>
{
    // 1. Imutabilidade: usamos 'init' para que o valor não mude após a criação
    public string Nome { get; init; }
    public int Idade { get; init; }

    // Construtor para inicializar as propriedades
    public Pessoa(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }

    // 2. Igualdade por Valor: sobrescrevemos o Equals
    public override bool Equals(object? obj) => Equals(obj as Pessoa);

    public bool Equals(Pessoa? other)
    {
        if (other is null) return false;
        if (ReferenceEquals(this, other)) return true; // Se for o mesmo endereço, é igual
        
        // Compara os VALORES das propriedades
        return Nome == other.Nome && Idade == other.Idade;
    }

    // 3. HashCode: necessário para que coleções (como Dictionary) funcionem por valor
    public override int GetHashCode()
    {
        return HashCode.Combine(Nome, Idade);
    }

    // 4. Operadores == e !=: classes comuns comparam referência, records comparam valor
    public static bool operator ==(Pessoa? left, Pessoa? right) => Equals(left, right);
    public static bool operator !=(Pessoa? left, Pessoa? right) => !Equals(left, right);

    // 5. ToString amigável: mostra os dados, não apenas o nome da classe
    public override string ToString()
    {
        return $"Pessoa {{ Nome = {Nome}, Idade = {Idade} }}";
    }

    // 6. Deconstructor: permite fazer var (nome, idade) = pessoa;
    public void Deconstruct(out string nome, out int idade)
    {
        nome = Nome;
        idade = Idade;
    }
}
```

## Operador `with`
O operador `with` permite criar um novo objeto a partir de outro, copiando os valores das propriedades e permitindo que algumas sejam modificadas. Ele é especialmente útil para trabalhar com objetos imutáveis, como os records.

```cs
var pessoa1 = new Pessoa("João", 30);
var pessoa2 = pessoa1 with { Idade = 31 }; // Cria um novo objeto com a mesma Nome, mas Idade diferente
```


## Mitos sobre records


### Records suportam herança
Records podem herdar de outros records, mas não podem herdar de classes. 
```cs
public record Funcionario(string Nome, int Idade, string Cargo) : Pessoa(Nome, Idade);
```

### Nem sempre imutaveis
Embora seja recomendado que as propriedades de um record sejam imutaveis, isso não é uma regra. Por padrao, ao usar a sintaxe posicional, as propriedades sao imutaveis, mas se usarmos a sintaxe de corpo, podemos criar propriedades mutaveis.

```cs
public record Pessoa
{
    public string Nome { get; set; }
    public int Idade { get; set; }
}
```

Nesse cenario, ainda continuariamos tendo a comparacao por valor e os outros beneficios dos records, mas as propriedades poderiam ser alteradas depois de serem definidas.