# Tipos de passagem
Em C#, existem alguns modificadores de passagem de parâmetros que controlam como os argumentos são passados para os métodos.

## Por valor (by value)
Por padrão, os parâmetros em C# são passados por valor. Isso significa que uma cópia do valor do argumento é feita e passada para o método. Se o tipo do parâmetro for um tipo de valor (como `int`, `double`, `struct`, etc), a cópia do valor é feita. Se o tipo do parâmetro for um tipo de referência (como `class`), a cópia do valor da referência é feita, ou seja, ambos os parâmetros apontam para o mesmo objeto na memória.

O C# nunca copia um objeto inteiro na memória, apenas sua referência. Isso tem implicações importantes:
- Se o parâmetro for um tipo de valor, as alterações feitas ao parâmetro dentro do método não afetarão o argumento original fora do método.
- Se o parâmetro for um tipo de referência, as alterações feitas ao objeto referenciado dentro do método afetarão o argumento original fora do método, pois ambos os parâmetros apontam para o mesmo objeto.

### Exemplo:
```csharp
void AumentarSalario(decimal valor) {
    valor += 500; // Altera apenas a cópia local
}

decimal salario = 2000;
AumentarSalario(salario);
// salario continua sendo 2000
```

```csharp
void AumentarSalario(Funcionario funcionario) {
    funcionario.Salario += 500; // Altera o objeto referenciado
}

Funcionario funcionario = new Funcionario { Salario = 2000 };
AumentarSalario(funcionario);
// funcionario.Salario agora é 2500
```

## Por referência (by reference)
C# também permite passar parâmetros por referência usando o modificador `ref`. Quando um parâmetro é passado por referência, o método recebe uma referência ao argumento original, permitindo que o método modifique o valor do argumento fora do método. Para usar `ref`, tanto a declaração do método quanto a chamada do método devem incluir o modificador `ref`.

### Exemplo:
```csharp
void AumentarSalario(ref decimal valor) {
    valor += 500; // Altera o valor original
}

decimal salario = 2000;
AumentarSalario(ref salario);
// salario agora é 2500
```

### Diferença para tipos de referência
Mesmo para tipos de referência, o `ref` permite que você altere a referência em si, ou seja, pode apontar para um objeto diferente. Sem `ref`, você só pode alterar o estado do objeto referenciado, mas não pode fazer com que o parâmetro aponte para um objeto diferente.

```csharp
void MetodoSemRef(Cachorro c) {
    c.Nome = "Rex";       // Altera o objeto original (mudou a propriedade)
    c = new Cachorro();   // O "Link" foi quebrado. 'c' agora aponta para outro lugar.
    c.Nome = "Totó";      // Isso não afeta a variável lá de fora.
}
void MetodoComRef(ref Cachorro c) {
    c.Nome = "Rex";       // Altera o objeto original (mudou a propriedade)
    c = new Cachorro();   // O "Link" continua. 'c' ainda aponta para o mesmo lugar.
    c.Nome = "Totó";      // Isso afeta a variável lá de fora, porque 'c' ainda aponta para o mesmo lugar.
}
```

## `out` e `in`
Além de `ref`, C# também tem os modificadores `out` e `in`:
- `out`: Usado para indicar que um parâmetro é de saída. O método deve atribuir um valor a um parâmetro `out` antes de retornar. Ele é útil para retornar múltiplos valores de um método.
- `in`: Usado para indicar que um parâmetro é de entrada somente. O método não pode modificar o valor do parâmetro `in`. Ele é útil para passar grandes estruturas de dados sem a sobrecarga de cópia, garantindo que o método não modifique o valor.


### Out
Ao usar `out`, não precisamos inicializar a variável antes de passá-la, mas dentro do método, devemos atribuir um valor a ela antes de retornar.

```csharp
bool TentarDividir(int dividendo, int divisor, out int resultado) {
    if (divisor == 0) {
        resultado = 0; // Obrigatório atribuir
        return false;
    }
    resultado = dividendo / divisor;
    return true;
}

if (TentarDividir(10, 2, out int res)) {
    Console.WriteLine(res); // Saída: 5
}
```

### In
O modificador `in` é usado para passar um parâmetro por referência, mas de forma apenas leitura. É muito util para evitar a cópia de `structs` grandes, garantindo que o método não possa modificar o valor do parâmetro.

```csharp
void ImprimirPonto(in Point p) {
    Console.WriteLine($"X: {p.X}, Y: {p.Y}");
    // p.X = 10; // Isso causaria um erro de compilação, pois 'p' é somente leitura
}

Point ponto = new Point { X = 5, Y = 10 };
ImprimirPonto(ponto);
```