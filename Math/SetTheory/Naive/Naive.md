



# Three ways of defining the set of primes

The set of prime numbers can be defined in various ways. Here are three common definitions:

The basic one:

$$ \mathbb{P} = \{ p \in \mathbb{N} : prime(p) \} $$

Where $prime(p)$ is a predicate that holds true if and only if $p$ is a prime number.

The second one, using the property of divisibility:

$$ \mathbb{P} = \{ p \in \mathbb{N} : p > 1 \text{ and } \forall d \in \mathbb{N}, (d | p) \implies (d = 1 \text{ or } d = p) \} $$

The third one, using euclid's lemma:

if $p | ab$ then $p | a$ or $p | b$

Pratical example:

Consider p = 3, and a =6, and b = 9.

The product ab = 54.

It's true that 3 | 54

Its also true that 3 | 6

And also true that 3 | 9


## Set T
Imagine $T = \{(p,p+2): prime(p) \text{ and } prime(p+2)\}$, which is the set of twin primes.

This is the set of twin primes, which are pairs of prime numbers that differ by 2. For example, (3, 5), (11, 13), and (17, 19) are all elements of the set $T$.

There is a conjecture in number theory called the Twin Prime Conjecture, which states that there are infinitely many twin primes. However, this conjecture has not yet been proven or disproven.

# Subset relations

## Definition:
$S \subseteq T$ means that every element of $S$ is also an element of $T$. In other words, if $x \in S$, $\implies$ $x \in T$.

### Corollary 1: $\emptyset \subseteq T$
The empty set is a subset of every set, including $T$. This is because there are no elements in the empty set to violate the condition of being a subset.

In logic, we say that the statement "for all $x$ in $\emptyset$, $x$ is in $T$" is vacuously true, since there are no elements in $\emptyset$ to contradict it.


# Findindg subsets of T

Imagine $A = \{a,b,c\}.

What are the subsets of $A$?
The subsets of $A$ are:
1. $\emptyset$
2. $\{a\}$
3. $\{b\}$
4. $\{c\}$
5. $\{a, b\}$
6. $\{a, c\}$
7. $\{b, c\}$
8. $\{a, b, c\}$

There are $2^n$ subsets of a set with $n$ elements, so for a set with 3 elements, there are $2^3 = 8$ subsets, which matches our list above.

This operation is called the power set of $A$, denoted as $\mathcal{P}(A)$, which is the set of all subsets of $A$. In this case, $\mathcal{P}(A) = \{\emptyset, \{a\}, \{b\}, \{c\}, \{a, b\}, \{a, c\}, \{b, c\}, \{a, b, c\}\}$.

Another example can be:

$B = \{a, \{b, c\}\}$
The subsets of $B$ are:
1. $\emptyset$
2. $\{a\}$
3. $\{\{b, c\}\}$
4. $\{a, \{b, c\}\}$

It's  important to note that $\{b, c\}$ is considered a single element in the set $B$, so it is treated as an indivisible unit when determining subsets. So, $\{b\}$ is not a subset of $B$, and $\{c\}$ is not a subset of $B$ either, because they are not elements of $B$ on their own.


# Family sets

To better understand this, move the point of view from a pair of sets to a collection of sets. You, instead of looking at two sets, look at a family of sets.

Under this perspective, imagine a family $\mathcal{F}$ of sets. Imagine it as a bag full of boxes, where each box is a set. 

## Union
### Generalized union

The generalized union of a family of sets $\mathcal{F}$, denoted as $\bigcup \mathcal{F}$, that is, the union of all sets in the family $\mathcal{F}$.

In therms of boxes, imagine $\bigcup \mathcal{F}$ as opening all the boxes in the bag and collecting all the items from those boxes into a single collection. The result is a set that contains all the elements that are in any of the sets in the family $\mathcal{F}$.

#### Definition:

Defined as a generalized operation on sets, the union of a collection of sets $\{A_i\}_{i \in I}$, denoted as $\bigcup_{i \in I} A_i$, is the set of all elements that are in at least one of the sets in the collection. Formally, we can define it as:
$$ \bigcup_{i \in I} A_i = \{ x : \exists i \in I, x \in A_i \} $$

#### Example:
Consider $\mathcal{F} = \{\{1, 2\}, \{2, 3\}, \{4\}\}$.

Then, the union of the sets in $\mathcal{F}$ is:
$$ \bigcup \mathcal{F} = \{1, 2\} \cup \{2, 3\} \cup \{4\} = \{1, 2, 3, 4\} $$

