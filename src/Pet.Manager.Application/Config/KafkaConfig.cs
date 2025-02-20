namespace Anima.Inscricao.Application.Config;

public class KafkaConfig
{
    public string? BootstrapServer { get; set; }

    public string? SaslUsername { get; set; }

    public string? SaslPassword { get; set; }

    public KafkaTopicsConfig? Topics { get; set; }
}
