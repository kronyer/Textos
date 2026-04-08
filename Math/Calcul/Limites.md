# Definição formal de limites

Para todo $\varepsilon > 0$, existe um $\delta > 0$ tal que, para todo $x$ que satisfaça $0 < |x - a| < \delta$, temos $|f(x) - L| < \varepsilon$.

Destrinchando a formula, a parte que diz $0 < |x - a | < \delta$ significa que $x$ está perto de $a$, mas não é igual a $a$. 

$|f(x) - L | < \varepsilon$ é a consequencia. Se o $a$ estiver perto o suficiente de $x$, então $f(x)$ estará perto de $L$.


# Unicidade do limite

..prova por absurdo assumindo L1 e L2...


O unico numero $L$ satisfaz a definição de limite é o limite de $f(x)$ para $x$ tentendo a $p$

$$\lim_{x \to p} f(x) = L$$


## Definição

Sejam f uma funç~çao e p um ponto do dominio de f ou extemedida de um dos intervalos que compoem o dominio de f. DIzemos que f tem limite L em p se para todo $\varepsilon > 0$ existe um $\delta > 0$ tal que, para todo $x$ que satisfaça $0 < |x - p| < \delta$, temos $|f(x) - L| < \varepsilon$.

$$ 0 < |x - p| < \delta \Rightarrow |f(x) - L| < \varepsilon $$



# Calculando limites

## Limite de uma constante

$$ \lim_{x \to p} f(x) = k $$

é igual a $k$.

## Outros limites


### 1
$$ \lim_{x \to 2}  (3x-2)$$

É uma função afim, portanto, continua em todo $p$ real, em particular em p=2.

$$ \lim_{x \to 2}  (3x-2) = 3*2 - 2 = 4 $$


### 2 
$$ \lim{x \to 1} \frac{x²-1}{x-1} $$

A função não é definida em $x=1$, mas podemos fatorar o numerador:
$$ \lim_{x \to 1} \frac{(x-1)(x+1)}{x-1} $$ (definida pelo produto notável da diferença de quadrados [$ a^2 - b^2 = (a-b)(a+b)$])

Simplificando a expressão, temos:
$$ \lim_{x \to 1} (x+1) $$

Agora, a função é contínua em $x=1$, então podemos substituir diretamente:
$$ \lim_{x \to 1} (x+1) = 1 + 1 = 2 $$


### Limites com sistema de equações

$$ \lim_{x \to 1 \text{em que} f(x) = \begin{cases}
\frac{x^2-1}{x-1} & \text{se } x \neq 1 \\
3 & \text{se } x = 1
\end{cases}} $$


Primeiro resolvendo para $x \neq 1$:

Aplicando a fatoração do numerador, temos:
$$ \lim_{x \to 1} \frac{(x-1)(x+1)}{x-1} $$
e mais uma vez, simplificando a expressão, temos:
$$ \lim_{x \to 1} (x+1) $$

Agora, a função é contínua em $x=1$, então podemos substituir diretamente:
$$ \lim_{x \to 1} (x+1) = 1 + 1 = 2 $$

Agora, para $x=1$, a função é definida como $f(1) = 3$.

Ela nao é continua em $x=1$, pois como $2 \neq 3$, o limite da função quando $x$ se aproxima de 1 é diferente do valor da função em $x=1$.


### 3 Verifique 

$$ \lim_{x \to p} x^n = p^n \text{, para todo p real} $$

e

$$ \lim_{x \to p} \sqrt[n]{x} = \sqrt[n]{p} \text{, para todo p no domíbio de } g(x) = \sqrt[n]{x} $$

Passo a Passo da Verificação (Exemplo: $x^2$ em $p = 3$)A função existe no ponto?Sim, $f(3) = 3^2 = 9$. (Condição 1: OK)O limite existe quando $x \to 3$?Ao aproximar $x$ de $3$ (por exemplo, $2.9, 2.99 \dots$ ou $3.1, 3.01 \dots$), o valor de $x^2$ se aproxima de $9$. Não há quebras, saltos ou furos no gráfico de uma parábola. Então, $\lim_{x \to 3} x^2 = 9$. (Condição 2: OK)O limite é igual à função?Como $\lim_{x \to 3} f(x) = 9$ e $f(3) = 9$, eles são iguais. (Condição 3: OK)Verificação Geral (Para qualquer $n$)Para funções polinomiais e radiciais dentro do domínio, a "verificação" teórica geralmente se baseia em:Polinômios ($x^n$): São contínuos em todo o conjunto dos Números Reais ($\mathbb{R}$). Não importa qual valor de $p$ você escolha, o limite será sempre $p^n$.Raízes ($\sqrt[n]{x}$): * Se $n$ for ímpar (ex: $\sqrt[3]{x}$), a função é contínua para todo $x$ real.Se $n$ for par (ex: $\sqrt{x}$), a função é contínua para todo $p > 0$. No ponto $p=0$, ela é contínua à direita.


# Assumir coisas:

Será provado mais pra frente, tome como verdade por enquanto:

a) $$lim_{x \to p} (f(x) + g(x)) = \lim_{x \to p} f(x) + \lim_{x \to p} g(x)$$
Ou seja, o limite de uma soma é igual à soma dos limites das parcelas

b) $$lim_{x \to p} k f (x) = k \lim_{x \to p} f(x)$$
Ou seja, o limite de uma função multiplicada por uma constante é igual à constante multiplicada pelo limite da função.
(k constante)

c) $$lim_{x \to p} f(x) g(x) = L_1 \cdot L_2 = \lim_{x \to p} f(x) \cdot \lim_{x \to p} g(x)$$
Ou seja, o limite de um produto é igual ao produto dos limites das parcelas

