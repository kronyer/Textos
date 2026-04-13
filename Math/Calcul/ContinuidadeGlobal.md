# Continuidade global

Semelhante as provas de continuidade em um ponto, agora provamos a continuidade em um numero $c$ qualquer dentro do dominio da função (reais), ou seja, para todo $c \in \mathbb{R}$, a função é continua em $c$.


A definição formal de continuidade é a mesma:

Uma função $f(x)$ é continua em um ponto $c$ se para todo $\epsilon > 0$, existe um $\delta > 0$ tal que para todo $x$ dentro do intervalo $(c - \delta, c + \delta)$, a diferença entre $f(x)$ e $f(c)$ é menor que $\epsilon$.

$$\forall \epsilon > 0, \exists \delta > 0 : |x - c| < \delta \implies |f(x) - f(c)| < \epsilon$$


## Exemplos

1. $f(x) = 5x +3$

Mais uma vez, queremos $|f(x) - f(c)| < \epsilon$

Substituimos pelas letras, e temos $|5x + 3 - (5c + 3)| < \epsilon$
Manipulando, temos $|5x - 5c| < \epsilon$
Fatorando o 5, temos $5|x - c| < \epsilon$

Precisamos garantir aqui que $|x-c| < \delta$ para que $5|x - c| < \epsilon$. Se escolhermos $\delta = \frac{\epsilon}{5}$, então $5|x - c| < 5\frac{\epsilon}{5} = \epsilon$

2. Prove que $f(x) = K$ onde $K$ é uma constante, é continua em todo ponto $c \in \mathbb{R}$

- Aqui queremos que $|f(x) - f(c)| < \epsilon$ para todo $\epsilon > 0$.
- Portanto, temos que $|f(x) - f(c)| = |K - K| < \epsilon $
- $|f(x) - f(c)| = 0 < \epsilon$
- Isso é verdade para todo $\epsilon > 0$, então a função é continua em todo ponto $c \in \mathbb{R}$