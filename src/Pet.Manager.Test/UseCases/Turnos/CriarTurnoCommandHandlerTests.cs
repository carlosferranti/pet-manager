using Anima.Inscricao.Application.UseCases.Turnos.CriarTurno;
using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.IntegracaoSistemas;
using Anima.Inscricao.Domain.Modalidades;
using Anima.Inscricao.Domain.Turnos;
using Anima.Inscricao.Domain.Turnos.Entities;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test.Extensions;

using Microsoft.Extensions.DependencyInjection;

using Moq;

namespace Anima.Inscricao.Test.UseCases.Turnos;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class CriarTurnoCommandHandlerTests
{
    private readonly Mock<INotificationContext> _notificationContext = new();
    private readonly Mock<ITurnoRepository> _turnoRepository = new();
    private readonly Mock<IIntegracaoSistemaRepository> _integracaoSistemaRepository = new();
    private readonly Mock<IUnitOfWork> _unitOfWork = new();

    public CriarTurnoCommandHandlerTests()
    {
        new ServiceExtensions()
            .BuildServiceProvider(new ServiceCollection());
    }

    [Fact]
    public async Task DeveInserirTurnoComSucessoAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        await useCase.Handle(new CriarTurnoCommand
        {
            Nome = "Vespertino",
        }, default);

        // Assert
        _turnoRepository.Verify(x => x.InsertAsync(It.IsAny<Turno>()), Times.Once);
        _unitOfWork.Verify(x => x.CommitAsync(CancellationToken.None), Times.Once);
    }

    [Fact]
    public async Task NaoDeveInserirQuandoNomeJaExisteAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        await useCase.Handle(new CriarTurnoCommand
        {
            Nome = TurnoConstants.TurnoTarde.Nome,
        }, default);

        // Assert
        _turnoRepository.Verify(x => x.InsertAsync(It.IsAny<Turno>()), Times.Never);
        _unitOfWork.Verify(x => x.CommitAsync(CancellationToken.None), Times.Never);
    }

    private CriarTurnoCommandHandler ObterUseCase()
    {
        return new CriarTurnoCommandHandler(
            _notificationContext.Object,
            _turnoRepository.Object,
            _integracaoSistemaRepository.Object,
            _unitOfWork.Object);
    }
}
