using Anima.Inscricao.Application._Shared.Commands;
using Anima.Inscricao.Application._Shared.DTOs;
using Anima.Inscricao.Application.DTOs.SistemasIntegracao;

namespace Anima.Inscricao.Application.UseCases.Intakes.CriarIntake;

public class CriarIntakeCommand : ICommand<EntityKeyDto?>
{
    public string Nome { get; set; } = string.Empty;

    public DateTime VigenciaInicio { get; set; }

    public DateTime VigenciaTermino { get; set; }

    public SistemaIntegracaoDto? Integracao { get; set; }
}