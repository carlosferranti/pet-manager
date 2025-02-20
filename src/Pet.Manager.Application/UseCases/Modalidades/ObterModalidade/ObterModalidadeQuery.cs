using System.Text.Json.Serialization;

using Anima.Inscricao.Application._Shared.Queries;

using Anima.Inscricao.Application.DTOs.Modalidades;

namespace Anima.Inscricao.Application.UseCases.Modalidades.ObterModalidade;

public class ObterModalidadeQuery : IQuery<ModalidadeDto>
{
    [JsonIgnore]
    public Guid Key { get; set; }
}