### Union of two sets

The union of two sets $A$ and $B$, denoted as $A \cup B$, is the set of all elements that are in $A$, in $B$, or in both. Formally, we can define it as:
$$ A \cup B = \{ x : x \in A \text{ or }x \in B \} $$



## Intersection
### Generalized intersection

Thinking as boxes and bags, the intersection of a family of sets $\mathcal{F}$, denoted as $\bigcap \mathcal{F}$, can be visualized as finding the common items that are present in every box in the bag. Another way of saying is that doesen't matter the box, if an item is in the intersection, it must be in every box.


#### Definition:

Defined as a generalized operation on sets, the intersection of a collection of sets $\{A_i\}_{i \in I}$, denoted as $\bigcap_{i \in I} A_i$, is the set of all elements that are common to every set in the collection. Formally, we can define it as:
$$ \bigcap_{i \in I} A_i = \{ x : \forall i \in I, x \in A_i \} $$

#### Example:
Consider $\mathcal{F} = \{\{1, 2\}, \{2, 3\}, \{2, 4\}\}$.

Then, the intersection of the sets in $\mathcal{F}$ is:
$$ \bigcap \mathcal{F} = \{1, 2\} \cap \{2, 3\} \cap \{2, 4\} = \{2\} $$


### Intersection of two sets

Defined as a binary operation on sets, the intersection of two sets $A$ and $B$, denoted as $A \cap B$, is the set of all elements that are common to both $A$ and $B$. Formally, we can define it as:
$$ A \cap B = \{ x : x \in A \text{ and } x \in B \} $$


# Properties of union and intersection

## Commutativity
The union and intersection of sets are commutative operations, meaning that the order of the sets does not affect the result.

$$ A \cup B = B \cup A \text{, and }  A \cap B = B \cap A $$


We can prove it by formal logic:
To prove that $A \cup B = B \cup A$, we need to show that every element in $A \cup B$ is also in $B \cup A$, and vice versa.

1. Let $x \in A \cup B$. By definition of union, this means that $x \in A$ or $x \in B$.
   - If $x \in A$, then $x$ is also in $B \cup A$ because $B \cup A$ includes all elements of $A$.
   - If $x \in B$, then $x$ is also in $B \cup A$ because $B \cup A$ includes all elements of $B$.
   Therefore, in either case, we have $x \in B \cup A$. This shows that every element in $A \cup B$ is also in $B \cup A$, so we have $A \cup B \subseteq B \cup A$.


2. Now, let $y \in B \cup A$. By definition of union, this means that $y \in B$ or $y \in A$.
   - If $y \in B$, then $y$ is also in $A \cup B$ because $A \cup B$ includes all elements of $B$.
   - If $y \in A$, then $y$ is also in $A \cup B$ because $A \cup B$ includes all elements of $A$.
   Therefore, in either case, we have $y \in A \cup B$. This shows that every element in $B \cup A$ is also in $A \cup B$, so we have $B \cup A \subseteq A \cup B$.

Since we have shown that $A \cup B \subseteq B \cup A$ and $B \cup A \subseteq A \cup B$, we can conclude that $A \cup B = B \cup A$.


We can also prove that $A \cap B = B \cap A$ using a similar approach:
To prove that $A \cap B = B \cap A$, we need to show that every element in $A \cap B$ is also in $B \cap A$, and vice versa.

1. Let $x \in A \cap B$. That means $x \in A$ and $x \in B$. .
    - Since $x \in A$ and $x \in B$, it follows that $x$ is also in $B \cap A$ because $B \cap A$ includes all elements that are in both $B$ and $A$. 
    - Therefore, we have $x \in B \cap A$. This shows that every element in $A \cap B$ is also in $B \cap A$, so we have $A \cap B \subseteq B \cap A$.
2. Now, let $y \in B \cap A$. That means $y \in B$ and $y \in A$.
    - Since $y \in B$ and $y \in A$, it follows that $y$ is also in $A \cap B$ because $A \cap B$ includes all elements that are in both $A$ and $B$. 
    - Therefore, we have $y \in A \cap B$. This shows that every element in $B \cap A$ is also in $A \cap B$, so we have $B \cap A \subseteq A \cap B$.
Since we have shown that $A \cap B \subseteq B \cap A$ and $B \cap A \subseteq A \cap B$, we can conclude that $A \cap B = B \cap A$. 

## Associativity
The union and intersection of sets are associative operations, meaning that the grouping of the sets does not affect the result.

