using System.Text.Json.Serialization;

using Anima.Inscricao.Application._Shared.Commands;

namespace Anima.Inscricao.Application.UseCases.Modalidades.AtualizarModalidade;

public class AtualizarModalidadeCommand : ICommand
{
    [JsonIgnore]
    public Guid Key { get; set; }

    public string Nome { get; set; } = string.Empty;

    public string? Descricao { get; set; }
}
