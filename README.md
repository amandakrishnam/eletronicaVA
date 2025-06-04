# Sistema de Gerenciamento para Eletrônica V.A

Este projeto é um sistema de gerenciamento desenvolvido para a empresa Eletrônica V.A, localizada na cidade de Conchas. O seu principal objetivo é facilitar o gerenciamento de clientes, seus respectivos produtos eletrônicos e a geração de ordens de serviço para reparos e manutenções.

## Arquitetura

O projeto foi desenvolvido utilizando princípios do Domain-Driven Design (DDD). Esta abordagem foca em modelar o software para que ele corresponda ao domínio de negócio da empresa, facilitando a comunicação entre desenvolvedores e especialistas do domínio.

Os principais agregados e entidades do domínio incluem:

*   **Cliente:** Representa os clientes da Eletrônica V.A. Armazena informações como nome, contato e documentos.
*   **Produto:** Representa os aparelhos eletrônicos dos clientes que necessitam de serviço. Contém detalhes como tipo, modelo, marca e o defeito relatado.
*   **Ordem de Serviço:** Representa a solicitação de serviço para um determinado produto de um cliente. Inclui informações sobre o orçamento, status do serviço e descrição dos trabalhos a serem realizados.

## Como Executar o Projeto

Para executar este projeto em seu ambiente de desenvolvimento, siga os passos abaixo:

### Pré-requisitos

*   **PostgreSQL:** Certifique-se de ter o PostgreSQL instalado e em execução. Você pode baixá-lo em [https://www.postgresql.org/download/](https://www.postgresql.org/download/).
*   **.NET SDK:** É necessário ter o .NET SDK instalado (versão compatível com o projeto, e.g., .NET 7 ou superior). Você pode baixá-lo em [https://dotnet.microsoft.com/download](https://dotnet.microsoft.com/download).
*   **EF Core CLI tools:** Instale as ferramentas de linha de comando do Entity Framework Core. Se ainda não as tiver, instale globalmente com o comando:
    ```bash
    dotnet tool install --global dotnet-ef
    ```

### Configuração do Banco de Dados

1.  **String de Conexão:** A configuração da string de conexão com o banco de dados PostgreSQL encontra-se no arquivo `Eletronica.App/Data/ContextoDados.cs`. Por padrão, está configurada para:
    ```csharp
    optionsBuilder.UseNpgsql("Host=localhost;Database=eletronicaBD;Username=postgres;Password=1234");
    ```
    Ajuste os valores de `Host`, `Database`, `Username`, e `Password` conforme a configuração do seu ambiente PostgreSQL. Certifique-se de que o banco de dados (`eletronicaBD` por padrão) exista ou crie-o antes de prosseguir.

2.  **Aplicar Migrations:** Após configurar a string de conexão, abra um terminal na pasta raiz do projeto `Eletronica.App` (onde o arquivo `.csproj` está localizado) e execute o seguinte comando para aplicar as migrations e criar/atualizar o esquema do banco de dados:
    ```bash
    dotnet ef database update
    ```

### Compilando e Executando a Aplicação

Existem duas maneiras principais de compilar e executar a aplicação:

1.  **Via Linha de Comando (CLI):**
    *   Navegue até a pasta raiz do projeto `Eletronica.App`.
    *   Compile o projeto com o comando:
        ```bash
        dotnet build
        ```
    *   Execute a aplicação com:
        ```bash
        dotnet run
        ```

2.  **Via Visual Studio (ou outra IDE compatível):**
    *   Abra o arquivo da solução `eletronica.sln` no Visual Studio.
    *   Configure `Eletronica.App` como projeto de inicialização.
    *   Pressione F5 ou clique no botão "Iniciar" para compilar e executar o projeto.

A aplicação Windows Forms deverá ser iniciada.

## Funcionalidades

O sistema oferece as seguintes funcionalidades principais:

*   **Gerenciamento de Clientes:** Cadastro, consulta, atualização e exclusão de clientes.
*   **Gerenciamento de Produtos:** Cadastro e associação de produtos eletrônicos aos seus respectivos clientes.
*   **Gestão de Ordens de Serviço:**
    *   Criação de novas ordens de serviço detalhando o produto, o defeito relatado e informações do cliente.
    *   Definição de orçamento para o reparo.
    *   Acompanhamento do status da ordem de serviço (ex: Em Espera, Em Andamento, Pronto).
    *   Registro dos serviços realizados.
*   **Gerenciamento de Usuários e Grupos de Usuários:** (Funcionalidade inferida)
    *   Cadastro e controle de usuários do sistema.
    *   Definição de grupos de usuários com diferentes níveis de permissão (esta parte é uma suposição comum para tais entidades, mas pode ser ajustada se mais detalhes forem conhecidos).
*   **Gerenciamento de Tipos de Serviços:** Cadastro dos diferentes tipos de serviços que a eletrônica pode realizar.

## Tecnologias Utilizadas

*   **.NET:** Plataforma de desenvolvimento da Microsoft.
*   **Entity Framework Core:** ORM para acesso a dados.
*   **PostgreSQL:** Banco de dados relacional utilizado.
*   **Windows Forms:** Para a interface gráfica do usuário (GUI) da aplicação desktop.
