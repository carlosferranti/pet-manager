using System.Text.Json.Serialization;

using Anima.Inscricao.Application._Shared.Commands;

namespace Anima.Inscricao.Application.UseCases.Configuracoes.RemoverConfiguracao;

public class RemoverConfiguracaoCommand : ICommand
{
    [JsonIgnore]
    public Guid Key { get; set; }
}
