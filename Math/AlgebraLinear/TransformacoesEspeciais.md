# Injetiva
Uma transformação linear \( T: V \to W \) é **injetiva** se, para quaisquer vetores $x$ e $y$ em $V$, a condição $\Phi(x) = \Phi(y) \implies x = y$

Em uma linguagem mais intuitiva, isso significa que a transformação linear não "colapsa" diferentes vetores de $V$ em um mesmo vetor de $W$. Cada vetor em $V$ tem uma imagem única em $W$.

Na prática: Se uma transformação é injetiva, o único vetor que ela leva para o zero é o próprio vetor nulo ($Kernel = \{0\}$).

## O que é o Kernel?
O **kernel** de uma transformação linear \( T: V \to W \) é o conjunto de todos os vetores em $V$ que são mapeados para o vetor zero em $W$. Em outras palavras, o kernel é definido como:
$$\text{Ker}(T) = \{ v \in V \mid T(v) = 0 \}$$


# Sobrejetiva
Uma transformação linear \( T: V \to W \) é **sobrejetiva** se, para todo vetor $w$ em $W$, existe pelo menos um vetor $v$ em $V$ tal que $\Phi(V) = W$.

Em outras palavras, isso significa que a transformação linear "cobre" todo o espaço $W$. Cada vetor em $W$ tem pelo menos um vetor correspondente em $V$ que é mapeado para ele.

# Bijetiva
Uma transformação linear \( T: V \to W \) é **bijetiva** se ela é tanto injetiva quanto sobrejetiva. Isso significa que cada vetor em $V$ é mapeado para um vetor único em $W$ (injetiva) e que cada vetor em $W$ tem um vetor correspondente em $V$ (sobrejetiva). Em outras palavras, uma transformação linear bijetiva estabelece uma correspondência um-para-um entre os vetores de $V$ e os vetores de $W$.

Uma transformação linear bijetiva pode ser invertida, ou seja, existe uma transformação linear \( T^{-1}: W \to V \) tal que \( T^{-1}(T(v)) = v \) para todo \( v \in V \) e \( T(T^{-1}(w)) = w \) para todo \( w \in W \).



# Casos especias de transformações lineares





## Homomorfismo

Toda transformação linear é um homomorfismo, pois ela respeita as operações de adição de vetores e multiplicação por escalar. 

A transformação $\Phi : \mathbb{R²} \to \mathbb{C}, \Phi(x) = x_1+ ix_2$ é um homomorfismo.

$$\Phi(\begin{bmatrix} x_1 \\ x_2 \end{bmatrix} \begin{bmatrix}
    y_1 \\ y_2
\end{bmatrix}) = (x_1 + y_1) + i(x_2 +y_2) = x_1 + ix_2 + y_1 + i_y2$$

$$ = \Phi(\begin{bmatrix} x_1 \\ x_2 \end{bmatrix}) + \Phi(\begin{bmatrix}
    y_1 \\ y_2
\end{bmatrix})$$

$$ \Phi(\alpha \begin{bmatrix} x_1 \\ x_2 \end{bmatrix}) = \alpha x_1 + i\alpha x_2 = \alpha(x_1 + ix_2) = \alpha \Phi(\begin{bmatrix} x_1 \\ x_2 \end{bmatrix})$$

Isso também justifica o porque de numeros complexos poderem ser representados como tuplas de números reais. Existe uma transformação linear bijetiva (isomorfismo) entre $\mathbb{R}^2$ e $\mathbb{C}$, onde cada par de números reais $(x_1, x_2)$ é mapeado para um número complexo $x_1 + ix_2$. Essa correspondência preserva as operações de adição e multiplicação por escalar, o que é uma característica fundamental de um isomorfismo.

### Endomorfismo
Uma transformação linear \( T: V \to V \) é um **endomorfismo**. Isso significa que a transformação linear mapeia o espaço vetorial $V$ para ele mesmo. Em outras palavras, um endomorfismo é uma transformação linear que atua dentro do mesmo espaço vetorial, preservando suas operações de adição de vetores e multiplicação por escalar.

## Sobre a "qualidade" das transformações lineares

## Isomorfismo
Uma transformação linear \( T: V \to W \) é um **isomorfismo** se ela é bijetiva. Isso significa que $V$ e $W$ são estruturalmente idênticos em termos de suas propriedades de espaço vetorial. Em outras palavras, um isomorfismo estabelece uma correspondência um-para-um entre os vetores de $V$ e os vetores de $W$, preservando as operações de adição de vetores e multiplicação por escalar.

É um caso de isomorfismo a transformação linear que mapeia $\mathbb{R}^2$ para $\mathbb{C}$, onde cada par de números reais $(x_1, x_2)$ é mapeado para um número complexo $x_1 + ix_2$. Essa transformação é bijetiva e preserva as operações de adição e multiplicação por escalar, o que a torna um isomorfismo entre os espaços vetoriais $\mathbb{R}^2$ e $\mathbb{C}$.


### Automorfismo
Uma transformação linear \( T: V \to V \) é um **automorfismo** se ela é um isomorfismo. Isso significa que $T$ é uma transformação linear bijetiva que mapeia o espaço vetorial $V$ para ele mesmo. Em outras palavras, um automorfismo é uma transformação linear que estabelece uma correspondência um-para-um entre os vetores de $V$ e os vetores de $V$, preservando as operações de adição de vetores e multiplicação por escalar.


#### Identidade $id_V$
A transformação linear identidade, denotada por \( id_V: V \to V \), é definida por \( id_V(v) = v \) para todo vetor \( v \in V \). Em outras palavras, a transformação identidade mapeia cada vetor para si mesmo. A transformação identidade é um exemplo de automorfismo, pois é bijetiva e preserva as operações de adição de vetores e multiplicação por escalar.



Como não saimos do espaço V, o automorfismo é um caso especial de isomorfismo, onde o espaço de partida e o espaço de chegada são o mesmo. O exemplo mais simples de automorfismo é a transformação identidade \( id_V: V \to V \), que mapeia cada vetor para si mesmo. O automorfismo é importante porque ele representa as simetrias internas do espaço vetorial $V$, ou seja, as transformações que preservam a estrutura do espaço vetorial.


#### Rotação e Reflexão

Também pode ser considerado automorfismo uma rotação ou reflexão em um espaço vetorial, desde que seja uma transformação linear bijetiva. Por exemplo, uma rotação de 90 graus em $\mathbb{R}^2$ é um automorfismo, pois é uma transformação linear que mapeia o espaço para ele mesmo de forma bijetiva, preservando as operações de adição de vetores e multiplicação por escalar.