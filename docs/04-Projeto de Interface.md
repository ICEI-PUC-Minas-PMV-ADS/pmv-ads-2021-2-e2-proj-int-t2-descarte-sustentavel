
# Projeto de Interface

<span style="color:red"> <a href="2-Especificação do Projeto.md"> Documentação de Especificação</a></span>

A montagem da interface do sistema foi cuidadosamente desenvolvida para proporcionar maior conforto ao usuário, para isso estamos estabelecendo foco em acessibilidade, usabilidade e agilidade, todas as telas são projetadas para funcionamento em desktops.

 
## Diagrama de Fluxo

Conforme pode ser visto, a *Figura 5* mostra o diagrama de fluxo de interação do usuário pelas telas do sistema. Cada uma das telas deste fluxo é detalhada na seção de Wireframes que será desenvolvido. 

|FLUXO DO USUÁRIO| DESCRIÇÃO | RF |
|--|-------------------------------------------------------|----------------------|
|Home | A home da aplicação sera reponsavel por ligar as funcionalidades principais do sistema| RF-008 |
|Cadastro de usuário | O usuário deve conseguir realizar um cadastro na aplicação dividido em pessoa fisica e pessoa jurídica | RF-002 |
|Solicitar coleta|O usuário deverá ter efetuado login, se não estiver logado a pagina devera solicitar login e senha logo após analisar se o email e senha são validos, se for valido será redirecionado para mostrar pontos de coleta e visualisar materiais possíveis de descarte e então podera enviar sua solicitação de coleta, mas se o email e senha não for valido a página devera esperar 5/s e solicitar login novamente| RF-001 || RF-003|| RF-004| | RF-006 |
|Acompanhar solicitação de coleta|O usuário irá clicar em acompanhar solicitação o sistema vai veriificar se está logado se sim, será redirecionado para mostar status de coleta, mas se não estiver logado a página devera solicitar login e senha logo depois irá analisar se o email e senha são validos, a pagina devera esperar 5/s e solicitar login novamente| RF-001 || RF-003 || RF-005 |
|Realizar baixa dos materiais coletados|O usuário devera clicar em realizar baixa dos materiais coletado na página home, então o sistema ira analisar se está logado se sim deverá mostar as coletas ativas e então podera selecionar as, coleta a serem baixadas logo depois irá atualizar a base de dados do sistema, mas se não estiver logado a página deverá solicitar login e senha logo depois irá analisar se o email e senha são validos, se não for valido a página irá esperar 5/s e solicitar login novamente| RF-001 || RF-003 || RF-011|

  ![](https://user-images.githubusercontent.com/61097764/132771419-fcb564bc-8fae-477b-9143-f12b979a4a34.png)
  Figura 5 – Diagrama de Fluxo de Usuário

## Wireframes

Conforme fluxo de telas do projeto amostrado no item anterior, as telas do sistema são apresentadas em detalhes nos itens que se seguem. Todas essas telas têm uma estrutura comum que é apresentada na *Figura 6*. Nesta estrutura existem 3 grandes blocos, descritos a seguir. São eles:
- **Cabeçalho** - local onde são dispostos elementos fixos de identidade (logo) e icone de usuário;   
- **Conteúdo** - apresenta o conteúdo da tela em questão;   
- **Menu lateral** - apresenta o menu da aplicação que permite navegar pelas páginas.
- **Rodapé** - apresenta detalhes adicionais sobre o projeto e um mapa do site.

![](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2021-2-e2-proj-int-t2-descarte-sustentavel/blob/main/docs/img/Padrao.png)
Figura 6 – Estrutura padrão do site 

## Tela - LandingPage / Login 
A tela inicial ou LandingPage apresentada na *Figura 7* permite visualizar notícias e informações relevantes sobre o projeto na extensão da página e ao clicar no icon de usuário abre um modal conforme explicado no tópico *Modal - Login* que segue.   
![](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2021-2-e2-proj-int-t2-descarte-sustentavel/blob/main/docs/img/LandingPage.png)
Figura 7 – LandingPage

## Modal - Login 
O modal que se abre ao clicar no icon de usuário no canto superior direito do cabeçalho permite ao usuário fazer login na aplicação, preenchendo suas credenciais conforme orientado. Além disso, o usuário pode ser direcionado para se cadastrar na opção “Não tem uma conta?” e para redefinir a senha da conta na opção "Esqueceu sua senha?". O modal em questão pode ser visualizado conforme *Figura 8*.
![](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2021-2-e2-proj-int-t2-descarte-sustentavel/blob/main/docs/img/Login.png)
Figura 8 – Modal Login

## Fluxo de Telas - Cadastro de Usuário 
O fluxo de *Cadastro de Usuário* ilustrado na *Figura 9* permite ao usuário se cadastrar na aplicação caso este ainda não possua uma conta, seguindo um formulário solicitando informações obrigatórias de acordo com o tipo de perfil a ser criado.
![](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2021-2-e2-proj-int-t2-descarte-sustentavel/blob/main/docs/img/Cadastro.png)
Figura 9 – Fluxo de Cadastro de Usuário. 

## Fluxo de Telas - Esqueci a Senha  
Caso o usuário já possua uma conta mas não saiba sua senha, é permitido que ele altere sua senha por meio do fluxo apresentado na *Figura 10*. 
![](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2021-2-e2-proj-int-t2-descarte-sustentavel/blob/main/docs/img/Esqueci%20a%20Senha.png)
Figura 10 – Fluxo de Telas de Redefinição de Senha 

## Tela - Homepage 
Depois de fazer o login na aplicação, o usuário é redirecionado para uma homepage que possui a mesma estrutura da LandingPage, mas agora logado, ele possui a opção de clicar no ícone de menu ao lado da logo no cabeçalho para expandir uma barra lateral com os links para todas as páginas possíveis de serem utilizadas por ele. Além disso, ao clicar no ícone de perfil ele poderá ver informações como seu nome, tipo de usuário e fazer logout. A *Homepage* é ilustrada detalhadamente na *Figura 11*.
![](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2021-2-e2-proj-int-t2-descarte-sustentavel/blob/main/docs/img/Homepage.png)
Figura 11 – Tela Homepage

## Tela – Cadastrar Nova Solicitação
A tela de *Cadastrar Nova Solicitação*, conforme *Figura 12*, permite ao usuário solicitar o descarte de um novo material preenchendo os campos do formulário conforme solicitado e clicando em *Salvar*.
![](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2021-2-e2-proj-int-t2-descarte-sustentavel/blob/main/docs/img/SolicitacaoDescarte.png)
Figura 12 – Tela Cadastar nova Solicitação de Descarte

## Tela – Histórico de Descartes Realizados  
A *Histórico de Descartes Realizados* permite ao usuário do tipo *Descartador* visualizar todos as solicitações de descarte já realizadas, com detalhes importantes sobre elas. Essa tela segue ilustrada na *Figura 13*.
![](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2021-2-e2-proj-int-t2-descarte-sustentavel/blob/main/docs/img/Historico.png)
Figura 13 – Tela Histórico de Descartes Realizados

## Tela – Sobre   
A tela *Sobre* é ilustrada na *Figura 14* e apresenta um pouco da história do projeto, como foi idealizado, como é mantido e mostra ainda a equipe responsável pelo trabalho.   
![](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2021-2-e2-proj-int-t2-descarte-sustentavel/blob/main/docs/img/Sobre.png)
Figura 14 – Tela Sobre 

## Tela – Contato  
A tela *Contato* permite que usuário entre em contato com a equipe idealizadora, enviando uma mensagem pela caixa de texto. Essa tela pode ser vista conforme a *Figura 15*.
![](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2021-2-e2-proj-int-t2-descarte-sustentavel/blob/main/docs/img/Contato.png)
Figura 15 – Tela Contato 
 
