namespace Anima.Inscricao.Application.DTOs.Etapas;

public class EtapaTemplateDto
{
    public Guid Key { get; set; }

    public string Nome { get; set; } = string.Empty;

    public string Descricao { get; set; } = string.Empty;

    public string NomeArquivo { get; set; } = string.Empty;
}