namespace Anima.Inscricao.Application.DTOs.Inscricoes;

public class CandidatoDto
{
    public int Id { get; set; }

    public Guid Key { get; set; }

    public required InfoPessoaisDto InfoPessoais { get; set; }

    public required InfoDocumentosDto InfoDocumentos { get; set; }

    public required StatusInscricaoDto statusInscricao { get; set; }
}
