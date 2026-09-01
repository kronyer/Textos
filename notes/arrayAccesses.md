Dado o algoritmo:

```cs
int sum = 0;
for (int i = 0; i < n; i++)
    for (int j = i+1; j < n; j++)
        for (int k = 1; k < n; k = k*2)
            if (a[i] + a[j] >= a[k]) sum++;
```

Quantos acessos de array existem em função de `n`?

Os dois outer arrays são um problema de combinatória simples, de n escolhe 2

$$ {n \choose 2} \equiv \frac{n(n-1)}{2} ~ \frac{n²}{2} $$

p.s: é definido $f(N) ~ g(N) \equiv \lim{n \to \infin} \frac{f(N)}{g(N)} = 1  $


Já o terceiro array, não acontece `n` vezes, mas sim $\log n$ vezes. Para cada vez que esse terceiro loop é acessado, ocorrem três acessos em arrays:

`a[i]` `a[j]` e `a[k]`

Então, no terceiro, temos $3 \log n$, multiplicado pelo resultado anterior:
$$ \frac{3}{2} n² \log n$$

$\square$