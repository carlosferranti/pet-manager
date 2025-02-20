using System.Text.Json.Serialization;

using Anima.Inscricao.Application._Shared.Commands;

namespace Anima.Inscricao.Application.UseCases.Instituicoes.RemoverInstituicao;

public class RemoverInstituicaoCommand : ICommand
{
    [JsonIgnore]
    public Guid Key { get; set; }
}
