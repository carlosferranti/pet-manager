using Anima.Inscricao.Domain.Inscricoes.Enums;

namespace Anima.Inscricao.Application.DTOs.Inscricoes;

public class InscricaoSeguroFiancaDto
{
    public string? NomeFiador { get; init; }

    public string? TipoRelacionamentoSegurado { get; init; }

    public decimal? PercentualFiador { get; init; }

    public decimal? RendaMediaMensal { get; init; }

    public TipoDocumentoInscricao? TipoDocumento { get; init; }

    public string? ValorDocumento { get; init; }

    public TipoContatoInscricao? TipoContato { get; init; }

    public string? ValorContato { get; init; }

}