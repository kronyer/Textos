# Teorema de bayes

O teorema de Bayes é uma fórmula matemática que descreve a probabilidade de um evento, com base em informações prévias sobre o evento. Ele é usado para atualizar as probabilidades de um evento com base em novas evidências.

Dado pela formula:

$$ P(A|B) = \frac{P(B|A) \cdot P(A)}{P(B)} $$

Ou seja, é a probabilidade de A ocorrer dado que B aconteceu, é igual a probabilidade do inverso, ou seja, a probabilidade de B ocorrer dado que A, multiplicada pela probabilidade de A, e dividida pela probabilidade de B.

Exemplo real:
Suponha que um teste para uma doença seja 99% preciso, ou seja, ele tem uma taxa de falso positivo de 1%. Se a prevalência da doença na população é de 0,1%, qual é a probabilidade de uma pessoa ter a doença se o teste der positivo?


Dado:

* P(D) = 0,01 (probabilidade de ter a doença
* P(¬D) = 0,99 (probabilidade de não ter a doença)

Temos o teste para essa doença:
* P(Positivo|D) = 0,99 (probabilidade de teste positivo dado que a pessoa tem a doença)
* P(Positivo|¬D) = 0,05

Se uma pessoa ao acaso faz o teste e o resultado é positivo, qual a verdadeira probabilidade dela ter a doença P(D|Positivo)?

Usando bayes:

$$ P(D|Positivo) = \frac{P(Positivo|D) \cdot P(D)}{P(Positivo | D) \cdot P(D) + P(Positivo | ¬D) \cdot P(¬D)} $$

Substituindo os valores:

$$P(D|Positivo) = \frac{0,99 \cdot 0,01}{0,99 \cdot 0,01 + 0,05 \cdot 0,99}$$

Logo, a probabilidade é de aproximadamente 0.16



# Diferença para naive bayes

O calculo utilizando bayes para um evento é simples, mas quando temos multiplas variavels (x1,x2...) que influenciam uma hipótese C, a equação exata seria:

$$ P(C|x1,x2,...,xn) = \frac{P(x1,x2,...,xn|C) \cdot P(C)}{P(x1,x2,...,xn)} $$

Para calcular esse P voce teria que calcular todas as interações e dependencias entre as variáveis, o que é computacionalmente inviável.

Naive bayes é uma suposição ingenua de que assume que todas as variaveis $x_i$ são independentes entre si, o que simplifica a equação para:


$$P(x1,x2,...,x_n|C) = P(x1|C) \cdot P(x2|C) \cdot ... \cdot P(xn|C)$$

ou seja, um produtório das probabilidades individuais, o que torna o cálculo muito mais simples e rápido, mesmo que a suposição de independência nem sempre seja verdadeira.

$$ P(C|x1,x2,...,xn) = \frac{P(x1|C) \cdot P(x2|C) \cdot ... \cdot P(xn|C) \cdot P(C)}{P(x1,x2,...,xn)} $$


$$P(C | x_1, \dots, x_n) \propto P(C) \prod_{i=1}^{n} P(x_i | C)$$