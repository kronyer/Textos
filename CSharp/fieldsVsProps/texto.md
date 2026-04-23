# Fields vs Properties
No que diz respeito a encapsulamento, os campos (fields) e as propriedades (properties) são dois conceitos fundamentais em C#.

## Campos (Fields)
Campos são variáveis declaradas diretamente dentro de uma classe ou struct. Eles podem ser públicos, privados ou protegidos, dependendo do modificador de acesso usado. Eles não contém lógica adicional, ou seja, são apenas um local para armazenar dados. Por exemplo:

```csharp
public class Jogador
{
    // Isso é um campo privado
    private int saude; 
}
```

## Propriedades (Properties)
Propriedades são membros de uma classe que fornecem um mecanismo flexível para ler, gravar ou calcular os valores de campos privados. Elas são usadas para encapsular a lógica de acesso aos dados, permitindo que você controle como os valores são definidos ou recuperados, sendo um wrapper da variavel. Por exemplo:

```csharp
public class Jogador
{
    private int _saude; // Campo (Field)

    public int Saude // Propriedade (Property)
    {
        get { return _saude; }
        set 
        { 
            // Lógica: Impede que a saúde seja negativa
            if (value < 0) _saude = 0;
            else _saude = value;
        }
    }
}
```

O C# 3 introduziu as propriedades automáticas, que permitem declarar uma propriedade sem precisar de um campo de apoio explícito. O compilador gera automaticamente um campo privado para armazenar o valor da propriedade. Por exemplo:

```csharp
public class Jogador
{
    public int Saude { get; set; } // Propriedade automática
}
```

No entanto, para propriedades automáticas, o campo de apoio é gerado pelo compilador e não é acessível diretamente no código. Se você precisar de lógica personalizada para acessar ou modificar o valor da propriedade, precisará usar uma propriedade tradicional com um campo de apoio explícito, chamado de `backing field`.

Isso é, precisaria, já que no .NET 10 surgiu uma keyword chamado `field` que permite acessar o campo de apoio gerado pelo compilador para uma propriedade automática, mesmo sem declará-lo explicitamente. Por exemplo:

```csharp
//antes:
private int _idade;
public int Idade 
{ 
    get => _idade; 
    set => _idade = value < 0 ? 0 : value; 
}

//agora:
public int Idade 
{ 
    get; 
    set => field = value < 0 ? 0 : value; 
}
```
