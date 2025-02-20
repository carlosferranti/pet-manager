using Anima.Inscricao.Application.UseCases.Intakes.AtualizarIntake;
using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Intakes;
using Anima.Inscricao.Domain.Intakes.Entities;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test.Extensions;

using Microsoft.Extensions.DependencyInjection;

using Moq;

namespace Anima.Inscricao.Test.UseCases.Intakes;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class AtualizarIntakeCommandHandlerTests
{
    private readonly Mock<INotificationContext> _notificationContext = new();
    private readonly Mock<IIntakeRepository> _intakeRepository = new();
    private readonly Mock<IUnitOfWork> _unitOfWork = new();

    public AtualizarIntakeCommandHandlerTests()
    {
        new ServiceExtensions()
            .BuildServiceProvider(new ServiceCollection());
    }

    [Fact]
    public async Task DeveAtualizarIntakeComSucessoAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        await useCase.Handle(new AtualizarIntakeCommand
        {
            Key = IntakeConstants.IntakePrimeiroSemestre.Key,
            VigenciaTermino = DateTime.Now,
            VigenciaInicio = DateTime.Now,
            Nome = "1º intake",
        }, default);

        // Assert
        _intakeRepository.Verify(x => x.Update(It.IsAny<Intake>()), Times.Once);
        _unitOfWork.Verify(x => x.CommitAsync(CancellationToken.None), Times.Once);
    }

    [Fact]
    public async Task NaoDeveAtualizarQuandoInformacoesJaExistemAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        await useCase.Handle(new AtualizarIntakeCommand
        {
            Key = IntakeConstants.IntakePrimeiroSemestre.Key,
            Nome = IntakeConstants.IntakeSegundoSemestre.Nome,
            VigenciaTermino = IntakeConstants.IntakeSegundoSemestre.Vigencia.Termino,
            VigenciaInicio = IntakeConstants.IntakeSegundoSemestre.Vigencia.Inicio,
        }, default);

        // Assert
        _intakeRepository.Verify(x => x.InsertAsync(It.IsAny<Intake>()), Times.Never);
        _unitOfWork.Verify(x => x.CommitAsync(CancellationToken.None), Times.Never);
    }

    private AtualizarIntakeCommandHandler ObterUseCase()
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
