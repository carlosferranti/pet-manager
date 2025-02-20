using Anima.Inscricao.Application.DTOs.SistemasIntegracao;
using Anima.Inscricao.Domain.Inscricoes.Enums;

namespace Anima.Inscricao.Application.DTOs.Inscricoes;

public class InscricaoFormaEntradaDto
{
    public int? FormaEntradaId { get; set; }

    public Guid FormaEntradaKey { get; set; }

    public string FormaEntradaNome { get; set; } = string.Empty;

    public TipoSelecaoFormaEntrada TipoSelecao { get; set; }

    public string? CodigoTipoSelecao { get; set; }

    public List<SistemaIntegracaoDto>? Integracoes { get; set; }
}