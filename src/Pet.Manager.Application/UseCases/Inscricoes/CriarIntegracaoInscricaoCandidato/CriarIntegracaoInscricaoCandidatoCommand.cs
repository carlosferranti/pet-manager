using Anima.Inscricao.Application._Shared.Commands;
using Anima.Inscricao.Application._Shared.DTOs;
using Anima.Inscricao.Application.DTOs.SistemasIntegracao;

namespace Anima.Inscricao.Application.UseCases.Inscricoes.CriarIntegracaoInscricaoCandidato;

public class CriarIntegracaoInscricaoCandidatoCommand : ICommand<EntityKeyDto?>
{
    public Guid InscricaoCandidatoKey { get; set; }

    public SistemaIntegracaoDto Integracao { get; set; } = null!;
}