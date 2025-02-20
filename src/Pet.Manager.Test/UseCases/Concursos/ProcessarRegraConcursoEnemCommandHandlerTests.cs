using Anima.Inscricao.Application.DTOs.Concursos;
using Anima.Inscricao.Application.DTOs.Enem;
using Anima.Inscricao.Application.Interfaces.Repositories;
using Anima.Inscricao.Application.Interfaces.Services;
using Anima.Inscricao.Application.UseCases.Concursos.ProcessarRegraConcursoEnem;
using Anima.Inscricao.Application.UseCases.Concursos.ProcessarRegraConcursoInscricaoAtiva;
using Anima.Inscricao.Domain.Concursos;
using Anima.Inscricao.Domain.FormasEntrada;
using Anima.Inscricao.Domain.Intakes;
using Anima.Inscricao.Domain.IntegracaoSistemas;
using Anima.Inscricao.Domain.Marcas;
using Anima.Inscricao.Domain.Modalidades;
using Anima.Inscricao.Domain.OfertaConcursos;
using Anima.Inscricao.Domain.Ofertas;
using Anima.Inscricao.Infra.Data.Oracle.Repositories;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test.Extensions;
using Anima.Inscricoes.Domain.Inscricoes;

using FluentAssertions;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

using Moq;

namespace Anima.Inscricao.Test.UseCases.Concursos;

public class ProcessarRegraConcursoEnemCommandHandlerTests
{
    private readonly Mock<IEnemService> _enemServiceMock = new();
    private readonly Mock<ILogger<ProcessarRegraConcursoEnemCommandHandler>> _loggerMock = new();
    private readonly Mock<IInscricaoRepository> _inscricaoRepository = new();
    private readonly Mock<IConcursoRepository> _concursoRepository = new();
    private readonly Mock<IOfertaConcursoRepository> _ofertaConcursoRepository = new();
    private readonly Mock<IIntakeRepository> _intakeRepository = new();
    private readonly Mock<IMarcaRepository> _marcaRepository = new();
    private readonly Mock<IOfertaRepository> _ofertaRepository = new();
    private readonly Mock<IFormaEntradaRepository> _formaEntradaRepository = new();
    private readonly Mock<IModalidadeRepository> _modalidadeRepository = new();

    public ProcessarRegraConcursoEnemCommandHandlerTests()
    {
        new ServiceExtensions().BuildServiceProvider(new ServiceCollection());
    }

    [Fact]
    public async Task NaoDeveRetornarConcursosQuandoNaoPossuirClassificacaoEnemAsync()
    {
        // Arrange
        _enemServiceMock
            .Setup(x => x.ObterClassificacaoEnemAsync(It.IsAny<ObterClassificacaoResquestDto>()))
            .ReturnsAsync((ClassificacaoEnemDto)null!);


        var handler = ObterUseCase();
        handler
            .Setup(x => x.PossuiInscricaoEnemPraMesmaModalidadeAsync(It.IsAny<Guid>(), It.IsAny<Guid>(), It.IsAny<string>(), It.IsAny<Guid>()))
            .ReturnsAsync(false);

        // Act
        var result = await handler.Object.Handle(new ProcessarRegraConcursoEnemCommand()
        {
            Cpf = "12345678901",
            IntakeKey = IntakeConstants.IntakePrimeiroSemestre.Key,
            MarcaKey = MarcaConstants.Una.Key,
            ModalidadeKey = ModalidadeConstants.ModalidadeLive.Key,
            Concursos = new()
            {
                new ConcursosPorOfertaDto()
                {
                    FormaEntradaKey = FormaEntradaConstants.FormaEntradaEnem.Key,
                    NomeFormaEntrada = FormaEntradaConstants.FormaEntradaEnem.Nome,
                    Concursos = new()
                    {
                        new ConcursosPorOfertaDto.ConcursosFormaEntradaDto()
                        {
                            NomeConcurso = "Concurso 1",
                        }
                    }
                }
            },
        }, CancellationToken.None);

        // Assert
        result.Exists(c => c.FormaEntradaKey == FormaEntradaConstants.FormaEntradaEnem.Key).Should().BeFalse();
    }

