using Anima.Inscricao.Application.UseCases.Turnos.RemoverTurno;
using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Turnos;
using Anima.Inscricao.Domain.Turnos.Entities;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test.Extensions;

using Microsoft.Extensions.DependencyInjection;

using Moq;

namespace Anima.Inscricao.Test.UseCases.Turnos;

public class RemoverTurnoCommandHandlerTests
{
    private readonly Mock<INotificationContext> _notificationContext = new();
    private readonly Mock<ITurnoRepository> _turnoRepository = new();
    private readonly Mock<IUnitOfWork> _unitOfWork = new();

    public RemoverTurnoCommandHandlerTests()
    {
        new ServiceExtensions()
            .BuildServiceProvider(new ServiceCollection());
    }

    [Fact]
    public async Task DeveRemoverTurnoComSucessoAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        await useCase.Handle(new RemoverTurnoCommand()
        {
            Key = TurnoConstants.TurnoManha.Key,
        }, default);

        // Assert
        _turnoRepository.Verify(x => x.Delete(It.IsAny<Turno>()), Times.Once);
    }

    private RemoverTurnoCommandHandler ObterUseCase()
    {
        _turnoRepository
            .Setup(x => x.GetAsync(TurnoConstants.TurnoManha.Key))
            .ReturnsAsync(TurnoConstants.TurnoManha);

        return new(
                   _notificationContext.Object,
                   _turnoRepository.Object,
                   _unitOfWork.Object);
    }
}
