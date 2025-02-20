using System.Text.Json.Serialization;

using Anima.Inscricao.Application._Shared.Queries;
using Anima.Inscricao.Application.DTOs.Inscricoes;

namespace Anima.Inscricao.Application.UseCases.Inscricoes.ObterInscricaoCandidato;

public class ObterInscricaoCanditadoQuery : IQuery<InscricaoCandidatoDetalhesDto>
{
    [JsonIgnore]
    public Guid Key { get; set; }
}
