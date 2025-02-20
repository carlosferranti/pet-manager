using Anima.Inscricao.Application._Shared.Commands;
using Anima.Inscricao.Application._Shared.DTOs;

namespace Anima.Inscricao.Application.UseCases.Fichas.CriarFicha;

public class CriarFichaCommand : ICommand<EntityKeyDto?>
{
    public string Nome { get; set; } = string.Empty;

    public string Descricao { get; set; } = string.Empty;

    public bool Padrao { get; set; }

    public List<CriarEtapaFichaCommand> Etapas { get; set; } = new();

    public List<CriarCampoFichaCommand>? Campos { get; set; }

    public record CriarEtapaFichaCommand(Guid EtapaKey, int Sequencia);

    public record CriarCampoFichaCommand(Guid CampoKey, bool ObrigatorioNaFicha, bool ObrigatorioNoComplemento);
}