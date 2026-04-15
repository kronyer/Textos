$$Ã\Phi = T^{-1} Ã\Phi S$$

A mudança de base é uma troca de perspectiva, tendo uma velha transformação $\Phi$ que é de $V$ para $W$ que usava as bases $B$ (base canônica - entrada de $\Phi$) e $C$ (base de saída de $\Phi$), e agora queremos uma nova transformação $\Phi S$ que é de $V$ para $W$ que usa as bases $B'$ (nova base de entrada) e $C'$ (nova base de saída). Para isso, precisamos de uma transformação $T$ que seja de $W$ para $W$ que use as bases $C$ e $C'$.

Para que essa mudança ocorra, precisamos de matrizes de transcrição $S$ e $T$ que sejam invertíveis, ou seja, que tenham inversas. A matriz $
S$ é a matriz de transcrição que leva a base $B$ para a base $B'$, e a matriz $T$ é a matriz de transcrição que leva a base $C$ para a base $C'$.


# Entendendo a fomula

$Ã\Phi = T^{-1} Ã\Phi S$ Significa que primeiro aplicamos S para mudar a base de entrada, depois aplicamos a transformação $\Phi$ e por fim aplicamos $T^{-1}$ para mudar a base de saída.


Em um caminho mais detalhado temos:

1. $S$ é a entrada, temos um vetor $B'$. A matriz $S$ é a matriz de transcrição que leva da nova base $B'$ para a base antiga $B$. Então, aplicamos $S$ para obter o vetor na base antiga $B$.
2. A transformação $A\Phi$ tem como domínio a base antiga $B$, por isso, precisamos do vetor na base antiga $B$. O resultado, imagem, sai na base antiga $C$.
3. Como T transforma a nova base de saída $C'$ para a base antiga $C$, precisamos aplicar $T^{-1}$ para obter o resultado na nova base de saída $C'$.

# De uma forma mais intuitiva

Temos nossa base antiga $B$, que pensando em $\mathbb{R}²$ seria algo como os vetores $b_1 = (1,0)$ e $b_2 = (0,1)$. E temos nossa base nova $B'$, composta de vetores $b'_1$ e $b'_2$. 

Tomemos nossa base $B$ como a base canônica, onde $b_1 = (1,0) = \hat{i}$ e $b_2 = (0,1) = \hat{j}$.  

Imagine que Pedro esteja descrevendo um vetor $v$ usando a base $B$, e ele diz que $\vec{v} = (3,2)$, o que significa que $v = 3\hat{i} + 2\hat{j}$. 

Agora, maria, está vendo o mesmo vetor $v$, mas usando a base $B'$. Ela tem uma matriz de transcrição $S$ que a ajuda a converter as coordenadas de $v$ da base $B$ para a base $B'$. Então, Maria aplica $S$ para obter as coordenadas de $v$ na base $B'$.

Essa matriz representa a transformação dos vetores da base $B$ para a base $B'$, isso é, cada coluna de $S$ é a representação de um vetor da base $B$ na base $B'$.

O vetor para Maria é definido como $S\vec{v} = (5/3, 1/3)$, ou seja, Pedro, que está na base $B$ precisa de 5/3 vezes o vetor $b_1$ e 1/3 vezes o vetor $b_2$ para chegar ao vetor $v$.

O que sabemos então é que existe uma materiz $S$ que é a matriz de transcrição que leva da base $B$ para a base $B'$. 
$$ S = \begin{bmatrix} a & c \\ b & d \end{bmatrix} $$
Então, o que temos é:
$$ S\vec{v} = \begin{bmatrix} a & b \\ c & d \end{bmatrix} \begin{bmatrix} 3 \\ 2 \end{bmatrix} = \begin{bmatrix} 3a + 2b \\ 3c + 2d \end{bmatrix} = \begin{bmatrix}
    5/3 \\ 1/3
\end{bmatrix}$$

Podemos descobrir os valores de $a$, $b$, $c$ e $d$ a partir dessa equação.
$$\begin{cases}
3a + 2b = 5/3 \\
3c + 2d = 1/3
\end{cases}$$

Sabendo que a base $B'$ é composta por vetores $b'_1=(2,1)$ e $b'_2=(-1,1)$, nossa matriz $S$ é formada por esses vetores como colunas, ou seja:
$$ S = \begin{bmatrix} 2 & -1 \\ 1 & 1 \end{bmatrix} $$

Então, o que temos é:
$$ S\vec{v} = S = 
\begin{bmatrix} 2 & -1 \\ 1 & 1 \end{bmatrix}
 \begin{bmatrix} 3 \\ 2 \end{bmatrix}
  = \begin{bmatrix} 3a + 2b \\ 3c + 2d \end{bmatrix} = \begin{bmatrix}
    5/3 \\ 1/3
