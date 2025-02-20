using Anima.Inscricao.Application._Shared.Commands;

namespace Anima.Inscricao.Application.UseCases.Etapas.AtualizarEtapaTemplate;

public class AtualizarEtapaTemplateCommand : ICommand
{
    public Guid Key { get; set; }

    public string Nome { get; set; } = string.Empty;

    public string Descricao { get; set; } = string.Empty;

    public string NomeArquivo { get; set; } = string.Empty;
}
