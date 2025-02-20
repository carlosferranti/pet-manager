using Anima.Inscricao.Application._Shared.Commands;
using Anima.Inscricao.Application.DTOs.Candidatos;
using Anima.Inscricao.Application.DTOs.Concursos;
using Anima.Inscricao.Application.DTOs.Instituicao;

namespace Anima.Inscricao.Application.UseCases.Concursos.ProcessarRegraConcursoDestrancamentoReopcao;

public class ProcessarRegraConcursoDestrancamentoRetornoCommand : ICommand<List<ConcursosPorOfertaDto>>
{
    public List<CandidatoVinculoDto>? VinculosAnima { get; set; }

    public List<ConcursosPorOfertaDto> Concursos { get; set; } = new();

    public InstituicaoDto Instituicao { get; set; } = null!;
}
