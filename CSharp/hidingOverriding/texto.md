# Hiding vs Overriding
Hiding e overriding são dois conceitos relacionados à herança em C#. Ambos envolvem a redefinição de membros (métodos, propriedades, etc.) em uma classe derivada, mas eles funcionam de maneiras diferentes.

## Hiding
Hiding ocorre quando um membro em uma classe derivada tem o mesmo nome que um membro na classe base, mas não é marcado com a palavra-chave `override`. Nesse caso, o membro da classe derivada "esconde" o membro da classe base. Para acessar o membro da classe base, é necessário usar a palavra-chave `base`.

```csharp
public class BaseClass
{
    public void Display()
    {        Console.WriteLine("BaseClass Display");
    }
}

public class DerivedClass : BaseClass
{
    public new void Display() // 'new' indica que este método esconde o da classe base
    {
        Console.WriteLine("DerivedClass Display");
    }
}
// Uso:
DerivedClass obj = new DerivedClass();
obj.Display(); // Chama o método da classe derivada
((BaseClass)obj).Display(); // Chama o método da classe base usando cast
```

## Overriding
Overriding ocorre quando um membro em uma classe derivada tem o mesmo nome e assinatura que um membro virtual ou abstrato na classe base, e é marcado com a palavra-chave `override`. Isso permite que o membro da classe derivada substitua o comportamento do membro da classe base. O membro da classe base deve ser declarado como `virtual`, `abstract` ou `override` para que possa ser sobrescrito.

```csharp
public class BaseClass
{
    public virtual void Display()
    {
        Console.WriteLine("BaseClass Display");
    }
}

public class DerivedClass : BaseClass
{
    public override void Display() // 'override' indica que este método substitui o da classe base
    {
        Console.WriteLine("DerivedClass Display");
    }
}

// Uso:
DerivedClass obj = new DerivedClass();
obj.Display(); // Chama o método da classe derivada
BaseClass baseObj = obj; // Upcasting
baseObj.Display(); // Chama o método da classe derivada devido ao polimorfismo
```


# Diferenças por baixo dos panos
## No Overriding (Late Binding)
O compilador usa a instrução callvirt.
No IL, o callvirt não chama um endereço fixo. Ele consulta a vtable (Virtual Method Table) do objeto em tempo de execução.

Mesmo que você tenha Base obj = new Derivada();, o callvirt olha para a vtable da instância real (Derivada) e executa o método dela. É aqui que o polimorfismo acontece.

## No Hiding (Early/Static Binding)
O compilador pode usar callvirt (para evitar null checks), mas a resolução é diferente. Como o método new na classe filha não está na mesma "linha" da vtable do método da base, o runtime entende que são coisas distintas.

Se a variável for do tipo Base, ele chama o método da Base.

Se for do tipo Derivada, ele chama o da Derivada.

Não há "vínculo" entre eles; o endereço é resolvido com base no tipo que o compilador enxerga no momento.


# Observando no SharpLab.io

O seguinte código pode ser testado no SharpLab.io para observar as diferenças entre hiding e overriding:

```csharp
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
        obj2.Display();
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
```

Que nos retorna:

