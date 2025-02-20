using Anima.Inscricao.Application._Shared.Commands;

namespace Anima.Inscricao.Application.UseCases.Fichas.AtualizarFicha;

public class AtualizarFichaCommand : ICommand
{
    public Guid Key { get; set; }

    public string Nome { get; set; } = string.Empty;

    public string Descricao { get; set; } = string.Empty;

    public bool Padrao { get; set; }

    public List<AtualizarEtapaFichaCommand>? Etapas { get; set; }

    public List<AtualizarCampoFichaCommand>? Campos { get; set; }

    public record AtualizarEtapaFichaCommand(Guid EtapaKey, int Sequencia);
    
    public record AtualizarCampoFichaCommand(Guid CampoKey, bool ObrigatorioNaFicha, bool ObrigatorioNoComplemento);
}
