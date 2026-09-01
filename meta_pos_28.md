# Estudo: Verificação Formal de Machine Learning

## Fase 1: A Matemática do Contínuo (01/02/2028 - 01/06/2028)

**Objetivo:** Sair do mundo discreto (grafos, indução) e construir o rigor axiomático em Álgebra Linear Contínua e Otimização.

### Ordem

* [ ] Revisão de Cálculo Vetorial e Matrizes (Math for ML)
* [ ] Teoria dos Conjuntos Convexos (Boyd)
* [ ] Funções Convexas e Dualidade (Boyd)

### Cursos vídeos

* [ ] [Stanford EE364A: Convex Optimization (Stephen Boyd)](https://www.youtube.com/playlist?list=PL3940DD956CDF0622) — *Apenas para acompanhar a leitura, as aulas do próprio autor são fantásticas.*

### Livros

* [ ] [suspicious link removed] (Deisenroth) — *Cap. 2 (Álgebra Linear), Cap. 5 (Cálculo Vetorial) e Cap. 7 (Otimização Contínua).*
* [ ] **Convex Optimization** (Boyd & Vandenberghe) — *O núcleo desta fase. Capítulos 2 (Convex Sets), 3 (Convex Functions) e 5 (Duality).*

#### Notas

* Não pule a dualidade Lagrangiana no livro do Boyd. É a mecânica exata que algoritmos modernos usam para encontrar os limites (*bounds*) ao redor de funções de ativação como ReLU e Tanh.

---

## Fase 2: O Motor Lógico e Deep Learning Teórico (01/06/2028 - 01/10/2028)

**Objetivo:** Entender como um software consegue provar equações matemáticas e formalizar Redes Neurais como equações.

### Ordem

* [ ] O Algoritmo Simplex e Programação Linear Inteira (MILP)
* [ ] Teoria dos Reais Fechados e SMT Solvers
* [ ] Formulação matemática de MLPs e RNNs

### Livros

* [ ] **The Calculus of Computation** (Bradley & Manna) — *Capítulos sobre Lógica de Primeira Ordem com Aritmética Linear, e como motores SMT (como o Z3) funcionam por baixo dos panos.*
* [ ] Deep Learning (Ian Goodfellow) — *Apenas os capítulos teóricos focados na formulação matemática (Cap. 6 - Deep Feedforward Networks e Cap. 10 - Sequence Modeling / RNNs).*

### Prática

* [ ] Implementar restrições lógicas contínuas em Python usando a API do **Z3Py**.
* [ ] Codificar o comportamento de um único neurônio ReLU puramente no Z3.

---

## Fase 3: O Estado da Arte em Verificação de ML (01/10/2028 - 01/02/2029)

**Objetivo:** Mergulhar na literatura definitiva da área de Neural Network Verification.

### Ordem

* [ ] Grafos computacionais e restrições formais
* [ ] Verificação via SMT e MILP (Métodos Completos)
* [ ] Interpretação Abstrata: Intervalos, Zonótopos e Poliedros (Métodos Incompletos)
* [ ] O algoritmo CROWN (Relaxação Linear)

### Livros

* [ ] **Introduction to Neural Network Verification** (Aws Albarghouthi) — *O livro definitivo. Leia de capa a capa. É aqui que você junta tudo o que aprendeu nas Fases 1 e 2.*

### Prática

* [ ] Estudar a sintaxe padrão **VNN-LIB** (usada para escrever teoremas de ML).
* [ ] Utilizar a biblioteca `auto_LiRPA` para calcular o *lower/upper bound* de uma rede neural simples em PyTorch.

---

## Fase 4: NLP e Aplicação ao Projeto (01/02/2029 - 01/06/2029)

**Objetivo:** Aplicar a teoria em modelos sequenciais e dados discretos (o que seria um escopo perfeito para sua tese/dissertação usando o seu projeto Escansão).

### Leitura de Papers (Literatura de Fronteira)

* [ ] *Certifying Some Distributional Robustness with Principled Adversarial Training* (Base teórica de robustez).
* [ ] *Robustness Verification for Recurrent Neural Networks* (Papers focados em LSTMs, lidando com o gargalo das ativações Tanh/Sigmoid).
* [ ] *Verifying NLP Models against Perturbations* (Como modelar as perturbações no espaço de Embeddings de caracteres/palavras).

### Prática / Projeto de Mestrado

* [ ] Definir matematicamente um conjunto de **Axiomas Fonéticos/Linguísticos** (ex: regras irrefutáveis de sinalefa e tonicidade da língua portuguesa).
* [ ] Isolar a camada `char_lstm` do seu modelo de escansão.
* [ ] Rodar um verificador formal para provar (ou refutar) se a sua LSTM bidirecional viola esses axiomas sob pequenas perturbações no espaço de embedding contínuo.

---

## Leitura Contínua e Ferramentas (Ao longo do roadmap)

* [ ] Acompanhar o **VNN-COMP** (*Verification of Neural Networks Competition*) — a competição anual onde grupos de pesquisa testam os verificadores mais rápidos.
* [ ] Ler a documentação do framework **Marabou** (SMT solver específico para redes neurais).