Para que $V$ seja um espaço vetorial sobre um corpo $\mathbb{R}$, ele deve satisfazer as seguintes propriedades:


## Axiomas da adição de vetores:
1. **Associatividade**: Para todos $u, v, w \in V$, temos $(u + v) + w = u + (v + w)$.
2. **Elemento neutro**: Existe um vetor $0 \in V$ tal que para todo $v \in V$, temos $v + 0 = v$.
3. **Elemento inverso**: Para cada vetor $v \in V$, existe um vetor $-v \in V$ tal que $v + (-v) = 0$.
4. **Comutatividade**: Para todos $u, v \in V$, temos $u + v = v + u$.

## Axiomas da multiplicação por escalar:
1. **Distributividade em relação à adição de vetores**: Para todo $a \in \mathbb{R}$ e para todos $u, v \in V$, temos $a(u + v) = au + av$.
2. **Distributividade em relação à adição de escalares**: Para todos $a, b \in \mathbb{R}$ e para todo $v \in V$, temos $(a + b)v = av + bv$.
3. **Associatividade da multiplicação por escalar**: Para todos $a, b \in \mathbb{R}$ e para todo $v \in V$, temos $a(bv) = (ab)v$. 
4. **Elemento neutro da multiplicação por escalar**: Para todo $v \in V$, temos $1v = v$, onde $1$ é o elemento neutro da multiplicação em $\mathbb{R}$.


# Provas

## Provando em $\mathbb{R}^2$

### A1: Associatividade da adição de vetores
Sejam $u = (u_1, u_2)$, $v = (v_1, v_2)$ e $w = (w_1, w_2)$ em $\mathbb{R}^2$. E sendo seus componentes, 2-uplas de números reais.

Calculamos $(u + v) + w$ e $u + (v + w)$:

1. $(u + v) + w = ((u_1 + v_1), (u_2 + v_2)) + (w_1, w_2) = ((u_1 + v_1) + w_1, (u_2 + v_2) + w_2)$
2. $u + (v + w) = (u_1, u_2) + ((v_1 + w_1), (v_2 + w_2)) = (u_1 + (v_1 + w_1), u_2 + (v_2 + w_2))$
Como a adição de números reais é associativa, temos:
- $(u_1 + v_1) + w_1 = u_1 + (v_1 + w_1)$
- $(u_2 + v_2) + w_2 = u_2 + (v_2 + w_2)$
Portanto, $(u + v) + w = u + (v + w)$, o que prova a associatividade da adição de vetores em $\mathbb{R}^2$.


$\square$

### A2: Elemento neutro da adição de vetores
O elemento neutro para a adição de vetores em $\mathbb{R}^2$ é o vetor $0 = (0, 0)$. Para qualquer vetor $v = (v_1, v_2) \in \mathbb{R}^2$, temos:
- $v + 0 = (v_1, v_2) + (0, 0) = (v_1 + 0, v_2 + 0) = (v_1, v_2) = v$
Portanto, o vetor $0$ é o elemento neutro da adição de vetores em $\mathbb{R}^2$.

$$\forall v \in \mathbb{R}^2, v + 0 = v$$


$\square$

### A3: Elemento inverso da adição de vetores
Para cada vetor $v = (v_1, v_2) \in \mathbb{R}^2$, o elemento inverso é o vetor $-v = (-v_1, -v_2)$. Verificamos que $v + (-v) = 0$:
- $v + (-v) = (v_1, v_2) + (-v_1, -v_2) = (v_1 + (-v_1), v_2 + (-v_2)) = (0, 0) = 0$
Portanto, para cada vetor $v$, existe um vetor $-v$ tal que $v + (-v) = 0$, o que prova a existência do elemento inverso da adição de vetores em $\mathbb{R}^2$.

$$\forall v \in \mathbb{R}^2, \exists -v \in \mathbb{R}^2 : v + (-v) = 0$$

$\square$

### A4: Comutatividade da adição de vetores
Sejam $u = (u_1, u_2)$ e $v = (v_1, v_2)$ em $\mathbb{R}^2$. E sendo seus componentes, 2-uplas de números reais.

