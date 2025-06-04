# Sistema de Gerenciamento para Eletrônica V.A

Este projeto é um sistema de gerenciamento desenvolvido para a empresa Eletrônica V.A, localizada na cidade de Conchas. O seu principal objetivo é facilitar o gerenciamento de clientes, seus respectivos produtos eletrônicos e a geração de ordens de serviço para reparos e manutenções.

## Arquitetura

O projeto foi desenvolvido utilizando princípios do Domain-Driven Design (DDD). Esta abordagem foca em modelar o software para que ele corresponda ao domínio de negócio da empresa, facilitando a comunicação entre desenvolvedores e especialistas do domínio.

Os principais agregados e entidades do domínio incluem:

*   **Cliente:** Representa os clientes da Eletrônica V.A. Armazena informações como nome, contato e documentos.
*   **Produto:** Representa os aparelhos eletrônicos dos clientes que necessitam de serviço. Contém detalhes como tipo, modelo, marca e o defeito relatado.
*   **Ordem de Serviço:** Representa a solicitação de serviço para um determinado produto de um cliente. Inclui informações sobre o orçamento, status do serviço e descrição dos trabalhos a serem realizados.

## Como Executar o Projeto

_(Esta seção será atualizada com instruções detalhadas sobre a configuração do banco de dados, compilação e execução do projeto.)_

Atualmente, o projeto está configurado para utilizar um banco de dados PostgreSQL. As configurações de conexão podem ser encontradas na classe `ContextoDados.cs`.

## Tecnologias Utilizadas

*   **.NET:** Plataforma de desenvolvimento da Microsoft.
*   **Entity Framework Core:** ORM para acesso a dados.
*   **PostgreSQL:** Banco de dados relacional utilizado.
*   **Windows Forms:** Para a interface gráfica do usuário (GUI) da aplicação desktop.
