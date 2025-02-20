using System.Text.Json.Serialization;

using Anima.Inscricao.Application._Shared.Queries;
using Anima.Inscricao.Application.DTOs.CursosExternos;

namespace Anima.Inscricao.Application.UseCases.CursosExternos.ObterCursoExterno;

public class ObterCursoExternoQuery : IQuery<CursoExternoDto>
{
    [JsonIgnore]
    public Guid Key { get; set; }
}
