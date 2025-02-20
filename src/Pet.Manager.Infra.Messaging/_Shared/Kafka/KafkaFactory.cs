using Anima.Inscricao.Application.Config;

using Confluent.Kafka;

using Microsoft.Extensions.Options;

namespace Anima.Inscricao.Infra.Messaging._Shared.Kafka;

public class KafkaFactory : IKafkaFactory
{
    private readonly ProducerConfig producerConfig;
    private readonly ConsumerConfig consumerConfig;

    public KafkaFactory(IOptions<KafkaConfig> kafkaConfig)
    {
        string bootstrapServers = kafkaConfig.Value.BootstrapServer ?? throw new ArgumentNullException(kafkaConfig.Value.BootstrapServer);
        string username = kafkaConfig.Value.SaslUsername ?? throw new ArgumentNullException(kafkaConfig.Value.SaslUsername);
        string password = kafkaConfig.Value.SaslPassword ?? throw new ArgumentNullException(kafkaConfig.Value.SaslPassword);

        producerConfig = new ProducerConfig
        {
            BootstrapServers = bootstrapServers,
            SecurityProtocol = SecurityProtocol.SaslSsl,
            SaslMechanism = SaslMechanism.ScramSha512,
            SaslUsername = username,
            SaslPassword = password,
            Acks = Acks.Leader,
            EnableDeliveryReports = false,
            EnableSslCertificateVerification = false,
        };

        consumerConfig = new ConsumerConfig
        {
            BootstrapServers = bootstrapServers,
            AutoOffsetReset = AutoOffsetReset.Earliest,
        };
    }

    /// <inheritdoc/>
    public IConsumer<TKey, TValue> CreateConsumer<TKey, TValue>(string groupId)
    {
        consumerConfig.GroupId = groupId;
        return new ConsumerBuilder<TKey, TValue>(consumerConfig).Build();
    }

    /// <inheritdoc/>
    public IProducer<TKey, TValue> CreateProducer<TKey, TValue>()
    {
        return new ProducerBuilder<TKey, TValue>(producerConfig).Build();
    }
}
