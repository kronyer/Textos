# Upcasting vs Downcasting

# Upcasting - Up (subir hierarquia)

É a ação de converter uma objeto de uma classe derivada para uma classe base. O upcasting é seguro e não requer uma conversão explícita, pois a classe derivada é um tipo mais específico da classe base. O upcasting é útil quando você deseja tratar um objeto de uma classe derivada como se fosse um objeto da classe base, permitindo que você acesse apenas os membros da classe base.

Se o método for virtual, o método da classe derivada será chamado, mesmo que o objeto seja tratado como um objeto da classe base. Isso é conhecido como polimorfismo.

Falando em códigos, seria o ato de converter um objeto da classe `Dog` para a classe `Animal`, onde `Dog` é uma classe derivada de `Animal`. O código seria algo como:

```csharp
class Animal
{
    // virtual permite que as filhas alterem o comportamento
    public virtual void MakeSound() 
    {
        Console.WriteLine("Animal makes a sound");
    }
}

class Dog : Animal
{
    // override efetivamente substitui o método da base
    public override void MakeSound() 
    {
        Console.WriteLine("Dog barks");
    }
}

Dog myDog = new Dog();
Animal myAnimal = myDog; // Upcasting
myAnimal.MakeSound(); // Output: "Dog barks"
```

# Downcasting - Down (descer hierarquia)
É a ação de converter um objeto de uma classe base para uma classe derivada. O downcasting é inseguro e requer uma conversão explícita, pois a classe base pode não conter os membros específicos da classe derivada. O downcasting é útil quando você deseja acessar os membros específicos da classe derivada, mas deve ser feito com cuidado para evitar erros em tempo de execução.

Continuando com o exemplo anterior, o downcasting seria o ato de converter um objeto da classe `Animal` para a classe `Dog`. O código seria algo como:

```csharp
Animal myAnimal = new Dog(); // Upcasting
Dog myDog = (Dog)myAnimal; // Downcasting
myDog.MakeSound(); // Output: "Dog barks"
```