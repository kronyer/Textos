# Roadmap de Leitura — C#/.NET e Arquitetura/DDD

Duas trilhas paralelas, independentes entre si (sem correspondência forçada dia a dia). Ordem pensada por dependência de conceitos: vocabulário e fundamentos antes de livros que os pressupõem.

## Já lido

- [x] Domain-Driven Design (Evans)
- [x] Os 4 livros do Mark J. Price sobre .NET
- [x] O Mítico Homem-Mês

---

## Trilha 1 — C# e .NET (Linguagem e Runtime)

- [ ] C# in Depth (Jon Skeet)
- [ ] Effective C# — 50 Specific Ways to Improve Your C# (Bill Wagner)
- [ ] LINQ to Objects Using C# 4.0
- [ ] CLR via C# (Jeffrey Richter)
- [ ] Pro .NET Memory Management (Konrad Kokosa)
- [ ] Metaprogramming in .NET
- [ ] Functional Programming in C# (Enrico Buonanno)
- [ ] Functional C# (Javier Lozano)
- [ ] Aprenda Programação Funcional (O'Reilly)
- [ ] Category Theory for Programmers (Bartosz Milewski)
- [ ] Elegant Objects, Vol. 1 (Yegor Bugayenko)
- [ ] Elegant Objects, Vol. 2 (Yegor Bugayenko)
- [ ] Concurrency in C# Cookbook (Stephen Cleary)
- [ ] Dependency Injection Principles, Practices, and Patterns (Mark Seemann & Steven van Deursen)

### Consulta contínua (não linear)
- [ ] C# 12 in a Nutshell — manter como referência de sintaxe/BCL durante toda a trilha

---

## Trilha 2 — Arquitetura, Design e Engenharia

**Fase 1 — Fundamentos de código limpo/design**
- [ ] O Programador Pragmático
- [ ] Refatoração (Martin Fowler)
- [ ] Trabalho Eficaz com Código Legado (Michael Feathers)
- [ ] Test-Driven Development by Example (Kent Beck)
- [ ] Padrões de Projetos — GoF

**Fase 2 — Arquitetura de software (visão ampla)**
- [ ] Fundamentos da Arquitetura de Software (Mark Richards & Neal Ford)
- [ ] Arquitetura de Software: As Partes Difíceis (Neal Ford, Mark Richards et al.)
- [ ] Padrões de Arquitetura de Aplicações Corporativas — PoEAA (Martin Fowler)
- [ ] A Philosophy of Software Design (John Ousterhout)
- [ ] Clean Architecture (Robert C. Martin)

**Fase 3 — DDD aprofundado**
- [ ] Aprenda Domain-Driven Design (Vlad Khononov)
- [ ] Domain Modeling Made Functional (Scott Wlaschin)
- [ ] Implementing Domain-Driven Design (Vaughn Vernon)
- [ ] Team Topologies (Matthew Skelton & Manuel Pais)

**Fase 4 — Tópicos avançados/especializados**
- [ ] Padrões para Desenho de API
- [ ] Enterprise Integration Patterns (Gregor Hohpe & Bobby Woolf)
- [ ] Designing Data-Intensive Applications (Martin Kleppmann)
- [ ] Release It! (Michael Nygard)
- [ ] Practical TLA+ (Hillel Wayne)

**Leitura leve / intercalável (estilo "romance de gestão")**
- [ ] The Phoenix Project (Gene Kim, Kevin Behr, George Spafford)
- [ ] The Unicorn Project (Gene Kim) — opcional, sequência do Phoenix Project

### Consulta sob demanda (não linear)
- [ ] Storytelling de Domínio — consultar ao precisar de modelagem visual colaborativa
- [ ] Engenharia de Software (Sommerville) — consultar para processos, ciclo de vida e requisitos formais

---

## Notas de uso

- Ritmo sugerido: 1 livro por dia/sessão em cada trilha, avançando em paralelo e de forma independente.
- Itens em "Consulta contínua" e "Consulta sob demanda" não entram na contagem linear — são referências a serem abertas quando necessário.
- Os itens de "Leitura leve / intercalável" (Phoenix/Unicorn Project) não precisam seguir a ordem linear da Fase 4 — são bons para intercalar entre livros mais densos, como CLR via C# ou Implementing DDD.
- Domain Modeling Made Functional é a ponte entre a trilha de C# funcional e a trilha de DDD — vale ler logo após Khononov, com o tema ainda fresco.
- Pro .NET Memory Management é o sucessor espiritual do CLR via C# — leia logo em seguida, com o modelo mental do runtime ainda fresco (GC, JIT, layout de memória, VTables).
- Category Theory for Programmers é o fechamento teórico da trilha funcional — vem depois de Functional Programming in C# / Functional C# / Aprenda Programação Funcional, para solidificar a base matemática (funtores, mônadas) já com a prática absorvida.