# Modificadores de acesso

Modificadores de acesso são palavras-chave que definem a visibilidade de uma classe, método, ou propriedade. 

São muito poderosos para controlar acessos e dependências, e são essenciais para o encapsulamento, um dos pilares da programação orientada a objetos.

## Tipos de modificadores de acesso
- `public`: O membro é acessível de qualquer lugar.
- `private`: O membro é acessível apenas dentro da classe onde foi declarado.
- `protected`: O membro é acessível dentro da classe onde foi declarado e em classes derivadas.
- `internal`: O membro é acessível apenas dentro do mesmo assembly.
- `protected internal`: O membro é acessível dentro do mesmo assembly ou em classes derivadas.
- `private protected`: O membro é acessível apenas dentro da classe onde foi declarado e em classes derivadas dentro do mesmo assembly.
- `file`: O membro é acessível apenas dentro do mesmo arquivo de código-fonte.

## Diferença `file` e `internal`
O modificador `file` é mais restritivo que o `internal`, pois limita o acesso apenas ao arquivo onde o membro é declarado, enquanto o `internal` permite acesso a qualquer código dentro do mesmo assembly, mesmo que esteja em arquivos diferentes.

Um `assembly` é definido por um `.csproj` e pode conter múltiplos arquivos de código-fonte. Portanto, um membro `internal` pode ser acessado por qualquer código dentro do mesmo projeto, enquanto um membro `file` só pode ser acessado por código dentro do mesmo arquivo, definido por `.cs`.