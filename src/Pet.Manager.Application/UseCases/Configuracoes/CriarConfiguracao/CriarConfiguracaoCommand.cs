using Anima.Inscricao.Application._Shared.Commands;
using Anima.Inscricao.Application._Shared.DTOs;

namespace Anima.Inscricao.Application.UseCases.Configuracoes.CriarConfiguracao;

public class CriarConfiguracaoCommand : ICommand<EntityKeyDto?>
{
    public string ChaveGenerica { get; set; } = string.Empty;

    public string Valor { get; set; } = string.Empty;
}
