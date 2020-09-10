## ConfirpProject1
Aplicação Web desenvolvida como parte do processo seletivo da empresa CONFIRP em setembro/2020 para a vaga de programador trainee.

Objetivo:
* Construir uma aplicação utilizando as linguagens C# e SQL, e o framework .Net para acessar um banco de dado relacional e demonstrar funcionalidades básicas (CRUD - Create, Read, Update, Delete).
O desafio propõe a simulação de um banco de dados onde há registros de pai (ou mãe) e filhos. As tabelas que representam as entidades devem possuir relações como, por exemplo, “inner join”.

Ferramentas utilizadas:
* Visual Studio Community 2019 (v16.7.3)
* Microsoft SQL Server - Developer Edition (v15.0.2000.5, RTM)
* SQL Server Management Studio (v18.6)
* .Net Framework (4.7.2)

Processo:
* Base de dados criada com duas tabelas simples e funcionais que representam os funcionários de uma empresa fictícia e seus dependentes, como num registro do departamento de RH.
* Projeto criado com o template ASP.NET Web Application, Entity Framework, padrão MVC, configurado com um servidor local (localhost).

Como executar:
* Importar o backup da base de dados no MS SQL Server Management Studio: Databases -> Restore Database… -> selecionar arquivo “ConfirpProjectDB.bak”.
* Criar e popular as tabelas no MS SQL Server Management Studio: abrir o arquivo “ConfirpProject-SQLQuery” e executar as queries. Alguns exemplos de Stored Procedures demonstram operações de “Inner Join” entre as tabelas.
* Importar a pasta do projeto “ConfirpProject1” pelo Visual Studio. Rodar o arquivo “RouteConfig.cs” (App_Start/RouteConfig.cs) com o IIS Express.

Limitação:
* A solução proposta não considera a possibilidade de dois funcionários da empresa serem registrados como responsáveis ao mesmo tempo de um ou mais dependentes (por exemplo: um casal que trabalha na mesma empresa e tem um dependente em comum). Uma solução alternativa seria modelar as tabelas com uma relação de “muitos-para-muitos” e criar uma nova tabela intermediária (“join table”).
 
 
 
  
  
###### 09 de setembro de 2020
 
###### Renato Eiji Bellocchi
###### renato.bellocchi@gmail.com
