using System.Text.Json.Serialization;

using Anima.Inscricao.Application._Shared.Commands;

namespace Anima.Inscricao.Application.UseCases.Concursos.RemoverConcurso;

public class RemoverConcursoCommand : ICommand
{
    [JsonIgnore]
    public Guid Key { get; set; }
}
