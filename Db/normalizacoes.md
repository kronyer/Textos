# Normalizacoes
Podemos pensar em normalizações como um processo de padronização de dados, como checks para garantir que os dados estejam organizados da melhor forma possível, evitando redundâncias e inconsistências.

Existem 5 normalizações, cada uma com um conjunto de regras e objetivos específicos:

## Rigor formal

Antes de tudo, vamos definir as relacoes como sendo $R = \{A_1, A_2, ..., A_n\}$, onde cada $A_i$ é um atributo. E uma instancia $r(R)$ é um conjunto de tuplas, onde cada tupla é uma linha da tabela.

### Dependencia Funcional
Sejam $X \subseteq R$ e $Y \subseteq R$, dizemos que $X$ determina funcionalmente $Y$ (escrevemos $X \to Y$) se, para quaisquer duas tuplas $t_1$ e $t_2$ em $r(R)$, se $t_1[X] = t_2[X]$, então $t_1[Y] = t_2[Y]$. Em outras palavras, o valor de $X$ determina unicamente o valor de $Y$.

Em uma linguagem mais simples, isso significa que se tivermos o mesmo valor para os atributos em $X$, então os valores dos atributos em $Y$ também serão os mesmos. Por exemplo, se $X$ for o atributo "CPF" e $Y$ for o atributo "Nome", então $CPF \to Nome$ significa que cada CPF único corresponde a um nome único.

Eh intuitivo pensar em funcoes matematicas, onde $f(x) = y$ significa que o valor de $x$ determina unicamente o valor de $y$. A dependencia funcional é uma generalização disso para conjuntos de atributos em um banco de dados.

### Superchave e chave candidata
Um subconjunto $K \subseteq R$ é uma superchave se $K \to R$, ou seja, se $K$ determina funcionalmente todos os atributos de $R$. Em outras palavras, uma superchave é um conjunto de atributos que pode ser usado para identificar unicamente cada tupla na relação.

Ja chave candidata é uma superchave minimal, ou seja, é uma superchave que não possui nenhum subconjunto próprio que também seja uma superchave. Em outras palavras, uma chave candidata é um conjunto mínimo de atributos que pode ser usado para identificar unicamente cada tupla na relação.

### Atributos primos
Um atributo é considerado primo se ele fizer parte de pelo menos uma chave candidata. Ou seja, 


## Formas Normais

### Primeira Forma Normal (1NF)
A primeira forma normal nao diz sobre dependencias, mas sim sobre estrutura.

Dizemos que $R$ está na 1NF se, para todo atributo $A \in R$, o domínio de $A$ (denotado por $\text{Dom}(A)$) contém apenas valores atômicos.

$\text{Dom}(A) \text{ é atômico} \iff \forall v \in \text{Dom}(A), v \text{ é indivisível}$

Em linguagem mais simples, isso significa que cada atributo deve conter apenas um valor por tupla. Por exemplo, se tivermos um atributo "Telefone" que pode conter múltiplos números de telefone, isso violaria a 1NF. Para estar na 1NF, cada tupla deve ter apenas um número de telefone.

#### Exemplo de violação da 1NF e correcao
Suponha que temos uma relação $R$ com os seguintes atributos: $R = \{ID, Nome, Telefones\}$, onde "Telefones" pode conter múltiplos números de telefone separados por vírgula.
| ID | Nome  | Telefones          |
|----|-------|--------------------|
| 1  | Alice | 1234, 5678         |

Essa relação não está na 1NF porque o atributo "Telefones" contém múltiplos valores. Para corrigir isso, podemos criar uma nova relação $R'$ com os seguintes atributos
$R' = \{ID, Nome, Telefone\}$, onde cada tupla representa um número de telefone diferente para o mesmo ID e Nome.
| ID | Nome  | Telefone |
|----|-------|----------|
| 1  | Alice | 1234     |
| 1  | Alice | 5678     |

### Segunda Forma Normal (2NF)
A segunda forma normal visa eliminar a dependencia funcional de atributos nao primos em relação a uma chave composta.


Seja $R$ um esquema de relação definido como um conjunto finito de atributos $\{A_1, A_2, \dots, A_n\}$.

Seja $F$ o conjunto de dependências funcionais válidas em $R$.

Seja $K$ uma chave candidata de $R$. Por definição, $K \subseteq R$ e satisfaz duas propriedades:
* Unicidade: $K \rightarrow R$
* Irredutibilidade: $\not\exists K' \subset K$ tal que $K' \rightarrow R$
 
Seja $A \in R$ um atributo que não pertence a nenhuma chave candidata $K$. Este é o nosso atributo não-primo ($A \notin K$).

A formalização da 2NF se concentra nesta proposição condicional:
"Se $K$ é uma chave candidata e $X \subset K$ (com $X \neq K$), então $\not\exists (X \rightarrow A)$ para todo $A \notin K$."