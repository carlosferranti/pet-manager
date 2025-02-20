using Anima.Inscricao.Application._Shared.Commands;
using Anima.Inscricao.Application.DTOs.Candidatos;
using Anima.Inscricao.Application.DTOs.Concursos;
using Anima.Inscricao.Domain._Shared.ValueObjects;

namespace Anima.Inscricao.Application.UseCases.Concursos.ProcessarRegraConcursoSegundaGraduacao;

public class ProcessarRegraConcursoSegundaGraduacaoCommand : ICommand<List<ConcursosPorOfertaDto>>
{
    public List<CandidatoVinculoDto>? VinculosAnima { get; set; }

    public List<ConcursosPorOfertaDto> Concursos { get; set; } = new();

    public Vigencia VigenciaIntake { get; set; } = null!;

    public string Cpf { get; set; } = string.Empty;
}