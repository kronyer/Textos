Dada uma transformação linear $L: V \to W$ e outra transformação linear $M: W \to U$, a composição dessas transformações é uma nova transformação linear $M \circ L: V \to U$ definida por:
$$(M \circ L)(v) = M(L(v))$$

E podemos pensa-la em termos práticos como aplicar a transformação $L$ a um vetor $v$ para obter um vetor intermediário $w = L(v)$, e então aplicar a transformação $M$ a esse vetor intermediário para obter o resultado final $u = M(w)$.

Em exemplo, aplicar shear, e depois rotação em $R²$:

$$\begin{bmatrix} 1 & k \\ 0 & 1 \end{bmatrix} \begin{bmatrix} \cos \theta & -\sin \theta \\ \sin \theta & \cos \theta \end{bmatrix} = \begin{bmatrix} \cos \theta + k\sin \theta & -\sin \theta + k\cos \theta \\ \sin \theta & \cos \theta \end{bmatrix}$$