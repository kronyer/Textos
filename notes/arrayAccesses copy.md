Seja $T(N)$ a quantidade de comparações que uma BS faz.

Tendo N, sabemos que a cada comparação feita, sobra metade do array para continuar, portanto, $N/2$. Cada divisão equivale a uma comparação, e no total são feitas $\lg n$ comparações, até sobrar só 1 elemento.

$$T(N) \leq T(N/2) + 1$$ 
$$T(N/2) \leq T(N/4) + 1$$

entao

$$T(N) \leq T(N/4) + 1 + 1$$

e tendo
$$T(N/4)≤T(N/8)+1$$

ficamos com

$$T(N) \leq T(N/8) + 1 + 1 + 1$$

Podemos continuar até o denominador virar $N$, até $N/2^k = N/N = 1$.
A pergunta que fica é, quantos $+1$ teriamos acumulado? Se repararmos o $+1$ é sempre igual ao expoente $k$ do nosso denominador.

| denominador | quantidade de +1 |
| --- | --- |
| N/2 | 1 |
| N/4 | 2 |
| N/8 | 3 |

Temos 
$$2^k = N$$

e para termos o k

$$ k = \lg N $$

Voltando a nossa proposição

$$T(N) \leq T(1) + 1 + 1 + ... + 1 = 1 + \lg N$$

Como $T(1) = 1$ (nosso caso base), o numero maximo de comparaçõse que uma BS pode fazer está relacionado com N pela função $1 + \lg N$.

$\square$