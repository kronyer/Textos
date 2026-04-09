# Numericamente

Numericamente, se tiver dois vetores da mesma dimensão, ou duas listas de números, podemos calcular o produto escalar entre eles, que é a soma dos produtos dos elementos correspondentes. Por exemplo, se tivermos os vetores $\mathbf{v} = (v_1, v_2, v_3)$ e $\mathbf{w} = (w_1, w_2, w_3)$, o produto escalar é dado por:
$$\mathbf{v} \cdot \mathbf{w} = v_1 w_1 + v_2 w_2 + v_3 w_3$$


# Interpretação geométrica
Podemos pensar no dot product entre dois vetores $v$ e $w$ como a projeção de um vetor sobre o outro. O produto escalar é igual ao comprimento do vetor $v$ multiplicado pelo comprimento da projeção de $v$ sobre $w$.

Temos duas formas de calcular, ou sendo (u_1, u_2) e (v_1, v_2) ou usando a fórmula $u \cdot v = ||u|| \cdot ||v|| \cdot \cos(\theta)$, onde $\theta$ é o ângulo entre os vetores $u$ e $v$.

Lembrando que $||u||$ é o comprimento do vetor $u$, que é calculado usando a fórmula $||u|| = \sqrt{u_1^2 + u_2^2}$.


## dot product é comutativo
O produto escalar é comutativo, ou seja, $u \cdot v = v \cdot u$. Isso ocorre porque a ordem dos fatores não altera o produto, ou seja, $u_1 v_1 + u_2 v_2$ é igual a $v_1 u_1 + v_2 u_2$.

Podemos provar isso usando a definição do produto escalar:
$$u \cdot v = u_1 v_1 + u_2 v_2$$
$$v \cdot u = v_1 u_1 + v_2 u_2$$
Como a multiplicação de números reais é comutativa, temos:
$$u_1 v_1 = v_1 u_1$$
$$u_2 v_2 = v_2 u_2$$
Portanto, somando as duas igualdades, obtemos:
$$u \cdot v = v \cdot u$$



No fundo, estamos fazendo uma multiplicação de matrizes, onde qualquer um dos vetores é uma matriz 1x2, ou seja, é $v^T$ ou $u^T$

$$\begin{bmatrix} u_1 & u_2 \end{bmatrix} \cdot \begin{bmatrix} v_1 \\ v_2 \end{bmatrix} = u_1 v_1 + u_2 v_2$$