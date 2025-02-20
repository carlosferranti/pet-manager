using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.OfertaConcursos;
using Microsoft.Extensions.DependencyInjection;
using Anima.Inscricao.Test.Extensions;

using Moq;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Application.UseCases.OfertaConcursos.RemoverOfertaConcurso;
using Anima.Inscricao.Domain.OfertaConcursos.Entities;

namespace Anima.Inscricao.Test.UseCases.OfertaConcursos;

public class RemoverOfertaConcursoCommandHandlerTests
{
    private readonly Mock<INotificationContext> _notificationContext = new();
    private readonly Mock<IOfertaConcursoRepository> _ofertaConcursoRepository = new();
    private readonly Mock<IUnitOfWork> _unitOfWork = new();

    public RemoverOfertaConcursoCommandHandlerTests()
    {
        new ServiceExtensions()
            .BuildServiceProvider(new ServiceCollection());
    }

    [Fact]
    public async Task DeveRemoverOfertaConcursoComSucessoAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        await useCase.Handle(new RemoverOfertaConcursoCommand()
        {
            Key = OfertaConcursoConstants.OfertaConcursoTeste1.Key,
        }, default);

        // Assert
        _ofertaConcursoRepository.Verify(x => x.Delete(It.IsAny<OfertaConcurso>()), Times.Once);
    }

    private RemoverOfertaConcursoCommandHandler ObterUseCase()
    {
        _ofertaConcursoRepository
         .Setup(x => x.GetAsync(OfertaConcursoConstants.OfertaConcursoTeste1.Key))
         .ReturnsAsync(OfertaConcursoConstants.OfertaConcursoTeste1);

        return new(_notificationContext.Object,
             _ofertaConcursoRepository.Object,
            _unitOfWork.Object);
    }
}
