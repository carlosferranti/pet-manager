using Confluent.Kafka;

namespace Anima.Inscricao.Infra.Messaging._Shared.Kafka;

public interface IKafkaFactory
{
    IConsumer<TKey, TValue> CreateConsumer<TKey, TValue>(string groupId);

    IProducer<TKey, TValue> CreateProducer<TKey, TValue>();
}
