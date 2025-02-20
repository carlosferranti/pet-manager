using System.Text.Json.Serialization;

using Anima.Inscricao.Application._Shared.Queries;
using Anima.Inscricao.Application.DTOs.Instituicao;

namespace Anima.Inscricao.Application.UseCases.Instituicoes.ObterInstituicao;

public class ObterInstituicaoQuery : IQuery<InstituicaoDto>
{
    [JsonIgnore]
    public Guid Key { get; set; }
}
