# Puzzle Diário — versão 10/10

O plano original era 8/10: boa diversidade cognitiva, mas quinta e sexta não tinham banco de puzzles pronto — você teria que *inventar* o exercício todo dia, o que é insustentável a médio prazo. A versão abaixo mantém a mesma lógica de "5 músculos cognitivos diferentes", mas troca as duas partes fracas por algo que existe em quantidade real, e separa "puzzle resolvido em 15-20min" de "exercício de produção", que é outra categoria de tarefa.

Regra geral: **cronometre**. Se passar de 20-25 min sem breakthrough, pare e volte no dia seguinte — puzzle bom não é maratona, é série.

---

## Segunda — Visualização Cega / Espacial
**Tempo: 15-20 min**

Mantido como estava — é o dia mais bem resolvido do plano original.

- [PuzzleDepot — Spatial IQ Tests](https://puzzledepot.com/iqtests/spatial/): 250 questões de rotação mental e dobra de cubo, com pontuação de QI.
- Prática alternativa sem site nenhum: resolver um cubo mágico **de memória** — olhe o cubo embaralhado por 15s, feche os olhos (ou vire de costas) e resolva só de cabeça. É o exercício mais puro de "girar sólidos sem desenhar" que existe.
- [Puzzle Baron — Nonograms/coleção de grades lógico-espaciais](https://logic.puzzlebaron.com/puzzles.php) como variação ocasional.

**Dica:** alterne entre dois modos — um dia rotação livre (visualizar o objeto girando), outro dia contagem de interseções/sombras (tipo "quantas faces você vê de um poliedro truncado a partir deste ângulo").

---

## Terça — Raciocínio Indutivo Simbólico
**Tempo: 20-25 min**

Raven's Matrices sozinhas secam rápido porque bancos gratuitos de qualidade são raros. A correção: alternar com **ARC**, que tem centenas de tarefas genuinamente novas e é o padrão-ouro atual de "deduzir a regra a partir de exemplos".

- [ARC-Game (volotat)](https://volotat.github.io/ARC-Game/) — versão jogável no navegador do Abstraction and Reasoning Corpus. Cada tarefa mostra 2-4 pares entrada→saída e você deduz a transformação (cor, rotação, contagem, operação lógica implícita) e aplica num caso novo. É literalmente "deduzir operadores booleanos/aritméticos a partir de matrizes" — o request original, mas com fonte inesgotável.
- [Repositório oficial fchollet/ARC-AGI no GitHub](https://github.com/fchollet/ARC-AGI) tem a interface original + todos os 800 tasks, se quiser baixar e resolver offline.
- Para Raven's clássico como variação: qualquer banco de "IQ test raven matrices practice" — mas trate como sobremesa ocasional, não prato principal, porque repete rápido.

---

## Quarta — Dedução Axiomática em Jogos
**Tempo: 15-20 min**

Mantido, com fontes mais específicas.

- **Sudoku expert/hard**: [sudoku.com](https://sudoku.com) (dificuldade "expert") ou os originais da [Nikoli](https://www.nikoli.co.jp/en/) para quem quer a fonte canônica do gênero.
- **Xadrez — dedução de rotas mínimas / táticas forçadas**: [Lichess Puzzles](https://lichess.org/training) (ilimitado, gratuito, sem conta) ou o [Puzzle diário do Chess.com](https://www.chess.com/puzzles). Ambos têm modo "rush" cronometrado, que empurra você pro limite de 15-20min naturalmente.
- **Análise de subconjuntos "pura"**: [Puzzle Baron — Logic Grid Puzzles](https://logic.puzzlebaron.com/) — categorias e clues, sem chute, só eliminação lógica. É o formato mais próximo de "axiomas + dedução restrita" fora do xadrez/sudoku.

---

## Quinta — Isomorfismos / Tradução de Domínio
**Tempo: 20-30 min** (o dia mais denso do plano — aceite que ele não cabe sempre em 15min)

Aqui está a principal correção do plano. "Pegar um processo real e mapear em autômato/grafo/álgebra" não tem banco de puzzles pronto — é modelagem, não resolução. A saída 10/10 é **separar as duas coisas**:

1. **Puzzle pronto, mesmo músculo mental** — LSAT Logic Games treinam exatamente tradução de linguagem natural → sistema formal de regras (ordenação, agrupamento, condicionais), que é 80% do que "isomorfismo" pede no dia a dia:
   - [7Sage — Free LSAT Games](https://7sage.com/games): jogos curtos, sem login, focados em lógica condicional e tradução — ótimo encaixe de 15-20min.
   - [CrackLSAT — 25 testes práticos de Logic Games](https://www.cracklsat.net/lsat/logic-games/): mais tradicional, ~6min por jogo.
   - [Cambridge LSAT — pacote gratuito com gabarito](https://www.cambridgelsat.com/resources/free-downloads/logic-games-practice/): bom para quem quer conferir a modelagem formal depois de resolver.

2. **Exercício de produção, semanal em vez de diário** — reserve isso para 1x por semana (por exemplo, sempre na quinta, mas só a cada 15 dias, alternando com o item 1): pegue um processo real do seu dia (fila do banco, seu próprio fluxo de trabalho, uma regra de jogo) e modele como autômato finito, grafo ou expressão algébrica. Eu posso gerar um cenário novo pra você toda semana sob demanda — é mais eficiente que caçar puzzle pronto pra isso, porque esse tipo de exercício não é padronizável.

---

## Sexta — Redução ao Absurdo & Casos-Limite
**Tempo: 15-20 min para o puzzle + reserva mensal para o exercício de limite**

Mesma lógica da quinta: "levar regras cotidianas a n→0 ou n→∞" é ensaio, não puzzle com gabarito. Correção:

1. **Puzzle pronto que treina o mesmo raciocínio** — problemas de Fermi e estimativa, e problemas de olimpíada que dependem de caso-limite/extremo para achar a resposta:
   - [Coleção de puzzles espaciais/lógicos do 1001 Math Problems](https://www.1001mathproblems.com/p/spatial-puzzles-3d.html) tem vários que se resolvem achando o caso degenerado.
   - Problemas de "extremal principle" de olimpíada (AoPS tem categoria própria) — buscar "olympiad extremal principle problems" dá material renovável por meses.
   - Fermi estimation puzzles ("quantos afinadores de piano existem em SP?") — ótimos para casos-limite aplicados, gratuitos em qualquer busca.

2. **O exercício de "regra cotidiana em n→0/∞" vira mensal**, não diário — é mais ensaio filosófico-matemático do que puzzle, e força-lo a caber toda sexta é o que estava deixando a semana pesada demais no fim. Reserve a última sexta do mês pra isso, com mais tempo (30-40min), e use as outras sextas pros problemas de extremo acima.

---

## Resumo da grade revisada

| Dia | Foco | Tempo | Fonte principal |
|---|---|---|---|
| Seg | Espacial | 15-20 min | PuzzleDepot / cubo mágico de memória |
| Ter | Indutivo simbólico | 20-25 min | ARC-Game |
| Qua | Dedução axiomática | 15-20 min | Sudoku expert / Lichess puzzles / Puzzle Baron |
| Qui | Isomorfismo | 20-30 min | LSAT Logic Games (semanal: modelagem própria) |
| Sex | Absurdo/limites | 15-20 min | Extremal principle / Fermi (mensal: ensaio de limite) |

A mudança central: você tinha 3 dias com banco infinito e 2 dias sem fonte nenhuma. Agora todo dia tem puzzle pronto e renovável, e as duas tarefas de "produção" (modelagem e ensaio de limite) viraram ritual semanal/mensal em vez de obrigação diária — o que é o que realmente as torna sustentáveis.
