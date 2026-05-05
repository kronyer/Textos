# Central Package Management

Central Package Management é um recurso que permite gerenciar as dependências de pacotes NuGet de forma centralizada em um arquivo `Directory.Packages.props`. Ele foi introduzido para simplificar a manutenção de projetos que compartilham as mesmas dependências, evitando a necessidade de atualizar manualmente cada projeto individualmente.

Isso é muito útil em soluções com múltiplos projetos, onde você pode ter várias bibliotecas e aplicativos que dependem das mesmas versões de pacotes. Com o Central Package Management, você define as versões dos pacotes em um único lugar, e todos os projetos que fazem referência a esses pacotes herdam automaticamente as versões definidas.

## Como usar?

1. Crie um arquivo `Directory.Packages.props` na raiz da sua solução (ou em um diretório pai comum).

2. Adicione as dependências de pacotes que deseja gerenciar centralmente, especificando as versões:

```xml
<Project>
  <ItemGroup>
    <PackageVersion Include="Newtonsoft.Json" Version="13.0.1" />
    <PackageVersion Include="Serilog" Version="2.10.0" />
    <!-- Adicione outras dependências aqui -->
  </ItemGroup>
</Project>
```

3. Nos projetos que precisam dessas dependências, adicione as referências aos pacotes sem especificar a versão:

```xml
<Project>
  <ItemGroup>
    <PackageReference Include="Newtonsoft.Json" />
    <PackageReference Include="Serilog" />
    <!-- Outras referências -->
  </ItemGroup>
</Project>
```

Por fim, crie um arquivo `Directory.Build.props` para centralizar as configurações de build, como a opção de gerenciar as versões dos pacotes centralmente:

```xml
 <PropertyGroup>
    <OutputPath>bin/$(Configuration)/</OutputPath>
    <BaseOutputPath>bin/</BaseOutputPath>
    <BaseIntermediateOutputPath>obj/</BaseIntermediateOutputPath>
    <!-- Central Package Management - versoes gerenciadas em Directory.Packages.props -->
    <ManagePackageVersionsCentrally>true</ManagePackageVersionsCentrally>
  </PropertyGroup>
```

## Package Source Mapping

Para melhorar ainda mais a segurança e o controle sobre as dependências, o NuGet introduziu o recurso de Package Source Mapping. Ele permite que você defina quais pacotes podem ser restaurados de quais fontes, garantindo que apenas pacotes de fontes confiáveis sejam usados em seu projeto.

Isso é, podemos definir exatamente de onde cada pacote deve vir. O que impede ataques de supply chain, onde um atacante pode tentar injetar um pacote malicioso em uma fonte de pacotes pública.

Exemplo de configuração de Package Source Mapping:

