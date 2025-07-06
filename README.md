# MyFinance Web .NET

## Descrição do Projeto
O MyFinance Web é uma aplicação web desenvolvida em .NET para gerenciamento de finanças pessoais. O projeto permite aos usuários controlar suas receitas, despesas e realizar o acompanhamento financeiro de forma eficiente e organizada.

## Arquitetura Utilizada
O projeto segue uma arquitetura em camadas (N-tier), organizada da seguinte forma:

- **Controllers**: Camada de apresentação que gerencia as requisições HTTP
- **Models**: Camada de modelos de dados
- **Domain**: Camada que contém as regras de negócio e entidades do domínio
- **Services**: Camada de serviços que implementa a lógica de negócio
- **Infrastructure**: Camada de infraestrutura para acesso a dados e serviços externos

## Tecnologias
- ASP.NET Core MVC
- C#
- Entity Framework Core
- SQL Server
- HTML/CSS/JavaScript
- Bootstrap

## Como Configurar e Executar o Projeto

### Pré-requisitos
- .NET SDK 6.0 ou superior
- SQL Server
- Visual Studio 2022 ou VS Code

### Passos para Execução
1. Clone o repositório:
   ```bash
   git clone https://github.com/seu-usuario/myfinance-web-dotnet-o8.git
   ```

2. Navegue até a pasta do projeto:
   ```bash
   cd myfinance-web-dotnet-o8/src/myfinance-web-dotnet-o8
   ```

3. Restaure os pacotes NuGet:
   ```bash
   dotnet restore
   ```

4. Configure a string de conexão com o banco de dados no arquivo `appsettings.json`

5. Execute as migrações do banco de dados:
   ```bash
   dotnet ef database update
   ```

6. Execute o projeto:
   ```bash
   dotnet run
   ```

7. Acesse a aplicação em seu navegador através do endereço: `https://localhost:7155`