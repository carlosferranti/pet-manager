using System.Text.Json.Serialization;

using Anima.Inscricao.Application._Shared.Queries;
using Anima.Inscricao.Application.DTOs.Turnos;

namespace Anima.Inscricao.Application.UseCases.Turnos.ObterTurno;

public class ObterTurnoQuery : IQuery<TurnoDto>
{
    [JsonIgnore]
    public Guid Key { get; set; }
}
