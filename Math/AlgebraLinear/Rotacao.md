Uma rotação linear por $\theta$ em $\mathbb{R}^2$é representada pela matriz de rotação:
$$R(\theta) = \begin{bmatrix} \cos \theta & -\sin \theta \\ \sin \theta & \cos \theta \end{bmatrix}$$

Isso surge do fato de que, pensando na base ortogonal canônica de $R^2$, $\mathbf{e}_1 = (1, 0)$ e $\mathbf{e}_2 = (0, 1)$, a rotação de um vetor $v$ por um ângulo $\theta$ pode ser expressa como uma combinação linear dos vetores base rotacionados:
$$R(\theta) \mathbf{e}_1 = \begin{bmatrix} \cos \theta \\ \sin \theta \end{bmatrix}$$
Que é fácil de visualizar, uma vez que pensando em $T(\mathbf{e}_1)$, seu resultante será um vetor de módulo 1 (pois é uma rotação).

Seu novo x será representado por $\cos \theta$ que está no eixo x, e seu novo y será representado por $\sin \theta$ que está no eixo y.

Portanto: $T(\mathbf{e}_1) = \cos \theta \mathbf{e}_1x + \sin \theta \mathbf{e}_1y$.

Já o vetor $\mathbf{e}_1$ já está em y, ou seja, começa com 90 graus, e a identidade trigonométrica $\cos(\theta + 90) = -\sin \theta$ e $\sin(\theta + 90) = \cos \theta$ nos dá a rotação de $\mathbf{e}_1$:
$$R(\theta) \mathbf{e}_1 = \begin{bmatrix} -\sin \theta \\ \cos \theta \end{bmatrix}$$
Portanto: $T(\mathbf{e}_2) = -\sin \theta \mathbf{e}_1x + \cos \theta \mathbf{e}_1y$.