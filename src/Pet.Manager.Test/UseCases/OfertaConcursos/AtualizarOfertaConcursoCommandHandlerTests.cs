using Anima.Inscricao.Application.UseCases.OfertaConcursos.AtualizarOfertaConcurso;
using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Concursos;
using Anima.Inscricao.Domain.OfertaConcursos;
using Anima.Inscricao.Domain.OfertaConcursos.Entities;
using Anima.Inscricao.Domain.Ofertas;
using Anima.Inscricao.Domain.Ofertas.Entities;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test.Extensions;

using Microsoft.Extensions.DependencyInjection;

using Moq;

namespace Anima.Inscricao.Test.UseCases.OfertaConcursos;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class AtualizarOfertaConcursoCommandHandlerTests
{
    private readonly Mock<INotificationContext> _notificationContextMock = new();
    private readonly Mock<IOfertaConcursoRepository> _ofertaConcursoRepositoryMock = new();
    private readonly Mock<IOfertaRepository> _ofertaRepositoryMock = new();
    private readonly Mock<IConcursoRepository> _concursoRepositoryMock = new();
    private readonly Mock<IUnitOfWork> _unitOfWorkMock = new();

    public AtualizarOfertaConcursoCommandHandlerTests()
    {
        var serviceProvider = new ServiceExtensions().BuildServiceProvider(new ServiceCollection());
    }

    [Fact]
    public async Task DeveAtualizarOfertaConcursoComSucessoAsync()
    {
        // Arrange
        var ofertaConcurso = OfertaConcursoConstants.OfertaConcursoTeste1;
        var command = new AtualizarOfertaConcursoCommand
        {
            Key = ofertaConcurso.Key,
            OfertaKey = OfertaConstants.OfertaTeste2.Key,
            ConcursoKey = ConcursoConstants.ConcursoVestibular.Key
        };

        _ofertaRepositoryMock.Setup(x => x.GetAsync(It.IsAny<Guid>())).ReturnsAsync(OfertaConstants.OfertaTeste1);
        _concursoRepositoryMock.Setup(x => x.GetAsync(It.IsAny<Guid>())).ReturnsAsync(ConcursoConstants.ConcursoEnem);
        _ofertaConcursoRepositoryMock.Setup(x => x.GetAsync(It.IsAny<Guid>())).ReturnsAsync(ofertaConcurso);

        var useCase = ObterUseCase();

        // Act
        await useCase.Handle(command, CancellationToken.None);

        // Assert
        _ofertaConcursoRepositoryMock.Verify(x => x.Update(It.IsAny<OfertaConcurso>()), Times.Once);
        _unitOfWorkMock.Verify(x => x.CommitAsync(CancellationToken.None), Times.Once);
    }

    private AtualizarOfertaConcursoCommandHandler ObterUseCase()
    {
        return new(_notificationContextMock.Object,
             _ofertaConcursoRepositoryMock.Object,
            _ofertaRepositoryMock.Object,
            _concursoRepositoryMock.Object,
            _unitOfWorkMock.Object);
    }
}