d) $$lim_{x \to p} \frac{f(x)}{g(x)} = \frac{L_1}{L_2} = \frac{\lim_{x \to p} f(x)}{\lim_{x \to p} g(x)}$$

Desde que $L_2 \neq 0$.
Ou seja, o limite de um quociente é igual ao quociente dos limites das parcelas, desde que o limite do denominador seja diferente de zero.


### 6

$$ \lim_{x \to 2} (5x³ - 8)$$

Assumindo as definições apresentedas acima, temos:
$$ \lim_{x \to 2} (5x³ - 8) = 5 \cdot \lim_{x \to 2} x^3 - \lim_{x \to 2} 8 $$
$$ = 5 \cdot 2^3 - 8 $$
$$ = 5 \cdot 8 - 8 $$
$$ = 40 - 8 $$
$$ = 32 $$


### 7

$$ \lim_{x \to 3} \frac{\sqrt{x} - \sqrt{3}}{x - 3} $$

Não podemos substituir diretamente $x=3$ porque isso resultaria em uma indeterminação do tipo $\frac{0}{0}$. Para resolver isso, podemos multiplicar o numerador e o denominador pelo conjugado do numerador:
$$ \lim_{x \to 3} \frac{\sqrt{x} - \sqrt{3}}{x - 3} \cdot \frac{\sqrt{x} + \sqrt{3}}{\sqrt{x} + \sqrt{3}} $$
$$ = \lim_{x \to 3} \frac{(\sqrt{x} - \sqrt{3})(\sqrt{x} + \sqrt{3})}{(x - 3)(\sqrt{x} + \sqrt{3})} $$
$$ = \lim_{x \to 3} \frac{x - 3}{(x - 3)(\sqrt{x} + \sqrt{3})} $$
$$ = \lim_{x \to 3} \frac{1}{\ksqrt{x} + \sqrt{3}} $$
Agora podemos substituir $x=3$:
$$ = \frac{1}{\sqrt{3} + \sqrt{3}} $$
$$ = \frac{1}{2\sqrt{3}} $$


### 8

$$ \lim{x \to 1} \frac{x⁴-2x+1}{x³+3x²+1}$$

Podemos resolver separadamentes pela propriedade `d`

Temos, substituindo que, $\lim_{x \to 1} x^4 - 2x + 1 = 0$ e $\lim_{x \to 1} x^3 + 3x^2 + 1 = 5$. Portanto, o limite é:
$$ \lim_{x \to 1} \frac{x^4 - 2x + 1}{x^3 + 3x^2 + 1} = \frac{0}{5} = 0 $$

### 9

$$ \lim_{x \to -1} \frac{x^3 + 1}{x² +4x +3}$$

Substituindo diretamente $x=-1$, temos:
$$ \frac{(-1)^3 + 1}{(-1)^2 + 4(-1) + 3} = \frac{0}{0} $$

Pelo limite da fração inferior ser 0, `d`nao se aplica.

Sendo ambas as expressoes divisiveis por $x+1$, podemos fatorar o numerador e o denominador:

$$ \lim_{x \to -1} \frac{(x+1)(x^2 - x + 1)}{(x+1)(x+3)} $$

Simplificando a expressão, temos:
$$ \lim_{x \to -1} \frac{x^2 - x + 1}{x + 3} $$


### 10

$$ \lim_{x \to 2} \frac{\sqrt[3]{x} - \sqrt[3]{2}}{x - 2}$$

Multiplicando o numerador e o denominador pelo conjugado do numerador, temos:

p.s.: Esse conjugado surge de "completar o quadrado" para eliminar a raiz cúbica do numerador. A expressão $(\sqrt[3]{x} - \sqrt[3]{2})(\sqrt[3]{x^2} + \sqrt[3]{2x} + \sqrt[3]{4})$ é uma aplicação da identidade de fatoração para a diferença de cubos, que é dada por:
$$ a^3 - b^3 = (a - b)(a^2 + ab + b^2) $$
Neste caso, $a = \sqrt[3]{x}$ e $b = \sqrt[3]{2}$. Portanto, ao multiplicar o numerador pela expressão $\sqrt[3]{x^2} + \sqrt[3]{2x} + \sqrt[3]{4}$, estamos utilizando essa identidade para simplificar a expressão e eliminar a raiz cúbica do numerador, o que nos permite calcular o limite de forma mais direta

$$ \lim_{x \to 2} \frac{\sqrt[3]{x} - \sqrt[3]{2}}{x - 2} \cdot \frac{\sqrt[3]{x^2} + \sqrt[3]{2x} + \sqrt[3]{4}}{\sqrt[3]{x^2} + \sqrt[3]{2x} + \sqrt[3]{4}} $$
$$ = \lim_{x \to 2} \frac{(\sqrt[3]{x} - \sqrt[3]{2})(\sqrt[3]{x^2} + \sqrt[3]{2x} + \sqrt[3]{4})}{(x - 2)(\sqrt[3]{x^2} + \sqrt[3]{2x} + \sqrt[3]{4})} $$
$$ = \lim_{x \to 2} \frac{x - 2}{(x - 2)(\sqrt[3]{x^2} + \sqrt[3]{2x} + \sqrt[3]{4})} $$
$$ = \lim_{x \to 2} \frac{1}{\sqrt[3]{x^2} + \sqrt[3]{2x} + \sqrt[3]{4}} $$
Agora podemos substituir $x=2$:
$$ = \frac{1}{\sqrt[3]{4} + \sqrt[3]{4} + \sqrt[3]{4}} $$
$$ = \frac{1}{3\sqrt[3]{4}} $$