using Anima.Inscricao.Application._Shared.Commands;
using Anima.Inscricao.Application._Shared.DTOs;
using Anima.Inscricao.Application.DTOs.SistemasIntegracao;

namespace Anima.Inscricao.Application.UseCases.Modalidades.CriarModalidade;

public class CriarModalidadeCommand : ICommand<EntityKeyDto?>
{
    public string Nome { get; set; } = string.Empty;

    public string? Descricao { get; set; }

    public SistemaIntegracaoDto? Integracao { get; set; }
}