$$ (A \cup B) \cup C = A \cup (B \cup C) \text{, and }  (A \cap B) \cap C = A \cap (B \cap C) $$


### Proof:
To prove that $(A \cup B) \cup C = A \cup (B \cup C)$, we need to show that every element in $(A \cup B) \cup C$ is also in $A \cup (B \cup C)$, and vice versa.

1. Let $x \in (A \cup B) \cup C$. By definition of union, this means that $x \in A \cup B$ or $x \in C$.
   - If $x \in A \cup B$, then $x$ is in either $A$ or $B$. In either case, $x$ is also in $A \cup (B \cup C)$ because $A \cup (B \cup C)$ includes all elements of $A$ and all elements of $B$.
   - If $x \in C$, then $x$ is also in $A \cup (B \cup C)$ because $A \cup (B \cup C)$ includes all elements of $C$.
   Therefore, in either case, we have $x \in A \cup (B \cup C)$. This shows that every element in $(A \cup B) \cup C$ is also in $A \cup (B \cup C)$, so we have $(A \cup B) \cup C \subseteq A \cup (B \cup C)$.

2. Now, let $y \in A \cup (B \cup C)$. By definition of union, this means that $y \in A$ or $y \in B \cup C$.
   - If $y \in A$, then $y$ is also in $(A \cup B) \cup C$ because $(A \cup B) \cup C$ includes all elements of $A$.
   - If $y \in B \cup C$, then $y$ is in either $B$ or $C$. In either case, $y$ is also in $(A \cup B) \cup C$ because $(A \cup B) \cup C$ includes all elements of $B$ and all elements of $C$.
   Therefore, in either case, we have $y \in (A \cup B) \cup C$. This shows that every element in $A \cup (B \cup C)$ is also in $(A \cup B) \cup C$, so we have $A \cup (B \cup C) \subseteq (A \cup B) \cup C$.


Since we have shown that $(A \cup B) \cup C \subseteq A \cup (B \cup C)$ and $A \cup (B \cup C) \subseteq (A \cup B) \cup C$, we can conclude that $(A \cup B) \cup C = A \cup (B \cup C)$.

To prove that $(A \cap B) \cap C = A \cap (B \cap C)$, we need to show that every element in $(A \cap B) \cap C$ is also in $A \cap (B \cap C)$, and vice versa.
1. Let $x \in (A \cap B) \cap C$. By definition of intersection, this means that $x \in A \cap B$ and $x \in C$.
   - Since $x \in A \cap B$, it follows that $x \in A$ and $x \in B$. 
   - Since $x \in C$, it follows that $x$ is also in $A \cap (B \cap C)$ because $A \cap (B \cap C)$ includes all elements that are in both $A$ and $(B \cap C)$. 
   Therefore, we have $x \in A \cap (B \cap C)$. This shows that every element in $(A \cap B) \cap C$ is also in $A \cap (B \cap C)$, so we have $(A \cap B) \cap C \subseteq A \cap (B \cap C)$.
2. Now, let $y \in A \cap (B \cap C)$. By definition of intersection, this means that $y \in A$ and $y \in B \cap C$.
   - Since $y \in B \cap C$, it follows that $y \in B$ and $y \in C$. 
   - Since $y \in A$, it follows that $y$ is also in $(A \cap B) \cap C$ because $(A \cap B) \cap C$ includes all elements that are in both $(A \cap B)$ and $C$. 
   Therefore, we have $y \in (A \cap B) \cap C$. This shows that every element in $A \cap (B \cap C)$ is also in $(A \cap B) \cap C$, so we have $A \cap (B \cap C) \subseteq (A \cap B) \cap C$.

Since we have shown that $(A \cap B) \cap C \subseteq A \cap (B \cap C)$ and $A \cap (B \cap C) \subseteq (A \cap B) \cap C$, we can conclude that $(A \cap B) \cap C = A \cap (B \cap C)$.

## Distributivity
The union and intersection of sets are distributive operations, meaning that the union distributes over intersection and the intersection distributes over union.
$$ A \cup (B \cap C) = (A \cup B) \cap (A \cup C) \text{, and }  A \cap (B \cup C) = (A \cap B) \cup (A \cap C) $$

### Proof:
To prove that $A \cup (B \cap C) = (A \cup B) \cap (A \cup C)$, we need to show that every element in $A \cup (B \cap C)$ is also in $(A \cup B) \cap (A \cup C)$, and vice versa.

