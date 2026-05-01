# Polimorfismi
Um dos pilares da OOP, polimorfismo é a capacidade de um objeto de se comportar de diferentes formas, dependendo do contexto. 

O mais comum, e talvez o senso comum do que seja polimorfismo, é o polimorfismo de subtipos, onde uma classe derivada pode ter uma implementação diferente de um método definido na classe base.

```csharp
public class Animal
{
    public virtual void MakeSound()
    {        Console.WriteLine("Animal makes a sound");
    }
}
public class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Dog barks");
    }
}
public class Cat : Animal
{
    public override void MakeSound()
    {        Console.WriteLine("Cat meows");
    }
}
```

Também podemos ter polimorfismo de sobrecarga, onde métodos com o mesmo nome têm assinaturas diferentes, e o compilador escolhe qual método chamar com base nos argumentos fornecidos.

```csharp
public class Calculator
{
    public int Add(int a, int b)
    {        return a + b;
    }
    public double Add(double a, double b)
    {        return a + b;
    }
}
```

## Polimorfismo e Upcasting
O polimorfismo de subtipos, mesmo quando o objeto sofre um upcasting para a classe base, o método sobrescrito na classe derivada é chamado, graças ao mecanismo de VTable.

```
Animal myDog = new Dog();
myDog.MakeSound(); // Output: "Dog barks"
```

## Funcionamento da VTable
Toda classe que possui metodos virtuais tem sua propria VTable, que é uma tabela de ponteiros das implementações dos métodos virtuais.

Portanto, quanto o `myDog.MakeSound()` é chamado, o runtime nao chama o metodo da classe `Animal`, ele segue o ponteiro na VTable até a implementação correta, que é a do `Dog`.


## Perfomance e JIT
Métodos comuns, estáticos, o compilador sabe exatamente qual código chamar, e pode otimizar a chamada, isso é chamado de early binding. Já métodos virtuais, o compilador não tem certeza de qual implementação será chamada, então ele gera um código que faz a consulta na VTable em tempo de execução, isso é chamado de late binding, e tem um custo de performance.

### Análise:
O seguinte código c#:

```csharp
using System;

public class Animal {
    // Chamada Direta (Static Binding / Early Binding)
    public void FazerSomComum() => Console.WriteLine("Som comum");

    // Chamada via VTable (Dynamic Binding / Late Binding)
    public virtual void FazerSomVirtual() => Console.WriteLine("Som virtual");
}

public class Program {
    public void Test() {
        Animal animal = new Animal();
        
        // 1. O compilador já sabe o endereço exato aqui
        animal.FazerSomComum(); 
        
        // 2. O compilador precisa consultar a VTable aqui
        animal.FazerSomVirtual(); 
    }
}
```

no sharplab.io, com o resultado em JIT Asm:

```asm
; Core CLR 9.0.1326.6317 on x86

Animal..ctor()
    L0000: push ebp
    L0001: mov ebp, esp
    L0003: push edi
    L0004: push eax
    L0005: mov [ebp-8], ecx
    L0008: cmp dword ptr [0x295fc140], 0
    L000f: je short L0016
    L0011: call 0x72e410c0
    L0016: mov ecx, [ebp-8]
    L0019: call dword ptr [0xc0e6388]
    L001f: nop
    L0020: nop
    L0021: pop ecx
    L0022: pop edi
    L0023: pop ebp
    L0024: ret

Animal.FazerSomComum()
    L0000: push ebp
    L0001: mov ebp, esp
    L0003: push edi
    L0004: push eax
    L0005: mov [ebp-8], ecx
    L0008: cmp dword ptr [0x295fc140], 0
    L000f: je short L0016
    L0011: call 0x72e410c0
    L0016: mov ecx, [0x9036f48]
    L001c: call dword ptr [0x1195c6f0]
    L0022: nop
    L0023: nop
    L0024: pop ecx
    L0025: pop edi
    L0026: pop ebp
    L0027: ret

Animal.FazerSomVirtual()
    L0000: push ebp
    L0001: mov ebp, esp
    L0003: push edi
    L0004: push eax
    L0005: mov [ebp-8], ecx
    L0008: cmp dword ptr [0x295fc140], 0
    L000f: je short L0016
    L0011: call 0x72e410c0
    L0016: mov ecx, [0x9036f4c]
    L001c: call dword ptr [0x1195c6f0]
    L0022: nop
    L0023: nop
    L0024: pop ecx
    L0025: pop edi
    L0026: pop ebp
    L0027: ret

Program..ctor()
    L0000: push ebp
    L0001: mov ebp, esp
    L0003: push edi
    L0004: push eax
    L0005: mov [ebp-8], ecx
    L0008: cmp dword ptr [0x295fc140], 0
    L000f: je short L0016
    L0011: call 0x72e410c0
    L0016: mov ecx, [ebp-8]
    L0019: call dword ptr [0xc0e6388]
    L001f: nop
    L0020: nop
    L0021: pop ecx
    L0022: pop edi
    L0023: pop ebp
    L0024: ret

Program.Test()
    L0000: push ebp
    L0001: mov ebp, esp
    L0003: sub esp, 0xc
    L0006: xor eax, eax
    L0008: mov [ebp-8], eax
    L000b: mov [ebp-0xc], eax
    L000e: mov [ebp-4], ecx
    L0011: cmp dword ptr [0x295fc140], 0
    L0018: je short L001f
    L001a: call 0x72e410c0
    L001f: nop
    L0020: mov ecx, 0x295fc600
    L0025: call 0x0692300c
    L002a: mov [ebp-0xc], eax
    L002d: mov ecx, [ebp-0xc]
    L0030: call Animal..ctor()
    L0035: mov eax, [ebp-0xc]
    L0038: mov [ebp-8], eax
    L003b: mov ecx, [ebp-8]
    L003e: cmp [ecx], ecx
    L0040: call Animal.FazerSomComum()
    L0045: nop
    L0046: mov ecx, [ebp-8]
    L0049: mov eax, [ebp-8]
    L004c: mov eax, [eax]
    L004e: mov eax, [eax+0x28]
    L0051: call dword ptr [eax+0x10]
    L0054: nop
    L0055: nop
    L0056: mov esp, ebp
    L0058: pop ebp
    L0059: ret

```

O que interessa nisso é

Para métodos estáticos:

```asm
L003b: mov ecx, [ebp-8]    ; 
L003e: cmp [ecx], ecx      ; 
L0040: call Animal.FazerSomComum() ;
```

Já para métodos virtuais:

```asm
L0046: mov ecx, [ebp-8]    ; Carrega o objeto
L0049: mov eax, [ebp-8]    ; Coloca o endereço do objeto em eax
L004c: mov eax, [eax]      ; ACESSO 1: Pega o ponteiro da Method Table (vptr)
L004e: mov eax, [eax+0x28] ; ACESSO 2: Vai até o início da VTable (offset 0x28)
L0051: call dword ptr [eax+0x10] ; ACESSO 3: Busca o endereço no Slot e pula
```