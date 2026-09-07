# RealDeal Recycle ♻️

**Projeto de Prova de Aptidão Profissional (PAP) - 12º Ano**  
Curso: Técnico de Informática - Programação  
Ano Letivo: 2023/2024

---

## 📋 Descrição do Projeto

**RealDeal Recycle** é um jogo educativo 2D/3D desenvolvido em **Unity** com o objetivo de ensinar e consciencializar sobre a importância da reciclagem e separação correta de resíduos. O projeto foi desenvolvido como Prova de Aptidão Profissional (PAP) no 12º ano do curso técnico de Informática.

### 🎯 Objetivos
- Ensinar a separação correta de resíduos (plástico, papel, vidro, orgânico)
- Consciencializar sobre o impacto ambiental do lixo
- Proporcionar uma experiência educativa gamificada e divertida
- Demonstrar competências técnicas em Unity/C# e desenvolvimento de jogos

---

## 🎮 Funcionalidades

- **Menu Principal** com navegação entre níveis
- **Sistema de Níveis** temáticos:
  - ♻️ Reciclagem Geral
  - 🌊 Resíduos Marítimos
  - 🌳 Resíduos Ambientais
- **Animações de fundo** (nuvens, montanhas, logótipo) com movimento parallax
- **Interface responsiva** com botões de voltar e menus de configurações
- **Sistema de cenas** com transição suave entre menus e jogabilidade

---

## 🛠️ Tecnologias Utilizadas

| Tecnologia | Versão | Uso |
|------------|--------|-----|
| **Unity** | 2022.3 LTS | Motor de jogo principal |
| **C#** | .NET Standard 2.1 | Scripts de jogabilidade e IU |
| **TextMesh Pro** | 3.0+ | Renderização de texto avançada |
| **Unity UI** | Built-in | Interface do utilizador |
| **Visual Studio / VS Code** | Mais recente | Ambiente de desenvolvimento |

---

## 📁 Estrutura do Projeto

```
Assets/
├── Editor/                    # Configurações do editor (notificações móveis)
├── Menu/                      # Elementos do menu principal
│   ├── ButSes Menu/           # Botões e logótipos do menu
│   ├── Imagens/               # Fundos, céus, montanhas, praias
│   └── Sprites Níveis/        # Sprites dos níveis de jogo
├── Plugins/
│   └── TextToTMP/             # Conversor Text → TextMesh Pro
├── Scenes/                    # Cenas do jogo (menu.unity)
├── Scripts Menu/              # Scripts de navegação e IU do menu
│   ├── Ambiental Niveis/      # Scripts nível ambiental
│   ├── Brevemente Aviso/      # Sistema "em breve"
│   ├── Maritimo Niveis/       # Scripts nível marítimo
│   └── Reciclagem Geral Niveis/ # Scripts nível geral
├── Script Jogo da Memória/    # Lógica do jogo da memória
├── scripts_move_menu/         # Animações de fundo (parallax)
│   ├── Move_logo.cs           # Animação do logótipo
│   ├── move_montanha_solo.cs  # Movimento montanhas/solo
│   └── move_nuvem*.cs         # Movimento nuvens (várias camadas)
└── TextMesh Pro/              # Recursos TextMesh Pro
```

---

## 🚀 Como Executar

### Pré-requisitos
- **Unity Hub** instalado
- **Unity 2022.3 LTS** (ou versão compatível)
- **Visual Studio 2022** ou **VS Code** com extensão C#

### Passos
1. Clonar o repositório:
   ```bash
   git clone https://github.com/hmmdg0001/RealDeal-Recycle.git
   ```
2. Abrir o **Unity Hub**
3. Clicar em **Add** → selecionar a pasta `RealDeal Recycle`
4. Aguardar a importação dos pacotes
5. Abrir a cena `Assets/Scenes/menu.unity`
6. Pressionar **Play** ▶️

---

## 🎓 Competências Demonstradas

### Programação (C# / Unity)
- ✅ Ciclo de vida MonoBehaviour (Start, Update)
- ✅ SceneManagement (carregar cenas)
- ✅ Sistema de IU (Botões, GameObjects, Canvas)
- ✅ Manipulação de Transform (Translate, position)
- ✅ Lógica condicional e gestão de estado
- ✅ Programação orientada a eventos (listeners onClick)

### Game Design & Development
- ✅ Design de níveis conceptual (temas ambientais)
- ✅ IU/UX para público jovem/educativo
- ✅ Animações procedurais (fundo parallax)
- ✅ Organização de assets e convenções de nomes
- ✅ Fluxo de prefabs (implícito na estrutura)

### Soft Skills & Metodologia
- ✅ Gestão de projeto (PAP - planeamento, execução, relatório)
- ✅ Documentação técnica
- ✅ Resolução de problemas
- ✅ Aprendizagem autónoma (Unity, C#)

---

## 📸 Capturas de Ecrã

| Menu Principal | Jogabilidade | Níveis |
|----------------|--------------|--------|
| ![Menu](Assets/Menu/Imagens/Menu%20Ceu.png) | *Em desenvolvimento* | *Em desenvolvimento* |

---

## 📚 Referências & Créditos

- **TextMesh Pro** - Unity Technologies
- **TextToTMP Plugin** - Conversão legacy Text → TMP
- **Elementos gráficos** - Criação própria / recursos educativos livres
- **Inspiração** - Jogos educativos de sustentabilidade (ex: Eco, Recycle Roundup)

---

## 📄 Licença

Este projeto é um trabalho académico (PAP - 12º Ano) sem fins comerciais.  
Código fonte disponível para fins educativos e de portefólio.

---

## 👨‍💻 Autor

**Henrique Marinho**  
📧 GitHub: [@hmmdg0001](https://github.com/hmmdg0001)  
🎓 Curso: Técnico de Informática - Programação  
📅 Conclusão: 2024

---

> *"A reciclagem não é apenas separar lixo, é separar o futuro do passado."* ♻️