1. Let $x \in A \cup (B \cap C)$. By definition of union, this means that $x \in A$ or $x \in B \cap C$.
   - If $x \in A$, then $x$ is in both $A \cup B$ and $A \cup C$, so $x$ is in $(A \cup B) \cap (A \cup C)$.
   - If $x \in B \cap C$, then $x$ is in both $B$ and $C$. Since $x$ is in $B$, it is also in $A \cup B$. Since $x$ is in $C$, it is also in $A \cup C$. Therefore, $x$ is in $(A \cup B) \cap (A \cup C)$.
   Therefore, in either case, we have $x \in (A \cup B) \cap (A \cup C)$. This shows that every element in $A \cup (B \cap C)$ is also in $(A \cup B) \cap (A \cup C)$, so we have $A \cup (B \cap C) \subseteq (A \cup B) \cap (A \cup C)$.

2. Now, let $y \in (A \cup B) \cap (A \cup C)$. By definition of intersection, this means that $y \in A \cup B$ and $y \in A \cup C$.
   - If $y \in A$, then $y$ is in $A \cup (B \cap C)$ because $A \cup (B \cap C)$ includes all elements of $A$.
   - If $y \in B$, then $y$ is in $A \cup (B \cap C)$ because $A \cup (B \cap C)$ includes all elements of $B$.
   - If $y \in C$, then $y$ is in $A \cup (B \cap C)$ because $A \cup (B \cap C)$ includes all elements of $C$.
   Therefore, in any case, we have $y \in A \cup (B \cap C)$. This shows that every element in $(A \cup B) \cap (A \cup C)$ is also in $A \cup (B \cap C)$, so we have $(A \cup B) \cap (A \cup C) \subseteq A \cup (B \cap C)$.

Since we have shown that $A \cup (B \cap C) \subseteq (A \cup B) \cap (A \cup C)$ and $(A \cup B) \cap (A \cup C) \subseteq A \cup (B \cap C)$, we can conclude that $A \cup (B \cap C) = (A \cup B) \cap (A \cup C)$.


To prove that $A \cap (B \cup C) = (A \cap B) \cup (A \cap C)$, we need to show that every element in $A \cap (B \cup C)$ is also in $(A \cap B) \cup (A \cap C)$, and vice versa.
1. Let $x \in A \cap (B \cup C)$. By definition of intersection, this means that $x \in A$ and $x \in B \cup C$.
   - If $x \in B$, then $x$ is in $A \cap B$ because $A \cap B$ includes all elements that are in both $A$ and $B$. Therefore, $x$ is in $(A \cap B) \cup (A \cap C)$.
   - If $x \in C$, then $x$ is in $A \cap C$ because $A \cap C$ includes all elements that are in both $A$ and $C$. Therefore, $x$ is in $(A \cap B) \cup (A \cap C)$.
   Therefore, in either case, we have $x \in (A \cap B) \cup (A \cap C)$. This shows that every element in $A \cap (B \cup C)$ is also in $(A \cap B) \cup (A \cap C)$, so we have $A \cap (B \cup C) \subseteq (A \cap B) \cup (A \cap C)$.
2. Now, let $y \in (A \cap B) \cup (A \cap C)$. By definition of union, this means that $y \in A \cap B$ or $y \in A \cap C$.
   - If $y \in A \cap B$, then $y$ is in both $A$ and $B$. Since $y$ is in $B$, it is also in $B \cup C$. Therefore, $y$ is in $A \cap (B \cup C)$ because $A \cap (B \cup C)$ includes all elements that are in both $A$ and $(B \cup C)$.
   - If $y \in A \cap C$, then $y$ is in both $A$ and $C$. Since $y$ is in $C$, it is also in $B \cup C$. Therefore, $y$ is in $A \cap (B \cup C)$ because $A \cap (B \cup C)$ includes all elements that are in both $A$ and $(B \cup C)$.
   Therefore, in either case, we have $y \in A \cap (B \cup C)$. This shows that every element in $(A \cap B) \cup (A \cap C)$ is also in $A \cap (B \cup C)$, so we have $(A \cap B) \cup (A \cap C) \subseteq A \cap (B \cup C)$.

Since we have shown that $A \cap (B \cup C) \subseteq (A \cap B) \cup (A \cap C)$ and $(A \cap B) \cup (A \cap C) \subseteq A \cap (B \cup C)$, we can conclude that $A \cap (B \cup C) = (A \cap B) \cup (A \cap C)$.