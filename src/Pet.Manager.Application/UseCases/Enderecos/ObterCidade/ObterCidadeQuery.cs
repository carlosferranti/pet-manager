using System.Text.Json.Serialization;

using Anima.Inscricao.Application._Shared.Queries;

using Anima.Inscricao.Application.DTOs.Enderecos;

namespace Anima.Inscricao.Application.UseCases.Enderecos.ObterCidade;

public class ObterCidadeQuery : IQuery<CidadeDto>
{
    [JsonIgnore]
    public Guid Key { get; set; }
}

