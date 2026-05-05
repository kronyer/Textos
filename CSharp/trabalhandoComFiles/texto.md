# Trabalhando com files

O namespace `System.IO` em C# fornece classes para trabalhar com arquivos e diretórios. Ele inclui classes para ler e escrever arquivos, manipular diretórios, e trabalhar com caminhos de arquivos.

Para leitura e escrita, usando `File` podemos:

```csharp
// Escreve texto em um arquivo
File.WriteAllText("caminho/do/arquivo.txt", "Conteúdo do arquivo"); 
// Lê o conteúdo de um arquivo
string conteudo = File.ReadAllText("caminho/do/arquivo.txt");
//ou
string linha = File.ReadLines("caminho/do/arquivo.txt").FirstOrDefault();
```

## Streams

As streams são uma abstração para ler e escrever dados de forma sequencial. Elas podem ser usadas para trabalhar com arquivos, memória, ou até mesmo redes. As classes `FileStream`, `MemoryStream`, e `NetworkStream` são exemplos de streams em C#.

```csharp
// Criando um FileStream para ler um arquivo
using (FileStream fs = new FileStream("caminho/do/arquivo.txt", FileMode.Open))
{
    // Ler dados do arquivo usando o FileStream
}
```

## GZip vs Brotli

GZip e Brotli são algoritmos de compressão usados para reduzir o tamanho dos arquivos. GZip é um algoritmo mais antigo e amplamente suportado, enquanto Brotli é um algoritmo mais recente que oferece melhor taxa de compressão, especialmente para arquivos de texto. Em C#, você pode usar as classes `GZipStream` e `BrotliStream` para trabalhar com esses algoritmos de compressão.

```csharp
// Usando GZipStream para comprimir um arquivo
using (FileStream originalFileStream = new FileStream("caminho/do/arquivo.txt", FileMode.Open))
using (FileStream compressedFileStream = new FileStream("caminho/do/arquivo.txt.gz", FileMode.Create))
using (GZipStream compressionStream = new GZipStream(compressedFileStream, CompressionMode.Compress))
{    originalFileStream.CopyTo(compressionStream);
}
```

```csharp
// Usando BrotliStream para comprimir um arquivo
using (FileStream originalFileStream = new FileStream("caminho/do/arquivo.txt", FileMode.Open))
using (FileStream compressedFileStream = new FileStream("caminho/do/arquivo.txt.br", FileMode.Create))
using (BrotliStream compressionStream = new BrotliStream(compressedFileStream, CompressionMode.Compress))
{    originalFileStream.CopyTo(compressionStream);
}
```