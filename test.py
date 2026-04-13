#%%
import matplotlib.pyplot as plt

# Dados do projeto
labels = [
    'Diagramação', 
    'Frete e encargos', 
    'Embalagens para envio',
    'Impressão', 
    'Taxa Catarse'
]

# Valores baseados nos seus dados e no cálculo da meta total
valores = [600, 2100, 1200, 4525.11 + 2207.47+ 4503.74, 2082.44]

# Configuração estética
colors = ['#ff9999','#66b3ff', '#31b9a2','#99ff99','#ffcc99','#c2c2f0','#ffb3e6']
explode = (0.05, 0.05, 0.05, 0.05, 0.1)  # Pequeno destaque em cada fatia

fig, ax = plt.subplots(figsize=(10, 7))

# Criando o gráfico de pizza
wedges, texts, autotexts = ax.pie(
    valores, 
    labels=labels, 
    autopct=lambda p: 'R$ {:.2f}\n({:.1f}%)'.format(p * sum(valores) / 100, p),
    startangle=140, 
    colors=colors, 
    pctdistance=0.85,
    explode=explode
)

# Desenhar o círculo central para transformar em donut
centre_circle = plt.Circle((0,0), 0.70, fc='white')
fig = plt.gcf()
fig.gca().add_artist(centre_circle)

# Ajustes de legenda e título
ax.axis('equal')  
plt.title(f'Distribuição da Meta Total: R$ {sum(valores):,.2f}', pad=20, fontsize=15)
plt.legend(wedges, labels, title="Categorias", loc="center left", bbox_to_anchor=(1, 0, 0.5, 1))

plt.tight_layout()
plt.savefig('grafico_donut_meta.png')
plt.show()
# %%
import matplotlib.pyplot as plt

# Custos fixos (o que você precisa que sobre no bolso)
custos_fixos = {
    'Diagramação': 600,
    'Frete e encargos': 2100,
    'Embalagens para envio': 1200,
    'Impressão': 4525.11 + 2207.47 + 4503.74
}

soma_custos = sum(custos_fixos.values())

# Cálculo da Meta Total para que a taxa de 13% incida sobre o valor bruto
taxa_percentual = 0.13
meta_total = soma_custos / (1 - taxa_percentual)
valor_taxa_catarse = meta_total * taxa_percentual

# Preparar dados para o gráfico
labels = list(custos_fixos.keys()) + ['Taxa Catarse (13%)']
valores = list(custos_fixos.values()) + [valor_taxa_catarse]

# Configuração visual
colors = ['#ff9999','#66b3ff', '#31b9a2','#99ff99','#ffcc99']
explode = (0.05, 0.05, 0.05, 0.05, 0.1)

fig, ax = plt.subplots(figsize=(10, 7))

ax.pie(
    valores, 
    labels=labels, 
    autopct=lambda p: 'R$ {:.2f}\n({:.1f}%)'.format(p * sum(valores) / 100, p),
    startangle=140, 
    colors=colors, 
    pctdistance=0.85,
    explode=explode
)

# Transformar em Donut
centre_circle = plt.Circle((0,0), 0.70, fc='white')
fig.gca().add_artist(centre_circle)

ax.axis('equal')  
plt.title(f'Distribuição Ajustada: Meta Total R$ {meta_total:,.2f}', pad=20, fontsize=15)
plt.tight_layout()
plt.savefig('grafico_donut_ajustado.png')
plt.show()
# %%
