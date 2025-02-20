using System.Text.Json.Serialization;

using Anima.Inscricao.Application._Shared.Queries;
using Anima.Inscricao.Application.DTOs.Marcas;

namespace Anima.Inscricao.Application.UseCases.Marcas.ObterMarca;

public class ObterMarcaQuery : IQuery<MarcaDto>
{
    [JsonIgnore]
    public Guid Key { get; set; }
}
