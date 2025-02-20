using System.Text.Json.Serialization;

using Anima.Inscricao.Application._Shared.Queries;
using Anima.Inscricao.Application.DTOs.Cursos;

namespace Anima.Inscricao.Application.UseCases.Cursos.ObterCurso;

public class ObterCursoQuery : IQuery<CursoDto>
{
    [JsonIgnore]
    public Guid Key { get; set; }
}

