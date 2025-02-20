using Anima.Inscricao.Application._Shared.DTOs.Paginacao;
using Anima.Inscricao.Application._Shared.Queries;
using Anima.Inscricao.Application.DTOs.Inscricoes;

namespace Anima.Inscricao.Application.UseCases.Inscricoes.PesquisarInscricoesCandidatos;

public class PesquisarInscricoesCandidatosQuery : IQuery<ResultadoPaginadoDto<CandidatoDto>>
{
    public PesquisarInscricoesCandidatosFiltros Filtros { get; set; } = new PesquisarInscricoesCandidatosFiltros(null, null, null, null, null);

    public PaginacaoDto Paginacao { get; set; } = new PaginacaoDto();

    public record PesquisarInscricoesCandidatosFiltros(string? ConcursoId, int? CandidatoId, string? Nome, string? Cpf, List<int>? StatusInscricaoIds);
}