    [Fact]
    public async Task NaoDeveRetornarConcursosQuandoNaoTiverCriterioAtendenteAsync()
    {
        // Arrange
        _enemServiceMock
            .Setup(x => x.ObterClassificacaoEnemAsync(It.IsAny<ObterClassificacaoResquestDto>()))
            .ReturnsAsync(new ClassificacaoEnemDto()
            {
                Cpf = "12345678901",
                Criterios = new List<ObterClassificacaoCriterioEnemDto>()
                {
                    new ObterClassificacaoCriterioEnemDto()
                    {
                        Atual = true,
                        Situacao = new ObterClassificacaoCriterioSituacaoEnemDto()
                        {
                            Descricao = "Inconclusivo",
                        }
                    }
                }
            });

        var handler = ObterUseCase();
        handler
            .Setup(x => x.PossuiInscricaoEnemPraMesmaModalidadeAsync(It.IsAny<Guid>(), It.IsAny<Guid>(), It.IsAny<string>(), It.IsAny<Guid>()))
            .ReturnsAsync(false);

        // Act
        var result = await handler.Object.Handle(new ProcessarRegraConcursoEnemCommand()
        {
            Cpf = "12345678901",
            IntakeKey = IntakeConstants.IntakePrimeiroSemestre.Key,
            MarcaKey = MarcaConstants.Una.Key,
            ModalidadeKey = ModalidadeConstants.ModalidadeLive.Key,
            Concursos = new()
            {
                new ConcursosPorOfertaDto()
                {
                    FormaEntradaKey = FormaEntradaConstants.FormaEntradaEnem.Key,
                    NomeFormaEntrada = FormaEntradaConstants.FormaEntradaEnem.Nome,
                    Concursos = new()
                    {
                        new ConcursosPorOfertaDto.ConcursosFormaEntradaDto()
                        {
                            NomeConcurso = "Concurso 1",
                        }
                    }
                }
            },
        }, CancellationToken.None);

        // Assert
        result.Exists(c => c.FormaEntradaKey == FormaEntradaConstants.FormaEntradaEnem.Key).Should().BeFalse();
    }

    [Fact]
    public async Task DeveRetornarConcursosQuandoTiverCriterioAtendenteAsync()
    {
        // Arrange
        _enemServiceMock
            .Setup(x => x.ObterClassificacaoEnemAsync(It.IsAny<ObterClassificacaoResquestDto>()))
            .ReturnsAsync(new ClassificacaoEnemDto()
            {
                Cpf = "12345678901",
                Criterios = new List<ObterClassificacaoCriterioEnemDto>()
                {
                    new ObterClassificacaoCriterioEnemDto()
                    {
                        Atual = true,
                        Situacao = new ObterClassificacaoCriterioSituacaoEnemDto()
                        {
                            Descricao = "Atende",
                        }
                    }
                }
            });

        var handler = ObterUseCase();
        handler
            .Setup(x => x.PossuiInscricaoEnemPraMesmaModalidadeAsync(It.IsAny<Guid>(), It.IsAny<Guid>(), It.IsAny<string>(), It.IsAny<Guid>()))
            .ReturnsAsync(false);

        // Act
        var result = await handler.Object.Handle(new ProcessarRegraConcursoEnemCommand()
        {
            Cpf = "12345678901",
            IntakeKey = IntakeConstants.IntakePrimeiroSemestre.Key,
            MarcaKey = MarcaConstants.Una.Key,
            ModalidadeKey = ModalidadeConstants.ModalidadeLive.Key,
            Concursos = new()
            {
                new ConcursosPorOfertaDto()
                {
                    FormaEntradaKey = FormaEntradaConstants.FormaEntradaEnem.Key,
                    NomeFormaEntrada = FormaEntradaConstants.FormaEntradaEnem.Nome,
                    Concursos = new()
                    {
                        new ConcursosPorOfertaDto.ConcursosFormaEntradaDto()
                        {
                            NomeConcurso = "Concurso 1",
                        }
                    }
                }
            },
        }, CancellationToken.None);

        // Assert
        result.Exists(c => c.FormaEntradaKey == FormaEntradaConstants.FormaEntradaEnem.Key).Should().BeTrue();
    }

