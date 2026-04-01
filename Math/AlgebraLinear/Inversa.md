# Inversão

## Matriz quadrada
Uma matriz $A$ é invertível se existe uma matriz $B$ tal que:
$$AB = BA = I$$
onde $I$ é a matriz identidade. A matriz $B$ é chamada de inversa de $A$ e é denotada por $A^{-1}$.

No entanto, nem todas as matrizes quadradas são invertíveis:
*  Uma matriz é invertível se e somente se seu determinante for diferente de zero.
*  Apenas matrizes quadradas podem ser invertidas. Matrizes retangulares não possuem inversa.
  
### Significado geométrico
Pensando a matriz $A$ como representante de uma transformação linear $L(v)$, se a matriz $A$ significa o movimento/transformação de um vetor $v$ para um vetor $w$, a matriz $A^{-1}$ representa o movimento/transformação de $w$ de volta para $v$. Ou seja, a inversa de uma transformação linear desfaz o efeito da transformação original.


## Matriz retangular ou de determinante zero
Matrizes retangulares ou matrizes quadradas com determinante zero não possuem inversa no sentido tradicional, pois não satisfazem a condição de invertibilidade. 

Existe, no entanto, a pseudo-inversa de Moore-Penrose, que é uma generalização da inversa para matrizes retangulares ou matrizes quadradas singulares. Ela surge como generalização da inversa para qualquer matriz $m \ \times \ n$


$$ Ax = b \iff A^\intercal Ax = A^\intercal b \iff x = (A^\intercal A)^{-1} A^\intercal b$$

Isso é possível porque $A^\intercal A$ é uma matriz quadrada e, se $A$ tem posto completo, então $A^\intercal A$ é invertível. Assim, a pseudo-inversa de Moore-Penrose permite resolver sistemas de equações lineares mesmo quando a matriz original não é invertível.

## Postos
quando falamos de posto completo (rank) estamos falando do numero de linhas (ou colunas) linearmente independentes de uma matriz. 

Em matrizes quadradas $n \times n$, seu posto máximo possível é $n$. E se ela, portanto, tiver posto $n$, seu posto é completo.
O que significa que ela é invertivel, seu determinante é diferente de zero, e todas suas linhas/colunas são linearmente independentes.
 
### Matrizes retangulares
Para matrizes retangulares, o seu posto nao pode ser maior que sua menor dimensão:
$$rank(A) \leq min(m, n)$$
Ela é, portanto, de posto completo se $rank(A) = min(m, n)$.


## $A^\intercal A$ é invertível
Quando sua matriz $A$ tem posto completo de coluna(só de coluna?) o produto $A^\intercal A$ é uma matriz quadrada que herda essa independência linear.

A lógica:
* Se A tem colunas LI, o unico vetor $x$ que satisfaz $Ax = 0$ é o vetor nulo.
* Isso garante que $A^\intercal A$ seja definida positiva, ou, ao menos, não seja singular (que isso?)
* Sendo não singular, $A^\intercal A$ é invertível, o que é crucial para a definição da pseudo-inversa de Moore-Penrose.
### A fórmula da Pseudo-inversa nesses casos
Se $A$ tem posto completo de coluna, a pseudo-inversa de Moore-Penrose pode ser calculada diretamente por esta fórmula (conhecida como inversa à esquerda):$$A^+ = (A^\intercal A)^{-1} A^\intercal$$Se você observar bem, ao multiplicar $A^+ \cdot A$:$$A^+ A = (A^\intercal A)^{-1} A^\intercal A = I$$