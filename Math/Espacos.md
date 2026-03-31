O espaço vetorial $V$, abeliano em relação à adição de vetores, mas nem grupo nem abeliano em relação à multiplicação por escalar.

O espaço vetorial é onde acontece a algebra linear, e para ser um espaço vetorial, é necessário obedecer a um conjunto de 8 axiomas, que são:
**Axiomas de Adição**
* Comutatividade: $\mathbf{u} + \mathbf{v} = \mathbf{v} + \mathbf{u}$
* Associatividade: $(\mathbf{u} + \mathbf{v}) + \mathbf{w} = \mathbf{u} + (\mathbf{v} + \mathbf{w})$
* Elemento Neutro: Existe um vetor $\mathbf{0} \in V$ tal que $\mathbf{u} + \mathbf{0} = \mathbf{u}$
* Elemento Oposto: Para todo $\mathbf{u}$, existe um $-\mathbf{u} \in V$ tal que $\mathbf{u} + (-\mathbf{u}) = \mathbf{0}$
  
**Axiomas de Multiplicação por Escalar**
* Distributividade (em relação à soma de vetores): $a(\mathbf{u} + \mathbf{v}) = a\mathbf{u} + a\mathbf{v}$
* Distributividade (em relação à soma de escalares): $(a + b)\mathbf{u} = a\mathbf{u} + b\mathbf{u}$
* Associatividade da Multiplicação: $a(b\mathbf{u}) = (ab)\mathbf{u}$
* Identidade: $1\mathbf{u} = \mathbf{u}$ (onde $1$ é o elemento neutro da multiplicação nos reais)


Um exemplo classico é o $\mathbb{R}^n$, que é um espaço vetorial sobre o corpo $\mathbb{R}$, onde a adição de vetores é a soma componente a componente e a multiplicação por escalar é a multiplicação de cada componente por um escalar.


## Subspaço
Já o subspaço, digamos $W$ de um espaço vetorial $V$, é um subconjunto de $V$ que é ele mesmo um espaço vetorial, ou seja, $W$ é fechado sob a adição de vetores e a multiplicação por escalar.

Por ser um subconjunto de $V$, o subspaço $W$ herda a estrutura de espaço vetorial, e, portanto, precisamos apenas checar 3 condições:
* O vetor zero de $V$ pertence a $W$.
* $W$ é fechado sob a adição de vetores: para quaisquer vetores $u, v \in W$, a soma $u + v$ também pertence a $W$.
* $W$ é fechado sob a multiplicação por escalar: para qualquer vetor $v \in W$ e qualquer escalar $c \in K$, o produto $cv$ também pertence a $W$.



## Span, ou espaço gerado
Span é a ferramenta usada para construir um subspaço.

Cosnidere o Espaço Vetorial $V$ o universo e o subspaço uma fração organizad. O span é a regra que define exatamente o tamanho e o formato dessa fração.

Span é o construtor, span é o resultado de todas as combinações possiveis que você pode fazer com um conjunto de vetores. O span de um conjunto de vetores $S$ é o menor subspaço que contém todos os vetores de $S$. Em outras palavras, o span de $S$ é o conjunto de todas as combinações lineares dos vetores em $S$.

### Quando o Span se torna o próprio Espaço?
Essa é a parte interessante. O span pode ser "menor" que o espaço original ou "igual" a ele:
* Subespaço Próprio: Se você está no $\mathbb{R}^3$ (espaço 3D) e faz o $span$ de apenas 2 vetores (L.I.), você gera um plano. Esse plano é um subespaço, mas não é o espaço $\mathbb{R}^3$ inteiro.
* O Espaço Inteiro: Se você pegar 3 vetores que não estão no mesmo plano (L.I.) no $\mathbb{R}^3$, o $span$ deles vai preencher todo o "universo" 3D. Nesse caso, o subespaço gerado coincide com o próprio espaço vetorial.