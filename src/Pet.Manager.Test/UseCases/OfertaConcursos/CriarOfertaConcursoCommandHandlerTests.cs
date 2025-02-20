using Anima.Inscricao.Application.UseCases.OfertaConcursos.CriarOfertaConcurso;
using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Concursos;
using Anima.Inscricao.Domain.IntegracaoSistemas;
using Anima.Inscricao.Domain.OfertaConcursos;
using Anima.Inscricao.Domain.OfertaConcursos.Entities;
using Anima.Inscricao.Domain.Ofertas;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test.Extensions;

using Microsoft.Extensions.DependencyInjection;

using Moq;

namespace Anima.Inscricao.Test.UseCases.OfertaConcursos;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class CriarOfertaConcursoCommandHandlerTests
{
    private readonly Mock<INotificationContext> _notificationContext = new();
    private readonly Mock<IOfertaConcursoRepository> _ofertaConcursoRepository = new();
    private readonly IOfertaRepository _ofertaRepository;
    private readonly IConcursoRepository _concursoRepository;
    private readonly Mock<IUnitOfWork> _unitOfWork = new();
    private readonly IIntegracaoSistemaRepository _integracaoSistemasRepository;

    public CriarOfertaConcursoCommandHandlerTests()
    {
        var serviceProvider = new ServiceExtensions()
            .BuildServiceProvider(new ServiceCollection());

        _ofertaRepository = serviceProvider.GetRequiredService<IOfertaRepository>();
        _concursoRepository = serviceProvider.GetRequiredService<IConcursoRepository>();
        _integracaoSistemasRepository = serviceProvider.GetRequiredService<IIntegracaoSistemaRepository>();
    }

    [Fact]

    public async Task DeveInserirOfertaConcursoComSucessoAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        await useCase.Handle(new CriarOfertaConcursoCommand
        {
            OfertaKey = OfertaConstants.OfertaTeste1.Key,
            ConcursoKey = ConcursoConstants.ConcursoEnem.Key,

        }, default);

        // Assert
        _ofertaConcursoRepository.Verify(x => x.InsertAsync(It.IsAny<OfertaConcurso>()), Times.Once);
        _unitOfWork.Verify(x => x.CommitAsync(CancellationToken.None), Times.Once);
    }

    [Fact]
    public async Task NaoDeveInserirOfertaConcursoQuandoInformacoesJaExistemAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        await useCase.Handle(new CriarOfertaConcursoCommand
        {
            OfertaKey = OfertaConstants.OfertaTeste1.Key,
            ConcursoKey = ConcursoConstants.ConcursoVestibular.Key,

        }, default);

        // Assert
        _ofertaConcursoRepository.Verify(x => x.InsertAsync(It.IsAny<OfertaConcurso>()), Times.Never);
        _unitOfWork.Verify(x => x.CommitAsync(CancellationToken.None), Times.Never);
    }

    private CriarOfertaConcursoCommandHandler ObterUseCase()
    {
        return new(
            _notificationContext.Object,
            _ofertaConcursoRepository.Object,
            _ofertaRepository,
            _concursoRepository,
            _integracaoSistemasRepository,
            _unitOfWork.Object);
    }
}
