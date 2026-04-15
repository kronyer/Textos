# Autovetores

A definição formal de um autovetor é:

$$A\vec{v} = \lambda \vec{v}$$
Onde $A$ é uma matriz quadrada, que representa uma transformação linear, $\vec{v}$ é um vetor não nulo e $\lambda$ é um escalar chamado autovalor correspondente ao autovetor $\vec{v}$.

Geometricamente, temos que o autovetor é um vetor que, após uma transformação linear representada por $A$, permanece na mesma direção, ou seja, é apenas escalado por um fator $\lambda$.

## Truque da identidade

$$\lambda \vec{v} = (\lambda I) \vec{v}$$
Que pela definição:
$$A\vec{v} = (\lambda I)\vec{v}$$
E por fim:
$$(A - \lambda I)\vec{v} = \vec{0}$$
Neste ponto, criamos uma nova matriz chamada $(A - \lambda I)$. Estamos procurando um vetor $\vec{v}$ que, quando passado por essa nova matriz, resulte no vetor zero.

### Determinante zero
Aqui existem duas possibilidades:

1. A matriz $(A - \lambda I)$ é invertível, ou seja, tem um determinante diferente de zero. Neste caso, a única solução para a equação $(A - \lambda I)\vec{v} = \vec{0}$ é o vetor nulo $\vec{v} = \vec{0}$.
2. Para que um vetor $\vec{v} \neq \vec{0}$ seja uma solução, a matriz $(A - \lambda I)$ deve ser singular, ou seja, seu determinante deve ser zero. Geometricamente, isso significa que a transformação representada por $(A - \lambda I)$ colapsa o espaço em uma dimensão menor.


Em algebra linear, colapsar o espaço significa ter um determinante zero.

Portanto, para encontrar os autovalores $\lambda$, precisamos resolver a equação:
$$\det(A - \lambda I) = 0$$


#### Exemplo

Imagine que temos a seguinte matriz $A$:
$$A = \begin{bmatrix} 2 &  2 \\ 1 & 3 \end{bmatrix}$$
Para encontrar os autovalores, calculamos:
$$\det(A - \lambda I) = \det\left(\begin{bmatrix} 2 - \lambda & 2 \\ 1 & 3 - \lambda \end{bmatrix}\right) = (2 - \lambda)(3 - \lambda) - 2*1 = \lambda^2 - 5\lambda + 4$$
Resolvendo a equação $\lambda^2 - 5\lambda + 4 = 0$, encontramos os autovalores $\lambda_1 = 4$ e $\lambda_2 = 1$.


## Eigenbasis
Imagine se as bases do nosso espaço vetorial fossem compostas por autovetores de uma transformação linear. $\hat{i}$ sendo escalada por $-1$ e $\hat{j}$ sendo escalada por $2$. Nesse caso, a matriz de transformação seria diagonal, com os autovalores na diagonal. Isso é o que chamamos de eigenbasis, ou base de autovetores.

Sempre que uma matriz tiver zeros em todos os lugares, exceto na diagonal, onde estão os autovalores, dizemos que a matriz está na forma diagonal. A vantagem de ter uma matriz diagonal é que as operações de multiplicação se tornam muito mais simples, pois cada componente do vetor é apenas escalada pelo autovalor correspondente.

Exemplo:

$$\begin{bmatrix} -1 & 0 \\ 0 & 2 \end{bmatrix} \begin{bmatrix}
    x \\ y
\end{bmatrix} = \begin{bmatrix}
    -1x \\ 2 y
\end{bmatrix}$$