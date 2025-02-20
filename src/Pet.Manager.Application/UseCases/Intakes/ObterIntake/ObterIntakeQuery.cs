using System.Text.Json.Serialization;

using Anima.Inscricao.Application._Shared.Queries;
using Anima.Inscricao.Application.DTOs.Intakes;

namespace Anima.Inscricao.Application.UseCases.Intakes.ObterIntake;

public class ObterIntakeQuery : IQuery<IntakeDto>
{
    [JsonIgnore]
    public Guid Key { get; set; }
}
