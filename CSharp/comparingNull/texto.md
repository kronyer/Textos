# Comparando null
Quando comparamos null, principalmente quando nao somos os unicos a escrever o código, é recomendado usar `is null` ao invés de `== null`, para evitar problemas de sobrecarga de operadores. O mesmo vale para `is not null` ao invés de `!= null`.

```csharp
public class MeuObjeto
{
    // Uma sobrecarga de operador mal implementada (ou muito específica)
    public static bool operator ==(MeuObjeto a, MeuObjeto b) => true;
    public static bool operator !=(MeuObjeto a, MeuObjeto b) => false;
}

// Em execução:
MeuObjeto obj = new MeuObjeto(); // O objeto foi instanciado!

Console.WriteLine(obj == null); // Retorna True 😱 (Passou pela sobrecarga)
Console.WriteLine(obj is null); // Retorna False ✅ (Checagem de referência segura)
```