using System.Text.Json.Serialization;

using Anima.Inscricao.Application._Shared.Commands;

namespace Anima.Inscricao.Application.UseCases.Cursos.RemoverCurso;

public class RemoverCursoCommand : ICommand
{
    [JsonIgnore]
    public Guid Key { get; set; }
}