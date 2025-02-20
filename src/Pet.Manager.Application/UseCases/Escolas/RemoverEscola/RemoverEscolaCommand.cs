using System.Text.Json.Serialization;

using Anima.Inscricao.Application._Shared.Commands;

namespace Anima.Inscricao.Application.UseCases.Escolas.RemoverEscola;

public class RemoverEscolaCommand : ICommand
{
    [JsonIgnore]
    public Guid Key { get; set; }
}
