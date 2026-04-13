# Matrizes regulares

Uma matriz $A \in \mathbb{R^{n \times n}}$ é regular, ou invertível, se existe uma matriz $B \in \mathbb{R^{n \times n}}$ tal que $AB = BA = I$, onde $I$ é a matriz identidade.

Para isso, seu determinante precisa ser diferente de zero, ou seja, $\det(A) \neq 0$.
E seu posto precisa ser igual a $n$, ou seja, $\text{posto}(A) = n$. E derivado disso, suas colunas precisam ser linearmente independentes, ou seja, $\text{colunas}(A)$ é um conjunto de vetores linearmente independentes.

# Equevalencia:

A equivalencia é uma relação entre duas matrizes $A$ e $Ã$ que descrevem a mesma transformação linear, mas sob bases diferentes, tanto em domínio quanto em contradomínio. 

Ou seja, $A$ e $Ã$ são equivalentes se:

$$Ã = T^{-1} A S$$

Onde $S$ é a matriz que representa a mudança de base no domínio, e $T$ é a matriz que representa a mudança de base no contradomínio.

# Semelhança

Parecido com a equivalencia, mas ao invés de termos duas matrizes de mudança de base, temos apenas uma, $S$.

Ou seja, $A$ e $Ã$ são semelhantes se:
$$Ã = S^{-1} A S$$

Aqui $S$ é a matriz que representa a mudança de base tanto no domínio quanto no contradomínio.

Matrizes similares são sempre equivalentes, mas matrizes equivalentes nem sempre são similares. A similaridade é uma relação mais restritiva do que a equivalência.