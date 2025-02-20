using Anima.Inscricao.Application.DTOs.Candidatos;
using Anima.Inscricao.Application.DTOs.Concursos;
using Anima.Inscricao.Application.DTOs.Instituicao;
using Anima.Inscricao.Application.Enums;
using Anima.Inscricao.Application.Interfaces.Repositories;
using Anima.Inscricao.Application.UseCases.Concursos.ProcessarRegraConcursoReopcao;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test.Extensions;

using FluentAssertions;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

using Moq;

namespace Anima.Inscricao.Test.UseCases.Concursos;

public class ProcessarRegraConcursoReopcaoCommandHandlerTests
{
    private readonly Mock<ICandidatoRepository> _candidatoRepository = new();
    private readonly Mock<ILogger<ProcessarRegraConcursoReopcaoCommandHandler>> _logger = new();

    public ProcessarRegraConcursoReopcaoCommandHandlerTests()
    {
        new ServiceExtensions().BuildServiceProvider(new ServiceCollection());
    }

    [Fact]
    public async Task NaoDeveRetornarConcursosQuandoNaoHouverVinculosAnimaAsync()
    {
        // Arrange
        var request = new ProcessarRegraConcursoReopcaoCommand
        {
            Concursos = new()
            {
                new()
                {
                    FormaEntradaKey = FormaEntradaConstants.FormaEntradaReopcao.Key,
                    NomeFormaEntrada = FormaEntradaConstants.FormaEntradaReopcao.Nome,
                    Concursos = new()
                    {
                        new ConcursosPorOfertaDto.ConcursosFormaEntradaDto()
                        {
                            NomeConcurso = "Concurso 1",
                        }
                    }
                }
            },
            VinculosAnima = new(),
        };

        // Act
        var useCase = ObterUseCase();
        var result = await useCase.Handle(request, CancellationToken.None);

        // Assert
        result.Exists(c => c.FormaEntradaKey == FormaEntradaConstants.FormaEntradaReopcao.Key).Should().BeFalse();
    }

    [Fact]
    public async Task NaoDeveRetornarConcursosQuandoDiarioClasseNaoEstaFechadoAsync()
    {
        // Arrange
        var request = new ProcessarRegraConcursoReopcaoCommand
        {
            Concursos = new()
            {
                new()
                {
                    FormaEntradaKey = FormaEntradaConstants.FormaEntradaReopcao.Key,
                    NomeFormaEntrada = FormaEntradaConstants.FormaEntradaReopcao.Nome,
                    Concursos = new()
                    {
                        new ConcursosPorOfertaDto.ConcursosFormaEntradaDto()
                        {
                            NomeConcurso = "Concurso 1",
                        }
                    }
                }
            },
            Cpf = "12345678901",
            Instituicao = new()
            {
                Integracoes = new()
                {
                    new()
                    {
                        NomeSistema = "Siaf",
                        CodigoOrigem = "1"
                    }
                }
            },
            VigenciaIntake = new(DateTime.Now.AddMonths(-1), DateTime.Now.AddMonths(6)),
            VinculosAnima = new()
            {
                new CandidatoVinculoDto()
                {
                    CodigoStatusAluno = StatusMatricula.Ativo,
                }
            },
            InstituicaoAssociadas = new()
            {
                new InstituicaoAssociadaVestibDto()
                {
                    CodigoInstituicao = "1",
                    CodigoInstituicaoAssociada = "1",
                    CodigoInstituicaoSiaf = "1",
                }
            },
        };

        _candidatoRepository
            .Setup(c => c.PesquisarDiarioClasseCandidatoAsync(It.IsAny<string>()))
            .ReturnsAsync(new List<DiarioClasseCandidatoDto>
            {
                new()
                {
                    CodigoStatusAluno = StatusMatricula.Ativo,
                    CodigoStatusDiario = TipoStatusDiarioClasse.Emitido,
                    InicioPeriodoLetivo = DateTime.Now.AddMonths(-1),
                    TerminoPeriodoLetivo = DateTime.Now.AddMonths(6),
                }
            });

        // Act
        var useCase = ObterUseCase();
        var result = await useCase.Handle(request, CancellationToken.None);

        // Assert
        result.Exists(c => c.FormaEntradaKey == FormaEntradaConstants.FormaEntradaReopcao.Key).Should().BeFalse();
    }

