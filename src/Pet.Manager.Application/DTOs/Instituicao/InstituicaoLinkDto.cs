namespace Anima.Inscricao.Application.DTOs.Instituicao;

public class InstituicaoLinkDto
{
    public int Id { get; set; }

    public Guid Key { get; set; }

    public int InscricaoId { get; set; }

    public long MarcaId { get; set; }

    public string? TipoLink { get; set; }

    public string? Url { get; set; }
}