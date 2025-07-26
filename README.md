# 💸 TransactionService

**Microsserviço de Gerenciamento de Transações Financeiras com ASP.NET Core e MongoDB Atlas.**

### Funcionalidades:
- **Criar transações** via API REST.
- **Listar transações** armazenadas.
- **Persistência em MongoDB Atlas**.

## Tecnologias Utilizadas

- ASP.NET Core 8
- MongoDB Atlas
- Clean Architecture

## Como Executar o Projeto

### Pré-requisitos

* [.NET 8 SDK](https://dotnet.microsoft.com/download)
* Conta no [MongoDB Atlas](https://www.mongodb.com/cloud/atlas) com URI de conexão

### Execução

1. Clone o repositório:

```bash
git clone https://github.com/thevictorgabriel/transaction-service.git
```

3. Execute a aplicação:

```bash
cd API
dotnet run
```

A API estará disponível em: `http://localhost:5024/transactions`
