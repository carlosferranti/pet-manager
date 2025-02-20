using Anima.Inscricao.Application.DTOs.Candidatos;
using Anima.Inscricao.Application.DTOs.Concursos;
using Anima.Inscricao.Application.Enums;
using Anima.Inscricao.Application.Interfaces.Repositories;
using Anima.Inscricao.Application.UseCases.Concursos.ProcessarRegraConcursoSegundaGraduacao;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test.Extensions;

using FluentAssertions;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

using Moq;

namespace Anima.Inscricao.Test.UseCases.Concursos;

public class ProcessarRegraConcursoSegundaGraduacaoCommandHandlerTests
{
    private readonly Mock<ICandidatoRepository> _candidatoRepository = new();
    private readonly Mock<ILogger<ProcessarRegraConcursoSegundaGraduacaoCommandHandler>> _logger = new();

    public ProcessarRegraConcursoSegundaGraduacaoCommandHandlerTests()
    {
        new ServiceExtensions().BuildServiceProvider(new ServiceCollection());
    }

    [Fact]
    public async Task DeveRetornarConcursosQuandoNaoHouverVinculosAnimaAsync()
    {
        // Arrange
        var request = new ProcessarRegraConcursoSegundaGraduacaoCommand
        {
            Concursos = new()
            {
                new ConcursosPorOfertaDto()
                {
                    FormaEntradaKey = FormaEntradaConstants.FormaEntradaSegundaGraduacao.Key,
                    NomeFormaEntrada = FormaEntradaConstants.FormaEntradaSegundaGraduacao.Nome,
                    Concursos = new()
                    {
                        new ConcursosPorOfertaDto.ConcursosFormaEntradaDto()
                        {
                            NomeConcurso = "Concurso 1",
                        }
                    }
                }
            },
            VinculosAnima = new()
        };

        // Act
        var useCase = ObterUseCase();
        var result = await useCase.Handle(request, CancellationToken.None);

        // Assert
        result.Exists(c => c.FormaEntradaKey == FormaEntradaConstants.FormaEntradaSegundaGraduacao.Key).Should().BeTrue();
    }

    [Fact]
    public async Task NaoDeveRetornarConcursosQuandoAlunoAtivoEmSemestreAnteriorAsync()
    {
        // Arrange
        var request = new ProcessarRegraConcursoSegundaGraduacaoCommand
        {
            Concursos = new()
            {
                new ConcursosPorOfertaDto()
                {
                    FormaEntradaKey = FormaEntradaConstants.FormaEntradaSegundaGraduacao.Key,
                    NomeFormaEntrada = FormaEntradaConstants.FormaEntradaSegundaGraduacao.Nome,
                    Concursos = new()
                    {
                        new ConcursosPorOfertaDto.ConcursosFormaEntradaDto()
                        {
                            NomeConcurso = "Concurso 1",
                        }
                    }
                }
            },
            VinculosAnima = new()
            {
                new CandidatoVinculoDto()
                {
                    CodigoStatusAluno = StatusMatricula.Ativo,
                }
            },
            Cpf = "12345678901",
            VigenciaIntake = new(new DateTime(2025, 01, 01), new DateTime(2025, 06, 30)),
        };

        _candidatoRepository
            .Setup(c => c.PesquisarDiarioClasseCandidatoAsync(It.IsAny<string>()))
            .ReturnsAsync(new List<DiarioClasseCandidatoDto>
            {
                new()
                {
                    CodigoStatusAluno = StatusMatricula.Ativo,
                    CodigoStatusDiario = TipoStatusDiarioClasse.Fechado,
                    InicioPeriodoLetivo = new DateTime(2024, 07, 01),
                    TerminoPeriodoLetivo = new DateTime(2024, 12, 31),
                }
            });

        // Act
        var useCase = ObterUseCase();
        var result = await useCase.Handle(request, CancellationToken.None);

        // Assert
        result.Exists(c => c.FormaEntradaKey == FormaEntradaConstants.FormaEntradaSegundaGraduacao.Key).Should().BeFalse();
    }

    private ProcessarRegraConcursoSegundaGraduacaoCommandHandler ObterUseCase()
    {
        return new(_candidatoRepository.Object, _logger.Object);
    }
}