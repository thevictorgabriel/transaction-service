namespace Domain.Entities;

public class Transaction
{
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public double Amount { get; set; }
    public string Type { get; set; } = string.Empty; // Credit ou Debit
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}
