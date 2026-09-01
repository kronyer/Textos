Queremos provar que o push em uma pilha com array que dobra de tamanho tem seu custo armortizado $O(1)$, contrariando a intuição isolada da operação isolada de pior caso $O(N)$

## Setup
- Array começa com capacidade 1
- Quando o arrau está cheio, e é feito um push, a capacidade dobra ($1 \to 2 \to 4 \to 8 \to ...$).
- Custo de um push sem resize é 1
Custo de um push com resize é a capacidade antiga + 1 (copia todos os antigos e insere o novo)

## Prova usando o método Agregado

Some todo custo total de M pushes e divida por M.

Considere que a inserção normal custa M (sendo M pelo menos 1).

Os resizes acontecem com a ilha em $2^k$, isso é, potêncais de 2 até M, cada resize copia esses elementos

$$ 1 + 2 + 4 + 8 + ... + 2^k < 2M$$

Isso se dá pela soma geométrica ser sempre menos que 2x o último termo.

Portanto, temos que o custo total é $\leq M + 2M = 3M$
E portanto, o custo amortizado por operação é $\leq 3M/M = O(1)$

## Metodo da contabilidade (Banqueiro)

Considere que cada push custa $3, que é dividido em:
- 1 para a propria inserçao
- 2 guardados como crédito

Entre um resize e o proximo, a pilha cresce de capacidade $2^{k-1}$ até $2^k$

Com isso, $2^{k-1}$ elementos novos são inseridos. COnsiderando que cada um tenha guardado 2 de crédito, temos:
$$ 2 \times 2^{k-1} = 2^k$

Como o próximo resize custa $2^k$, o crédito acumulado paga ele todo, portanto amortiza para $O(1)$

## Metodo potencial

Defina a função de potencial:

$$\Phi_i = 2n_i - cap_i$$

onde $n_i$ é o numero de elementos depois da operacao $i$, $cap_i$ é a capacidade do array nesse momento

Quando $\Phi = 0$ a pilha está na metade da capacidade, ou seja, logo depois de um resize.

No inicio, temos que o potencial é -1, isso pois $n_i=0$ e a capacidade é 1.

Logo, ele vai ficar oscilando