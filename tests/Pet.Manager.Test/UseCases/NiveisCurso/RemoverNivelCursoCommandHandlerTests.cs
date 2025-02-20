using Anima.Inscricao.Application.UseCases.NiveisCurso.RemoverNivelCurso;
using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.NiveisCurso;
using Anima.Inscricao.Domain.NiveisCurso.Entities;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test.Extensions;

using Microsoft.Extensions.DependencyInjection;

using Moq;

namespace Anima.Inscricao.Test.UseCases.NiveisCurso;

public class RemoverNivelCursoCommandHandlerTests
{
    private readonly Mock<INotificationContext> _notificationContext = new();
    private readonly Mock<INivelCursoRepository> _nivelCursoRepository = new();
    private readonly Mock<IUnitOfWork> _unitOfWork = new();

    public RemoverNivelCursoCommandHandlerTests()
    {
        new ServiceExtensions()
            .BuildServiceProvider(new ServiceCollection());
    }

    [Fact]
    public async Task DeveRemoverNivelCursoComSucessoAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        await useCase.Handle(new RemoverNivelCursoCommand()
        {
            Key = NivelCursoConstants.Licenciatura.Key,
        }, default);

        // Assert
        _nivelCursoRepository.Verify(x => x.Delete(It.IsAny<NivelCurso>()), Times.Once);
    }

    private RemoverNivelCursoCommandHandler ObterUseCase()
    {
        _nivelCursoRepository
            .Setup(x => x.GetAsync(NivelCursoConstants.Licenciatura.Key))
            .ReturnsAsync(NivelCursoConstants.Licenciatura);

        return new(
                   _notificationContext.Object,
                   _nivelCursoRepository.Object,
                   _unitOfWork.Object);
    }
}
