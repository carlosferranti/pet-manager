using Anima.Inscricao.Application.UseCases.Campos.CriarCampo;
using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Campos;
using Anima.Inscricao.Domain.Campos.Entities;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test.Extensions;

using Microsoft.Extensions.DependencyInjection;

using Moq;

namespace Anima.Inscricao.Test.UseCases.Campos;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class CriarCampoCommandHandlerTests
{
    private readonly Mock<INotificationContext> _notificationContext = new();
    private readonly Mock<ICampoRepository> _campoRepository = new();
    private readonly Mock<IUnitOfWork> _unitOfWork = new();

    public CriarCampoCommandHandlerTests()
    {
        new ServiceExtensions()
            .BuildServiceProvider(new ServiceCollection());
    }

    [Fact]
    public async Task DeveInserirCampoComSucessoAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        await useCase.Handle(new CriarCampoCommand
        {
            Nome = "Telefone",
        }, default);

        // Assert
        _campoRepository.Verify(x => x.InsertAsync(It.IsAny<Campo>()), Times.Once);
        _unitOfWork.Verify(x => x.CommitAsync(CancellationToken.None), Times.Once);
    }

    [Fact]
    public async Task NaoDeveInserirQuandoNomeJaExisteAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        await useCase.Handle(new CriarCampoCommand
        {
            Nome = CampoConstants.CPF.Nome,
        }, default);

        // Assert
        _campoRepository.Verify(x => x.InsertAsync(It.IsAny<Campo>()), Times.Never);
        _unitOfWork.Verify(x => x.CommitAsync(CancellationToken.None), Times.Never);
    }

    private CriarCampoCommandHandler ObterUseCase()
    {
        return new CriarCampoCommandHandler(
            _notificationContext.Object,
            _campoRepository.Object,
            _unitOfWork.Object);
    }
}
