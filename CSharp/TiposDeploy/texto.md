# Tipos de publish c#: FDD, FDE e self contained apps

## FDD (Framework Dependent Deployment)

Esse é o modelo padrão, o que acontece ao dar `dotnet publish` sem nenhum parâmetro. Nesse modelo, vários arquivos `*.dll` são gerados.

Para rodar a aplicação, é necessário ter o .NET instalado na máquina, e o comando para rodar a aplicação é `dotnet nome-da-aplicacao.dll`.

A vantagem desse modelo é que a aplicação é mais leve, pois não inclui o runtime do .NET, e é agnóstica em relação ao sistema operacional, ou seja, roda em qualquer sistema operacional que tenha o .NET instalado.

### Comando

```bash
dotnet publish -c Release
```

## FDE (Framework Dependent Executable)

Similar ao FDD, mas ao invés de gerar um arquivo `*.dll`, que precisaria ser executado com o comando `dotnet nome-da-aplicacao.dll`, ele gera um arquivo executável `*.exe` (no Windows) ou sem extensão (no Linux `./MeuApp`), que pode ser executado diretamente, sem a necessidade de usar o comando `dotnet`.

A única diferença entre FDD e FDE é a forma de execução, o conteúdo gerado é o mesmo, ou seja, ambos dependem do runtime do .NET para rodar e conservam as mesmas vantagens e desvantagens do FDD.

### Comando

```bash
dotnet publish -c Release -r win-x64 --self-contained false
```

## Self-contained apps

Nesse modelo, o runtime do .NET é incluído junto com a aplicação, ou seja, a aplicação é empacotada com tudo o que ela precisa para rodar, incluindo o runtime do .NET. Isso significa que a aplicação pode ser executada em qualquer máquina, mesmo que ela não tenha o .NET instalado.

Como contrapartida, a aplicação gerada é muito maior, pois inclui o runtime do .NET, e é específica para o sistema operacional para o qual foi publicada (Windows, Linux ou macOS).

### Comando

```bash
dotnet publish -c Release -r win-x64 --self-contained true
```

## Outros pontos sobre o publish:


### Publish single file

Esse é um recurso que pode ser usado tanto no FDD quanto no FDE, e tem como objetivo gerar um único arquivo executável, ao invés de vários arquivos `*.dll` e `*.exe`. Ele funciona empacotando todos os arquivos necessários para rodar a aplicação em um único arquivo executável.

### Comando

```bash
dotnet publish -c Release -r win-x64 -p:PublishSingleFile=true --self-contained true
```

Ou, sem ser self-contained:

```bash
dotnet publish -c Release -r win-x64 -p:PublishSingleFile=true --self-contained false
```

## Trim no publish

O trimming é um recurso que pode ser usado para diminuir o tamanho da aplicação publicada. Em resumo, ele analisa o código e remove partes nao "usadas" do runtime do .NET, ou seja, ele remove partes do runtime que não são utilizadas pela aplicação, o que pode reduzir significativamente o tamanho da aplicação publicada.

No entanto, isso pode causar problemas se a aplicação usar reflexão ou outras técnicas que dependem de partes do runtime que foram removidas, então é importante testar a aplicação cuidadosamente após usar o trimming.

### Comando

```bash
dotnet publish -c Release -r win-x64 -p:PublishSingleFile=true --self-contained true -p:PublishTrimmed=true
```

## Caminho do publish

### Jeito tradicional

Por padrão, ao compilar uma solução, que digamos, tenha 5 projetos diferentes, o .NET cria pastas `bin` e `obj` dentro de cada projeto, e dentro dessas pastas, ele cria subpastas para cada configuração (Debug, Release) e para cada framework alvo.

Se rodarmos um publish com FDO, por exemplo, encontrariamos o `.exe` em:
`C:\MeuRepositorio\MeuApp.Web\bin\Release\net8.0\win-x64\publish\MeuApp.exe.`

O que para deploy, CI/CD é um cenário horrível.

### Usando Use Artifacts via Build Props

Agora, temos a propriedade `UseArtifactsOutput` que ao ser usada, faz com que todos os arquivos gerados pelo processo de build e publish sejam colocados em uma pasta `.artifacts` na raiz do repositório.

P.S: Para não ter que fazer isso manualmente, podemos criar um arquivo `Directory.Build.props` na raiz do repositório com o seguinte conteúdo:

```xml
<Project>
  <PropertyGroup>
    <UseArtifactsOutput>true</UseArtifactsOutput>
  </PropertyGroup>
</Project>
```

#### Resultado com tree

```
📁 MeuRepositorio
 ┣ 📁 .artifacts
 ┃ ┣ 📁 bin
 ┃ ┃ ┗ 📁 MeuApp.Web
 ┃ ┃   ┗ 📁 release
 ┃ ┗ 📁 publish
 ┃   ┗ 📁 MeuApp.Web
 ┃     ┗ 📁 release
 ┃       ┗ 📄 MeuApp.exe   <-- Seu executável final (Single File) vem parar direto aqui!
 ┣ 📁 MeuApp.Web
 ┣ 📁 MeuApp.Domain
 ┣ 📄 MeuApp.sln
 ┗ 📄 Directory.Build.props
```

## Notas

- `-r` é o runtime identifier (RID), que indica para qual sistema operacional a aplicação será publicada.
- `p:*` são propriedades "injetadas" diretamente no `.csproj` durante o processo de publicação, ou seja, `-p:PublishSingleFile=true` é equivalente a adicionar `<PublishSingleFile>true</PublishSingleFile>` no `.csproj`.
