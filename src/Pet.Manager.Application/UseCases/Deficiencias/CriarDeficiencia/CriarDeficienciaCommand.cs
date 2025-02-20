using Anima.Inscricao.Application._Shared.Commands;
using Anima.Inscricao.Application._Shared.DTOs;
using Anima.Inscricao.Application.DTOs.SistemasIntegracao;

namespace Anima.Inscricao.Application.UseCases.Deficiencias.CriarDeficiencia;

public class CriarDeficienciaCommand : ICommand<EntityKeyDto?>
{
    public string Nome { get; set; } = string.Empty;

    public int? OrdemExibicao { get; set; }

    public SistemaIntegracaoDto? Integracao { get; set; }
}