```xml
<?xml version="1.0" encoding="utf-8"?>
<configuration>

  <!--
    ══════════════════════════════════════════════════════════════════════════════
    NUGET CONFIGURATION — XGreen Eventos
    ══════════════════════════════════════════════════════════════════════════════

    PACKAGE SOURCE MAPPING (PSM)
    Cada pacote — direto OU transitivo — DEVE corresponder a exatamente um padrão
    abaixo para ser resolvido. Se um pacote não fizer match, o restore falhará
    intencionalmente, impedindo dependency-confusion attacks e garantindo que
    NENHUM pacote venha de uma fonte não autorizada.

    Referências:
      https://learn.microsoft.com/nuget/consume-packages/package-source-mapping
      https://devblogs.microsoft.com/nuget/introducing-package-source-mapping/

    COMO ADICIONAR UM NOVO PACOTE:
      1. Identifique o namespace (ex: Serilog.*)
      2. Adicione o <package pattern="Serilog.*" /> no bloco nuget.org abaixo
      3. Se vier de feed privado, adicione-o no bloco do feed privado
      4. Execute `dotnet restore` para validar

    PACOTES TRANSITIVOS:
      Quando um restore falhar por pacote não mapeado, adicione o namespace
      correspondente aqui. Use `dotnet restore` com verbosity `detailed` para
      identificar o pacote exato.

    FEEDS PRIVADOS:
      Para adicionar um feed privado (Azure Artifacts / GitHub Packages):
        1. Descomente o bloco <add key="MyPrivateFeed" ... /> em packageSources
        2. Descomente e preencha o bloco <packageSource key="MyPrivateFeed"> abaixo
        3. Mova os padrões de pacotes internos de nuget.org para o novo bloco
    ══════════════════════════════════════════════════════════════════════════════
  -->

  <packageSources>
    <clear />
    <!-- Única fonte pública autorizada -->
    <add key="nuget.org" value="https://api.nuget.org/v3/index.json" protocolVersion="3" />

    <!--
      Feed privado — descomente e preencha quando necessário:
      <add key="MyPrivateFeed"
           value="https://pkgs.dev.azure.com/<org>/_packaging/<feed>/nuget/v3/index.json" />
    -->
  </packageSources>

  <packageSourceMapping>

    <!-- ── nuget.org ──────────────────────────────────────────────────────── -->
    <packageSource key="nuget.org">

      <!-- Microsoft — ASP.NET Core, Identity, EF Core, Extensions, IdentityModel -->
      <package pattern="Microsoft.AspNetCore.*" />
      <package pattern="Microsoft.EntityFrameworkCore.*" />
      <package pattern="Microsoft.Extensions.*" />
      <package pattern="Microsoft.IdentityModel.*" />
      <package pattern="Microsoft.NET.*" />
      <package pattern="Microsoft.Bcl.*" />
      <package pattern="Microsoft.CSharp" />
      <package pattern="Microsoft.Win32.*" />
      <package pattern="Microsoft.IO.*" />

      <!-- System.* — transitivos do runtime e bibliotecas base -->
      <package pattern="System.*" />
      <package pattern="runtime.*" />

      <!-- Database -->
      <package pattern="Npgsql" />
      <package pattern="Npgsql.*" />
      <package pattern="Laraue.*" />

      <!-- Messaging -->
      <package pattern="Rebus" />
      <package pattern="Rebus.*" />
      <package pattern="RabbitMQ.*" />

      <!-- API & Gateway -->
      <package pattern="MMLib.*" />
      <package pattern="Swashbuckle.*" />

      <!-- Observability -->
      <package pattern="prometheus-net" />
      <package pattern="prometheus-net.*" />

      <!-- Google Auth — inclui transitivos Google.Apis.* -->
      <package pattern="Google.*" />

      <!-- JSON — transitivo de Google.Apis, RabbitMQ, etc. -->
      <package pattern="Newtonsoft.Json" />

      <!-- Utilities -->
      <package pattern="FluentResults" />
      <package pattern="JetBrains.*" />
      <package pattern="SixLabors.*" />

      <!-- Testing — diretos -->
      <package pattern="Bogus" />
      <package pattern="coverlet.*" />
      <package pattern="Moq" />
      <package pattern="Testcontainers" />
      <package pattern="Testcontainers.*" />
      <package pattern="xunit" />
      <package pattern="xunit.*" />

      <!-- Transitivos de Testcontainers -->
      <package pattern="Docker.DotNet" />
      <package pattern="Docker.DotNet.*" />
      <package pattern="SharpCompress" />
      <package pattern="DotNet.Glob" />

      <!-- Criptografia — transitivos comuns -->
      <package pattern="BouncyCastle.*" />
      <package pattern="Portable.BouncyCastle" />

    </packageSource>

    <!--
      Feed privado — descomente e mova os padrões de pacotes internos para cá:
      <packageSource key="MyPrivateFeed">
        <package pattern="XGreen.*" />
        <package pattern="MeuNamespaceInterno.*" />
      </packageSource>
    -->

  </packageSourceMapping>

  <config>
    <!-- Impede que o NuGet aceite feeds HTTP não seguros (exige HTTPS) -->
<!--    <add key="allowInsecureConnections" value="false" />-->
  </config>

</configuration>
```

## Cultura da manutenção

Manter o arquivo de Package Source Mapping atualizado é crucial para garantir a segurança e a integridade do seu projeto. Sempre que uma nova dependência for adicionada, certifique-se de atualizar o arquivo `NuGet.Config` para incluir o padrão correspondente ao pacote. 

Também reserve um dia semanal ou mensalmente para revisar as dependências do projeto e garantir que todas estejam mapeadas e atualizadas. 