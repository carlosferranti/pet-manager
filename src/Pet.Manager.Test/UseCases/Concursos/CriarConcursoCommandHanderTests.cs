using Anima.Inscricao.Application._Shared.DTOs;
using Anima.Inscricao.Application.DTOs.Concursos;
using Anima.Inscricao.Application.DTOs.SistemasIntegracao;
using Anima.Inscricao.Application.UseCases.Concursos.CriarConcurso;
using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Concursos;
using Anima.Inscricao.Domain.Concursos.Entities;
using Anima.Inscricao.Domain.FormasEntrada;
using Anima.Inscricao.Domain.IntegracaoSistemas;
using Anima.Inscricao.Domain.Modalidades;
using Anima.Inscricao.Domain.ModalidadesAvaliacao;
using Anima.Inscricao.Domain.TiposFormacao;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test.Extensions;

using Microsoft.Extensions.DependencyInjection;

using Moq;

namespace Anima.Inscricao.Test.UseCases.Concursos;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class CriarConcursoCommandHanderTests
{
    private readonly Mock<INotificationContext> _notificationContextMock = new();
    private readonly Mock<IConcursoRepository> _concursoRepositoryMock = new();
    private readonly Mock<IUnitOfWork> _unitOfWorkMock = new();
    private readonly IFormaEntradaRepository _formaEntradaRepository;
    private readonly ITipoFormacaoRepository _tipoFormacaoRepository;
    private readonly IModalidadeRepository _modalidadeRepository;
    private readonly IIntegracaoSistemaRepository _integracaoSistemaRepository;
    private readonly IModalidadeAvaliacaoRepository _modalidadeAvaliacaoRepository;

    public CriarConcursoCommandHanderTests()
    {
        var serviceProvider = new ServiceExtensions()
            .BuildServiceProvider(new ServiceCollection());

        _formaEntradaRepository = serviceProvider.GetRequiredService<IFormaEntradaRepository>();
        _tipoFormacaoRepository = serviceProvider.GetRequiredService<ITipoFormacaoRepository>();
        _modalidadeRepository = serviceProvider.GetRequiredService<IModalidadeRepository>();
        _integracaoSistemaRepository = serviceProvider.GetRequiredService<IIntegracaoSistemaRepository>();
        _modalidadeAvaliacaoRepository = serviceProvider.GetRequiredService<IModalidadeAvaliacaoRepository>();
    }

    [Fact]
    public async Task DeveCriarConcursoComSucessoAsync()
    {
        // Arrange
        var command = new CriarConcursoCommand
        {
            FormasEntrada = new List<EntityKeyDto>()
            {
                new EntityKeyDto(FormaEntradaConstants.FormaEntradaEnem.Key),
            },
            TipoFormacaoKey = TipoFormacaoConstants.TipoFormacaoPos.Key,
            ModalidadeKey = ModalidadeConstants.ModalidadeSemiPresencial.Key,
            Nome = "Concurso Teste",
            PeriodoLetivo = "2022/1",
            InicioInscricao = DateTime.Now,
            TerminoInscricao = DateTime.Now.AddDays(7),
            InicioProva = DateTime.Now.AddDays(10),
            TerminoProva = DateTime.Now.AddDays(17),
            DivulgacaoResultado = DateTime.Now.AddDays(20),
            Parametros = new ConcursoParametrosDto
            {
                ExigeAceiteDeferimento = true,
                RecebeDocumentoConclusaoEnsinoSuperior = true,
                SolicitaAnoInscricaoEnem = true,
            },
            Integracao = new SistemaIntegracaoDto
            {
                CodigoOrigem = "123",
                NomeSistema = IntegracaoSistemaConstants.IntegracaoSistemaPortfolio.Nome,
            }
        };

        // Act
        var useCase = ObterUseCase();
        await useCase.Handle(command, CancellationToken.None);

        // Assert
        _concursoRepositoryMock.Verify(x => x.InsertAsync(It.Is<Concurso>(c =>
            c.Nome == command.Nome &&
            c.PeriodoLetivo == command.PeriodoLetivo &&
            c.VigenciaInscricao.Inicio == command.InicioInscricao &&
            c.VigenciaInscricao.Termino == command.TerminoInscricao &&
            c.InicioProva == command.InicioProva &&
            c.TerminoProva == command.TerminoProva &&
            c.ConcursoParametros.ExigeAceiteDeferimento == command.Parametros.ExigeAceiteDeferimento &&
            c.ConcursoParametros.RecebeDocumentoConclusaoEnsinoSuperior == command.Parametros.RecebeDocumentoConclusaoEnsinoSuperior &&
            c.ConcursoParametros.SolicitaAnoInscricaoEnem == command.Parametros.SolicitaAnoInscricaoEnem &&
            c.IntegracaoConcurso!.CodigoOrigem == command.Integracao.CodigoOrigem &&
            c.IntegracaoConcurso.IntegracaoSistemaId == IntegracaoSistemaConstants.IntegracaoSistemaPortfolio.Id &&
            c.FormasEntrada.Count() == 1 && c.FormasEntrada.Any(x => x.FormaEntradaId == FormaEntradaConstants.FormaEntradaEnem.Id) &&
            c.TiposFormacao.Count() == 1 && c.TiposFormacao.Any(x => x.TipoFormacaoId == TipoFormacaoConstants.TipoFormacaoPos.Id) &&
            c.Modalidades.Count() == 1 && c.Modalidades.Any(x => x.ModalidadeId == ModalidadeConstants.ModalidadeSemiPresencial.Id)
            )), Times.Once);

        _unitOfWorkMock.Verify(x => x.CommitAsync(CancellationToken.None), Times.Once);
    }

    private CriarConcursoCommandHander ObterUseCase()
    {
        return new(
            _notificationContextMock.Object,
            _concursoRepositoryMock.Object,
            _formaEntradaRepository,
            _tipoFormacaoRepository,
            _modalidadeRepository,
            _integracaoSistemaRepository,
            _modalidadeAvaliacaoRepository,
            _unitOfWorkMock.Object);
    }
}