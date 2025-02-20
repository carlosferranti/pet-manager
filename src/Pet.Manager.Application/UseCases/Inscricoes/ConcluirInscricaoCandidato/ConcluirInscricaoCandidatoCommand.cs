using System.Text.Json.Serialization;

using Anima.Inscricao.Application._Shared.Commands;

namespace Anima.Inscricao.Application.UseCases.Inscricoes.ConcluirInscricaoCandidato;

public class ConcluirInscricaoCandidatoCommand : ICommand
{
    [JsonIgnore]
    public Guid Key { get; set; }
}