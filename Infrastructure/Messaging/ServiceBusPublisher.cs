using Azure.Messaging.ServiceBus;
using System.Text.Json;

namespace Infrastructure.Messaging;

public class ServiceBusPublisher
{
    private readonly ServiceBusClient _client;
    private readonly ServiceBusSender _sender;

    public ServiceBusPublisher(string connectionString, string queueName)
    {
        _client = new ServiceBusClient(connectionString);
        _sender = _client.CreateSender(queueName);
    }

    public async Task SendMessageAsync<T>(T message)
    {
        var json = JsonSerializer.Serialize(message);
        await _sender.SendMessageAsync(new ServiceBusMessage(json));
    }
}
