# Subspaços afins

Subspaços afins são, geometricamente, subspaços que podem ser obtidos a partir de um subespaço vetorial por meio de uma translação.

Intuitivamente:

Um subespaço vetorial sempre passa pela origem, ou seja, contém o vetor nulo. Já um subespaço afim pode ser deslocado para qualquer lugar do espaço, e não precisa conter a origem. Logo, ele deixa de ser um subespaço vetorial.


Podemos descrever com a formula

$$L = x_0 + U$$
Onde $L$ é o subespaço afim, $x_0$ é um ponto fixo (um vetor) e $U$ é um subespaço vetorial.

Em R¹ teriamos 

$$ L = x_0 + \lambda b_1$$
Onde $b_1$ é um vetor que gera o subespaço vetorial $U$ e $\lambda$ é um escalar.

Ja em R² teriamos
$$ L = x_0 + \lambda b_1 + \mu b_2$$
Onde $b_1$ e $b_2$ são vetores que geram o subespaço vetorial $U$ e $\lambda$ e $\mu$ são escalares.


# Transformação afim
Se o subespaço afim é definido por $L = x_0 + U$, onde $U$ é um subespaço vetorial, então a transformação afim associada a $L$ é dada por:
* Uma transformação linear $\Phi$
* Uma translação $a$ que "empurra" o subespaço vetorial $U$ para o subespaço afim $L$.
$$\phi(x) = \Phi(x) + a$$