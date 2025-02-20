using Anima.Inscricao.Application.UseCases.Turnos.AtualizarTurno;
using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Turnos;
using Anima.Inscricao.Domain.Turnos.Entities;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test.Extensions;

using Microsoft.Extensions.DependencyInjection;

using Moq;

namespace Anima.Inscricao.Test.UseCases.Turnos;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class AtualizarTurnoCommandHandlerTest
{
    private readonly Mock<INotificationContext> _notificationContext = new();
    private readonly Mock<ITurnoRepository> _turnoRepository = new();
    private readonly Mock<IUnitOfWork> _unitOfWork = new();

    public AtualizarTurnoCommandHandlerTest()
    {
        new ServiceExtensions()
            .BuildServiceProvider(new ServiceCollection());
    }

    [Fact]
    public async Task DeveAtualizarTurnoComSucessoAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        await useCase.Handle(new AtualizarTurnoCommand
        {
            Key = TurnoConstants.TurnoManha.Key,
            Nome = "Manhã atualizado",
        }, default);

        // Assert
        _turnoRepository.Verify(x => x.Update(It.IsAny<Turno>()), Times.Once);
        _unitOfWork.Verify(x => x.CommitAsync(CancellationToken.None), Times.Once);
    }

    [Fact]
    public async Task NaoDeveAtualizarQuandoNomeJaExisteAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        await useCase.Handle(new AtualizarTurnoCommand
        {
            Key = TurnoConstants.TurnoManha.Key,
            Nome = TurnoConstants.TurnoTarde.Nome,
        }, default);

        // Assert
        _turnoRepository.Verify(x => x.Update(It.IsAny<Turno>()), Times.Never);
        _unitOfWork.Verify(x => x.CommitAsync(CancellationToken.None), Times.Never);
    }

    private AtualizarTurnoCommandHandler ObterUseCase()
    {
        _turnoRepository.Setup(x => x.GetAsync(It.IsAny<Guid>()))
            .ReturnsAsync(TurnoConstants.TurnoManha);

        return new AtualizarTurnoCommandHandler(
            _notificationContext.Object,
            _turnoRepository.Object,
            _unitOfWork.Object);
    }
}
