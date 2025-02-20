using Anima.Inscricao.Domain.Inscricoes.Enums;

namespace Anima.Inscricao.Application.DTOs.Inscricoes;

public class InscricaoOrigemDto
{
    public TipoOrigemInscricao? Tipo { get; set; }

    public string? Url { get; set; }
}
