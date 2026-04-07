In the naive set theory, it was assumed that for any property $\phi(x)$, there is a set of all things that satisfy that property. 

This assumption leads to the famous Russell's paradox. Consider the property $\phi(x)$ defined as "x is a set and x does not contain itself".
$$ R = \{ x | x \notin x \} $$

The question is: does the set $R$ contain itself?

* If $R$ contains itself, then by the definition of $R$, it should not contain itself. This is a contradiction.
* If $R$ does not contain itself, then by the definition of $R$, it should contain itself. This is also a contradiction.

The error was in the assumption that for any property $\phi(x)$, there is a set of all things that satisfy that property. The principle of unrestricted comprehension leads to contradictions like Russell's paradox.

The ZFC (Zermelo-Fraenkel with Choice) set theory avoids this paradox by restricting the kinds of sets that can be formed. In ZFC, sets are built up in a cumulative hierarchy, and there is no set of all sets that do not contain themselves. This way, the paradox is avoided, and the theory remains consistent.