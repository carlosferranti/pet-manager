using Anima.Inscricao.Application._Shared.Commands;
using Anima.Inscricao.Application._Shared.DTOs;
using Anima.Inscricao.Application.DTOs.SistemasIntegracao;

namespace Anima.Inscricao.Application.UseCases.Instituicoes.CriarInstituicao;

public class CriarInstituicaoCommand : ICommand<EntityKeyDto?>
{
    public string Nome { get; set; } = string.Empty;

    public string Sigla { get; set; } = string.Empty;

    public Guid MarcaKey { get; set; }

    public SistemaIntegracaoDto? Integracao { get; set; }
}
