
# Metodologia

<span style="color:red">Pré-requisitos: <a href="2-Especificação do Projeto.md"> Documentação de Especificação</a></span>

A metodologia contempla as definições de ferramental utilizado pela equipe tanto para a manutenção dos códigos e demais artefatos quanto para a organização do time na execução das tarefas do projeto.

Descreva aqui a metodologia de trabalho do grupo para atacar o problema. Definições sobre os ambiente de trabalho utilizados pela  equipe para desenvolver o projeto. Abrange a relação de ambientes utilizados, a estrutura para gestão do código fonte, além da definição do processo e ferramenta através dos quais a equipe se organiza (Gestão de Times).

## Relação de Ambientes de Trabalho

Os artefatos do projeto são desenvolvidos a partir de diversas plataformas e a relação dos ambientes com seu respectivo propósito é apresentada na tabela que se segue

Ambiente|Plataforma|Link de Acesso
|:--------|:----------:|:--------------:|
|Repositório|GitHub|  [GitHub](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2021-2-e2-proj-int-t2-descarte-sustentavel)|
|Documentos do projeto|GitHubDocs|Projeto Descarte Sustentável|[GitHub](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2021-2-e2-proj-int-t2-descarte-sustentavel/tree/main/docs)|
|Projeto de Interface e  Wireframes|Adobe XD|Adobe XD |[Adobe XD](Adobe XD | Ferramenta de colaboração e design de UI/UX rápida e avançada)|
|Gerenciamento do Projeto|Github|Descarte Sustentável (github.com)|

## Controle de Versão

A ferramenta de controle de versão adotada no projeto foi o
[Git](https://git-scm.com/), sendo que o [Github](https://github.com)
foi utilizado para hospedagem do repositório.

Para gestão do código fonte do software desenvolvido, o grupo utiliza um processo baseado no Git Flow, como mostra a Figura 2. Desta forma, todas as manutenções no código são realizadas em branches separados, identificados como Hotfix, Release, Develop e Feature.   

![Figura 2](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2021-2-e2-proj-int-t2-descarte-sustentavel/blob/main/docs/img/gitFlow.png)

*Figura 2 – Fluxo de controle do código fonte no repositório git*  

\
O projeto segue a seguinte convenção para o nome de branches:

- `main`: versão estável já testada do software
- `unstable`: versão já testada do software, porém instável
- `testing`: versão em testes do software
- `dev`: versão de desenvolvimento do software

Quanto à gerência de issues, o projeto adota a seguinte convenção para
etiquetas:

- `documentation`: melhorias ou acréscimos à documentação
- `bug`: uma funcionalidade encontra-se com problemas
- `melhoria`: uma funcionalidade precisa ser melhorada
- `implementação`: uma nova funcionalidade precisa ser introduzida
- `design`: definições de UI e template da aplicação

Discuta como a configuração do projeto foi feita na ferramenta de versionamento escolhida. Exponha como a gerência de tags, merges, commits e branchs é realizada. Discuta como a gerência de issues foi realizada.  



## Gerenciamento de Projeto

### Divisão de Papéis

A equipe utiliza metodologias ágeis, tendo escolhido o Scrum como base para definição do processo de desenvolvimento.  
Senndo assim, o time está organizado da seguinte maneira:  

* _Scrum Master_: Gabriel Teixeira Viana
* _Product Owner_: Gustavo Costa  
* Equipe de Desenvolvimento
  - Amanda Menezes de Oliveira
  - Daiane Aparecida Rocha
  -	Daniella Rodrigues Oliveira
  -	Elena Menezes Braga Campos 

### Processo

Para organização e distribuição das tarefas do projeto, a equipe está utilizando a ferramenta de gestão do Github estruturado da seguinte forma:  

* **Backlog**: recebe as tarefas a serem trabalhadas e representa o Product Backlog. Todas as atividades identificadas no decorrer do projeto também devem ser incorporadas a esta lista;  
* **To Do**: Esta lista representa o Sprint Backlog. Este é o Sprint atual que estamos trabalhando; 
* **In Progress**: representa as tarefas que estão em execução naquele momento; e 
* **Done**: nesta lista são colocadas as tarefas que passaram pelos testes e controle de qualidade e estão prontos para ser entregues ao usuário. Não há mais edições ou revisões necessárias, ele está agendado e pronto para a ação.  

Foi escolhido o quadro de kanban para o gerenciamento do projeto, com o sistema kanban é possível avaliar o progresso do trabalho da equipe, avaliar etapas posteriores, medir o tempo gasto em tarefas especificas e também promover a cooperação entre a equipe, tudo isso utilizando um sistema simples e visual. (AGUIAR, 2007). O quadro kanban do grupo no Github está disponível através da URL Doação (github.com) e é apresentado, no estado atual, na Figura 3:

![Figura 3](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2021-2-e2-proj-int-t2-descarte-sustentavel/blob/main/docs/img/kanban.png)
*Figura 3 – Tela do quadro kanban do Github criada pelo grupo*
 
 \
 A tarefas são classificadas em função da natureza ou prioridade da atividade e seguem o um esquema de etiquetagem entre cores e categorias que pode ser visto pela Figura 4: 

![Figura 4](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2021-2-e2-proj-int-t2-descarte-sustentavel/blob/8b6516da3bbaf4c774d571c720d234acfd8f7845/docs/img/labels.png)

*Figura 4 – Tela de etiquetas do quadro kanban no Github*

### Ferramentas

As ferramentas empregadas no projeto são:

- Editor de código: Visual Studio.
- Ferramentas de comunicação: Microsoft Teams
- Ferramentas para criação de diagramas: brModelo, StarUML, LucidApp
- Ferramentas de desenho de tela (_wireframing_): Adobe XD

O editor de código foi escolhido porque ele possui uma integração com o sistema de versão e permite depuração na máquina local. 
A ferramenta de comunicação utilizada foi recomendada pela Universidade e é bem completa para gestão de equipes e viabiliza chamadas de áudio, vídeo e conversa por chat. 
Para criar diagramas utilizamos as ferramentas mencionadas porque cada uma delas capta melhor algumas das necessidades da nossa solução. 
Por fim, a ferramenta escolhida para o desenvolvimento dos wireframes e interface de usuário foi ecolhida por permitir a edição colaborativa, além de ter funcionalidades voltadas especificamente para a natureza deste trabalho.
