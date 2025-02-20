using Anima.Inscricao.Application._Shared.Queries;
using Anima.Inscricao.Application.DTOs.Candidatos;

namespace Anima.Inscricao.Application.UseCases.Inscricoes.PesquisarVinculoCandidato;

public class PesquisarVinculoCandidatoQuery : IQuery<IEnumerable<CandidatoVinculoDto>>
{
    public string Cpf { get; set; } = string.Empty;

    public Guid? MarcaKey { get; set; }

    public Guid? FormaEntradaKey { get; set; }
}