\end{bmatrix}$$





 Portanto, a matriz $S$ é a matriz de transcrição que leva da base $B$ para a base $B'$, definida por $S = \begin{bmatrix} 5/3 & 1/3 \\ 1/3 & 2/3 \end{bmatrix}$.

Se partirmos da visão de Pedro para a de Maria, o caminho é fácil de entender, basta aplicar a matriz $S$ para converter as coordenadas do vetor $v$ da base $B$ para a base $B'$.

$$S\vec{v} = \begin{bmatrix} 5/3 & 1/3 \\ 1/3 & 2/3 \end{bmatrix} \begin{bmatrix} 3 \\ 2 \end{bmatrix} = \begin{bmatrix} 5/3*3 + 1/3*2 \\ 1/3*3 + 2/3*2 \end{bmatrix} = \begin{bmatrix} 5 + 2/3 \\ 1 + 4/3 \end{bmatrix} = \begin{bmatrix} 5 + 0.666... \\ 1 + 1.333... \end{bmatrix} = \begin{bmatrix} 5.666... \\ 2.333... \end{bmatrix}$$

O que também pode ser visto como:
$$S\vec{v} = 3 \cdot \begin{bmatrix} 5/3 \\ 1/3 \end{bmatrix} + 2 \cdot \begin{bmatrix} 1/3 \\ 2/3 \end{bmatrix} $$




$$S^{-1} \vec{v} = S\vec{v} $$ 



## Matriz direta e inversa
Assuma a base $B$ como a base canônica, onde $b_1 = (1,0) = \hat{i}$ e $b_2 = (0,1) = \hat{j}$ e a base $B'$ composta por vetores $b'_1 = (2,1)$ e $b'_2 = (-1,1)$.

A matriz direta $S$ que leva da base $B'$ para a base $B$ é dada por:
$$ S = \begin{bmatrix} 2 & -1 \\ 1 & 1 \end{bmatrix} $$
### Matriz direta
Ou seja, tendo um vetor $v$ na base $B'$, para obter suas coordenadas na base $B$, basta multiplicar o vetor $v$ pela matriz $S$:
$$ S\vec{v} = \begin{bmatrix} 2 & -1 \\ 1 & 1 \end{bmatrix} \vec{v} $$

#### Exemplo
Se temos um vetor $v$ na base $B'$ com coordenadas $(3,2)$, para obter suas coordenadas na base $B$, fazemos:
$$ S\vec{v} = \begin{bmatrix} 2 & -1 \\ 1 & 1 \end{bmatrix} \begin{bmatrix} 3 \\ 2 \end{bmatrix} = \begin{bmatrix} 2*3 + (-1)*2 \\ 1*3 + 1*2 \end{bmatrix} = \begin{bmatrix} 6 - 2 \\ 3 + 2 \end{bmatrix} = \begin{bmatrix} 4 \\ 5 \end{bmatrix} $$


### Matriz inversa
A matriz inversa $S^{-1}$ que leva da base $B$ para a base $B'$ é dada por:
$$ S^{-1} = \begin{bmatrix} 1/3 & 1/3 \\ -1/3 & 2/3 \end{bmatrix} $$
Ou seja, tendo um vetor $v$ na base $B$, para obter suas coordenadas na base $B'$, basta multiplicar o vetor $v$ pela matriz $S^{-1}$:
$$ S^{-1}\vec{v} = \begin{bmatrix} 1/3 & 1/3 \\ -1/3 & 2/3 \end{bmatrix} \vec{v} $$

#### Exemplo
Se temos um vetor $v$ na base $B$ com coordenadas $(3,2)$, para obter suas coordenadas na base $B'$, fazemos:
$$ S^{-1}\vec{v} = \begin{bmatrix} 1/3 & 1/3 \\ -1/3 & 2/3 \end{bmatrix} \begin{bmatrix} 3 \\ 2 \end{bmatrix} = \begin{bmatrix} 1/3*3 + 1/3*2 \\ -1/3*3 + 2/3*2 \end{bmatrix} = \begin{bmatrix} 1 + 2/3 \\ -1 + 4/3 \end{bmatrix} = \begin{bmatrix} 1.666... \\ 0.333... \end{bmatrix} $$

#### Como achar a matriz inversa
Para encontrar a matriz inversa $S^{-1}$, podemos usar o método de Gauss-Jordan ou a fórmula para matrizes 2x2. Para uma matriz 2x2 dada por:
$$ S = \begin{bmatrix} a & b \\ c & d \end{bmatrix} $$
A matriz inversa é dada por:
$$ S^{-1} = \frac{1}{ad - bc} \begin{bmatrix} d & -b \\ -c & a \end{bmatrix} $$
Aplicando isso à nossa matriz $S$:
$$ S = \begin{bmatrix} 2 & -1 \\ 1 & 1 \end{bmatrix} $$
Calculamos o determinante:
$$ ad - bc = (2)(1) - (-1)(1) = 2 + 1 = 3 $$
Então, a matriz inversa é:
$$ S^{-1} = \frac{1}{3} \begin{bmatrix} 1 & 1 \\ -1 & 2 \end{bmatrix} = \begin{bmatrix} 1/3 & 1/3 \\ -1/3 & 2/3 \end{bmatrix} $$

