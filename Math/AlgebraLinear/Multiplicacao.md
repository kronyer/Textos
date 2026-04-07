Tomando a matriz como representante de uma transformação linear, podemos definir a transformação por onde os vetores base pousam após a transformação, que formam as colunas de uma matriz.

Para encontrar onde um vetor $v$ pousa após a transformação, basta multiplicar a matriz $A$ pela coordenada do vetor $v$ em relação à base:

$$Av = w$$

Ou seja:

$$\begin{bmatrix} a & b \\ c & d \end{bmatrix} \begin{bmatrix} x \\ y \end{bmatrix} = x \begin{bmatrix} a  \\ c \end{bmatrix} + y \begin{bmatrix} b  \\ d \end{bmatrix}= \begin{bmatrix} ax + by \\ cx + dy \end{bmatrix}$$

## Formas de pensar a multiplicação de matrizes


### Produto interno

$$C_{ij} = \sum_{k=1}^{n} a_{ik} b_{kj}$$

O que, eh melhor ilustrado por:

$$ C = AB$$

E a partir disso, podemos fazer o somatório de cada linha de $A$ com cada coluna de $B$ para obter os elementos de $C$.

$$C_{11} = a_{11}b_{11} + a_{12}b_{21} + ... + a_{1n}b_{n1}$$

e generalizando:
$$C_{ij} = a_{i1}b_{1j} + a_{i2}b_{2j} + ... + a_{in}b_{nj}$$

e a matriz tem forma:

$$\begin{bmatrix} C_{11} & C_{12} & ... & C_{1m} \\ C_{21} & C_{22} & ... & C_{2m} \\ ... & ... & ... & ... \\ C_{n1} & C_{n2} & ... & C_{nm} \end{bmatrix}$$

### Multiplicação por blocos - Matriz A por matriz B
É a forma clássica:

$$\begin{bmatrix} A_{11} & A_{12} \\ A_{21} & A_{22} \end{bmatrix} \begin{bmatrix} B_{11} & B_{12} \\ B_{21} & B_{22} \end{bmatrix} = \begin{bmatrix} A_{11}B_{11} + A_{12}B_{21} & A_{11}B_{12} + A_{12}B_{22} \\ A_{21}B_{11} + A_{22}B_{21} & A_{21}B_{12} + A_{22}B_{22}\end{bmatrix}$$

### Forma 2 — Matriz A por coluna de B

Cada coluna de $C$ é $A$ aplicado à coluna correspondente de $B$:

$$A\mathbf{b}_j = \mathbf{c}_j$$

$$AB = A\begin{bmatrix} \mathbf{b}_1 & \mathbf{b}_2 & \cdots & \mathbf{b}_p \end{bmatrix} = \begin{bmatrix} A\mathbf{b}_1 & A\mathbf{b}_2 & \cdots & A\mathbf{b}_p \end{bmatrix} = C$$


### Forma 3 — Linha de A por matriz B

Cada linha de $C$ é a linha correspondente de $A$ multiplicando $B$ inteira:

$$\mathbf{a}_i^T B = \mathbf{c}_i^T$$

$$AB = \begin{bmatrix} \mathbf{a}_1^T \\ \mathbf{a}_2^T \\ \vdots \\ \mathbf{a}_m^T \end{bmatrix} B = \begin{bmatrix} \mathbf{a}_1^T B \\ \mathbf{a}_2^T B \\ \vdots \\ \mathbf{a}_m^T B \end{bmatrix} = C$$


### Forma 4 — Soma de produtos externos

$AB$ é a soma de $n$ matrizes de rank 1, cada uma formada por uma coluna de $A$ multiplicada pela linha correspondente de $B$:

$$AB = \sum_{k=1}^{n} \mathbf{a}_k \mathbf{b}_k^T$$

Explicitando:

$$AB = \mathbf{a}_1 \mathbf{b}_1^T + \mathbf{a}_2 \mathbf{b}_2^T + \cdots + \mathbf{a}_n \mathbf{b}_n^T$$

onde cada termo $\mathbf{a}_k \mathbf{b}_k^T$ é uma matriz inteira (produto externo).