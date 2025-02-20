using System.Text.Json.Serialization;

using Anima.Inscricao.Application._Shared.Queries;
using Anima.Inscricao.Application.DTOs.Ofertas;

namespace Anima.Inscricao.Application.UseCases.Ofertas.ObterOferta;

public class ObterOfertaQuery : IQuery<OfertaDto>
{
    [JsonIgnore]
    public Guid Key { get; set; }
}
