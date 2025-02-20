using Anima.Inscricao.Application._Shared.Commands;
using Anima.Inscricao.Application._Shared.DTOs;
using Anima.Inscricao.Application.DTOs.SistemasIntegracao;

namespace Anima.Inscricao.Application.UseCases.TiposFormacao.CriarTipoFormacao;

public class CriarTipoFormacaoCommand : ICommand<EntityKeyDto?>
{
    public string Nome { get; set; } = string.Empty;

    public SistemaIntegracaoDto? Integracao { get; set; }
}
