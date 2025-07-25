# 💸 TransactionService

**Microsserviço de Gerenciamento de Transações Financeiras com ASP.NET Core, MongoDB Atlas e Azure Service Bus.**

### Funcionalidades:
- **Criar transações** via API REST.
- **Listar transações** armazenadas.
- **Persistência em MongoDB Atlas**.
- **Envio assíncrono de mensagens** para o **Azure Service Bus**.

## Tecnologias Utilizadas

- ASP.NET Core 8
- MongoDB Atlas
- Azure Service Bus
- Clean Architecture
- xUnit para testes unitários

## Como Executar o Projeto

### Pré-requisitos

* [.NET 8 SDK](https://dotnet.microsoft.com/download)
* Conta no [MongoDB Atlas](https://www.mongodb.com/cloud/atlas) com URI de conexão
* Azure Service Bus configurado (connection string da fila)

### Execução

1. Clone o repositório:

```bash
adicionar depos de cria no github
```

3. Execute a aplicação:

```bash
cd API
dotnet run
```

A API estará disponível em: `http://localhost:5024/transactions`
