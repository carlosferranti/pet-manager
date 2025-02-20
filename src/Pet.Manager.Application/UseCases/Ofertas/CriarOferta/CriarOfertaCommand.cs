using Anima.Inscricao.Application._Shared.Commands;
using Anima.Inscricao.Application._Shared.DTOs;
using Anima.Inscricao.Application.DTOs.SistemasIntegracao;

namespace Anima.Inscricao.Application.UseCases.Ofertas.CriarOferta;

public class CriarOfertaCommand : ICommand<EntityKeyDto?>
{
    public Guid ProdutoKey { get; set; }

    public Guid IntakeKey { get; set; }

    public SistemaIntegracaoDto? Integracao { get; set; }
}
