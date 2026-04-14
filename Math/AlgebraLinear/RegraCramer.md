# Regra de cramer

A regra de cramer é um método para resolver sistemas lineares usando determinantes. Para um sistema de $n$ equações e $n$ incógnitas, a solução para cada incógnita pode ser encontrada usando a fórmula:
$$x_i = \frac{\text{det}(A_i)}{\text{det}(A)}$$
onde $A$ é a matriz dos coeficientes do sistema, e $A_i$ é a matriz obtida substituindo a coluna $i$ de $A$ pelo vetor dos termos constantes.

Em outras palavras, pense algoritmicamente dessa forma:

Temos um sistema linear:
$$\begin{cases} ax + by = e \\ cx + dy = f \end{cases}$$

Primeiro, descobrimos o determinante principal:
$$D = \text{det}\begin{pmatrix} a & b \\ c & d \end{pmatrix} = ad - bc$$

Depois, para encontrar $x$, substituímos a primeira coluna por $e$ e $f$:
$$D_x = \text{det}\begin{pmatrix} e & b \\ f & d \end{pmatrix} = ed - bf$$

E para encontrar $y$, substituímos a segunda coluna por $e$ e $f$:
$$D_y = \text{det}\begin{pmatrix} a & e \\ c & f \end{pmatrix} = af - ce$$

O resultado final se mostra como:
$$x = \frac{D_x}{D} \quad \text{e} \quad y = \frac{D_y}{D}$$