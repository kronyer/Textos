# Native AOT c#

No c#, pelo menos em um fluxo normal, pelo Roslyn, o código é compilado para IL, e depois o JIT compila para código nativo ao ser executado (Just in Time). Diferentemente do java, o dotnet não tem capacidade de interpretar o código, ele precisa ser compilado para código nativo (exceção do mono).

O JIT, embora eficiente, tem um cold start, ou seja, a primeira vez que o código é executado, ele precisa ser compilado, o que pode causar uma latência maior. O Native AOT (Ahead of Time) é uma forma de compilar o código para código nativo antes da execução, eliminando essa latência.

Com o AOT, o código sai de C# direto para código de máquina, sem passar pelo IL e JIT, contendo um runtime minimo. Isso pode ser útil para cenários onde a latência é crítica.

## Trade offs

No entanto, ao usar aot, perdemos algumas funcionalidades do runtime, como reflection (e consequentemente as várias bibliotecas que dependem dela). Além disso, APIs que usam controllers ainda não sao suportadas, apenas as Minimal APIs são.

Além disso, podemos notar um tempo de build maior, e a necessidade de Cross-compilation, ou seja, precisamos compilar o código para cada plataforma alvo (windows, linux, macos, etc) dentro de uma máquina com a plataforma alvo. 


## Exemplo de uso

```xml
<PropertyGroup>
  <PublishAot>true</PublishAot>
</PropertyGroup>
```

```
dotnet publish -r win-x64 -p:PublishSingleFile=true --self-contained true
```