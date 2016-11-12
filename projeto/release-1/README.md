# Automatizando a fábrica da ACME

## Introdução

A ACME _(American Company that Makes Everything)_ é uma cia que produz os mais
diversos produtos para atender os clientes mais criteriosos. Sua diversificação
é tamanha, produzindo desde ração para aves e bigornas, até explosivos e naves
espaciais.

Seu processo de fabricação passa hoje por um processo de requisição de matéria-
prima manual, o que atrasa muito a entrega do produto final aos consumidores, 
principalmente aqueles que se encontram com desejo extremo de comer aves no meio
do deserto.

Para agilizar o processo, uma área administrativa com as configurações de matéria-
prima para cada produto deve ser criada. O objetivo final será a criação de um
serviço que, ao solicitar uma ordem de fabricação, requisita automaticamente os
materiais no estoque, agilizando o processo de fabricação. 

## O software

O _ACME Ágil_ será criado para atender a demanda da fábrica e produção, tornando
a empresa mais eficiente.

Será desenvolvido em duas _sprints_, conforme especificado abaixo:

### Sprint 1 - Manutenção do cadastro de produtos e matéria-prima

O objetivo desta _sprint_ é entregar as telas de configuração de produto e estoque
de matéria-prima.

#### User Story 1 - Cadastro de matéria-prima

Como gestor de almoxarifado, eu quero cadastrar as matérias-primas e as quantidades
em estoque para servir de controle e informação para a fábrica.

##### Critérios de aceite

* As informações para cadastro de matéria-prima são:
    - Nome (obrigatório, 150 caracteres);
    - Estoque mínimo (númerico inteiro);
    - Estoque atual (numérico inteiro);

#### User Story 2 - Listagem de matéria-prima

Como usuário com acesso a lista de almoxarifado, eu quero consultar as matérias-
primas existentes no almoxarifado e as quantidades em estoque.

##### Critérios de aceite

* A listagem de matéria-prima deve vir em ordem alfabética
* Os campos exibidos na lista devem ser:
    - Nome
    - Quantidade em estoque
* Caso um item esteja com quantidade em estoque menor que o mínimo, este item
deve aparecer em vermelho
* Exibir um botão para cadastro de uma nova matéria-prima
* (opcional) Na linha do item, exibir um link para edição da matéria-prima

#### User Story 3 - Cadastro de produtos

Como gestor de fábrica, eu quero cadastrar as produtos e suas matérias-primas
para iniciar o processo de produção.

##### Critérios de aceite

* As informações para cadastro de produto são:
    - Nome (obrigatório, 150 caracteres);
    - Listagem de matéria-prima e quantidade necessária para cada uma

#### User Story 4 - Listagem de produtos

Como usuário com acesso a produtos, eu quero consultar os produtos que podem ser
fabricados pela ACME

##### Critérios de aceite

* A listagem de produtos deve vir em ordem alfabética
* Os campos exibidos na lista devem ser:
    - Produto

* Caso algum produto não tenha matéria-prima suficiente em estoque para iniciar
a produção, este item deve aparecer em vermelho
* Exibir um botão para cadastro de um novo produto
* (opcional) Na linha do item, exibir um link para edição de produto

## Recomendações

* Não se preocupe com o layout. A ideia é avaliar os seus conceitos de MVC, Injeção de Dependência e EF.
* Tente fazer um seed para criação de produtos e matéria-primas
* Utilize o recurso de migration para criação do seu banco de dados. Isso é fundamental, blz?

## Referências

* [Criação de uma aplicação MVC com EF Core](https://docs.microsoft.com/en-us/aspnet/core/data/ef-mvc/intro#add-code-to-initialize-the-database-with-test-data)
* [Usando Migrations](https://docs.microsoft.com/en-us/aspnet/core/data/ef-mvc/migrations)