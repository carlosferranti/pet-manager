using Anima.Inscricao.Application.DTOs.SistemasIntegracao;

namespace Anima.Inscricao.Application.DTOs.Cupons;

public class CupomDto
{
    public Guid Key { get; set; }

    public Guid ConcursoKey { get; set; }

    public string ConcursoPeriodoLetivo { get; set; } = string.Empty;

    public string Codigo { get; set; } = string.Empty;

    public string Descricao { get; set; } = string.Empty;

    public int TipoDesconto { get; set; }

    public string DescricaoTipoDesconto { get; set; } = string.Empty;

    public float ValorDesconto { get; set; }

    public DateTime? DataValidade { get; set; }

    public SistemaIntegracaoDto? Integracao { get; set; }
}
