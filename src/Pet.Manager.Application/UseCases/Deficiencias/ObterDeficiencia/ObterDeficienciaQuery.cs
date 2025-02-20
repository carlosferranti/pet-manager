using System.Text.Json.Serialization;

using Anima.Inscricao.Application._Shared.Queries;
using Anima.Inscricao.Application.DTOs.Deficiencias;

namespace Anima.Inscricao.Application.UseCases.Deficiencias.ObterDeficiencia;

public class ObterDeficienciaQuery : IQuery<DeficienciaDto>
{
    [JsonIgnore]
    public Guid Key { get; set; }
}