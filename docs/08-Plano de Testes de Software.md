# Plano de Testes de Software

<span style="color:red">Pré-requisitos: <a href="2-Especificação do Projeto.md"> Especificação do Projeto</a></span>, <a href="3-Projeto de Interface.md"> Projeto de Interface</a>

|Caso de Teste |CT-01 – Cadastro do usuário |
|--------------------|----------------------------------------------------------------------|
|**Requisitos Associados** | RF-001 - A página inicial da aplicação deve possibilitar ao usuário fazer login, se cadastrar ou alterar sua senha. RF-002 - O site deve conter um formulário de cadastro para novos usuários contendo a intenção de cadastro desejada (Quero Descartar/ Desejo Recolher) e os dados conforme tipo de usuário. |
|**Entrada** | Cadastro: Após preencher o email, senha, telefone. Login: Após preencher o email e senha. |
|**Objetivo do Teste** | Permitir que o usuário acesse a plataforma através do login e cadastro. Permitir o cadastro do usuário que quer descartar e o que deseja recolher o material.  |
|**Passos** | 1) Acessar o Navegador  2) Informar o endereço do Site  3) Clicar no botão Cadastre-se  4) Preencher os campos com informações validas 5) Clicar no botão Cadastrar. |
|**Critérios de Êxito** | "Cadastro concluido :) seja muito bem vindo". |

|Caso de Teste |CT-02 – Login do usuário |
|--------------------|----------------------------------------------------------------------|
|**Requisitos Associados** | RF-001 - A página inicial da aplicação deve possibilitar ao usuário fazer login, se cadastrar ou alterar sua senha. |
|**Entrada** | Login: Após preencher o email e senha. |
|**Objetivo do Teste** | Permitir que o usuário acesse a plataforma através do login. |
|**Passos** | 1) Acessar o Navegador  2) Informar o endereço do Site  3) Clicar no botão no canto superior de login  4) Preencher os campos com informações validas 5) Clicar no botão Logar. |
|**Critérios de Êxito** | O usuário sera direcionado a homepage e tera acesso ao seu menu. |

|Caso de Teste |CT-03 – Solicitação de coleta dos materiais |
|--------------------|----------------------------------------------------------------------|
|**Requisitos Associados** | RF-003 - A aplicação deve permitir realizar cadastro de descarte ou solicitação de coleta de materiais. |
|**Entrada** | Atraves de um formulário contendo tipos de materiais, qntd e itens. Acompanhamento do historico de pedidos atraves do menu. |
|**Objetivo do Teste** | Permitir ao usuário a opção de solicitar a coleta, descartar materiais (recicláveis ou eletrônicos) e o acompanhamento de sua solicitação. |
|**Passos** | 1) Acessar o navegador 2) Acessar a plataforma 3) Realizar o login 4) Escolher a opção desejada (solicitar coleta ou descarte) 5) Confirmar opção desejada 6) Acompanhar o andamento da solicitação.   |
|**Critérios de Êxito** | "Solicitação concluida". Visualizar se o pedido consta no Histórico de Pedidos.  |

|Caso de Teste |CT-04 – Solicitação de descarte |
|--------------------|----------------------------------------------------------------------|
|**Requisitos Associados** | RF-003 - A aplicação deve permitir realizar cadastro de descarte ou solicitação de coleta de materiais. |
|**Entrada** | Atraves de um formulário contendo tipos de materiais, qntd e itens. |
|**Objetivo do Teste** | Permitir ao usuário a opção de solicitar a coleta, descartar materiais (recicláveis ou eletrônicos). |
|**Passos** | 1) Acessar o navegador 2) Acessar a plataforma 3) Realizar o login 4) Escolher a opção de descarte 5) Confirmar opção desejada |
|**Critérios de Êxito** | "Solicitação concluida". |

|Caso de Teste |CT-05 – Verificação dos pontos de descarte |
|--------------------|----------------------------------------------------------------------|
|**Requisitos Associados** | RF–004 - A aplicação deverá permitir ao usuário verificar no mapa os pontos de descarte mais próximos. |
|**Entrada** | Visualizar atraves da extensão do Google Maps |
|**Objetivo do Teste** | Permitir ao usuário verificar os ecopontos disponíveis.  |
|**Passos** | 1) Acessar a plataforma 2) Fazer o login 3) Escolher a opção de descarte 4) Visualizar os pontos disponíveis.  |
|**Critérios de Êxito** |  |

