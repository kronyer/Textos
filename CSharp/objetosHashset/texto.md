# Hash code e objetos

O hash pode ser entendido como uma função $H$ que mapeia um valor de entrada (como um objeto) para um valor de saída (um número inteiro). 

Cada objeto em C# tem um método `GetHashCode()` que retorna um valor inteiro representando o hash do objeto. O hash é usado principalmente para otimizar a busca e comparação de objetos em estruturas de dados como `HashSet` e `Dictionary`.

Se um objeto é igual a outro (ou seja, `Equals` retorna true), eles devem ter o mesmo hash code. No entanto, objetos diferentes podem ter o mesmo hash code (isso é chamado de colisão). Por isso, é importante que o método `GetHashCode()` seja implementado de forma a minimizar colisões.

## GetHashCode e Equals

Ao implementar `GetHashCode()`, é importante garantir que ele seja consistente com `Equals()`. Se dois objetos são considerados iguais por `Equals()`, eles devem retornar o mesmo valor de hash code.

Por exemplo, se você tem uma classe `Person` com propriedades `Name` e `Age`, você pode implementar `GetHashCode()` usando essas propriedades:

```csharp
public override int GetHashCode()
{    return HashCode.Combine(Name, Age);
}
``` 

E o método `Equals()` pode ser implementado para comparar as propriedades:

```csharp
public override bool Equals(object obj)
{
    if (obj is Person other)
    {
        return Name == other.Name && Age == other.Age;
    }
    return false;
}
```

Como regra, temos que, ao dar override em `Equals()`, devemos dar override em `GetHashCode()`, para garantir a consistência entre os dois métodos.

## Matematica do Hash Code

As funções hash, conhecidas como funções de dispersão / espalhamento, são projetadas para distribuir uniformemente os valores de hash em um espaço de saída. Ou seja, nao estamos falando de criptografia, mas sim de uma função que mapeia um valor de entrada para um valor de saída de forma eficiente e com baixa probabilidade de colisões.


### Definicao formal

Definimos $H: U \to [0, m-1]$ como uma função hash, onde $U$ é o universo de chaves possíveis e $m$ é o tamanho do espaço de hash. A função hash deve ser eficiente de computar e deve distribuir as chaves uniformemente. 

No caso do c#, e de outras linguagens que usam Int32, $H(x) \in [-2^{31}, 2^{31}-1]$.

### Colisoes

Pelo principio da casa dos pombos, se temos mais chaves do que valores de hash, inevitavelmente teremos colisões. Por isso, é importante que a função hash seja projetada para minimizar colisões, especialmente em casos onde o número de chaves é grande.

Isso é, nosso dominio (combinações possiveis de strings em um nome de um objeto, por exemplo) é muito maior do que o codominio (o numero de inteiros possiveis), entao teremos muitas chaves mapeando para o mesmo valor de hash, que se limita a 2^32 possibilidades.

$$\exists \, x, y \in U \text{ tal que } x \neq y \land H(x) = H(y)$$

Devido a essa possibilidade de colisão, é que o método `Equals()` é importante, pois ele é usado para comparar objetos que têm o mesmo hash code para determinar se eles são realmente iguais ou se é apenas uma colisão.

### Propriedades de uma boa função hash

Para garantir que a busca em uma estrutura de dados seja constante, a função hash deve ser rápida de computar e deve distribuir as chaves uniformemente. Isso significa que a função hash deve minimizar colisões, para que a busca seja eficiente.

#### Uniformidade Simples (Simple Uniform Hashing)

A probabilidade de qualquer chave x gerar um determinado hash deve ser estritamente uniforme. Em outras palavras, a probabilidade de cair em qualquer slot do hash deve ser a mesma para todas as chaves.

$$ P(H(x) = i) = \frac{1}{m} \text{ para } i = 0, 1, ..., m-1 $$

Em um caso contrário, onde a função hash não é uniforme, podemos ter um cenário onde muitas chaves mapeiam para o mesmo valor de hash, o que pode levar a uma degradação do desempenho da estrutura de dados. Quase como uma árvore desbalanceada, onde a busca pode se tornar linear em vez de constante.

#### Alta difusão (Efeito avalanche)

Uma mudança minuscula na entrada deve resultar em uma mudança significativa no hash. Isso ajuda a garantir que chaves semelhantes não mapeiem para o mesmo valor de hash, o que pode ajudar a reduzir colisões.


### Funcionamento do `Hash.Combime`

Olhando o código fonte do `HashCode.Combine`, temos numeros primos hardcodeds.

- 2246822519U
- 2654435761U
- 3266489917U
- 668265263U
- 374761393U

Eles não são números arbitrários digitados por um programador. São as constantes primas exatas do algoritmo XxHash32. Em hexadecimal, o 2654435761U, por exemplo, é 0x9E3779B1, um valor intimamente ligado à proporção áurea ($\phi$) adaptada para 32 bits. O uso desses primos específicos garante que as multiplicações espalhem os bits pelo espaço de forma simétrica, evitando acúmulos matemáticos.

#### Embaralhador principal 

```cs
[MethodImpl(MethodImplOptions.AggressiveInlining)]
private static uint Round(uint hash, uint input)
{
    return BitOperations.RotateLeft(hash + input * 2246822519U, 13) * 2654435761U;
}
```

Passo a passo temos, o input é multiplicado por 2246822519U (um primo longo) para expandir o valor, e isso é somado com o hash acumulado até então. O resultado é então rotacionado para a esquerda em 13 bits, o que ajuda a espalhar os bits de forma mais uniforme. Finalmente, o resultado é multiplicado por 2654435761U, outro primo, para garantir uma boa dispersão dos bits.


#### Efeito avalanche absoluto (`MixFinal`)

```cs
[MethodImpl(MethodImplOptions.AggressiveInlining)]
private static uint MixFinal(uint hash)
{
    hash ^= hash >> 15;
    hash *= 2246822519U;
    hash ^= hash >> 13;
    hash *= 3266489917U;
    hash ^= hash >> 16;
    return hash;
}
```

Isso é conhecido como Avalanche Finalizer. Usando deslocamentos para a direita (>>) em conjunto com a operação de disjunção exclusiva matemática (^ ou $\oplus$), a função força os bits mais significativos (da esquerda) a interagirem com os bits menos significativos (da direita).Se o seu objeto original teve apenas um único bit alterado, essa sequência de multiplicações combinadas com $\oplus$ garante que $\approx 50\%$ dos 32 bits do resultado final sejam invertidos, destruindo qualquer similaridade com o hash anterior.

#### Seed dinâmico

No inicio do código é declarado:

```cs
private static readonly uint s_seed = HashCode.GenerateGlobalSeed();
```

Que adiciona uma constance $C$ ao processo. Essa $C$ é gerada pelo hardware `Interop.GetRandomBytes`

E em resumo, temos: 

$$H(x) = f(x) + C \pmod{2^{32}}$$