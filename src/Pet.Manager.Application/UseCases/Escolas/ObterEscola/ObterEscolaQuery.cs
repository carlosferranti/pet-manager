using System.Text.Json.Serialization;

using Anima.Inscricao.Application._Shared.Queries;
using Anima.Inscricao.Application.DTOs.Escola;

namespace Anima.Inscricao.Application.UseCases.Escolas.ObterEscola;

public class ObterEscolaQuery : IQuery<EscolaDto>
{
    [JsonIgnore]
    public Guid Key { get; set; }
}
