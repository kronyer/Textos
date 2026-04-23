# Usando static

A keyword `static` em c# altera o funcionamento padrão de classe/objeto. Em uma classe normal, você precisa criar uma instância (objeto) para acessar seus membros (variáveis e métodos). Com `static`, os membros pertencem à classe em si, e não a uma instância específica. 

Em memória, ela é carregada apenas uma vez, no runtime(?).


## Metodos estáticos
Métodos também podem ser estáticos, e podem ser chamados pela classe sem a necessidade de criar um objeto. Eles não podem acessar membros de instância (variáveis ou métodos que não são estáticos) diretamente, pois não têm uma referência a um objeto específico.

```csharp
public class Calculadora
{
    public static int Somar(int a, int b)
    {
        return a + b;
    }
}
```

Se a classe for estática, todos os seus membros devem ser estáticos. Além disso, uma classe estática não pode ser instanciada, ou seja, você não pode criar objetos dela.


## Propriedades estáticas
Propriedades também podem ser estáticas, e funcionam de maneira semelhante aos métodos estáticos. Elas pertencem à classe e podem ser acessadas sem criar uma instância. Essa propriedade é compartilhada entre todas as instâncias da classe, ou seja, se uma instância modificar o valor da propriedade estática, essa mudança será refletida para todas as outras instâncias.

```csharp
public class Configuracao
{
    public static string NomeDoSistema { get; set; }
}
```

# Uso em ExtensionMethods
Até o .net9, para criarmos extension methods, precisariamos de uma classe estática, e o método também deveria ser estático:

```csharp
public static class StringExtensions
{
    public static bool IsNullOrEmpty(this string str)
    {        return string.IsNullOrEmpty(str);
    }
}
```

No .net10, existem Extension Types, que permitem criar extension methods sem a necessidade de uma classe estática. Isso torna o código mais flexível e fácil de usar, pois você pode criar métodos de extensão para tipos específicos sem a necessidade de uma classe dedicada para isso.

```csharp
public implicit extension MyStringExtension for string
{
    // Não precisa de 'static', não precisa de 'this string str' no parâmetro
    public bool IsNullOrEmpty() => string.IsNullOrEmpty(this);
    
    // E agora você pode transformar isso em uma Propriedade!
    public bool HasValue => !string.IsNullOrEmpty(this);
}
```