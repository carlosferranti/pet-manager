using System.Text.Json.Serialization;

using Anima.Inscricao.Application._Shared.Queries;
using Anima.Inscricao.Application.DTOs.OfertaConcursos;

namespace Anima.Inscricao.Application.UseCases.OfertaConcursos.ObterOfertaConcurso;

public class ObterOfertaConcursoQuery : IQuery<OfertaConcursoDto>
{
    [JsonIgnore]
    public Guid Key { get; set; }
}
