using System.Text.Json.Serialization;

using Anima.Inscricao.Application._Shared.Commands;

namespace Anima.Inscricao.Application.UseCases.TiposFormacao.RemoverTipoFormacao;

public class RemoverTipoFormacaoCommand : ICommand
{
    [JsonIgnore]
    public Guid Key { get; set; }
}
