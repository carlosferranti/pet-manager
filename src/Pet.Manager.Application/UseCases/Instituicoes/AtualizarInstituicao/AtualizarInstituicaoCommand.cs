using System.Text.Json.Serialization;

using Anima.Inscricao.Application._Shared.Commands;

namespace Anima.Inscricao.Application.UseCases.Instituicoes.AtualizarInstituicao;

public class AtualizarInstituicaoCommand : ICommand
{
    [JsonIgnore]
    public Guid Key { get; set; }

    public string Nome { get; set; } = string.Empty;

    public string? Sigla { get; set; }

    public Guid MarcaKey { get; set; }
}
