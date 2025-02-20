using Anima.Inscricao.Application.DTOs.Concursos;
using Anima.Inscricao.Application.Enums;
using Anima.Inscricao.Application.UseCases.Concursos.ProcessarRegraTransferencia;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test.Extensions;

using FluentAssertions;

using Microsoft.Extensions.DependencyInjection;

namespace Anima.Inscricao.Test.UseCases.Concursos;

public class ProcessarRegraConcursoTransferenciaCommandHandlerTests
{
    public ProcessarRegraConcursoTransferenciaCommandHandlerTests()
    {
        new ServiceExtensions().BuildServiceProvider(new ServiceCollection());
    }

    [Fact]
    public async Task DeveRetornarConcursosQuandoNaoHouverVinculosAnimaAsync()
    {
        // Arrange
        var request = new ProcessarRegraConcursoTransferenciaCommand
        {
            Concursos = new()
            {
                new ConcursosPorOfertaDto()
                {
                    FormaEntradaKey = FormaEntradaConstants.FormaEntradaTransferencia.Key,
                    NomeFormaEntrada = FormaEntradaConstants.FormaEntradaTransferencia.Nome,
                    Concursos = new()
                    {
                        new ConcursosPorOfertaDto.ConcursosFormaEntradaDto()
                        {
                            NomeConcurso = "Concurso 1",
                        }
                    },
                }
            },
            VinculosAnima = new(),
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
        };

        // Act
        var useCase = ObterUseCase();
        var result = await useCase.Handle(request, CancellationToken.None);

        // Assert
        result.Exists(c => c.FormaEntradaKey == FormaEntradaConstants.FormaEntradaTransferencia.Key).Should().BeTrue();
    }

    [Fact]
    public async Task DeveRetornarConcursosQuandoVinculosAnimaAtendemRegraDeEntradaAsync()
    {
        // Arrange
        var request = new ProcessarRegraConcursoTransferenciaCommand
        {
            Concursos = new()
            {
                new ConcursosPorOfertaDto()
                {
                    FormaEntradaKey = FormaEntradaConstants.FormaEntradaTransferencia.Key,
                    NomeFormaEntrada = FormaEntradaConstants.FormaEntradaTransferencia.Nome,
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
                new()
                {
                    CodigoStatusAluno = StatusMatricula.Ativo,
                    DataEntrada = DateTime.Now.AddYears(-1),
                }
            },
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
            VigenciaIntake = new(DateTime.Now.AddMonths(-1), DateTime.Now.AddMonths(6))
        };

        // Act
        var useCase = ObterUseCase();
        var result = await useCase.Handle(request, CancellationToken.None);

        // Assert
        result.Exists(c => c.FormaEntradaKey == FormaEntradaConstants.FormaEntradaTransferencia.Key).Should().BeTrue();
    }

    [Fact]
    public async Task NaoDeveRetornarConcursosQuandoVinculosAnimaNaoAtendemRegraDeEntradaAsync()
    {
        // Arrange
        var request = new ProcessarRegraConcursoTransferenciaCommand
        {
            Concursos = new()
            {
                new ConcursosPorOfertaDto()
                {
                    FormaEntradaKey = FormaEntradaConstants.FormaEntradaTransferencia.Key,
                    NomeFormaEntrada = FormaEntradaConstants.FormaEntradaTransferencia.Nome,
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
                new()
                {
                    CodigoStatusAluno = StatusMatricula.Ativo,
                    DataEntrada = DateTime.Now,
                    CodigoInstituicao = 1,
                }
            },
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
            VigenciaIntake = new(DateTime.Now.AddMonths(-1), DateTime.Now.AddMonths(6))
        };

        // Act
        var useCase = ObterUseCase();
        var result = await useCase.Handle(request, CancellationToken.None);

        // Assert
        result.Exists(c => c.FormaEntradaKey == FormaEntradaConstants.FormaEntradaTransferencia.Key).Should().BeFalse();
    }

    private ProcessarRegraConcursoTransferenciaCommandHandler ObterUseCase()
    {
        return new();
    }
}