using System.Diagnostics;
using System.IO.Compression;

string originalPath = "dados.txt";
string gzipPath = "dados.gz";
string brotliPath = "dados.br";

// 1. Preparando os testes
long originalSize = new FileInfo(originalPath).Length;

// --- TESTE GZIP ---
var swGzip = Stopwatch.StartNew();
using (FileStream source = File.OpenRead(originalPath))
using (FileStream target = File.Create(gzipPath))
using (GZipStream compression = new GZipStream(target, CompressionLevel.Optimal))
{
    source.CopyTo(compression);
}
swGzip.Stop();

// --- TESTE BROTLI ---
var swBrotli = Stopwatch.StartNew();
using (FileStream source = File.OpenRead(originalPath))
using (FileStream target = File.Create(brotliPath))
using (BrotliStream compression = new BrotliStream(target, CompressionLevel.Optimal))
{
    source.CopyTo(compression);
}
swBrotli.Stop();

// 2. Resultados
long gzipSize = new FileInfo(gzipPath).Length;
long brotliSize = new FileInfo(brotliPath).Length;

Console.WriteLine($"Original: {originalSize / 1024.0:N2} KB");
Console.WriteLine("-----------------------------------------");
Console.WriteLine($"GZip:   {gzipSize / 1024.0:N2} KB | Tempo: {swGzip.ElapsedMilliseconds}ms | Redução: {100 - (gzipSize * 100.0 / originalSize):N2}%");
Console.WriteLine($"Brotli: {brotliSize / 1024.0:N2} KB | Tempo: {swBrotli.ElapsedMilliseconds}ms | Redução: {100 - (brotliSize * 100.0 / originalSize):N2}%");