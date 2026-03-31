# Grupos    
Para ser um grupo, é necessário que haja uma operação binária que satisfaça as seguintes propriedades:
1. **Fechamento**: Para quaisquer elementos $a, b$ no conjunto, a operação deve produzir um resultado que também pertence ao conjunto.
2. **Associatividade**: Para quaisquer elementos $a, b, c$ no conjunto, a operação deve ser associativa, ou seja, $(a \cdot b) \cdot c = a \cdot (b \cdot c)$.
3. **Elemento neutro**: Deve existir um elemento neutro $e$ no conjunto tal que para qualquer elemento $a$ no conjunto, $e \cdot a = a \cdot e = a$.
4. **Elemento inverso**: Para cada elemento $a$ no conjunto, deve existir um elemento inverso $a^{-1}$ tal que $a \cdot a^{-1} = a^{-1} \cdot a = e$.

## Grupos Abelianos
O grupo é chamado de **abeliano** (ou comutativo) se a operação também for comutativa, ou seja, para quaisquer elementos $a, b$ no conjunto, $a \cdot b = b \cdot a$.

5. **Comutatividade**: Para quaisquer elementos $a, b$ no conjunto, a operação deve ser comutativa, ou seja, $a \cdot b = b \cdot a$.


## Espaços Vetoriais como Grupos Abelianos

Qualquer espaço vetorial $V$ é um grupo abeliano em relação à adição de vetores. Isso significa que:

Ele é um espaço vetorial sobre um corpo $K$, ou seja, sobre $\mathbb{R}$ ou $\mathbb{C}$. A estrutura $(V, +)$ é um grupo abeliano.

1. A adição de vetores é **associativa**: para quaisquer vetores $u, v, w \in V$, temos $(u + v) + w = u + (v + w)$.
2. Existe um elemento **neutro** para a adição, que é o vetor zero $0 \in V$, tal que para qualquer vetor $v \in V$, temos $v + 0 = v$.
3. Para cada vetor $v \in V$, existe um vetor **oposto** $-v \in V$ tal que $v + (-v) = 0$.
4. A adição de vetores é **comutativa**: para quaisquer vetores $u, v \in V$, temos $u + v = v + u$.
5. Clojure, ou seja, a adição de vetores é fechada em $V$: para quaisquer vetores $u, v \in V$, o resultado da adição $u + v$ também pertence a $V$.

## Estrutura $(V, +, \cdot)$ não é nem grupo, muito menos abeliano
Embora $(V, +)$ seja um grupo abeliano, a estrutura completa $(V, +, \cdot)$ não é um grupo, pois a multiplicação por escalar não é uma operação binária que satisfaz as propriedades de um grupo. A multiplicação por escalar é uma operação que envolve um elemento do corpo $K$ e um vetor de $V$, e não é fechada em $V$.

Isso é, existem três motivos para que a multiplicação por escalar não seja uma operação de grupo:
1. Operação interna vs. operação externa: A multiplicação por escalar é uma operação externa, pois envolve um elemento do corpo $K$ e um vetor de $V$, enquanto as operações de grupo são operações internas que envolvem apenas elementos do conjunto.