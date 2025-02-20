using System.Text.Json.Serialization;

using Anima.Inscricao.Application._Shared.Queries;
using Anima.Inscricao.Application.DTOs.NiveisCurso;

namespace Anima.Inscricao.Application.UseCases.NiveisCurso.ObterNivelCurso;

public class ObterNivelCursoQuery : IQuery<NivelCursoDto>
{
    [JsonIgnore]
    public Guid Key { get; set; }
}
