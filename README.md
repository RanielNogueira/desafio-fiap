# Desafio
[![N|Solid](https://upload.wikimedia.org/wikipedia/commons/d/d4/Fiap-logo-novo.jpg)](#)

# Tecnologias utilizadas

  - Back-end ASP.NET Core 3.1
  - Banco de dados SQL Server e o ORM Entity-framework, para o acesso ao dados.
  - Front-end (Angularjs, Bootstrap, Jquery)

# Arquitetura da solução

A solução está dividida em camadas, abaixo o detalhamento:
  - [DOMAIN] - Modelos de classe e "Interfaces" (Modelos de contratro)
  - [SERVICE] - (Camada que intermedia o acesso a base dados por meio de repositórios)
  - [UI CLIENTE] - Aplicação ASP.NET Core, onde o cliente irá se cadastrar para receber newsletter. 
  - [UI ADMIN] - Aplicação ASP.NET Core, onde o administrador irá visualizar os newsletters, cadastrados. 

# Scripts

Na pasta "Script Database", se encontra o script para criar o banco de dados e a tabela necessária para o funcionamento da aplicação.

# Adendo

Alterar as strings de conexão, nas aplicações UI.Cliente e UI.Admin, para a nova instância do SQL Server.

