using System.Text.Json.Serialization;

using Anima.Inscricao.Application._Shared.Queries;

using Anima.Inscricao.Application.DTOs.Enderecos;

namespace Anima.Inscricao.Application.UseCases.Enderecos.ObterEstado;

public class ObterEstadoQuery : IQuery<EstadoDto>
{
    [JsonIgnore]
    public Guid Key { get; set; }
}
