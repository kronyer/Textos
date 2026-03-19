import { defineConfig } from 'vitepress'

export default defineConfig({
  base: '/Textos/',
  lang: 'pt-BR',
  title: "KrTech",
  description: "Computação e Matemática",
  themeConfig: {
    // Aqui é onde a mágica das pastas acontece
    sidebar: [
      {
        text: 'C# & .NET 10',
        collapsed: false,
        items: [
          { text: 'Base64 e Codificação', link: '/CSharp/base64andOthers/texto' },
          { text: 'Inline Arrays', link: '/CSharp/inline_arrays/texto' },
        ]
      },
      {
        text: 'Metas',
        items: [
          { text: 'Minhas Metas', link: '/metas' }
        ]
      }
    ],
    socialLinks: [
      { icon: 'github', link: 'https://github.com/kronyer' }
    ]
  },
  markdown: {
    math: true // Ativa o LaTeX que instalamos
  }
})