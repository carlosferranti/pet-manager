using Anima.Inscricao.Application.UseCases.Campi.AtualizarCampus;
using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Campi;
using Anima.Inscricao.Domain.Campi.Entities;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test.Extensions;

using Microsoft.Extensions.DependencyInjection;

using Moq;

namespace Anima.Inscricao.Test.UseCases.Campi;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class AtualizarCampusCommandHandlerTests
{
    private readonly Mock<INotificationContext> _notificationContext = new();
    private readonly Mock<ICampusRepository> _campusRepository = new();
    private readonly Mock<IUnitOfWork> _unitOfWork = new();

    public AtualizarCampusCommandHandlerTests()
    {
        new ServiceExtensions()
            .BuildServiceProvider(new ServiceCollection());
    }

    [Fact]
    public async Task DeveAtualizarCampusComSucessoAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        await useCase.Handle(new AtualizarCampusCommand
        {
            Key = CampusConstants.CampusOlinda.Key,
            Nome = "Alto da Sé",
        }, default);

        // Assert
        _campusRepository.Verify(x => x.Update(It.IsAny<Campus>()), Times.Once);
        _unitOfWork.Verify(x => x.CommitAsync(CancellationToken.None), Times.Once);
    }

    [Fact]
    public async Task NaoDeveAtualizarQuandoNomeJaExisteAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        await useCase.Handle(new AtualizarCampusCommand
        {
            Key = CampusConstants.CampusOlinda.Key,
            Nome = CampusConstants.CampusRecife.Nome,
            NomeComercial = CampusConstants.CampusRecife.NomeComercial,
        }, default);

        // Assert
        _campusRepository.Verify(x => x.Update(It.IsAny<Campus>()), Times.Never);
    }

    [Fact]
    public async Task DeveAtualizarNomeComercialComSucesso()
    {
        var useCase = ObterUseCase();

        await useCase.Handle(new AtualizarCampusCommand
        {
            Key = CampusConstants.CampusOlinda.Key,
            Nome = CampusConstants.CampusOlinda.Nome,
            NomeComercial = "Olinda",
        }, default);

        _campusRepository.Verify(x => x.Update(It.IsAny<Campus>()), Times.Once);

    }

    private AtualizarCampusCommandHandler ObterUseCase()
    {
        _campusRepository.Setup(x => x.GetAsync(CampusConstants.CampusOlinda.Key))
            .ReturnsAsync(CampusConstants.CampusOlinda);

        return new AtualizarCampusCommandHandler(
            _notificationContext.Object,
            _campusRepository.Object,
            _unitOfWork.Object);
    }
}
