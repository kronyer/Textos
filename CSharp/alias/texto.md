# Alias c#
Alias é uma funcionalidade do C# que permite criar um nome alternativo para um tipo, namespace ou membro. Isso pode ser útil para evitar conflitos de nomes, melhorar a legibilidade do código ou simplesmente para encurtar nomes longos.

## Criando um alias
Para criar um alias, você pode usar a diretiva `using` seguida do nome do alias e do tipo ou namespace que deseja referenciar. Por exemplo:
```csharp
using Project = MyCompany.Project;
```
Neste exemplo, `Project` é um alias para `MyCompany.Project`. Agora, você pode usar `Project` em vez de `MyCompany.Project` em seu código.

### Usando alias para tipos
Você também pode criar alias para tipos específicos. Por exemplo:
```csharp
using IntList = System.Collections.Generic.List<int>;
```
Neste caso, `IntList` é um alias para `List<int>`, e você pode usar `IntList` para declarar variáveis ou criar instâncias de `List<int>`:
```csharp
IntList numbers = new IntList();
numbers.Add(1);
numbers.Add(2);
```

### Usando alias para membros
Além de tipos e namespaces, você também pode criar alias para membros específicos. Por exemplo:
```csharp
using ConsoleWriteLine = System.Console.WriteLine;
```
Agora, você pode usar `ConsoleWriteLine` para chamar o método `WriteLine` do `Console`:
```csharp
ConsoleWriteLine("Hello, World!");
```

### Aliases para tuplas
Você também pode criar alias para tuplas, o que pode ser útil para melhorar a legibilidade do código. Por exemplo:
```csharp
using Point = (int X, int Y);
```
Agora, você pode usar `Point` para declarar variáveis do tipo tupla:
```csharp
Point p = (X: 10, Y: 20);
Console.WriteLine($"X: {p.X}, Y: {p.Y}");
```

## Global using
A partir do C# 10, você pode usar a diretiva `global using` para criar aliases que estão disponíveis em todo o projeto, sem a necessidade de importar o alias em cada arquivo. Por exemplo:
```csharp
global using Project = MyCompany.Project;
```
Com isso, o alias `Project` estará disponível em todos os arquivos do projeto, facilitando o uso do tipo ou namespace referenciado sem a necessidade de importar o alias em cada arquivo.