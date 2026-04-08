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


# Rotação em $\mathbb{R}^3$

## Noções que precso saber:

### Autovetor

Autovetores ou Eisenvector é um vetor especial, que quando submetido a uma transformação $\Phi$, o resultado é um múltiplo escalar do próprio vetor. Ou seja, para um autovetor $v$ e um autovalor (eigenvalue) $\lambda$, temos:
$$\Phi(v) = \lambda v$$

Portanto, pensando em rotações em $\mathbb{R}^3$, giramos o objeto em torno de um eixo, os pontos que estão nesse eixo não se movem.

Ou seja, se fizermos uma rotação em torno do eixo z, qualquer vetor que seja LD da base $\mathbf{e}_3$ (que é o eixo z) será um autovetor, pois ele não se move, ou seja, a transformação é a identidade para esses vetores.

Toda rotação em $\mathbb{R}^{i}$, onde $i$ seja um número ímpar, tem pelo menos um autovetor, ou seja, um eixo de rotação.

### Kernel

Kernel ou núcleo é o conjunto de todos os vetores que uma transformação linear $\Phi$ "aniquila", ou seja, que são mapeados para o vetor zero. Formalmente, o kernel de $\Phi$ é definido como:
$$\text{Ker}(\Phi) = \{ v \in V : \Phi(v) = 0 \}$$

Podemos ter uma intuição geométrica de achatamento, onde $T(x,y,z) = (x,y,0)$, ou seja, o kernel é o plano xy, pois todos os vetores que estão nesse plano são mapeados para o vetor zero.

Nesse cenário, o eixo z é o kernel da transformação, pois todos os vetores que estão nesse eixo são mapeados para o vetor zero.

## Rotações em $\mathbb{R}^3$ 
Para pensarmos em $R³$ nao estamos mais pensando em um "ponto", mas sim em uma transformação em torno de um eixo.

Rotação acontecendo no eixo z:

$T(e_3) = e_3$ (pois é um autovetor)

* $T(e_1) = \cos \theta e_1 + \sin \theta e_2$
* $T(e_2) = -\sin \theta e_1 + \cos \theta e_2$

note o $e_2$ que se explica trigonometricamente:
A nova posição $x$ é $\cos(90^\circ + \theta) = \mathbf{-\sin \theta}$
A nova posição $y$ é $\sin(90^\circ + \theta) = \mathbf{\cos \theta}$