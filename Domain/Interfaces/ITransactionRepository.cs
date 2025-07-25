using Domain.Entities;

namespace Domain.Interfaces;

public interface ITransactionRepository
{
    Task<List<Transaction>> GetAllAsync();
    Task AddAsync(Transaction transaction);
}

