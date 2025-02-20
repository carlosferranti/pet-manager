using System.Text.Json.Serialization;

using Anima.Inscricao.Application._Shared.Queries;
using Anima.Inscricao.Application.DTOs.FormasEntrada;

namespace Anima.Inscricao.Application.UseCases.FormasEntrada.ObterFormaEntrada;

public class ObterFormaEntradaQuery : IQuery<FormaEntradaDto>
{
    [JsonIgnore]
    public Guid Key { get; set; }
}
