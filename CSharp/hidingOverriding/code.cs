using System;

public class Program {
    public static void Main() {
        // Cenário 1: Polimorfismo (Late Binding)
        // A variável é Base, mas o objeto é Derived.
        BasePolimorfico obj1 = new DerivedPolimorfico();
        obj1.Display(); 

        Console.WriteLine("---");

        // Cenário 2: Hiding (Static Binding)
        // A variável é Base, o objeto é Derived, mas o método NÃO é virtual.
        BaseHiding obj2 = new DerivedHiding();
        DerivedHiding obj3 = new DerivedHiding();
        obj2.Display();
        obj3.Display();
    }
}

// --- CLASSES PARA OVERRIDING ---
public class BasePolimorfico {
    public virtual void Display() => Console.WriteLine("Base Polimórfica");
}

public class DerivedPolimorfico : BasePolimorfico {
    public override void Display() => Console.WriteLine("Derived (Override)");
}

// --- CLASSES PARA HIDING ---
public class BaseHiding {
    public void Display() => Console.WriteLine("Base Hiding");
}

public class DerivedHiding : BaseHiding {
    public new void Display() => Console.WriteLine("Derived (New/Hiding)");
}