Sejam f, g continuas em p e k uma constante, então $f+g$ e $kf$ e $f\cdot g$ são contínuas em p.; $ \frac{f}{g}$ é contínua em p, desde que $g(p)\neq 0$.

Dado f e g continuas em p, $\lim_{x\to p} f(x) = f(p)$ e $\lim_{x\to p} g(x) = g(p)$, então:
Segue das propriedades (a) (b) e (c)

## Lembrando as propriedades?
(a) $\lim_{x\to p} (f(x) + g(x)) = L_1 + L_2 = \lim_{x\to p} f(x) + \lim_{x\to p} g(x)$
*O limite de uma soma é a soma dos limites*

(b) $\lim_{x\to p} kf(x) = kL_1 = k\lim_{x\to p} f(x)$
*k constante*

(c) $\lim_{x\to p} f(x)g(x) = L_1L_2 = \lim_{x\to p} f(x)\cdot \lim_{x\to p} g(x)$
*O limite de um produto é o produto dos limites*

(d) $\lim_{x\to p} \frac{f(x)}{g(x)} = \frac{L_1}{L_2} = \frac{\lim_{x\to p} f(x)}{\lim_{x\to p} g(x)}$, desde que $L_2 \neq 0$.
*O limite de um quociente é o quociente dos limites, desde que o limite do denominador seja diferente de zero*

## VOltando

Portanto, segue-se das propriedades (a), (b) e (c) que $f+g$, $kf$ e $f\cdot g$ são contínuas em p. E segue-se da propriedade (d) que $\frac{f}{g}$ é contínua em p, desde que $g(p)\neq 0$.

$\lim_{x\to p} f(x) = f(p)$ e $\lim_{x\to p} g(x) = g(p)$, então:
(a) $\lim_{x\to p} (f(x) + g(x)) = \lim_{x\to p} f(x) + \lim_{x\to p} g(x) = f(p) + g(p)$
(b) $\lim_{x\to p} kf(x) = k\lim_{x\to p} f(x) = kf(p)$
(c) $\lim_{x\to p} f(x)g(x) = \lim_{x\to p} f(x)\cdot \lim_{x\to p} g(x) = f(p)\cdot g(p)$
(d) $\lim_{x\to p} \frac{f(x)}{g(x)} = \frac{\lim_{x\to p} f(x)}{\lim_{x\to p} g(x)} = \frac{f(p)}{g(p)}$, desde que $g(p) \neq 0$.


# Provando mais:

Vamos provar que se $f_1,f_2, ..., f_n$ são funções contínuas em p, então $f_1 + f_2 + ... + f_n$ é contínua em p.


Pensando indutivamente, a soma e o produto das funções f e g são continuas, portanto, usemos de base n = 2

Nossa base é verdadeira, pois deriva diretamente de (a), isso é:

se $f_1$ e $f_2$ são contínuas em p, então $f_1 + f_2$ é contínua em p. $\lim_{x\to p} (f_1(x) + f_2(x)) = \lim_{x\to p} f_1(x) + \lim_{x\to p} f_2(x) = f_1(p) + f_2(p)$

Assumindo que a hipotese seja veradeira para um $k$ natural $>= 2$. Ou seja, supomos a soma de $k$ funções contínuas:
$$ S_k(x) = f_1(x) + f_2(x) + ... + f_k(x) $$ é contínua em p.

Agora, precisamos verificar que também é verdadeiro para $k+1$. Ou seja, precisamos verificar que a função $S_{k+1}(x) = S_k(x) + f_{k+1}(x)$ é contínua em p.

$$ S_{k+1} = S_k + f_{k+1} $$

Pela nossa hipotese, $S_k$ é contínua em p, e por nossa premissa, $f_{k+1}$ é contínua em p. Portanto, pela propriedade (a), $S_{k+1}$ é contínua em p.


Agora, praticamente do mesmo jeito, vamos provar que o produto de $n$ funções contínuas é contínua.

Nossa base é verdadeira, pois deriva diretamente de (c), isso é:
se $f_1$ e $f_2$ são contínuas em p, então $f_1 \cdot f_2$ é contínua em p. $\lim_{x\to p} (f_1(x) \cdot f_2(x)) = \lim_{x\to p} f_1(x) \cdot \lim_{x\to p} f_2(x) = f_1(p) \cdot f_2(p)$


Assumindo que a hipotese seja veradeira para um $k$ natural $>= 2$. Ou seja, supomos o produto de $k$ funções contínuas:
$$ P_k(x) = f_1(x) \cdot f_2(x) \cdot ... \cdot f_k(x) $$ é contínua em p.

Agora, precisamos verificar que também é verdadeiro para $k+1$. Ou seja, precisamos verificar que a função $P_{k+1}(x) = P_k(x) \cdot f_{k+1}(x)$ é contínua em p.

$$ P_{k+1} = P_k \cdot f_{k+1} $$

Pela nossa hipotese, $P_k$ é contínua em p, e por nossa premissa, $f_{k+1}$ é contínua em p. Portanto, pela propriedade (c), $P_{k+1}$ é contínua em p.