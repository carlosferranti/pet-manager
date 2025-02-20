using System.Text.Json.Serialization;

using Anima.Inscricao.Application._Shared.Queries;
using Anima.Inscricao.Application.DTOs.Campi;

namespace Anima.Inscricao.Application.UseCases.Campi.ObterCampus;

public class ObterCampusQuery : IQuery<CampusDto>
{
    [JsonIgnore]
    public Guid Key { get; set; }

}
