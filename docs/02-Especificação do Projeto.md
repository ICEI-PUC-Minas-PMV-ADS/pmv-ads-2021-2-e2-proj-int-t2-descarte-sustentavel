# Especificações do Projeto 

<span style="color:red">Pré-requisitos: <a href="1-Documentação de Contexto.md"> Documentação de Contexto</a></span>

Definição do problema e ideia de solução a partir da perspectiva do usuário. É composta pela definição do  diagrama de personas, histórias de usuários, requisitos funcionais e não funcionais além das restrições do projeto.

Apresente uma visão geral do que será abordado nesta parte do documento, enumerando as técnicas e/ou ferramentas utilizadas para realizar a especificações do projeto

## Personas

Pedro Paulo tem 26 anos, é arquiteto recém-formado e autônomo. Pensa em se desenvolver profissionalmente através de um mestrado fora do país, pois adora viajar, é solteiro e sempre quis fazer um intercâmbio. Está buscando uma agência que o ajude a encontrar universidades na Europa que aceitem alunos estrangeiros. Teste


Enumere e detalhe as personas da sua solução. Para tanto, baseie-se tanto nos documentos disponibilizados na disciplina e/ou nos seguintes links:

> **Links Úteis**:
> - [Rock Content](https://rockcontent.com/blog/personas/)
> - [Hotmart](https://blog.hotmart.com/pt-br/como-criar-persona-negocio/)
> - [O que é persona?](https://resultadosdigitais.com.br/blog/persona-o-que-e/)
> - [Persona x Público-alvo](https://flammo.com.br/blog/persona-e-publico-alvo-qual-a-diferenca/)
> - [Mapa de Empatia](https://resultadosdigitais.com.br/blog/mapa-da-empatia/)
> - [Mapa de Stalkeholders](https://www.racecomunicacao.com.br/blog/como-fazer-o-mapeamento-de-stakeholders/)
>
Lembre-se que você deve ser enumerar e descrever precisamente e personalizada todos os clientes ideais que sua solução almeja.

## Histórias de Usuários

Com base na análise das personas forma identificadas as seguintes histórias de usuários:

|EU COMO... `PERSONA`| QUERO/PRECISO ... `FUNCIONALIDADE` |PARA ... `MOTIVO/VALOR`                 |
|--------------------|------------------------------------|----------------------------------------|
|Clara Lima   | Preencher o formulário do pedido da coleta            | Para solicitar o pedido de coleta na residência          |
|Juliana Viana       | Excluir pedidos de coleta criados                 |  Organizar pedidos já feitos  |
|Flora Martim   | Visualizar pedidos em andamento              | Ter controle sob a demanda dos pedidos  |
|Luciane Silva        | Visualizar informações e dados relevantes sobre sustentabilidade               | Para ter informação sobre um assunto relevante |
|Juliana Viana       | Visualizar os pontos de coleta mais próximos da minha casa                 | Para facilitar o descarte de matérias recicláveis e matérias eletrônicos  |
|Clara Lima       | Descartar minha televisão de tubo antiga que parou de funcionar                  | Dar o descarte adequado para o lixo eletrônico e não ter substâncias tóxicas em lugares impróprios |
|Clara Lima        | Descartar meus livros que já não uso mais                | Para desocupar o espaço em casa e enviar para o lugar apropriado |
|Flora Martim | Coletar materiais recicláveis | Para diminuir o lixo no meio ambiente e dar a eles o local devido |
|João Marques | Coletar materiais eletrônicos | Para diminuir substâncias tóxicas no ambiente |
|Vera Viana | Saber como solicitar a coleta de materiais recicláveis               | Para o recolhimento dos materiais recicláveis m administrar contas |
|Juliana Viana        | Saber a data e a fonte da notícia de sustentabilidade               |Verificar a veracidade da informação apresentada e disponibilizar no aplicativo |
|Clara Lima      |Saber a quantidade de produto descartado                   | PPara o recebimento adequado do material no ecoponto|


## Requisitos

O escopo funcional do projeto é definido por meio dos requisitos funcionais que descrevem as possibilidades interação dos usuários, bem como os requisitos não funcionais que descrevem os aspectos que o sistema deverá apresentar de maneira geral. Estes requisitos são apresentados a seguir. 

### Requisitos Funcionais

|ID    |                             Descrição do Requisito     | Prioridade |
|------|--------------------------------------------------------|------------|
|RF-001| A página inicial da aplicação deve possibilitar ao usuário fazer login, se cadastrar ou alterar sua senha; | ALTA  |
|RF-002| O site deve conter um formulário de cadastro para novos usuários contendo a intenção de cadastro desejada (Quero Descartar/ Desejo Recolher) e os dados conforme tipo de usuário; | ALTA  | 
|RF-003| A aplicação deve permitir realizar cadastro de descarte ou solicitação de coleta de materiais; | ALTA  | 
|RF-004| A aplicação deverá permitir ao usuário verificar no mapa os pontos de coleta mais próximos; | ALTA | 
|RF-005|A aplicação deverá permitir fazer o acompanhamento das suas solicitações de coleta; | MÉDIA | 
|RF-006| A aplicação deve conter um conjunto de materiais predefinidos permitidos para coleta; | ALTA  | 
|RF-007| A aplicação deverá permitir ao usuário indicar o peso aproximado do material a ser coletado em residência, com os pesos pré-estabelecidos pelo aplicativo; | MÉDIA | 
|RF-008| A aplicação deverá permitir ao usuário visualizar uma lista de notícias e informações úteis na página inicial; | BAIXA | 
|RF-009| A aplicação deverá ter como itens de menu: Home, Nova Coleta/Descarte, *Histórico de Descartes, Sobre e Contato*; | BAIXA | 
|RF-010| A aplicação deve permitir ao usuário selecionar entre descarte de recicláveis e eletrônicos no momento da solicitação; | MÉDIA | 
|RF-011| A aplicação deve permitir ao usuário do tipo Ecoponto dar baixa nas solicitações dos materiais que foram coletados. | MÉDIA | 

### Requisitos não Funcionais

A tabela a seguir apresenta os requisitos não funcionais que o projeto deverá atender.  

|ID     | Descrição do Requisito  |Prioridade |
|-------|-------------------------|----|
|RNF-001| A aplicação deve ser publicada em um ambiente acessível publicamente na Internet (Repl.it, GitHub Pages, Heroku); | ALTA| 
|RNF-002| A aplicação deverá ser responsiva, permitindo a visualização em um celular de forma adequada;  | ALTA | 
|RNF-003| DA aplicação deve ser intuitiva, de fácil utilização e entendimento, descartando a necessidade de treinamentos; |  MÉDIA | 
|RNF-004| A aplicação deve ser compatível com os principais navegadores do mercado (Google Chrome, Firefox, Microsoft Edge);  |  ALTA | 
|RNF-005| A aplicação deve possuir uma interface limpa, com visualização voltada apenas para as necessidades do usuário no momento, também como forma de melhorar a performance e o desempenho. |  MÉDIA | 


## Restrições

As questões que limitam a execução desse projeto e que se configuram como obrigações claras para o desenvolvimento do projeto em questão são apresentadas na tabela a seguir.

|ID| Restrição                                             |
|--|-------------------------------------------------------|
|RE-01| O projeto deverá ser entregue no final do semestre letivo, não podendo extrapolar a data de 19/12/2021.|
|RE-02| O aplicativo deve se restringir às tecnologias básicas da Web no Frontend.|
|RE-03| A equipe não pode subcontratar o desenvolvimento do trabalho.|


## Diagrama de Casos de Uso

|ATOR| DESCRIÇÃO                                            |
|--|-------------------------------------------------------|
|Usuário| Pessoa interessada em descartar materiais da maneira correta. |
|BD| Banco de dados que deve armazenar e buscar as informações dos usuários e das solicitações de descarte e coleta.|
|Ecoponto| Local disponibilizado  para descarte dos materiais recicláveis e eletrônico.|

|CASO DE USO| DESCRIÇÃO | RF |
|--|-------------------------------------------------------|----------------------|
|Visualizar notícias e informações úteis na HomePage | Na homepage da aplicação deve conter algumas notícias e informações úteis para o usuário| RF-008 |
|Realizar cadastro de usuário | O usuário deve conseguir realizar um cadastro na aplicação | RF-002 |
|Efetuar login na aplicação | O usuário deve conseguir realizar um login na aplicação com suas credenciais cadastradas | RF-001 |
|Alterar a senha | O usuário deve conseguir alterar a sua senha | RF-001 |
|O usuário deve conseguir alterar a sua senha | A aplicação deve permitir ao usuário solicitar a coleta de materiais na sua residência| RF-003 |
|Buscar requisitos de coleta |A aplicação deve buscar quais são os requisitos para que a coleta seja realizada diretamente na residência do usuário | RF-006 |
|Solicitar Descarte de materiais | A aplicação deve permitir ao usuário solicitar a realização de descarte de materiais indo até um ecoponto selecionado | RF-003|
|Buscar materiais possíveis de descarte | A aplicação deve buscar quais são os materiais permitidos para o descarte em no ecoponto selecionado pelo usuário Buscar materiais possíveis de descarte | RF-006 |
|Visualizar os pontos de coleta mais próximos  | A aplicação deverá mostrar quais são os ecopontos que permitem a coleta/descarte mais próximos dele | RF-004| 
|Acompanhar a solicitação de coleta | Em caso de coleta de materiais na residência, o usuário deve conseguir acompanhar o status da sua solicitação| RF-005 |
|Realizar a baixa dos materiais coletados  | O Ecoponto deverá conseguir realizar a baixa nas solicitações de descarte e coleta informando que os materiais foram devidamente coletados  | RF-011|

|RELACIONAMENTO| DESCRIÇÃO                                            |
|--|-------------------------------------------------------|
|INCLUSÃO| É necessário fazer o login na aplicação antes de realizar os casos de uso: “Solicitar Coleta de Materiais”, “Solicitar Descarte de Materiais” e “Realizar a baixa dos materiais coletados” |
||Para solicitar coleta de materiais é necessário que o banco de dados busque quais são os requisitos de coleta |
||Para solicitar descarte de materiais é necessário que o banco de dados busque quais são os requisitos de descarte | 
|Extensão| Caso o usuário ainda não tenha cadastro, será necessário fazê-lo antes de fazer login na aplicação |||Caso o usuário tenha esquecido sua senha, será necessário alterá-la antes de fazer login na aplicação |
||Caso o usuário deseje saber onde descartar seus materiais, é possível visualizar os pontos de coleta mais próximos |

