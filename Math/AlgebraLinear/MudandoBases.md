$$Ã\Phi = T^{-1} Ã\Phi S$$

A mudança de base é uma troca de perspectiva, tendo uma velha transformação $\Phi$ que é de $V$ para $W$ que usava as bases $B$ (base canônica - entrada de $\Phi$) e $C$ (base de saída de $\Phi$), e agora queremos uma nova transformação $\Phi S$ que é de $V$ para $W$ que usa as bases $B'$ (nova base de entrada) e $C'$ (nova base de saída). Para isso, precisamos de uma transformação $T$ que seja de $W$ para $W$ que use as bases $C$ e $C'$.

Para que essa mudança ocorra, precisamos de matrizes de transcrição $S$ e $T$ que sejam invertíveis, ou seja, que tenham inversas. A matriz $
S$ é a matriz de transcrição que leva a base $B$ para a base $B'$, e a matriz $T$ é a matriz de transcrição que leva a base $C$ para a base $C'$.


# Entendendo a fomula

$Ã\Phi = T^{-1} Ã\Phi S$ Significa que primeiro aplicamos S para mudar a base de entrada, depois aplicamos a transformação $\Phi$ e por fim aplicamos $T^{-1}$ para mudar a base de saída.


Em um caminho mais detalhado temos:

1. $S$ é a entrada, temos um vetor $B'$. A matriz $S$ é a matriz de transcrição que leva da nova base $B'$ para a base antiga $B$. Então, aplicamos $S$ para obter o vetor na base antiga $B$.
2. A transformação $A\Phi$ tem como domínio a base antiga $B$, por isso, precisamos do vetor na base antiga $B$. O resultado, imagem, sai na base antiga $C$.
3. Como T transforma a nova base de saída $C'$ para a base antiga $C$, precisamos aplicar $T^{-1}$ para obter o resultado na nova base de saída $C'$.