Para matrizes maiores, o processo é mais complexo:
1. Formar a matriz aumentada $[S | I]$, onde $I$ é a matriz identidade do mesmo tamanho que $S$.
2. Usar operações elementares de linha para transformar a parte esquerda da matriz aumentada em a matriz identidade.
3. A parte direita da matriz aumentada, após as operações, será a matriz inversa $S^{-1}$.

$$\begin{bmatrix} 2 & -1 & | & 1 & 0 \\ 1 & 1 & | & 0 & 1 \end{bmatrix} \xrightarrow{\text{Operações de linha}} \begin{bmatrix} 1 & 0 & | & 1/3 & 1/3 \\ 0 & 1 & | & -1/3 & 2/3 \end{bmatrix} $$ 

## Mudando a base de uma transformação linear
Dada uma transformação linear $\Phi: V \to W$ e duas bases $B$ e $C$ para os espaços vetoriais $V$ e $W$, respectivamente, a matriz de $\Phi$ em relação a essas bases é dada por $A\Phi$. Se quisermos mudar as bases para $B'$ e $C'$, a nova matriz de $\Phi$ em relação a essas novas bases é dada por:
$$ A\Phi' = T^{-1} A\Phi S $$
Onde $S$ é a matriz de transcrição que leva da base $B'$ para a base $B$, e $T$ é a matriz de transcrição que leva da base $C'$ para a base $C$.

Pensemos em $\Phi$ como uma rotação de 90 graus no plano. Se usarmos a base canônica $B$ para descrever essa rotação, a matriz de $\Phi$ em relação a $B$ seria:
$$ A\Phi = \begin{bmatrix} 0 & -1 \\ 1 & 0 \end{bmatrix} $$
Agora, se quisermos usar uma nova base $B'$ composta por vetores $b'_1 = (2,1)$ e $b'_2 = (-1,1)$, precisamos encontrar a matriz de transcrição $S$ que leva da base $B'$ para a base $B$. Já vimos que essa matriz é:
$$ S = \begin{bmatrix} 2 & -1 \\ 1 & 1 \end{bmatrix} $$
E a matriz de transcrição $T$ que leva da base $C'$ para a base $C$ seria a mesma, já que estamos usando as mesmas bases para $V$ e $W$:
$$ T = \begin{bmatrix} 2 & -1 \\ 1 & 1 \end{bmatrix} $$
Então, para encontrar a nova matriz de $\Phi$ em relação às novas bases, calculamos:
$$ A\Phi' = T^{-1} A\Phi S $$
Calculando $T^{-1}$:
$$ T^{-1} = \begin{bmatrix} 1/3 & 1/3 \\ -1/3 & 2/3 \end{bmatrix} $$
Agora, calculamos $A\Phi S$:
$$ A\Phi S = \begin{bmatrix} 0 & -1 \\ 1 & 0 \end{bmatrix} \begin{bmatrix} 2 & -1 \\ 1 & 1 \end{bmatrix} = \begin{bmatrix} -1 & -1 \\ 2 & -1 \end{bmatrix} $$
Finalmente, calculamos $A\Phi'$:
$$ A\Phi' = T^{-1} A\Phi S = \begin{bmatrix} 1/3 & 1/3 \\ -1/3 & 2/3 \end{bmatrix} \begin{bmatrix} -1 & -1 \\ 2 & -1 \end{bmatrix} = \begin{bmatrix} 1/3*(-1) + 1/3*2 & 1/3*(-1) + 1/3*(-1)) \\ -1/3*(-1) + 2/3*2 & -1/3*(-1) + 2/3*(-1) \end{bmatrix} = \begin{bmatrix} 1/3 & -2/3 \\ 5/3 & -1/3 \end{bmatrix} $$

### Em um cenário onde $V \neq W$
Para ilustrar o caso onde os espaços são diferentes ($V \neq W$), vamos considerar uma projeção do espaço $\mathbb{R}^3$ para o plano $\mathbb{R}^2$.Imagine que a transformação $\Phi: \mathbb{R}^3 \to \mathbb{R}^2$ apenas "descarta" a terceira coordenada: $\Phi(x, y, z) = (x, y)$.

Dada uma transformação linear $\Phi: V \to W$ e duas bases $B$ (para $V$) e $C$ (para $W$), a matriz original é $A\Phi$. Para mudar para as bases $B'$ e $C'$, usamos:$$A\Phi' = T^{-1} A\Phi S$$

$V = \mathbb{R}^3$ com base canônica $B = \{e_1, e_2, e_3\}$.
$W = \mathbb{R}^2$ com base canônica $C = \{f_1, f_2\}$.
