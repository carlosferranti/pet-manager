using Anima.Inscricao.Application.DTOs.Concursos;
using Anima.Inscricao.Application.Enums;
using Anima.Inscricao.Application.UseCases.Concursos.ProcessarRegraConcursoDestrancamentoReopcao;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test.Extensions;

using FluentAssertions;

using Microsoft.Extensions.DependencyInjection;

namespace Anima.Inscricao.Test.UseCases.Concursos;

public class ProcessarRegraConcursoDestrancamentoRetornoCommandHandlerTests
{
    public ProcessarRegraConcursoDestrancamentoRetornoCommandHandlerTests()
    {
        new ServiceExtensions().BuildServiceProvider(new ServiceCollection());
    }

    [Fact]
    public async Task NaoDeveRetornarConcursosQuandoNaoHouverVinculosAnimaAsync()
    {
        // Arrange
        var request = new ProcessarRegraConcursoDestrancamentoRetornoCommand
        {
            Concursos = new()
            {
                new ConcursosPorOfertaDto()
                {
                    FormaEntradaKey = FormaEntradaConstants.FormaEntradaDestrancamentoRetorno.Key,
                    NomeFormaEntrada = FormaEntradaConstants.FormaEntradaDestrancamentoRetorno.Nome,
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
        result.Exists(c => c.FormaEntradaKey == FormaEntradaConstants.FormaEntradaDestrancamentoRetorno.Key).Should().BeFalse();
    }

    [Fact]
    public async Task DeveRetornarConcursosQuandoHouverVinculosAnimaAsync()
    {
        // Arrange
        var request = new ProcessarRegraConcursoDestrancamentoRetornoCommand
        {
            Concursos = new()
            {
                new ConcursosPorOfertaDto()
                {
                    FormaEntradaKey = FormaEntradaConstants.FormaEntradaDestrancamentoRetorno.Key,
                    NomeFormaEntrada = FormaEntradaConstants.FormaEntradaDestrancamentoRetorno.Nome,
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
                new ()
                {
                    CodigoStatusAluno = StatusMatricula.Trancado,
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
            }
        };

        // Act
        var useCase = ObterUseCase();
        var result = await useCase.Handle(request, CancellationToken.None);

        // Assert
        result.Exists(c => c.FormaEntradaKey == FormaEntradaConstants.FormaEntradaDestrancamentoRetorno.Key).Should().BeTrue();
    }

    private ProcessarRegraConcursoDestrancamentoRetornoCommandHandler ObterUseCase()
    {
        return new();
    }
}