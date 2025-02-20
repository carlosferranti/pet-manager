using Anima.Inscricao.Application.UseCases.Intakes.RemoverIntake;
using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Intakes;
using Anima.Inscricao.Domain.Intakes.Entities;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test.Extensions;

using Microsoft.Extensions.DependencyInjection;

using Moq;

namespace Anima.Inscricao.Test.UseCases.Intakes;

public class RemoverIntakeCommandHandlerTests
{
    private readonly Mock<INotificationContext> _notificationContext = new();
    private readonly Mock<IIntakeRepository> _intakeRepository = new();
    private readonly Mock<IUnitOfWork> _unitOfWork = new();

    public RemoverIntakeCommandHandlerTests()
    {
        new ServiceExtensions()
            .BuildServiceProvider(new ServiceCollection());
    }

    [Fact]
    public async Task DeveRemoverIntakeComSucessoAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        await useCase.Handle(new RemoverIntakeCommand()
        {
            Key = IntakeConstants.IntakePrimeiroSemestre.Key,
        }, default);

        // Assert
        _intakeRepository.Verify(x => x.Delete(It.IsAny<Intake>()), Times.Once);
    }

    private RemoverIntakeCommandHandler ObterUseCase()
    {
        _intakeRepository
            .Setup(x => x.GetAsync(IntakeConstants.IntakePrimeiroSemestre.Key))
            .ReturnsAsync(IntakeConstants.IntakePrimeiroSemestre);

        return new(
                   _notificationContext.Object,
                   _intakeRepository.Object,
                   _unitOfWork.Object);
    }
}
