using Domain.Entities;
using Domain.Interfaces;
using MongoDB.Driver;

namespace Infrastructure.Repositories;

public class MongoTransactionRepository : ITransactionRepository
{
    private readonly IMongoCollection<Transaction> _collection;

    public MongoTransactionRepository(string connectionString)
    {
        var client = new MongoClient(connectionString);
        var database = client.GetDatabase("TransactionsDb");
        _collection = database.GetCollection<Transaction>("Transactions");
    }

    public async Task<List<Transaction>> GetAllAsync() =>
        await _collection.Find(_ => true).ToListAsync();

    public async Task AddAsync(Transaction transaction) =>
        await _collection.InsertOneAsync(transaction);
}