|Caso de Teste |CT-06 – Definição dos tipos de materiais  |
|--------------------|----------------------------------------------------------------------|
|**Requisitos Associados** | RF-006 - A aplicação deve conter um conjunto de materiais predefinidos permitidos para coleta. RF-007 - A aplicação deverá permitir ao usuário indicar o peso aproximado do material a ser coletado em residência, com os pesos pré-estabelecidos pelo aplicativo. |
|**Entrada** | Através do campo "Cadastrar Nova Solicitação", o usuário identifica o campo de materias pré-definidos. |
|**Objetivo do Teste** | Permitir o usuário determinar o material desejado e indicar o peso aproximado. |
|**Passos** | 1) Acessar a plataforma 2) Realizar o login 3) Escolher a opção de coleta 4) Definir o material e o peso. |
|**Critérios de Êxito** | Visualizar o campo que contem as opções de materiais . Ver se o pedido foi armazenado no Banco de dados contendo o peso e o material informado. |

|Caso de Teste |CT-07 – Tela Principal |
|--------------------|----------------------------------------------------------------------|
|**Requisitos Associados** | RF-008 - A aplicação deverá permitir ao usuário visualizar uma lista de notícias e informações úteis na página inicial. |
|**Entrada** | Acessar a tela incial |
|**Objetivo do Teste** | Disponobilizar ao usuário noticias informativas sobre o tema da aplicação. |
|**Passos** |1) Acessar o Navegador 2) Informar o endereço do Site 3) Visualizar a página principal. |
|**Critérios de Êxito** | Visualizar as noticias dinâmicas apresentadas na pagina principal. |  

|Caso de Teste |CT-08 – Redirecionamento dos itens no Menu |
|--------------------|----------------------------------------------------------------------|
|**Requisitos Associados** |RF-009 - A aplicação deverá ter como itens de menu: Home, Nova Coleta/Descarte, Histórico de Descartes, Sobre e Contato |
|**Entrada** | Clicar nos Buttons: Home, Nova Coleta/Descarte, Histórico de Descartes, Sobre e Contato |
|**Objetivo do Teste** | Verificar se os links do navbar estão redirecionando para as devidas telas. |
|**Passos** |1) Realizar Login  2) Clicar em cada item do navbar (home, cadastrar doação, histórico de doações, sobre e contato) e verificar se o sistema redirecionou para a tela correta 3) Clicar no logotipo e verificar se redirecionou para a tela Home.  |
|**Critérios de Êxito** |Ao clicar no Logotipo ou no item ‘Home’, deverá abrir a tela principal. Ao clicar no item Nova Coleta/Descarte o usuário será redirecionado ao formulário. Ao clicar no item ‘Histórico de descarte’ deverá abrir a tela do usuário com todas suas solicitações feitas.  Ao clicar no item ‘Sobre’ deve abrir tela com o navbar, título e conteúdo em forma de texto com imagens. Ao clicar no item ‘Contato’ deve ser direcionado para a tela com navbar, título, formulário de contato e imagem.   |  

|Caso de Teste |CT-09 – Alterar Senha  |
|--------------------|----------------------------------------------------------------------|
|**Requisitos Associados** |RF-02 - O site deve conter um formulário que permita o usuário criar uma nova senha em caso de esquecimento. |
|**Entrada** | Após clicar no botão esqueci senha, o usuário deverá informar o email cadastrado. |
|**Objetivo do Teste** | Verificar se os campos do formulário estão sendo exibidos corretamente.  |
|**Passos** |1) Acessar o Navegador  2) Informar o endereço do Site  3) Visualizar a página de login  4)Esqueci senha 5) Informar o email, onde será enviado um link para a nova senha 11) Insira uma nova senha no campo [senha] e no campo [confirme sua senha] redigite a senha e clique no botão próximo que levará para a próxima tela |
|**Critérios de Êxito** | Senha alterada com sucesso. |
