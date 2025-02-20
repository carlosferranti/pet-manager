using System.Text.Json;

using Anima.Inscricao.Infra.Messaging._Shared.Kafka;
using Confluent.Kafka;

using Microsoft.Extensions.Logging;

namespace Anima.Inscricao.Infra.Messaging.Publishes.Shared;

public class BaseKafkaEventHandler
{
    private readonly ILogger<BaseKafkaEventHandler> _logger;
    private readonly IKafkaFactory _kafkaFactory;

    public BaseKafkaEventHandler(ILogger<BaseKafkaEventHandler> logger, IKafkaFactory kafkaFactory)
    {
        _logger = logger;
        _kafkaFactory = kafkaFactory;
    }

    protected async Task PublishEvent(string topic, object value, CancellationToken cancellationToken)
    {
        try
        {
            using (var kafka = _kafkaFactory.CreateProducer<string, string>())
            {
                await kafka.ProduceAsync(
                topic,
                new Message<string, string>()
                {
                    Key = Guid.NewGuid().ToString(),
                    Value = JsonSerializer.Serialize(value),
                },
                cancellationToken);

                kafka.Flush(cancellationToken);
            }
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Erro ao publicar mensagem no kafka.");
            throw;
        }
    }
}
