ProcessData("");

ProcessData(null);

static void ProcessData(string data)
{
    // Valida se o argumento é nulo
    ArgumentNullException.ThrowIfNull(data, nameof(data));

    // Continuação do processamento dos dados
    Console.WriteLine($"Processando: {data}");
}

