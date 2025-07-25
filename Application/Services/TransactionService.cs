using Domain.Entities;
using Domain.Interfaces;

namespace Application.Services;

public class TransactionService
{
    private readonly ITransactionRepository _repository;

    public TransactionService(ITransactionRepository repository)
    {
        _repository = repository;
    }

    public Task<List<Transaction>> GetAllAsync() => _repository.GetAllAsync();

    public Task CreateAsync(Transaction transaction)
    {
        // Validações básicas aqui (ex: amount > 0)
        return _repository.AddAsync(transaction);
    }
}
