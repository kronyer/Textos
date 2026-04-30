# Sealed
Sealed em c# eh uma keyword e faz parte do paradigma de orientação a objetos. Ela é usada para impedir que uma classe seja herdada ou que um método seja sobrescrito. 

Quando colocamos sealed em uma classe, estamos dizendo que essa classe não pode ser usada como base para outras classes. Isso é útil quando queremos garantir que a implementação de uma classe seja final e não possa ser modificada por meio de herança.

O mesmo vale para métodos. Quando um método é marcado como sealed, ele não pode ser sobrescrito por classes derivadas. Isso é útil quando queremos garantir que a implementação de um método seja final e não possa ser modificada por meio de herança. No entanto, para usar sealed em um metodo, e necessario que ele esteja sobrescrevendo um método virtual ou abstrato de uma classe base.

```csharp
public sealed class MinhaClasse
{
    public void MeuMetodo()
    {        Console.WriteLine("Este método não pode ser sobrescrito.");
    }
}
```

## Desvirtualizacao, JIT e CIL

Vamos colocar o seguinte codigo no sharplab.io:

```cs
using System;

public class ClasseAberta
{
    public virtual void Metodo() { }
}

public sealed class ClasseSelada
{
    public void Metodo() { }
}

public class Teste
{
    public void ChamarAberto(ClasseAberta obj)
    {
        obj.Metodo(); // Aqui o JIT gera instruções mais complexas
    }

    public void ChamarSelado(ClasseSelada obj)
    {
        obj.Metodo(); // Aqui o JIT corta caminho (Desvirtualização)
    }
}
```

A CLI dele permanece a mesma:

```cil
IL_0001: ldarg.1
IL_0002: callvirt instance void ClasseAberta::Metodo() // <--- Olha o callvirt aqui!

IL_0001: ldarg.1
IL_0002: callvirt instance void ClasseSelada::Metodo() // <--- O callvirt também está aqui!
```

Mas, passando para JIT Asm, vemos a diferença:

```asm
; Método para ClasseAberta
L001c: mov ecx, [ebp-0xc]      // Pega a referência do objeto
    L001f: mov eax, [ebp-0xc]      
    L0022: mov eax, [eax]          // 1º PULO: Acessa a memória para pegar o ponteiro da tabela (vtable)
    L0024: mov eax, [eax+0x28]     // 2º PULO: Busca o endereço específico do método dentro da tabela
    L0027: call dword ptr [eax+0x10] // 3º PULO: Faz a chamada indireta para o método (agora que descobriu qual é)

; Método para ClasseSelada
L001c: mov ecx, [ebp-0xc]      // Pega a referência do objeto
    L001f: cmp [ecx], ecx          // Truque rápido do JIT para checar se é nulo (NullReferenceException)
    L0021: call ClasseSelada.Metodo() // CHAMADA DIRETA! 🚀
```