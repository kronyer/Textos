# Continuidade

Definição formal usando a definição formal de limite ($\epsilon-\delta$):


A noção intuitiva de continuidade é que uma função é contínua em um ponto se não houver "quebra" ou "salto" na função nesse ponto. 

A noção formal:

Uma função $f(x)$ é continua em um ponto $c$ se para todo $\epsilon > 0$, existe um $\delta > 0$ tal que para todo $x$ dentro do intervalo $(c - \delta, c + \delta)$, a diferença entre $f(x)$ e $f(c)$ é menor que $\epsilon$.

$$\forall \epsilon > 0, \exists \delta > 0 : |x - c| < \delta \implies |f(x) - f(c)| < \epsilon$$

Pense em $\epsilon$ como a "tolerância" que você tem para a diferença entre $f(x)$ e $f(c)$, e $\delta$ como a "distância" que você precisa estar de $c$ para garantir que essa diferença seja menor que $\epsilon$.

Portanto $\epsilon$ está em $y$ e $\delta$ está em $x$.


## Roteiro de prova

Podemos dividir a prova em duas partes:


### Primeira parte: $|f(x) - f(c)| < \epsilon$ (começamos de trás)
1. Escrever a expressão $|f(x) - f(c)|$ 
2. Tentar manipular essa expressao para chegar a uma expressão do tipo $|x - c|
3. Estabelecer uma relção onde $|f(x) - f(c)| \leq k|x - c|$ para algum $k$ (isso é chamado de Lipschitz continuity)
4. A partir disso, podemos escolher $\delta = \frac{\epsilon}{k}$ para garantir que $|f(x) - f(c)| < \epsilon$

### Segunda parte, a prova formal

1. Dado $\epsilon > 0$, escolher $\delta = \frac{\epsilon}{k}$ (ou algum valor que dependa de $\epsilon$)
2. Se $|x - c| < \delta$, então $|f(x) - f(c)| \leq k|x - c| < k\delta = \epsilon$


## Na prática:

1. **Prove que $f(x) = 3x -1$ é continua em $c=2$**

- Aqui queremos que $|f(x) - f(2)| < \epsilon$ para todo $\epsilon > 0$.
- Portanto temos que $|f(x) - f(2)| = |3x - 1 - (3*2 - 1)| < \epsilon $
- Manipulando melhor, temos que $|f(x) - f(2)| = |3x - 1 - 5| = |3x - 6|$
- Podemos fatorar o 3, e temos que $|f(x) - f(2)| = 3|x - 2|$
- Esse $3|x - 2| < \epsilon$
- Agora precisamos descobrir o valor de $\delta$ que garante que $3|x - 2| < \epsilon$
- Se escolhermos $\delta = \frac{\epsilon}{3}$, então $3|x - 2| < 3\frac{\epsilon}{3} = \epsilon$ 

Explicando melhor a ultima parte, da nossa definição:

Se $|x - 2| < \delta$, então $3|x - 2| < 3\delta$." Para que isso resulte em algo menor que $\epsilon$, a escolha lógica é $\delta = \epsilon/3$.


2. **Prove que $f(x) = \frac{x}{2}$ é continua em $c=4$**

- Aqui queremos que $|f(x) - f(2)| < \epsilon$ para todo $\epsilon > 0$.
- Portanto, temos que $|f(x) - f(4)| = |\frac{x}{2} - \frac{4}{2}| < \epsilon $
- Fatorando, temos que $|f(x) - f(4)| = \frac{1}{2}|x - 4| < \epsilon$
- Agora, para descobrir um valor de delta que garante isso, podemos assumir esse $\delta = 2\epsilon$, então $|f(x) - f(4)| = \frac{1}{2}|x - 4| < \frac{1}{2}*2\epsilon = \epsilon$


3. Prove que $f(x) = \frac{x}{2} + 5$ é continua em $c=4$
- Aqui queremos que $|f(x) - f(2)| < \epsilon$ para todo $\epsilon > 0$.
- Portanto, temos que $|f(x) - f(4)| = |\frac{x}{2} + 5 - (\frac{4}{2} + 5)| < \epsilon $
- Manipulando mais, temos $|\frac{x}{2} + 5 - 7| < \epsilon$
- $|\frac{x}{2} - 2| < \epsilon$
- $|\frac{1}{2}||x - 4| < \epsilon$
- Agora, para descobrir um valor de delta que garante isso, podemos assumir esse $\delta = 2\epsilon$, então $|f(x) - f(4)| = \frac{1}{2}|x - 4| < \frac{1}{2}*2\epsilon = \epsilon$