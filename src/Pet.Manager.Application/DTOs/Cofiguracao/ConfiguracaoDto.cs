namespace Anima.Inscricao.Application.DTOs.Cofiguracao;

public class ConfiguracaoDto
{
    public Guid Key { get; set; }

    public string ChaveGenerica { get; set; } = string.Empty;

    public string Valor { get; set; } = string.Empty;

    public DateTimeOffset? DataCriacao { get; set; }

    public DateTimeOffset? DataAlteracao { get; set; }
}
