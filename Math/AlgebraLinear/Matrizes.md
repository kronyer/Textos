# Matrizes como representações de transformações lineares


# Multiplicação de matrizes

## Quatro jeitos

## Matriz A vezes todos os vetores coluna de B


## Vetor coluna de A vezes todos os vetores linha de B
Isso é muito util em sistemas lineares, onde

$$Ax = b$$
pode ser interpretado como a multiplicação da matriz $A$ pelo vetor coluna $x$, resultando no vetor coluna $b$.

Entao, supondo que $A$ seja 2x2 e $x$ seja um vetor coluna 2x1:

$$A = \begin{bmatrix} a_{11} & a_{12} \\ a_{21} & a_{22} \end{bmatrix}, \quad x = \begin{bmatrix} x_1 \\ x_2 \end{bmatrix}$$

E portanto temos:
$$Ax = \begin{bmatrix} a_{11} & a_{12} \\ a_{21} & a_{22} \end{bmatrix} \begin{bmatrix} x_1 \\ x_2 \end{bmatrix} = \begin{bmatrix} a_{11}x_1 + a_{12}x_2 \\ a_{21}x_1 + a_{22}x_2 \end{bmatrix}$$

E isso é a soma de dois vetores coluna, um resultado da multiplicação de $x_1$ por cada elemento da primeira coluna de $A$, e outro resultado da multiplicação de $x_2$ por cada elemento da segunda coluna de $A$.

$$Ax = x_1\begin{bmatrix} a_{11} \\ a_{21} \end{bmatrix} + \begin{bmatrix} a_{12} \\ a_{22}$$