Calculamos $u + v$ e $v + u$:
1. $u + v = (u_1, u_2) + (v_1, v_2) = (u_1 + v_1, u_2 + v_2)$
2. $v + u = (v_1, v_2) + (u_1, u_2) = (v_1 + u_1, v_2 + u_2)$
Como a adição de números reais é comutativa, temos:
- $u_1 + v_1 = v_1 + u_1$
- $u_2 + v_2 = v_2 + u_2$
Portanto, $u + v = v + u$, o que prova a comutatividade da adição de vetores em $\mathbb{R}^2$.

$\square$


### M1 : Distributividade em relação à adição de vetores
Sejam $a \in \mathbb{R}$ e $u = (u_1, u_2)$ e $v = (v_1, v_2)$ em $\mathbb{R}^2$. Calculamos $a(u + v)$ e $au + av$:
1. $a(u + v) = a((u_1, u_2) + (v_1, v_2)) = a(u_1 + v_1, u_2 + v_2) = (a(u_1 + v_1), a(u_2 + v_2))$
2. $au + av = a(u_1, u_2) + a(v_1, v_2) = (au_1, au_2) + (av_1, av_2) = (au_1 + av_1, au_2 + av_2)$
Como a multiplicação de números reais é distributiva em relação à adição, temos:
- $a(u_1 + v_1) = au_1 + av_1$
- $a(u_2 + v_2) = au_2 + av_2$
Portanto, $a(u + v) = au + av$, o que prova a distributividade da multiplicação por escalar em relação à adição de vetores em $\mathbb{R}^2$.


$\square$

### M2: Distributividade em relação à adição de escalares
Sejam $a, b \in \mathbb{R}$ e $v = (v_1, v_2)$ em $\mathbb{R}^2$. Calculamos $(a + b)v$ e $av + bv$:
1. $(a + b)v = (a + b)(v_1, v_2) = ((a + b)v_1, (a + b)v_2)$
2. $av + bv = a(v_1, v_2) + b(v_1, v_2) = (av_1, av_2) + (bv_1, bv_2) = (av_1 + bv_1, av_2 + bv_2)$
Como a multiplicação de números reais é distributiva em relação à adição, temos:
- $(a + b)v_1 = av_1 + bv_1$
- $(a + b)v_2 = av_2 + bv_2$
Portanto, $(a + b)v = av + bv$, o que prova a distributividade da multiplicação por escalar em relação à adição de escalares em $\mathbb{R}^2$.

$\square$

### M3: Associatividade da multiplicação por escalar
Sejam $a, b \in \mathbb{R}$ e $v = (v_1, v_2)$ em $\mathbb{R}^2$. Calculamos $a(bv)$ e $(ab)v$:
1. $a(bv) = a(b(v_1, v_2)) = a(bv_1, bv_2) = (a(bv_1), a(bv_2))$
2. $(ab)v = (ab)(v_1, v_2) = ((ab)v_1, (ab)v_2)$
Como a multiplicação de números reais é associativa, temos:
- $a(bv_1) = (ab)v_1$
- $a(bv_2) = (ab)v_2$
Portanto, $a(bv) = (ab)v$, o que prova a associatividade da multiplicação por escalar em $\mathbb{R}^2$.

$\square$

### M4: Elemento neutro da multiplicação por escalar
Seja $v = (v_1, v_2)$ em $\mathbb{R}^2$. Calculamos $1v$:
- $1v = 1(v_1, v_2) = (1v_1, 1v_2) = (v_1, v_2) = v$
Portanto, $1v = v$, o que prova que o elemento neutro da multiplicação por escalar é $1$ em $\mathbb{R}^2$.

$\square$


## Provando em $\mathbb{R}^n$
A prova para $\mathbb{R}^n$ é análoga à prova para $\mathbb{R}^2$, mas com vetores de $n$ componentes. As propriedades da adição de vetores e da multiplicação por escalar em $\mathbb{R}^n$ seguem as mesmas regras que em $\mathbb{R}^2$, e a associatividade, elemento neutro, elemento inverso, comutatividade, distributividade e associatividade da multiplicação por escalar podem ser provadas usando as propriedades dos números reais e a definição de adição de vetores e multiplicação por escalar em $\mathbb{R}^n$. Portanto, $\mathbb{R}^n$ também é um espaço vetorial sobre o corpo $\mathbb{R}$.