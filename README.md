# Desafio
[![N|Solid](https://lh3.googleusercontent.com/proxy/x_fBckbcHJlQsDvDKYeNeAqp9AnRBgdd_3A_8NO_Q7eb93pJWwiwC9nvOmk73KGwkqDp3aCNcjnoMsnj8P57ajiL54KVmg06d33xvbZJ4uOVR2ReEG0YNqGMUBkMJcNS_g83uDWgKlkn)](#)

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

