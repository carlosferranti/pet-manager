using System.Text.Json.Serialization;

using Anima.Inscricao.Application._Shared.Queries;
using Anima.Inscricao.Application.DTOs.TiposFormacao;

namespace Anima.Inscricao.Application.UseCases.TiposFormacao.ObterTipoFormacao;

public class ObterTipoFormacaoQuery : IQuery<TipoFormacaoDto>
{
    [JsonIgnore]
    public Guid Key { get; set; }
}