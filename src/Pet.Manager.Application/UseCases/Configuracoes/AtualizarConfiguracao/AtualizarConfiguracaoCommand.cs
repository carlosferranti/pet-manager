using Anima.Inscricao.Application._Shared.Commands;

namespace Anima.Inscricao.Application.UseCases.Configuracoes.AtualizarConfiguracao;

public class AtualizarConfiguracaoCommand : ICommand
{
    public Guid Key { get; set; }

    public string ChaveGenerica { get; set; } = string.Empty;

    public string Valor { get; set; } = string.Empty;
}