```IL
.assembly _
{
    .custom instance void [System.Runtime]System.Runtime.CompilerServices.CompilationRelaxationsAttribute::.ctor(int32) = (
        01 00 08 00 00 00 00 00
    )
    .custom instance void [System.Runtime]System.Runtime.CompilerServices.RuntimeCompatibilityAttribute::.ctor() = (
        01 00 01 00 54 02 16 57 72 61 70 4e 6f 6e 45 78
        63 65 70 74 69 6f 6e 54 68 72 6f 77 73 01
    )
    .custom instance void [System.Runtime]System.Diagnostics.DebuggableAttribute::.ctor(valuetype [System.Runtime]System.Diagnostics.DebuggableAttribute/DebuggingModes) = (
        01 00 07 01 00 00 00 00
    )
    .permissionset reqmin = (
        2e 01 80 8a 53 79 73 74 65 6d 2e 53 65 63 75 72
        69 74 79 2e 50 65 72 6d 69 73 73 69 6f 6e 73 2e
        53 65 63 75 72 69 74 79 50 65 72 6d 69 73 73 69
        6f 6e 41 74 74 72 69 62 75 74 65 2c 20 53 79 73
        74 65 6d 2e 52 75 6e 74 69 6d 65 2c 20 56 65 72
        73 69 6f 6e 3d 39 2e 30 2e 30 2e 30 2c 20 43 75
        6c 74 75 72 65 3d 6e 65 75 74 72 61 6c 2c 20 50
        75 62 6c 69 63 4b 65 79 54 6f 6b 65 6e 3d 62 30
        33 66 35 66 37 66 31 31 64 35 30 61 33 61 15 01
        54 02 10 53 6b 69 70 56 65 72 69 66 69 63 61 74
        69 6f 6e 01
    )
    .hash algorithm 0x00008004 // SHA1
    .ver 0:0:0:0
}

.class private auto ansi '<Module>'
{
} // end of class <Module>

.class public auto ansi beforefieldinit Program
    extends [System.Runtime]System.Object
{
    // Methods
    .method public hidebysig static 
        void Main () cil managed 
    {
        // Method begins at RVA 0x2050
        // Code size 39 (0x27)
        .maxstack 1
        .locals init (
            [0] class BasePolimorfico obj1,
            [1] class BaseHiding obj2
        )

        IL_0000: nop
        IL_0001: newobj instance void DerivedPolimorfico::.ctor()
        IL_0006: stloc.0
        IL_0007: ldloc.0
        IL_0008: callvirt instance void BasePolimorfico::Display()
        IL_000d: nop
        IL_000e: ldstr "---"
        IL_0013: call void [System.Console]System.Console::WriteLine(string)
        IL_0018: nop
        IL_0019: newobj instance void DerivedHiding::.ctor()
        IL_001e: stloc.1
        IL_001f: ldloc.1
        IL_0020: callvirt instance void BaseHiding::Display()
        IL_0025: nop
        IL_0026: ret
    } // end of method Program::Main

    .method public hidebysig specialname rtspecialname 
        instance void .ctor () cil managed 
    {
        // Method begins at RVA 0x2083
        // Code size 8 (0x8)
        .maxstack 8

        IL_0000: ldarg.0
        IL_0001: call instance void [System.Runtime]System.Object::.ctor()
        IL_0006: nop
        IL_0007: ret
    } // end of method Program::.ctor

} // end of class Program

.class public auto ansi beforefieldinit BasePolimorfico
    extends [System.Runtime]System.Object
{
    // Methods
    .method public hidebysig newslot virtual 
        instance void Display () cil managed 
    {
        // Method begins at RVA 0x208c
        // Code size 12 (0xc)
        .maxstack 8

        IL_0000: ldstr "Base Polimórfica"
        IL_0005: call void [System.Console]System.Console::WriteLine(string)
        IL_000a: nop
        IL_000b: ret
    } // end of method BasePolimorfico::Display

    .method public hidebysig specialname rtspecialname 
        instance void .ctor () cil managed 
    {
        // Method begins at RVA 0x2083
        // Code size 8 (0x8)
        .maxstack 8

        IL_0000: ldarg.0
        IL_0001: call instance void [System.Runtime]System.Object::.ctor()
        IL_0006: nop
        IL_0007: ret
    } // end of method BasePolimorfico::.ctor

} // end of class BasePolimorfico

.class public auto ansi beforefieldinit DerivedPolimorfico
    extends BasePolimorfico
{
    // Methods
    .method public hidebysig virtual 
        instance void Display () cil managed 
    {
        // Method begins at RVA 0x2099
        // Code size 12 (0xc)
        .maxstack 8

        IL_0000: ldstr "Derived (Override)"
        IL_0005: call void [System.Console]System.Console::WriteLine(string)
        IL_000a: nop
        IL_000b: ret
    } // end of method DerivedPolimorfico::Display

    .method public hidebysig specialname rtspecialname 
        instance void .ctor () cil managed 
    {
        // Method begins at RVA 0x20a6
        // Code size 8 (0x8)
        .maxstack 8

        IL_0000: ldarg.0
        IL_0001: call instance void BasePolimorfico::.ctor()
        IL_0006: nop
        IL_0007: ret
    } // end of method DerivedPolimorfico::.ctor

} // end of class DerivedPolimorfico

.class public auto ansi beforefieldinit BaseHiding
    extends [System.Runtime]System.Object
{
    // Methods
    .method public hidebysig 
        instance void Display () cil managed 
    {
        // Method begins at RVA 0x20af
        // Code size 12 (0xc)
        .maxstack 8

        IL_0000: ldstr "Base Hiding"
        IL_0005: call void [System.Console]System.Console::WriteLine(string)
        IL_000a: nop
        IL_000b: ret
    } // end of method BaseHiding::Display

    .method public hidebysig specialname rtspecialname 
        instance void .ctor () cil managed 
    {
        // Method begins at RVA 0x2083
        // Code size 8 (0x8)
        .maxstack 8

        IL_0000: ldarg.0
        IL_0001: call instance void [System.Runtime]System.Object::.ctor()
        IL_0006: nop
        IL_0007: ret
    } // end of method BaseHiding::.ctor

} // end of class BaseHiding

.class public auto ansi beforefieldinit DerivedHiding
    extends BaseHiding
{
    // Methods
    .method public hidebysig 
        instance void Display () cil managed 
    {
        // Method begins at RVA 0x20bc
        // Code size 12 (0xc)
        .maxstack 8

        IL_0000: ldstr "Derived (New/Hiding)"
        IL_0005: call void [System.Console]System.Console::WriteLine(string)
        IL_000a: nop
        IL_000b: ret
    } // end of method DerivedHiding::Display

    .method public hidebysig specialname rtspecialname 
        instance void .ctor () cil managed 
    {
        // Method begins at RVA 0x20c9
        // Code size 8 (0x8)
        .maxstack 8

        IL_0000: ldarg.0
        IL_0001: call instance void BaseHiding::.ctor()
        IL_0006: nop
        IL_0007: ret
    } // end of method DerivedHiding::.ctor

} // end of class DerivedHiding

```

