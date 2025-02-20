using System.Text.Json.Serialization;

using Anima.Inscricao.Application._Shared.Queries;
using Anima.Inscricao.Application.DTOs.Concursos;
using Anima.Inscricao.Application.DTOs.Cursos;

namespace Anima.Inscricao.Application.UseCases.Concursos.ObterConcurso;

public class ObterConcursoQuery : IQuery<ConcursoDto>
{
    [JsonIgnore]
    public Guid Key { get; set; }
}
