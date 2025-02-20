using Anima.Inscricao.Application._Shared.Queries;
using Anima.Inscricao.Application.DTOs.Instituicao;

namespace Anima.Inscricao.Application.UseCases.Instituicoes.PesquisarLinkRedirecionamentoCandidato;

public class PesquisarLinkRedireconamentoInstituicaoQuery : IQuery<InstituicaoLinkDto>
{
    public Guid key { get; set; }
}