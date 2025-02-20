using Anima.Inscricao.Application._Shared.Commands;
using Anima.Inscricao.Application.Constants;
using Anima.Inscricao.Application.DTOs.Concursos;
using Anima.Inscricao.Application.Interfaces.Repositories;
using Anima.Inscricao.Domain._Shared.ValueObjects;

using Microsoft.Extensions.Logging;

namespace Anima.Inscricao.Application.UseCases.Concursos.ProcessarRegraConcursoSegundaGraduacao;

public class ProcessarRegraConcursoSegundaGraduacaoCommandHandler : ICommandHandler<ProcessarRegraConcursoSegundaGraduacaoCommand, List<ConcursosPorOfertaDto>>
{
    private readonly ICandidatoRepository _candidatoRepository;
    private readonly ILogger<ProcessarRegraConcursoSegundaGraduacaoCommandHandler> _logger;

    public ProcessarRegraConcursoSegundaGraduacaoCommandHandler(
        ICandidatoRepository candidatoRepository,
        ILogger<ProcessarRegraConcursoSegundaGraduacaoCommandHandler> logger)
    {
        _candidatoRepository = candidatoRepository;
        _logger = logger;
    }

    public async Task<List<ConcursosPorOfertaDto>> Handle(ProcessarRegraConcursoSegundaGraduacaoCommand request, CancellationToken cancellationToken)
    {
        //RN1: Nessa abertura de card so NÃO FICA DISPONÍVEL quando
        //o aluno for ativo no semestre anteriores a ficha atual com diário de classe fechado
        //(Ficha de 2015/01, aluno ativo em semestre até 2024/01 ou 2024/02 com diário de classe fechado)
        //e concurso cadastrado

        try
        {
            if (request.VinculosAnima == null || !request.VinculosAnima.Any())
            {
                return request.Concursos;
            }

            List<Vigencia> semestresAnteriores = new();
            int semestreAtual = request.VigenciaIntake.ObterSemestre();
            int anoAtual = request.VigenciaIntake.Inicio.Year;
            DateTime dataInicioPrimeiroSemestre = new DateTime(anoAtual, 01, 01, 0, 0, 0, DateTimeKind.Utc);
            DateTime dataTerminoPrimeiroSemestre = new DateTime(anoAtual, 06, 30, 23, 59, 59, DateTimeKind.Utc);
            DateTime dataInicioSegundoSemestre = new DateTime(anoAtual, 07, 01, 0, 0, 0, DateTimeKind.Utc);
            DateTime dataTerminoSegundoSemestre = new DateTime(anoAtual, 12, 31, 23, 59, 59, DateTimeKind.Utc);

            switch (semestreAtual)
            {
                case 1:
                    semestresAnteriores.Add(new Vigencia(dataInicioSegundoSemestre.AddYears(-1), dataTerminoSegundoSemestre.AddYears(-1)));
                    semestresAnteriores.Add(new Vigencia(dataInicioPrimeiroSemestre.AddYears(-1), dataTerminoPrimeiroSemestre.AddYears(-1)));
                    break;
                case 2:
                    semestresAnteriores.Add(new Vigencia(dataInicioPrimeiroSemestre, dataTerminoPrimeiroSemestre));
                    semestresAnteriores.Add(new Vigencia(dataInicioSegundoSemestre.AddYears(-2), dataTerminoSegundoSemestre.AddYears(-2)));
                    break;
            }

            var diariosClasse = await _candidatoRepository.PesquisarDiarioClasseCandidatoAsync(request.Cpf);

            if (diariosClasse != null && diariosClasse.Any(d =>
            d.CodigoStatusAluno == Enums.StatusMatricula.Ativo &&
            d.CodigoStatusDiario == Enums.TipoStatusDiarioClasse.Fechado &&
            semestresAnteriores.Exists(s => s.EstaEmAndamento(d.InicioPeriodoLetivo))))
            {
                request.Concursos.RemoveAll(c => c.FormaEntradaKey == FormaEntradaConstants.SegundaGraduacao);
            }
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Erro ao processar regra de concurso de segunda graduação. {@Request}", request);
        }
        
        return request.Concursos;
    }
}
