using System.Text.Json.Serialization;

using Anima.Inscricao.Application._Shared.Queries;
using Anima.Inscricao.Application.DTOs.Acessibilidades;

namespace Anima.Inscricao.Application.UseCases.Acessibilidades.ObterAcessibilidade;

public class ObterAcessibilidadeQuery : IQuery<AcessibilidadeDto>
{
    [JsonIgnore]
    public Guid Key { get; set; }
}
