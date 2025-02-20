using System.Text.Json.Serialization;

using Anima.Inscricao.Application._Shared.Commands;

namespace Anima.Inscricao.Application.UseCases.OfertaConcursos.RemoverOfertaConcurso;

public class RemoverOfertaConcursoCommand : ICommand
{
    [JsonIgnore]
    public Guid Key { get; set; }
}