    [Fact]
    public async Task NaoDeveRetornarConcursosQuandoSemestreDiarioClasseNaoAtendeRegraAsync()
    {
        // Arrange
        var request = new ProcessarRegraConcursoReopcaoCommand
        {
            Concursos = new()
            {
                new()
                {
                    FormaEntradaKey = FormaEntradaConstants.FormaEntradaReopcao.Key,
                    NomeFormaEntrada = FormaEntradaConstants.FormaEntradaReopcao.Nome,
                    Concursos = new()
                    {
                        new ConcursosPorOfertaDto.ConcursosFormaEntradaDto()
                        {
                            NomeConcurso = "Concurso 1",
                        }
                    }
                }
            },
            Cpf = "12345678901",
            Instituicao = new()
            {
                Integracoes = new()
                {
                    new()
                    {
                        NomeSistema = "Siaf",
                        CodigoOrigem = "1"
                    }
                }
            },
            VigenciaIntake = new(new DateTime(2025, 01, 01), new DateTime(2025, 06, 30)),
            VinculosAnima = new()
            {
                new CandidatoVinculoDto()
                {
                    CodigoStatusAluno = StatusMatricula.Ativo,
                    CodigoMarca = 1,
                    CodigoInstituicao = 1,
                }
            },
            InstituicaoAssociadas = new()
            {
                new InstituicaoAssociadaVestibDto()
                {
                    CodigoInstituicao = "1",
                    CodigoInstituicaoAssociada = "1",
                    CodigoInstituicaoSiaf = "1",
                }
            },
        };

        _candidatoRepository
            .Setup(c => c.PesquisarDiarioClasseCandidatoAsync(It.IsAny<string>()))
            .ReturnsAsync(new List<DiarioClasseCandidatoDto>
            {
                new()
                {
                    CodigoStatusAluno = StatusMatricula.Ativo,
                    CodigoStatusDiario = TipoStatusDiarioClasse.Fechado,
                    InicioPeriodoLetivo = new DateTime(2025, 01, 01),
                    TerminoPeriodoLetivo = new DateTime(2025, 06, 30),
                }
            });

        // Act
        var useCase = ObterUseCase();
        var result = await useCase.Handle(request, CancellationToken.None);

        // Assert
        result.Exists(c => c.FormaEntradaKey == FormaEntradaConstants.FormaEntradaReopcao.Key).Should().BeFalse();
    }

    [Fact]
    public async Task DeveRetornarConcursosQuandoDiarioClasseAtendeRegraAsync()
    {
        // Arrange
        var request = new ProcessarRegraConcursoReopcaoCommand
        {
            Concursos = new()
            {
                new()
                {
                    FormaEntradaKey = FormaEntradaConstants.FormaEntradaReopcao.Key,
                    NomeFormaEntrada = FormaEntradaConstants.FormaEntradaReopcao.Nome,
                    Concursos = new()
                    {
                        new ConcursosPorOfertaDto.ConcursosFormaEntradaDto()
                        {
                            NomeConcurso = "Concurso 1",
                        }
                    }
                }
            },
            Cpf = "12345678901",
            Instituicao = new()
            {
                Integracoes = new()
                {
                    new()
                    {
                        NomeSistema = "Siaf",
                        CodigoOrigem = "1"
                    }
                }
            },
            VigenciaIntake = new(new DateTime(2025, 01, 01), new DateTime(2025, 06, 30)),
            VinculosAnima = new()
            {
                new CandidatoVinculoDto()
                {
                    CodigoStatusAluno = StatusMatricula.Ativo,
                    CodigoInstituicao = 1,
                }
            },
            InstituicaoAssociadas = new()
            {
                new InstituicaoAssociadaVestibDto()
                {
                    CodigoInstituicao = "1",
                    CodigoInstituicaoAssociada = "1",
                    CodigoInstituicaoSiaf = "1",
                }
            }
        };

        _candidatoRepository
            .Setup(c => c.PesquisarDiarioClasseCandidatoAsync(It.IsAny<string>()))
            .ReturnsAsync(new List<DiarioClasseCandidatoDto>
            {
                new()
                {
                    CodigoStatusAluno = StatusMatricula.Ativo,
                    CodigoStatusDiario = TipoStatusDiarioClasse.Fechado,
                    InicioPeriodoLetivo = new DateTime(2024, 01, 01),
                    TerminoPeriodoLetivo = new DateTime(2024, 06, 30),
                    CodigoInstituicao = 1,
                }
            });

        // Act
        var useCase = ObterUseCase();
        var result = await useCase.Handle(request, CancellationToken.None);

        // Assert
        result.Exists(c => c.FormaEntradaKey == FormaEntradaConstants.FormaEntradaReopcao.Key).Should().BeTrue();
    }

    private ProcessarRegraConcursoReopcaoCommandHandler ObterUseCase()
    {
        return new(_candidatoRepository.Object, _logger.Object);
    }
}