# Extension methods

Muitas vezes queremos adicionar uma funcionalidade a uma classe sem precisar criar um noto tipo derivado ou modificar a classe original (já que muitas vezes isso não é possível). Para isso, o C# oferece os **extension methods** , que permitem adicionar métodos a tipos existentes sem precisar criar uma nova classe ou modificar a classe original.

Também é muito util para tipos de valor, como `int`, `string`, etc., que não podem ser herdados. Além de permitir que implementar metodos para interfaces, o que é muito útil para adicionar funcionalidades a tipos que implementam essas interfaces.

## Implementação

Para criar um extension method, precisamod de uma classe static, um metodo static e o modificador `this` no primeiro parâmetro do método, indicando o tipo que queremos estender. Por exemplo:

```csharp
public static class StringExtensions
{
    public static bool IsNullOrEmpty(this string str)
    {
        return string.IsNullOrEmpty(str);
    }
}
```

Neste exemplo, criamos um extension method chamado `IsNullOrEmpty` para o tipo `string`. Agora, podemos usar esse método em qualquer string como se fosse um método normal, ou seja, nao precisamos usar string.IsNullOrEmpty, podemos usar diretamente:

```csharp
string myString = null;
bool isNullOrEmpty = myString.IsNullOrEmpty(); // true
myString = "";
isNullOrEmpty = myString.IsNullOrEmpty(); // true
myString = "Hello";
isNullOrEmpty = myString.IsNullOrEmpty(); // false
```

### Adicionando funcionalidades a uma interface

Podemos também adicionar funcionalidades a uma interface usando extension methods. Por exemplo, se quisermos adicionar um método `Print` para a interface `IEnumerable<T>`, podemos fazer o seguinte:

```csharp
public static class IEnumerableExtensions
{
    public static void Print<T>(this IEnumerable<T> collection)
    {
        foreach (var item in collection)
        {
            Console.WriteLine(item);
        }
    }
}
```

### Prioridade de chamada

Se um tipo tem um método com o mesmo nome e assinatura de um extension method, o método do tipo tem prioridade sobre o extension method. Por exemplo:

```csharp
public class MyClass
{
    public void Print()
    {
        Console.WriteLine("Método da classe MyClass");
    }
}

public static class MyClassExtensions
{
    public static void Print(this MyClass myClass)
    {
        Console.WriteLine("Extension method para MyClass");
    }
}

MyClass myObject = new MyClass();
myObject.Print(); // Chama o método da classe MyClass, não o extension method
```

## Nova sintaxe no .net 10

Por baixo dos  panos, os extension methods são apenas métodos estáticos que recebem o tipo estendido como primeiro parâmetro. Ou seja, quando chamamos `myString.IsNullOrEmpty()`, na verdade estamos chamando `StringExtensions.IsNullOrEmpty(myString)`.

O C# 14 traz uma mudança para como os extension members são implementados, permitindo que sejam mais flexíveis e poderosos. A feature se chama Extension Members e introduz uma nova sintaxe com blocos extension dentro de uma classe estática.

### Propriedades e indexadores de extensão

Antigamente, se você quisesse calcular o PrecoComImposto de um produto de uma biblioteca de terceiros, seria obrigado a criar um método: produto.GetPrecoComImposto(). Com Extension Members, você pode criar uma propriedade:

```csharp
public static class ProductExtensions
{
    extension(Product p)
    {
        // Agora parece um campo real da classe!
        public decimal PrecoComImposto => p.Price * 1.2M;

        // Você também pode adicionar indexadores
        public string this[int index] => $"Acessando info extra {index}";
    }
}
```

### Membros estáticos de extensão

Antigamente, os extension methods só podiam ser chamados em instâncias. Com Extension Members, agora é possível adicionar membros estáticos. O bloco extension sem receiver nomeado indica que os membros pertencem ao tipo, não a uma instância:

```csharp
public static class JsonExtensions
{
    extension(string) // sem nome = membros estáticos
    {
        // Adicionando um método estático à classe string!
        public static string FromJson(object obj) => JsonSerializer.Serialize(obj);
    }
}

// Uso:
string meuJson = string.FromJson(meuObjeto);
```

## Fluent interfaces

Extension methods são perfeitos para criar fluent interfaces, onde você pode encadear chamadas de métodos de forma legível e intuitiva. Por exemplo:

```csharp
public static class StringBuilderExtensions
{
    public static StringBuilder AppendLineWithPrefix(this StringBuilder sb, string prefix, string line)
    {
        return sb.AppendLine($"{prefix}: {line}");
    }
}

// Uso:
var sb = new StringBuilder();
sb.AppendLineWithPrefix("INFO", "Iniciando o processo")
  .AppendLineWithPrefix("DEBUG", "Processo em andamento")
  .AppendLineWithPrefix("ERROR", "Ocorreu um erro");
```
