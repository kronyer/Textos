#!/usr/bin/env dotnet-script

//shebang para ativar compilador


public sealed class MinhaClasse
{
    public void MeuMetodo()
    {        Console.WriteLine("Este método não pode ser sobrescrito, pois a classe nao pode ser herdada.");
    }
}

public class MinhaClasseHeranca : MinhaClasse
{
    // Este método não pode ser sobrescrito, pois a classe base é selada
    // public override void MeuMetodo() --- IGNORE ---
    // {
    //     Console.WriteLine("Tentando sobrescrever um método de uma classe selada.");
    // }
}

public class ClasseBase
{
    public virtual void MeuMetodoASelar()
    {
        Console.WriteLine("Este método pode ser sobrescrito.");
    }
}

public class ClasseNormalMetodoSelado : ClasseBase
{
    public virtual void MeuMetodo()
    {
        Console.WriteLine("Este método pode ser sobrescrito.");
    }

    public sealed override void MeuMetodoASelar()
    {
        Console.WriteLine("Este método é selado e não pode ser sobrescrito.");
    }
}

public class ClasseHerdada : ClasseNormalMetodoSelado
{
    // Este método pode ser sobrescrito normalmente
    public override void MeuMetodo()
    {
        Console.WriteLine("Sobrescrevendo um método normal.");
    }

    // Este método não pode ser sobrescrito, pois foi selado na classe base
    public override void MeuMetodoASelar()
     {
         Console.WriteLine("Tentando sobrescrever um método selado.");
     }
}