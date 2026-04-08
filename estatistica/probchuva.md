

O spfc ganha com probabilidade $0.7$ se chove e com $0.8$ se nao chove. A probabilidade de chover é de $0.3$

O sao paulo ganhou uma partida, qual a probabilidade de ter chovido?


Arrumando os dados que temos:

$P(Ganha|Chove) = 0.7 \\
P(Ganha|NaoChove) = 0.8 \\
P(Chove) = 0.2 \\
P(NaoChove) = 0.8$

Para sabermos a probabilidade de chover e de ganhar precisamos calcular:

## Probabilidade dos eventos acontecerem juntos, ganhar e chover, dado que a vitoria depende da chuva
$$P(Ganha \cap Chove) = P(Ganha|Chove) \cdot P(Chove) = 0.7 \cdot 0.3 = 0.21$$

## Probabilidade dos eventos acontecerem juntos, ganhar e nao chover, dado que a vitoria depende da chuva
$$P(Ganha \cap NaoChove) = P(Ganha|NaoChove) \cdot P(NaoChove) = 0.8 \cdot 0.7 = 0.56$$


## Probabilidade de ganhar, dado que pode chover ou nao chover
$$P(Ganha) = P(Ganha \cap Chove) + P(Ganha \cap NaoChove) = 0.21 + 0.56 = 0.77$$


## Probabilidade de chover, dado que o spfc ganhou
$$ P(Chove| Ganha) = \frac{P(Ganha \cap Chove)} {P(Ganha)} = \frac{0.21}{0.77} \approx 0.27$$



# MOstreq ue se A e B sao independentes entao \not A e \not B tambem sao independentes

Precisamos provar que 

$$ P(\not A \cap \not B) = P(\not A) \cdot P(\not B) $$

Pelas leis de morgan temos que 

$$ \not A \cap \not B = \not (A \cup B) $$

E $A \cup B$ é o evento complementar de $A \cap B$, ou seja, $P(A \cup B) = 1 - P(A \cap B)$

Como $A$ e $B$ são independentes, temos que $P(A \cap B) = P(A) \cdot P(B)$, então: 

