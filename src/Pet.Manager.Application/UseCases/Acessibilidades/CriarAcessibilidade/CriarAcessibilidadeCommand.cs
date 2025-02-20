using Anima.Inscricao.Application._Shared.Commands;
using Anima.Inscricao.Application._Shared.DTOs;
using Anima.Inscricao.Application.DTOs.SistemasIntegracao;

namespace Anima.Inscricao.Application.UseCases.Acessibilidades.CriarAcessibilidade;

public class CriarAcessibilidadeCommand : ICommand<EntityKeyDto?>
{
    public string Nome { get; set; } = string.Empty;

    public SistemaIntegracaoDto? Integracao { get; set; }
}
