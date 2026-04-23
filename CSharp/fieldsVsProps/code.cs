var jgVivo = new Jogador();
jgVivo.Saude = 100; // Usa a propriedade para definir a saúde
Console.WriteLine(jgVivo.Saude); // Usa a propriedade para acessar a saúde

var jgMorto = new Jogador();
jgMorto.Saude = -50; // Tenta definir a saúde como um valor negativo
Console.WriteLine(jgMorto.Saude); // A propriedade impede que a saúde

Console.WriteLine("Usando auto-properties:");
var jgVivoAuto = new JogadorFields();
jgVivoAuto.Saude = 100; // Usa a auto-propriedade para definir a saúde
Console.WriteLine(jgVivoAuto.Saude); // Usa a auto-propriedade para acessar a saúde
var jgMortoAuto = new JogadorFields();
jgMortoAuto.Saude = -50; // Tenta definir a saúde como um valor negativo
Console.WriteLine(jgMortoAuto.Saude); // A auto-propriedade impede que a saúde seja negativa
public class Jogador
{
    private int _saude; // Campo (Field)

    public int Saude // Propriedade (Property)
    {
        get { return _saude; }
        set 
        { 
            // Lógica: Impede que a saúde seja negativa
            if (value < 0) _saude = 0;
            else _saude = value;
        }
    }
}

public class JogadorFields
{
    public int Saude
    {
        get;
        set => field = value < 0 ? 0 : value; // Lógica para impedir saúde negativa
    }
}