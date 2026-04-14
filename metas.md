- [x] Nunca comparar com Double, e sim com decimal
- [x] Inline arrays
- [X] Jagged arrays vs multidimensional
- [x] C# bankers rounding
- [x] Base 64, base 64 url, base 62 e outras bases
- [x] Catch when
- [x] Checked overflow
- [X] Double e Int dividindo por zero
- [x] Break continue e return
- [ ] Partial functions na program, program.test.cs para evitar que com top level statements as funções dentro da program virem local functions
- [X] Documentar funções xml
- [x] Test doer e try patrern
- [ ] Debug tracer e ilogger e os Trace levels
- [x] Modificadores de acesso
- [x] Aliás, using, podemos renomear qualquer tipo, até tuplas
- [x] Enum herdando de byte e podendo ser lista usando |, com a annotation [Flags]
- [ ] Usando static, metodos, propriedades, classes
- [ ] [SetRequiredMembers] para forçar a inicialização de propriedades
- [x] Optional parameters, precisa do ? ou não
- [ ] Passagem de parametros, value, out ref e in
- [ ] Params keyword, permitindo qualquer collection
- [ ] Ref returns
- [ ] Usando tuplas, tuple name inference, aliasing, deconstruction
- [ ] Partial methods
- [ ] Fields vs properties
- [ ] Best way to calculate someone age
- [ ] Geters, setters, backing fields e partial properties
- [ ] Definindo indices com this[]
- [ ] pattern matching com objetos
- [ ] Records
  - [ ] usando `with` para criar novos objetos a partir de outros
  - [ ] record simpler syntax que já cria properties, construtor e deconstructor
  - [ ] Records nao sao sempre imutaveis (p.363)
- [ ] Modelando OOP com casamento, + e *, Person, Children, etc
- [ ] Delegates, functional pointer e currying?
  - [ ] Events vs delegates
- [ ] Interfaces:
  - [ ] Falando sobre interfaces comuns (p.323)
  - [ ] Implementação implicit vs explicit
  - [ ] Diferença entre interface e classe abstrata
- [ ] Nullable value types, isso vem de FP?
- [ ] Usando is null, nao o == null, para evitar problemas de sobrecarga de operadores
- [ ] ThrowIfNull e o `!!` operator
- [ ] Hiding vs overriding
- [ ] `sealed` em classes e metodos
- [ ] Polimorfismo
- [ ] Checar p.354
- [ ] Casting com as, retorna null quando falha?
- [ ] Extension methods quando nao da pra herdar
- [ ] Return `this` para permitir chaining, fluent style, isso é semelhabnte a FP com monads?
- [ ] Deconstructor vs deconstruct
- [ ] Late binding, como fica o código em IL
- [ ] Quadrado não deve herdar de shape, mas sim de retangulo
- [ ] Native sized int
- [ ] System runtime dll nao tem types, so types forward
- [ ] FDD FDE e self contained apps
  - [ ] Single file app sem self contained: `dotnet publish -r win-x64 -p:PublishSingleFile=true --self-contained false`
- [ ] Trim no publish
- [ ] Build props use artifacts
- [ ] Native aot
- [ ] Method interceptors e a geração de migrations (?)
- [ ] IList<T> [DefaultMember]
- [ ] Arrays são melhores que listas, usar quando o tamanho é conhecido, ou converter para array depois de operar com a lista
- [ ] Dictionary
  - [ ] KeyValue<TKey, TValue> e KeyValuePair<TKey, TValue>?? 
  - [ ] Dictionary ou hashset?
- [ ] Sets
  - [ ] Metodos de set
- [ ] Stack e Queue e priority queue
- [ ] Sorted collections
- [ ] AsReadOnly
- [ ] ToImmutableDicitionary, ToImmutableList, etc
- [ ] Frozen collections - FrozenDictionary
- [ ] Spread operator (..)
- [ ] IEnumerable como argumento de métodos é lento, usar List
- [ ] Nao retornar null em collections, retornar o .Empty relativo
- [ ] p489 span para arrays
- [ ] `Index` e `Range` para acessar partes de arrays
  - [ ] p.492 ReadonlySpan<char> foreach Range r in text.split
- [ ] Strings
  - [ ] Qual o tamanho maximo de bytes de uma string? 
  - [ ] SecureString
  - [ ] Span<char> para manipular strings sem criar novas instancias
  - [ ] Trabalhando com files
    - [ ] Streams - File, memory, network
    - [ ] GZip vs Brotli
- [ ] ASCII, ANSII, ISO e os UTC e UTF
- [ ] Como funciona um Hashet de objetos, o que é um hash code, como funciona o GetHashCode e Equals
- [ ] Serializando XML, usando [XMLAttribute]
- [ ] Serializando Json, JsonIgnore, JsonInclude

# Db
- [ ] cursor, exec sql em c puro
- [ ] ODMS


# Calc
- [x] Provar continuidade por $\epsilon-\delta$ 
- [x] Limites vs continuidade
- [ ] Unicidade do limite
- [x] Limite pode estar fora do dominio da função

# AL
- [ ] $A = LU$ ?
- [ ] Metodo gauss jordan para resolver sistemas lineares

# Estatistica
- [ ] Bayes
- [ ] Binomio de Newton
- [ ] Distribuições
  - [ ] Normal
  - [ ] Binomial
  - [ ] Poisson
  - [ ] Exponencial
  - [ ] Uniforme

# Outros

### 1. Algoritmos de String (Fuzzy)
- [ ] **Distância de Levenshtein**: Entender a matriz de custo e implementação via Programação Dinâmica.
- [ ] **Distância de Jaro-Winkler**: Diferença entre Levenshtein e métricas que priorizam prefixos.
- [ ] **Damerau-Levenshtein**: Como lidar com a transposição de caracteres adjacentes (ex: "te" vira "et").

### 2. Fonética Computacional
- [ ] **Soundex**: Estudo do algoritmo base e por que ele falha com nomes estrangeiros e vogais.
- [ ] **Metaphone**: Regras de transformação de grupos de letras em fonemas únicos.
- [ ] **Adaptação PT-BR**: Estudar regras específicas do português para "R/H" inicial, "S/Ç/Z" e "LH/NH".
- [ ] **Double Metaphone**: Implementação de chaves fonéticas duplas (primária e alternativa).

### 3. Recuperação de Informação (IR) Clássica
- [ ] **N-Grams / Trigramas**: Decomposição de strings em pedaços menores para busca parcial.
- [ ] **Inverted Index (Índice Invertido)**: A estrutura de dados fundamental por trás de motores de busca.
- [ ] **TF-IDF**: Entender como a frequência de um termo define a relevância do resultado.

### 4. Persistência e Otimização (PostgreSQL)
- [ ] **Extensão pg_trgm**: Como o banco usa trigramas para acelerar o operador `LIKE`.
- [ ] **Extensão fuzzystrmatch**: Uso prático das funções nativas e limitações de performance.
- [ ] **Índices GIN vs GiST**: Quando usar cada um para buscas de texto e trigramas.
- [ ] **Estratégia de Fallback**: Lógica de cascata (Match Exato -> Prefixo -> Fonético -> Fuzzy).

### 5. Avaliação de Qualidade
- [ ] **Precision (Precisão)**: Proporção de resultados relevantes entre os recuperados.
- [ ] **Recall (Revocação)**: Proporção de resultados relevantes recuperados em relação ao total existente.
- [ ] **F1-Score**: A média harmônica entre precisão e revocação.