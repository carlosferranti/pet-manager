using Anima.Inscricao.Application._Shared.Commands;
using Anima.Inscricao.Application._Shared.DTOs;
using Anima.Inscricao.Application.DTOs.SistemasIntegracao;

namespace Anima.Inscricao.Application.UseCases.Campi.CriarCampus;

public class CriarCampusCommand : ICommand<EntityKeyDto?>
{
    public string Nome { get; set; } = string.Empty;

    public string? NomeComercial { get; set; }

    public SistemaIntegracaoDto? Integracao { get; set; }
}
