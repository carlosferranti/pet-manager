using System.Text.Json.Serialization;

using Anima.Inscricao.Application._Shared.Queries;
using Anima.Inscricao.Application.DTOs.Fichas;

namespace Anima.Inscricao.Application.UseCases.Fichas.ObterFicha;

public class ObterFichaQuery : IQuery<FichaDto>
{
    [JsonIgnore]
    public Guid Key { get; set; }
}