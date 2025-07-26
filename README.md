# 💸 TransactionService

**Microsserviço de Gerenciamento de Transações Financeiras com ASP.NET Core e MongoDB Atlas.**

### Funcionalidades:
- **Criar transações via API REST.**
- **Listar transações armazenadas.** 
- **Persistência em MongoDB Atlas**

### Tecnologias Utilizadas

- ASP.NET Core 8
- MongoDB Atlas
- Clean Architecture

### Pré-requisitos

- [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download)
- [MongoDB Atlas](https://www.mongodb.com/cloud/atlas) (instância configurada)
- Git instalado

### Execução

1. Clone o repositório:

```bash
git clone https://github.com/thevictorgabriel/transaction-service.git
cd transaction-service
```

3. Execute a aplicação:

```bash
cd API
dotnet build
dotnet run
```

A interface para requisições disponível em: 
`http://localhost:5024/transactions`

Visualização geral das transações : 
`http://localhost:5024`
