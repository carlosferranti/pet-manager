using Anima.Inscricao.Application._Shared.Queries;
using Anima.Inscricao.Application.DTOs.Inscricoes;

namespace Anima.Inscricao.Application.UseCases.Inscricoes.PesquisarInscricaoAnteriorCandidato;

public class PesquisarInscricaoCandidatoMarcaQuery : IQuery<List<InscricaoDto>>
{
    public Guid MarcaKey { get; set; }

    public string Cpf { get; set; } = string.Empty;
}