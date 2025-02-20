using Anima.Inscricao.Application.UseCases.Cursos.RemoverCurso;
using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Cursos;
using Anima.Inscricao.Domain.Cursos.Entities;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test.Extensions;

using Microsoft.Extensions.DependencyInjection;

using Moq;

namespace Anima.Inscricao.Test.UseCases.Cursos;

public class RemoverCursoCommandHandlerTests
{
    private readonly Mock<INotificationContext> _notificationContext = new();
    private readonly Mock<ICursoRepository> _cursoRepository = new();
    private readonly Mock<IUnitOfWork> _unitOfWork = new();

    public RemoverCursoCommandHandlerTests()
    {
        new ServiceExtensions()
            .BuildServiceProvider(new ServiceCollection());
    }

    [Fact]
    public async Task DeveRemoverCursoComSucessoAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        await useCase.Handle(new RemoverCursoCommand()
        {
            Key = CursoConstants.CursoDireito.Key,
        }, default);

        // Assert
        _cursoRepository.Verify(x => x.Delete(It.IsAny<Curso>()), Times.Once);
    }

    private RemoverCursoCommandHandler ObterUseCase()
    {
        _cursoRepository
            .Setup(x => x.GetAsync(CursoConstants.CursoDireito.Key))
            .ReturnsAsync(CursoConstants.CursoDireito);

        return new(
                   _notificationContext.Object,
                   _cursoRepository.Object,
                   _unitOfWork.Object);
    }
}
