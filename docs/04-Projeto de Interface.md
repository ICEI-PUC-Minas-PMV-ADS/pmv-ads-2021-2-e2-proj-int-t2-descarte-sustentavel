
# Projeto de Interface

<span style="color:red">Pré-requisitos: <a href="2-Especificação do Projeto.md"> Documentação de Especificação</a></span>
<span style="color:red"> <a href="2-Especificação do Projeto.md"> Documentação de Especificação</a></span>

Visão geral da interação do usuário pelas telas do sistema e protótipo interativo das telas com as funcionalidades que fazem parte do sistema (wireframes).

 Apresente as principais interfaces da plataforma. Discuta como ela foi elaborada de forma a atender os requisitos funcionais, não funcionais e histórias de usuário abordados nas <a href="2-Especificação do Projeto.md"> Documentação de Especificação</a>.
A montagem da interface do sistema, foi cuidadosamente desenvolvida para proporcionar maior conforto ao usuário, para isso estamos estabelecendo foco em acessibilidade, usabilidade e agilidade, todas as telas são projetadas para funcionamento em desktops e dispositivos móveis. 

## Diagrama de Fluxo

O diagrama apresenta o estudo do fluxo de interação do usuário com o sistema interativo e  muitas vezes sem a necessidade do desenho do design das telas da interface. Isso permite que o design das interações seja bem planejado e gere impacto na qualidade no design do wireframe interativo que será desenvolvido logo em seguida.
Conforme se pode ver na figura X mostra o diagrama de fluxo de interação do usuário pelas telas do sistema. Cada uma das telas deste fluxo é detalhada na seção de Wireframes que será desenvolvido. Um diagrama de fluxo de dados (DFD) mapeia o fluxo de informações para qualquer processo ou sistema. Ele utiliza símbolos definidos, como retângulos, círculos e flechas, entre outros, além de rótulos de textos breves, para mostrar entradas e saídas de dados, pontos de armazenamento e as rotas entre cada destino. Você pode ver mais explicações e exemplos https://www.lucidchart.com/blog/how-to-make-a-user-flow-diagram.  

O diagrama de fluxo pode ser desenvolvido com “boxes” que possuem internamente a indicação dos principais elementos de interface - tais como menus e acessos - e funcionalidades, tais como editar, pesquisar, filtrar, configurar - e a conexão entre esses boxes a partir do processo de interação. Você pode ver mais explicações e exemplos https://www.lucidchart.com/blog/how-to-make-a-user-flow-diagram.
Veja o exemplo de estrutura básica de um diagrama de fluxo centrado nas ações dos usuários: 

![Exemplo de Diagrama de Fluxo](img/diagramafluxo2.jpg)

As referências abaixo irão auxiliá-lo na geração do artefato “Diagramas de Fluxo”.
|FLUXO DO USUÁRIO| DESCRIÇÃO | RF |
|--|-------------------------------------------------------|----------------------|
|Home | A home da aplicação sera reponsavel por ligar as funcionalidades principais do sistema| RF-008 |
|Cadastro de usuário | O usuário deve conseguir realizar um cadastro na aplicação dividido em pessoa fisica e pessoa jurídica | RF-002 |
|Solicitar coleta|O usuário deverá ter efetuado login, se não estiver logado a pagina devera solicitar login e senha logo após analisar se o email e senha são validos, se for valido será redirecionado para mostrar pontos de coleta e visualisar materiais possíveis de descarte e então podera enviar sua solicitação de coleta, mas se o email e senha não for valido a página devera esperar 5/s e solicitar login novamente| RF-001 || RF-003|| RF-004| | RF-006 |
|Acompanhar solicitação de coleta|O usuário irá clicar em acompanhar solicitação o sistema vai veriificar se está logado se sim, será redirecionado para mostar status de coleta, mas se não estiver logado a página devera solicitar login e senha logo depois irá analisar se o email e senha são validos, a pagina devera esperar 5/s e solicitar login novamente| RF-001 || RF-003 || RF-005 |
|Realizar baixa dos materiais coletados|O usuário devera clicar em realizar baixa dos materiais coletado na página home, então o sistema ira analisar se está logado se sim deverá mostar as coletas ativas e então podera selecionar as, coleta a serem baixadas logo depois irá atualizar a base de dados do sistema, mas se não estiver logado a página deverá solicitar login e senha logo depois irá analisar se o email e senha são validos, se não for valido a página irá esperar 5/s e solicitar login novamente| RF-001 || RF-003 || RF-011|

> **Links Úteis**:
> - [Fluxograma online: seis sites para fazer gráfico sem instalar nada | Produtividade | TechTudo](https://www.techtudo.com.br/listas/2019/03/fluxograma-online-seis-sites-para-fazer-grafico-sem-instalar-nada.ghtml)
<div align="center">
  <img src="https://user-images.githubusercontent.com/61097764/132771419-fcb564bc-8fae-477b-9143-f12b979a4a34.png" width="700px" height="700px" />
  </div>

## Wireframes

![Exemplo de Wireframe](img/wireframe-example.png)

São protótipos usados em design de interface para sugerir a estrutura de um site web e seu relacionamentos entre suas páginas. Um wireframe web é uma ilustração semelhante do layout de elementos fundamentais na interface.
 
> **Links Úteis**:
> - [Protótipos vs Wireframes](https://www.nngroup.com/videos/prototypes-vs-wireframes-ux-projects/)
> - [Ferramentas de Wireframes](https://rockcontent.com/blog/wireframes/)
> - [MarvelApp](https://marvelapp.com/developers/documentation/tutorials/)
> - [Figma](https://www.figma.com/)
> - [Adobe XD](https://www.adobe.com/br/products/xd.html#scroll)
> - [Axure](https://www.axure.com/edu) (Licença Educacional)
> - [InvisionApp](https://www.invisionapp.com/) (Licença Educacional)
