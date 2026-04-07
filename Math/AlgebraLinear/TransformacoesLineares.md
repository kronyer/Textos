Para uma transformação $L$ ser considerada linear, ela deve satisfazer as seguintes propriedades para quaisquer vetores $u, v$ e escalar $c$:
1. **Aditividade**: $L(u + v) = L(u) + L(v)$
2. **Homogeneidade**: $L(cu) = cL(u)$


E como corolário, a transformação linear também satisfaz:
3. **Preservação do vetor nulo**: $L(0) = 0$


## De onde vem $L(0) = 0$?
Podemos provar isso usando as propriedades de aditividade e homogeneidade:

1. Homogeneidade: 
$$L(\alpha \cdot v) = \alpha \cdot L(v)$$
Se escolhermos $\alpha = 0$, temos:
$$L(0 \cdot v) = 0 \cdot L(v)$$
$$L(0) = 0$$

2. Aditividade:
$$L(u + v) = L(u) + L(v)$$
Sabemos que 0 + 0 = 0, então:
$$L(0 + 0) = L(0) + L(0)$$
$$L(0) = L(0) + L(0)$$
Subtraindo $L(0)$ de ambos os lados, obtemos:
$$0 = L(0)$$