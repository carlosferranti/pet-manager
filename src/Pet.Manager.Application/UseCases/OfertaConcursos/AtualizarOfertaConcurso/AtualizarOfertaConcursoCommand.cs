using System.Text.Json.Serialization;

using Anima.Inscricao.Application._Shared.Commands;

namespace Anima.Inscricao.Application.UseCases.OfertaConcursos.AtualizarOfertaConcurso;

public class AtualizarOfertaConcursoCommand : ICommand
{
    [JsonIgnore]
    public Guid Key { get; set; }

    public Guid ConcursoKey { get; set; }

    public Guid OfertaKey { get; set; }
}