    [Fact]
    public async Task DeveRetornarConcursoSimplificadoQuandoTiverPerfilEnemMasTiverInscricaoNaOferta()
    {
        // Arrange
        _enemServiceMock
            .Setup(x => x.ObterClassificacaoEnemAsync(It.IsAny<ObterClassificacaoResquestDto>()))
            .ReturnsAsync(new ClassificacaoEnemDto()
            {
                Cpf = "12345678901",
                Criterios = new List<ObterClassificacaoCriterioEnemDto>()
                {
                    new ObterClassificacaoCriterioEnemDto()
                    {
                        Atual = true,
                        Situacao = new ObterClassificacaoCriterioSituacaoEnemDto()
                        {
                            Descricao = "Atende",
                        }
                    }
                }
            });

        var handler = ObterUseCase();
        handler
            .Setup(x => x.PossuiInscricaoEnemPraMesmaModalidadeAsync(It.IsAny<Guid>(), It.IsAny<Guid>(), It.IsAny<string>(), It.IsAny<Guid>()))
            .ReturnsAsync(true);

        // Act
        var result = await handler.Object.Handle(new ProcessarRegraConcursoEnemCommand()
        {
            Cpf = "12345678901",
            IntakeKey = IntakeConstants.IntakePrimeiroSemestre.Key,
            MarcaKey = MarcaConstants.Una.Key,
            ModalidadeKey = ModalidadeConstants.ModalidadeLive.Key,
            Concursos = new()
            {
                new ConcursosPorOfertaDto()
                {
                    FormaEntradaKey = FormaEntradaConstants.FormaEntradaEnem.Key,
                    NomeFormaEntrada = FormaEntradaConstants.FormaEntradaEnem.Nome,
                    Concursos = new()
                    {
                        new ConcursosPorOfertaDto.ConcursosFormaEntradaDto()
                        {
                            NomeConcurso = "Concurso 1",
                        }
                    }
                },
                new ConcursosPorOfertaDto()
                {
                    FormaEntradaKey = FormaEntradaConstants.FormaEntradaVestibularSimplificado.Key,
                    NomeFormaEntrada = FormaEntradaConstants.FormaEntradaVestibularSimplificado.Nome,
                    Concursos = new()
                    {
                        new ConcursosPorOfertaDto.ConcursosFormaEntradaDto()
                        {
                            NomeConcurso = "Concurso 1",
                        }
                    }
                }
            },
        }, CancellationToken.None);

        // Assert
        result.Exists(c => c.FormaEntradaKey == FormaEntradaConstants.FormaEntradaVestibularSimplificado.Key).Should().BeTrue();
    }

    [Fact]
    public async Task NaoDeveRetornarConcursoSimplificadoQuandoTiverPerfilEnem()
    {
        // Arrange
        _enemServiceMock
            .Setup(x => x.ObterClassificacaoEnemAsync(It.IsAny<ObterClassificacaoResquestDto>()))
            .ReturnsAsync(new ClassificacaoEnemDto()
            {
                Cpf = "12345678901",
                Criterios = new List<ObterClassificacaoCriterioEnemDto>()
                {
                    new ObterClassificacaoCriterioEnemDto()
                    {
                        Atual = true,
                        Situacao = new ObterClassificacaoCriterioSituacaoEnemDto()
                        {
                            Descricao = "Atende",
                        }
                    }
                }
            });

        var handler = ObterUseCase();
        handler
            .Setup(x => x.PossuiInscricaoEnemPraMesmaModalidadeAsync(It.IsAny<Guid>(), It.IsAny<Guid>(), It.IsAny<string>(), It.IsAny<Guid>()))
            .ReturnsAsync(false);

        // Act
        var result = await handler.Object.Handle(new ProcessarRegraConcursoEnemCommand()
        {
            Cpf = "12345678901",
            IntakeKey = IntakeConstants.IntakePrimeiroSemestre.Key,
            MarcaKey = MarcaConstants.Una.Key,
            ModalidadeKey = ModalidadeConstants.ModalidadeLive.Key,
            Concursos = new()
            {
                new ConcursosPorOfertaDto()
                {
                    FormaEntradaKey = FormaEntradaConstants.FormaEntradaEnem.Key,
                    NomeFormaEntrada = FormaEntradaConstants.FormaEntradaEnem.Nome,
                    Concursos = new()
                    {
                        new ConcursosPorOfertaDto.ConcursosFormaEntradaDto()
                        {
                            NomeConcurso = "Concurso 1",
                        }
                    }
                },
                new ConcursosPorOfertaDto()
                {
                    FormaEntradaKey = FormaEntradaConstants.FormaEntradaVestibularSimplificado.Key,
                    NomeFormaEntrada = FormaEntradaConstants.FormaEntradaVestibularSimplificado.Nome,
                    Concursos = new()
                    {
                        new ConcursosPorOfertaDto.ConcursosFormaEntradaDto()
                        {
                            NomeConcurso = "Concurso 1",
                        }
                    }
                }
            },
        }, CancellationToken.None);

        // Assert
        result.Exists(c => c.FormaEntradaKey == FormaEntradaConstants.FormaEntradaVestibularSimplificado.Key).Should().BeFalse();
    }

    private Mock<ProcessarRegraConcursoEnemCommandHandler> ObterUseCase()
    {
        return new Mock<ProcessarRegraConcursoEnemCommandHandler>(
            _enemServiceMock.Object,
            _loggerMock.Object,
            _inscricaoRepository.Object,
            _concursoRepository.Object,
            _ofertaConcursoRepository.Object,
            _intakeRepository.Object,
            _marcaRepository.Object,
            _ofertaRepository.Object,
            _formaEntradaRepository.Object,
            _modalidadeRepository.Object)
        {
            CallBase = true
        };
    }
}