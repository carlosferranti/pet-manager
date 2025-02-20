using Anima.Inscricao.Application._Shared.Commands;
using Anima.Inscricao.Application._Shared.DTOs;
using Anima.Inscricao.Application.DTOs.SistemasIntegracao;

namespace Anima.Inscricao.Application.UseCases.Cupons.CriarCupom;

public class CriarCupomCommand : ICommand<EntityKeyDto?>
{
    public string Codigo { get; set; } = string.Empty;

    public string Descricao { get; set; } = string.Empty;

    public float ValorDesconto { get; set; }

    public int TipoDesconto { get; set; }

    public DateTime? DataValidade { get; set; }

    public Guid ConcursoKey { get; set; }

    public SistemaIntegracaoDto? Integracao { get; set; }
}
