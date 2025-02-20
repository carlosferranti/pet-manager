using Anima.Inscricao.Application.DTOs.Concursos;
using Anima.Inscricao.Application.DTOs.Inscricoes;
using Anima.Inscricao.Application.DTOs.SistemasIntegracao;
using Anima.Inscricao.Application.Interfaces.Repositories;
using Anima.Inscricao.Application.UseCases.Concursos.ProcessarRegraConcursoInscricaoAtiva;
using Anima.Inscricao.Domain.Concursos;
using Anima.Inscricao.Domain.FormasEntrada;
using Anima.Inscricao.Domain.Inscricoes.Enums;
using Anima.Inscricao.Domain.Intakes;
using Anima.Inscricao.Domain.IntegracaoSistemas;
using Anima.Inscricao.Domain.Marcas;
using Anima.Inscricao.Domain.OfertaConcursos;
using Anima.Inscricao.Domain.Ofertas;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test.Extensions;
using Anima.Inscricoes.Domain.Inscricoes;

using FluentAssertions;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

using Moq;

namespace Anima.Inscricao.Test.UseCases.Concursos;

public class ProcessarRegraConcursoInscricaoAtivaCommandHandlerTests
{
    private readonly Mock<IInscricaoRepository> _inscricaoRepository = new();
    private readonly Mock<IConcursoRepository> _concursoRepository = new();
    private readonly Mock<IOfertaConcursoRepository> _ofertaConcursoRepository = new();
    private readonly Mock<IIntakeRepository> _intakeRepository = new();
    private readonly Mock<IMarcaRepository> _marcaRepository = new();
    private readonly Mock<IOfertaRepository> _ofertaRepository = new();
    private readonly Mock<IIntegracaoSistemaRepository> _integracaoSistemaRepository = new();
    private readonly Mock<IFormaEntradaRepository> _formaEntradaRepository = new();
    private readonly Mock<ICandidatoRepository> _candidatoRepository = new();
    private readonly Mock<ILogger<ProcessarRegraConcursoInscricaoAtivaCommandHandler>> _logger = new();

    public ProcessarRegraConcursoInscricaoAtivaCommandHandlerTests()
    {
        new ServiceExtensions()
            .BuildServiceProvider(new ServiceCollection());
    }

    [Fact]
    public async Task NaoDeveRetornarConcursosQuandoPossuirOutrasInscricoesAsync()
    {
        // Arrange
        var handler = ObterUseCase();

        var command = new ProcessarRegraConcursoInscricaoAtivaCommand()
        {
            Cpf = "662.045.180-20",
            IntakeKey = IntakeConstants.IntakePrimeiroSemestre.Key,
            MarcaKey = MarcaConstants.Una.Key,
            FormasEntrada = new()
            {
                new ConcursosPorOfertaDto()
                {
                    FormaEntradaKey = FormaEntradaConstants.FormaEntradaVestibularSimplificado.Key,
                    NomeFormaEntrada = FormaEntradaConstants.FormaEntradaVestibularSimplificado.Nome,
                    Concursos = new()
                    {
                        new ConcursosPorOfertaDto.ConcursosFormaEntradaDto()
                        {
                            ConcursoKey = ConcursoConstants.ConcursoVestibularSimplificado.Key,
                            NomeConcurso = "Concurso 1",
                        }
                    }
                }
            },
        };

        _candidatoRepository
        .Setup(x => x.VerificarReprovacaoCandidato(It.IsAny<string>(), It.IsAny<string>()))
        .ReturnsAsync(false);

        _candidatoRepository
         .Setup(x => x.VerificarInscricaoCancelada(It.IsAny<string>(), It.IsAny<string>()))
         .ReturnsAsync(false);

        // Act
        var result = await handler.Object.Handle(command, CancellationToken.None);

        // Assert
        result.Should().BeEmpty();
    }

