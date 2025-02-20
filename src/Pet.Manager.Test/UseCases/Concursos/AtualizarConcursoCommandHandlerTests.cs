using Anima.Inscricao.Application._Shared.DTOs;
using Anima.Inscricao.Application.UseCases.Concursos.AtualizarConcurso;
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
public class AtualizarConcursoCommandHandlerTests
{
    private readonly Mock<INotificationContext> _notificationContextMock = new();
    private readonly Mock<IConcursoRepository> _concursoRepositoryMock = new();
    private readonly Mock<IUnitOfWork> _unitOfWorkMock = new();
    private readonly IFormaEntradaRepository _formaEntradaRepository;
    private readonly ITipoFormacaoRepository _tipoFormacaoRepository;
    private readonly IModalidadeRepository _modalidadeRepository;
    private readonly IIntegracaoSistemaRepository _integracaoSistemaRepository;
    private readonly IModalidadeAvaliacaoRepository _modalidadeAvaliacaoRepository;

    public AtualizarConcursoCommandHandlerTests()
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
    public async Task DeveAtualizarConcursoComSucessoAsync()
    {
        // Arrange
        var concurso = ConcursoConstants.ConcursoVestibular;

        var command = new AtualizarConcursoCommand
        {
            FormasEntrada = new List<EntityKeyDto>() { new EntityKeyDto(FormaEntradaConstants.FormaEntradaEnem.Key) } ,
            TipoFormacaoKey = TipoFormacaoConstants.TipoFormacaoPos.Key,
            ModalidadeKey = ModalidadeConstants.ModalidadeSemiPresencial.Key,
            Key = concurso.Key,
            Nome = "Concurso Teste",
            PeriodoLetivo = "2022/1",
            InicioInscricao = DateTime.Now,
            TerminoInscricao = DateTime.Now.AddDays(7),
            InicioProva = DateTime.Now.AddDays(10),
            TerminoProva = DateTime.Now.AddDays(17),
            DivulgacaoResultado = DateTime.Now.AddDays(20)
        };

        _concursoRepositoryMock.Setup(x => x.GetAsync(command.Key))
            .ReturnsAsync(concurso);

        // Act
        var useCase = ObterUseCase();
        await useCase.Handle(command, CancellationToken.None);

        // Assert
        _concursoRepositoryMock.Verify(x => x.Update(It.Is<Concurso>(c=>
            c.Nome == command.Nome &&
            c.PeriodoLetivo == command.PeriodoLetivo &&
            c.FormasEntrada.Count() == 1 && c.FormasEntrada.Any(x => x.FormaEntradaId == FormaEntradaConstants.FormaEntradaEnem.Id) &&
            c.TiposFormacao.Count() == 1 && c.TiposFormacao.Any(x => x.TipoFormacaoId == TipoFormacaoConstants.TipoFormacaoPos.Id) &&
            c.Modalidades.Count() == 1 && c.Modalidades.Any(x => x.ModalidadeId == ModalidadeConstants.ModalidadeSemiPresencial.Id)
            )), Times.Once);

        _unitOfWorkMock.Verify(x => x.CommitAsync(CancellationToken.None), Times.Once);
    }
   
    private AtualizarConcursoCommandHandler ObterUseCase()
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