using System.Text.Json.Serialization;

using Anima.Inscricao.Application._Shared.Queries;
using Anima.Inscricao.Application.DTOs.Etapas;

namespace Anima.Inscricao.Application.UseCases.Etapas.ObterEtapaTemplate;

public class ObterEtapaTemplateQuery : IQuery<EtapaTemplateDto>
{
    [JsonIgnore]
    public Guid Key { get; set; }
}