## Entendendo o IL

### Cenário polimórfico (Overriding):
Vamos focar na seguinte parte:

```IL
IL_0007: ldloc.0
IL_0008: callvirt instance void BasePolimorfico::Display()
```

Ele chama `callvirt` (chamada virtual) apontando para a Base.

E olhando para a definição da classe `BasePolimorfico`, o método tem a flag `newslot virtual`, o que significa que ele é virtual e pode ser sobrescrito.

Já a classe `DerivedPolimorfico` tem a flag `virtual` sem o `newslot`, indicando que é uma implementação de um método virtual da base.

#### No late binding:
Como o método da base é virtual e a Derived não criou novo slot, o CLR entende que eles compartilhando o mesmo index na vtable. Então quando o callvirt é executado, o CLR olha para o objeto na heap, ve que ele é `DerivedPolimorfico` e usa o endereço do método da classe filha, que está naquele slot da vtable.

### Cenário de hiding:
Vamos agora observar as seguintes linhas:

```IL
IL_001f: ldloc.1
IL_0020: callvirt instance void BaseHiding::Display()
```

Aqui também é usado `callvirt`, Mas nesse cenário, a definição de `BaseHiding::Display` não tem a flag `virtual`, e também a `DerivedHiding::Display` não tem.

#### No static binding:
Como não existe a flag `virtual`, o CLR nao tem vtable para consultar. Logo, ignora que o objeto é do tipo `DerivedHiding` e chama diretamente o método da `BaseHiding`.