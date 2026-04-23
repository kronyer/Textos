# Indexadores
Através da keyword `this`, é possível criar indexadores em C#. Eles permitem que uma classe ou struct seja indexada como um array, mas com uma sintaxe personalizada.

## Implementação de um indexador
```csharp
public class MyCollection
{
    private int[] data = new int[100];

    public int this[int index]
    {
        get { return data[index]; }
        set { data[index] = value; }
    }
}
```

Ou, algo mais semelhante a um dicionário:

```csharp
public class Configuracoes
{
    private Dictionary<string, string> valores = new Dictionary<string, string>();

    public string this[string chave]
    {
        get => valores.ContainsKey(chave) ? valores[chave] : "Não encontrado";
        set => valores[chave] = value;
    }
}

// Uso:
var config = new Configuracoes();
config["Tema"] = "Escuro"; // Chama o 'set'
Console.WriteLine(config["Tema"]); // Chama o 'get'
```

### Sobrecarregar indexadores
É possível sobrecarregar indexadores para aceitar diferentes tipos de índices ou múltiplos índices:

```csharp
public class Agenda
{
    private string[] nomes = { "Alice", "Bob", "Charlie" };

    public string this[int i] => nomes[i];
    public int this[string nome] => Array.IndexOf(nomes, nome);
}
```

## Vantagens
Ao usar indexadores, podemos ter uma coleção nativa do C#, mas com regras e lógicas personalizadas para acessar os dados. Eles também permitem uma sintaxe mais limpa e intuitiva para acessar elementos de uma coleção.


