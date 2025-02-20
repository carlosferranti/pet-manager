namespace Anima.Inscricao.Application.Config;

public class KafkaTopicsConfig
{
    public string ConfirmacaoInscricao { get; set; } = string.Empty;

    public string CriacaoInscricao { get; set; } = string.Empty;

    public string AtualizacaoInscricao { get; set; } = string.Empty;
}
