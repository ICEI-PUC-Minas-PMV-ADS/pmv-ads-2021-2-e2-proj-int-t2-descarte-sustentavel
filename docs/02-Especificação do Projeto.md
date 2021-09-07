# Especificações do Projeto

<span style="color:red">Pré-requisitos: <a href="1-Documentação de Contexto.md"> Documentação de Contexto</a></span>

Definição do problema e ideia de solução a partir da perspectiva do usuário. É composta pela definição do  diagrama de personas, histórias de usuários, requisitos funcionais e não funcionais além das restrições do projeto.

Apresente uma visão geral do que será abordado nesta parte do documento, enumerando as técnicas e/ou ferramentas utilizadas para realizar a especificações do projeto

## Personas

Nome: Juliana Souza 

 

 

 

Idade: 29 Ocupação: Desenvolvedora de Software, Dona de Casa 

Aplicativos: Facebook, Whatsapp, Instagram. 

Motivações: Juliana tem problemas em relação a coleta de determinados resíduos recicláveis em sua residência, procurando assim algum site que informe a localização de lugares específicos para a descarga. 

Frustrações: Por trabalhar durante quase todo dia, Juliana não consegue acompanhar horários regulares de coleta reciclável em seu bairro, tornando-se assim inviável faltar em seu trabalho para depositar o lixo em um local ideal. 

Hobbie, História: Juliana sempre foi dedicada em relação a estudo/trabalho, encontrou sua paixão na tecnologia e durante sua faculdade unificou o trabalho ao seu dia-a-dia pois desde de jovem tinha o sonho de morar sozinha. 



## Histórias de Usuários

Com base na análise das personas forma identificadas as seguintes histórias de usuários:

|EU COMO... `PERSONA`| QUERO/PRECISO ... `FUNCIONALIDADE` |PARA ... `MOTIVO/VALOR`                 |
|--------------------|------------------------------------|----------------------------------------|
|Clara Lima   |Preencher o formulário do pedido da coleta             |Para solicitar o pedido de coleta na residência                |
|Juliana Viana       |Excluir pedidos de coleta criados                |Organizar pedidos já feitos |
|Flora Martim     |Visualizar  pedidos em andamento               |Ter controle sob a demanda dos pedidos  |
|Luciane Silva       |Visualizar informações e dados relevantes sobre sustentabilidade               |Para ter informação sobre um assunto relevante |
|Juliana Viana       |Visualizar  os pontos de coleta mais próximos da minha casa              |Para facilitar o descarte de matérias recicláveis e matérias eletrônicos |
|Clara Lima       |Descartar minha televisão de tubo antiga que parou de funcionar             |Dar o descarte adequado  para o lixo eletrônico e não ter substâncias tóxicas em lugares impróprios |
|Clara Lima       |Descartar meus livros que já não uso mais             |Para desocupar o espaço em casa e enviar para o lugar apropriado |
|Flora Martim      |Coletar materiais recicláveis                |Para diminuir o lixo no meio ambiente e dar a eles o local devido  |
|João Marques       |Coletar materiais eletrônicos  |Para diminuir substâncias tóxicas no ambiente |
|Vera Viana      | Saber como solicitar a coleta de materiais recicláveis                |Para o recolhimento dos materiais recicláveis  |
|Juliana Viana     |Saber a data e a fonte da notícia de sustentabilidad  |Verificar a veracidade da informação apresentada  e disponibilizar  no aplicativo |
|Clara Lima      |Saber a quantidade  de produto descartado               |Para o recebimento adequado  do material no ecoponto  |


## Requisitos

As tabelas que se seguem apresentam os requisitos funcionais e não funcionais que detalham o escopo do projeto.

### Requisitos Funcionais

|ID    | Descrição do Requisito  | Prioridade |
|------|-----------------------------------------|----|
|RF-001| Permitir que o usuário cadastre tarefas | ALTA | 
|RF-002| Emitir um relatório de tarefas no mês   | MÉDIA |

### Requisitos não Funcionais

A tabela a seguir apresenta os requisitos não funcionais que o projeto  deverá atender. 

|ID     | Descrição do Requisito  |Prioridade |
|-------|-------------------------|----|
|RNF-001|A aplicação deve ser publicada em um ambiente acessível publicamente na Internet (Repl.it, GitHub Pages, Heroku);  | ALTA | 
|RNF-002|A aplicação deverá ser responsiva, permitindo a visualização em um celular de forma adequada;  | ALTA | 
|RNF-003|A aplicação deve ser intuitiva, de fácil utilização e entendimento, descartando a necessidade  de treinamentos;  |  MÉDIA |
|RNF-004|A aplicação deve ser compatível com os principais navegadores do mercado (Google Chrome, Firefox, Microsoft Edge); |  ALTA |
|RNF-005|A aplicação deve possuir uma interface limpa, com visualização voltada apenas  para as necessidades do usuário no momento, também como forma de melhorar a performance e o desempenho. | MÉDIA |


## Restrições

As questões que limitam a execução desse projeto e que se configuram como obrigações claras para o desenvolvimento do projeto  em questão são apresentadas na tabela a seguir.  

|ID| Restrição                                             |
|--|-------------------------------------------------------|
|RE-01| O projeto deverá ser entregue no final do semestre letivo, não podendo extrapolar a data de 19/12/2021.|
|RE-02| O aplicativo deve se restringir às tecnologias básicas da Web no Frontend.|
|RE-03| A equipe não pode subcontratar o desenvolvimento do trabalho.|

## Diagrama de Casos de Uso

|`ATOR`| `DESCRIÇÃO`                                            |
|--|-------------------------------------------------------|
|Usuário| Pessoa interessada em descartar materiais da maneira correta |
|BD |Banco de dados que deve armazenar e buscar as informações dos usuários e das solicitações de descarte e coleta |
|Ecoponto | Local disponibilizado para descarte dos materiais recicláveis e eletrônico|