    private Mock<ProcessarRegraConcursoInscricaoAtivaCommandHandler> ObterUseCase()
    {
        var useCase = new Mock<ProcessarRegraConcursoInscricaoAtivaCommandHandler>(
            _inscricaoRepository.Object,
            _concursoRepository.Object,
            _ofertaConcursoRepository.Object,
            _ofertaRepository.Object,
            _intakeRepository.Object,
            _marcaRepository.Object,
            _integracaoSistemaRepository.Object,
            _formaEntradaRepository.Object,
            _logger.Object,
            _candidatoRepository.Object
        )
        {
            CallBase = true
        };

        useCase
            .Setup(x => x.ObterInscricoesConcluidasAsync(It.IsAny<Guid>(), It.IsAny<Guid>(), It.IsAny<string>()))
            .ReturnsAsync(new List<InscricaoDto>()
            {
                new InscricaoDto()
                {
                    Key = Guid.NewGuid(),
                    Oferta = new()
                    {
                        FormasEntrada = new()
                        {
                            new()
                            {
                                TipoSelecao = TipoSelecaoFormaEntrada.Manual,
                                FormaEntradaKey = FormaEntradaConstants.FormaEntradaVestibularSimplificado.Key,
                            }
                        },
                        Concurso = new()
                        {
                            Integracao = new()
                            {
                                CodigoOrigem = "123"
                            },
                            Key = ConcursoConstants.ConcursoVestibularSimplificado.Key
                        },
                    },
                    Integracoes = new List<SistemaIntegracaoDto>()
                    {
                        new()
                        {
                            CodigoOrigem = "123",
                            NomeSistema = "Vestib"
                        }
                    }
                }
            });

        return useCase;
    }

    [Fact]
    public async Task DeveManterConcursoQuandoAlunoForReprovado()
    {
        // Arrange
        var handler = ObterUseCase();

        var command = new ProcessarRegraConcursoInscricaoAtivaCommand()
        {
            Cpf = "123.456.789-00",
            IntakeKey = IntakeConstants.IntakePrimeiroSemestre.Key,
            MarcaKey = MarcaConstants.Una.Key,
            FormasEntrada = new List<ConcursosPorOfertaDto>()
            {
                new ConcursosPorOfertaDto()
                {
                    FormaEntradaKey = FormaEntradaConstants.FormaEntradaVestibularSimplificado.Key,
                    NomeFormaEntrada = "Vestibular Simplificado",
                    Concursos = new List<ConcursosPorOfertaDto.ConcursosFormaEntradaDto>()
                    {
                        new ConcursosPorOfertaDto.ConcursosFormaEntradaDto()
                        {
                            ConcursoKey = ConcursoConstants.ConcursoVestibularSimplificado.Key,
                            NomeConcurso = "Vestibular Simplificado"
                        }
                    }
                }
            }
        };

        _candidatoRepository
            .Setup(x => x.VerificarReprovacaoCandidato(It.IsAny<string>(), It.IsAny<string>()))
            .ReturnsAsync(true);

        _candidatoRepository
            .Setup(x => x.VerificarInscricaoCancelada(It.IsAny<string>(), It.IsAny<string>()))
            .ReturnsAsync(false);

        // Act
        var result = await handler.Object.Handle(command, CancellationToken.None);

        // Assert
        result.Should().NotBeEmpty();
        result[0].Concursos.Should().ContainSingle();
        result[0].Concursos[0].ConcursoKey.Should().Be(ConcursoConstants.ConcursoVestibularSimplificado.Key);
    }

    [Fact]
    public async Task NaoDeveRetornarConcursosQuandoInscricaoForCancelada()
    {
        // Arrange
        var handler = ObterUseCase();

        var command = new ProcessarRegraConcursoInscricaoAtivaCommand()
        {
            Cpf = "123.456.789-00",
            IntakeKey = IntakeConstants.IntakePrimeiroSemestre.Key,
            MarcaKey = MarcaConstants.Una.Key,
            FormasEntrada = new List<ConcursosPorOfertaDto>()
            {
                new ConcursosPorOfertaDto()
                {
                    FormaEntradaKey = FormaEntradaConstants.FormaEntradaVestibularSimplificado.Key,
                    NomeFormaEntrada = "Vestibular Simplificado",
                    Concursos = new List<ConcursosPorOfertaDto.ConcursosFormaEntradaDto>()
                    {
                        new ConcursosPorOfertaDto.ConcursosFormaEntradaDto()
                        {
                            ConcursoKey = ConcursoConstants.ConcursoVestibularSimplificado.Key,
                            NomeConcurso = "Vestibular Simplificado"
                        }
                    }
                }
            }
        };

        _candidatoRepository
            .Setup(x => x.VerificarReprovacaoCandidato(It.IsAny<string>(), It.IsAny<string>()))
            .ReturnsAsync(false);

        _candidatoRepository
            .Setup(x => x.VerificarInscricaoCancelada(It.IsAny<string>(), It.IsAny<string>()))
            .ReturnsAsync(true);

        // Act
        var result = await handler.Object.Handle(command, CancellationToken.None);

        // Assert
        result.Should().NotBeEmpty();
        result[0].Concursos.Should().ContainSingle();
        result[0].Concursos[0].ConcursoKey.Should().Be(ConcursoConstants.ConcursoVestibularSimplificado.Key);
    }
}
