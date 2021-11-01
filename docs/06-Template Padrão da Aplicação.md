# Template Padrão da Aplicação

<span style="color:red">Pré-requisitos: <a href="2-Especificação do Projeto.md"> Especificação do Projeto</a></span>, <a href="3-Projeto de Interface.md"> Projeto de Interface</a>, <a href="4-Metodologia.md"> Metodologia</a>

Layout padrão da aplicação que será utilizado em todas as páginas com a definição de identidade visual, aspectos de responsividade e iconografia.


## Guia de Estilos
Antes de definir o template da aplicação, foi necessário definir uma guia de estilos com todos os padrões que serão utilizados durante o desenvolvimento do projeto. Estão detalhados nos itens a seguir:

### Paleta de Cores
A paleta de cores definida conta com 4 cores primárias, sendo a principal delas definida como cor base, variando entre 6 diferentes tonalidades e também uma escala de cinzas que conta com 4 variações, conforme Figura 19:
![](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2021-2-e2-proj-int-t2-descarte-sustentavel/blob/main/docs/img/di_paleta_de_cores.png)
Figura 19 – Paleta de Cores

A escolha das cores não foi por um acaso, mas diz tudo o que queremos passar com a nossa aplicação:
- **Sustentabilidade** - Os tons de verde em conjunto com a logo em forma de planeta significam a nossa preocupação em promover a sustentabilidade;   
- **Meio Ambiente** - As variações de azul e verde em conjunto trabalham a estética ambiental da nossa marca;   
- **A Destinação correta dos materiais eletrônicos** - As escalas de cinza são para lembrar dos materiais eletrônicos.


### Tipografia
As fontes utilizadas na aplicação são Montserrat e Rubik, e seguem as seguintes definições de tamanho e estilização, como pode ser observado na Figura 20:
![](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2021-2-e2-proj-int-t2-descarte-sustentavel/blob/main/docs/img/di_tipografia.png)
Figura 20 – Tipografia e Fontes utilizadas


### Componentes
Dentre nossos principais componentes personalizados estão os botões e inputs, conforme pode ser visto na Figura 21:
![](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2021-2-e2-proj-int-t2-descarte-sustentavel/blob/main/docs/img/di_componentes.png)
Figura 21 – Principais componentes visuais da aplicação


### Ícones
![](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2021-2-e2-proj-int-t2-descarte-sustentavel/blob/main/docs/img/di_icons.png)
Figura 22 – Iconografia


## Aplicação nas telas e fluxos:

### Tela - LandingPage / Login 
A tela inicial ou LandingPage apresentada na *Figura 23* permite visualizar notícias e informações relevantes sobre o projeto na extensão da página e ao clicar no icon de usuário abre um modal conforme explicado no tópico *Modal - Login* que segue.   
![](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2021-2-e2-proj-int-t2-descarte-sustentavel/blob/main/docs/img/di_LandingPage.png)
Figura 23 – LandingPage

### Modal - Login 
O modal que se abre ao clicar no icon de usuário no canto superior direito do cabeçalho permite ao usuário fazer login na aplicação, preenchendo suas credenciais conforme orientado. Além disso, o usuário pode ser direcionado para se cadastrar na opção “Não tem uma conta?” e para redefinir a senha da conta na opção "Esqueceu sua senha?". O modal em questão pode ser visualizado conforme *Figura 24*.
![](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2021-2-e2-proj-int-t2-descarte-sustentavel/blob/main/docs/img/di_Login.png)
Figura 24 – Modal Login

### Fluxo de Telas - Cadastro de Usuário 
O fluxo de *Cadastro de Usuário* ilustrado na *Figura 25* permite ao usuário se cadastrar na aplicação caso este ainda não possua uma conta, seguindo um formulário solicitando informações obrigatórias de acordo com o tipo de perfil a ser criado.
![](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2021-2-e2-proj-int-t2-descarte-sustentavel/blob/main/docs/img/di_Cadastro.png)
Figura 25 – Fluxo de Cadastro de Usuário. 

## Fluxo de Telas - Esqueci a Senha  
Caso o usuário já possua uma conta mas não saiba sua senha, é permitido que ele altere sua senha por meio do fluxo apresentado na *Figura 26*. 
![](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2021-2-e2-proj-int-t2-descarte-sustentavel/blob/main/docs/img/di_EsqueciaSenha.png)
Figura 26 – Fluxo de Telas de Redefinição de Senha 

### Tela - Homepage 
Depois de fazer o login na aplicação, o usuário é redirecionado para uma homepage que possui a mesma estrutura da LandingPage, mas agora logado, ele possui a opção de clicar no ícone de menu ao lado da logo no cabeçalho para expandir uma barra lateral com os links para todas as páginas possíveis de serem utilizadas por ele. Além disso, ao clicar no ícone de perfil ele poderá ver informações como seu nome, tipo de usuário e fazer logout. A *Homepage* é ilustrada detalhadamente na *Figura 27*.
![](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2021-2-e2-proj-int-t2-descarte-sustentavel/blob/main/docs/img/di_Homepage.png)
Figura 27 – Tela Homepage

### Tela – Cadastrar Nova Solicitação
A tela de *Cadastrar Nova Solicitação*, conforme *Figura 28*, permite ao usuário solicitar o descarte de um novo material preenchendo os campos do formulário conforme solicitado e clicando em *Salvar*.
![](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2021-2-e2-proj-int-t2-descarte-sustentavel/blob/main/docs/img/di_SolicitacaoDescarte.png)
Figura 28 – Tela Cadastar nova Solicitação de Descarte

### Tela – Histórico de Descartes Realizados  
A *Histórico de Descartes Realizados* permite ao usuário do tipo *Descartador* visualizar todos as solicitações de descarte já realizadas, com detalhes importantes sobre elas. Essa tela segue ilustrada na *Figura 29*.
![](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2021-2-e2-proj-int-t2-descarte-sustentavel/blob/main/docs/img/di_Historico.png)
Figura 29 – Tela Histórico de Descartes Realizados

### Tela – Sobre   
A tela *Sobre* é ilustrada na *Figura 30* e apresenta um pouco da história do projeto, como foi idealizado, como é mantido e mostra ainda a equipe responsável pelo trabalho.   
![](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2021-2-e2-proj-int-t2-descarte-sustentavel/blob/main/docs/img/di_Sobre.png)
Figura 30 – Tela Sobre 

### Tela – Contato  
A tela *Contato* permite que usuário entre em contato com a equipe idealizadora, enviando uma mensagem pela caixa de texto. Essa tela pode ser vista conforme a *Figura 31*.
![](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2021-2-e2-proj-int-t2-descarte-sustentavel/blob/main/docs/img/di_Contato.png)
Figura 31 – Tela Contato 
