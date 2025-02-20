using Anima.Inscricao.Application.UseCases.Concursos.RemoverConcurso;
using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Concursos;
using Anima.Inscricao.Domain.Concursos.Entities;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test.Extensions;

using Microsoft.Extensions.DependencyInjection;

using Moq;

namespace Anima.Inscricao.Test.UseCases.Concursos;

public class RemoverConcursoCommandHandlerTests
{
    private readonly Mock<INotificationContext> _notificationContext = new();
    private readonly Mock<IConcursoRepository> _concursoRepository = new();
    private readonly Mock<IUnitOfWork> _unitOfWork = new();

    public RemoverConcursoCommandHandlerTests()
    {
        new ServiceExtensions()
            .BuildServiceProvider(new ServiceCollection());
    }

    [Fact]
    public async Task DeveRemoverConcursoComSucessoAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        await useCase.Handle(new RemoverConcursoCommand()
        {
            Key = ConcursoConstants.ConcursoVestibular.Key,
        }, default);

        // Assert
        _concursoRepository.Verify(x => x.Delete(It.IsAny<Concurso>()), Times.Once);
    }

    private RemoverConcursoCommandHandler ObterUseCase()
    {
        _concursoRepository
            .Setup(x => x.GetAsync(ConcursoConstants.ConcursoVestibular.Key))
            .ReturnsAsync(ConcursoConstants.ConcursoVestibular);

        return new(
                   _notificationContext.Object,
                   _concursoRepository.Object,
                   _unitOfWork.Object);
    }
}