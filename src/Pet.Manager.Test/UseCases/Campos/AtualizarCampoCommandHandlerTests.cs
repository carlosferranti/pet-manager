using Anima.Inscricao.Application.UseCases.Campos.AtualizarCampo;
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
public class AtualizarCampoCommandHandlerTests
{
    private readonly Mock<INotificationContext> _notificationContext = new();
    private readonly Mock<ICampoRepository> _campoRepository = new();
    private readonly Mock<IUnitOfWork> _unitOfWork = new();

    public AtualizarCampoCommandHandlerTests()
    {
        new ServiceExtensions()
            .BuildServiceProvider(new ServiceCollection());
    }

    [Fact]
    public async Task DeveAtualizarCampoComSucessoAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        await useCase.Handle(new AtualizarCampoCommand
        {
            Key = CampoConstants.Email.Key,
            Nome = "E-mail",
        }, default);

        // Assert
        _campoRepository.Verify(x => x.Update(It.IsAny<Campo>()), Times.Once);
        _unitOfWork.Verify(x => x.CommitAsync(CancellationToken.None), Times.Once);
    }

    [Fact]
    public async Task NaoDeveAtualizarQuandoNomeJaExisteAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        await useCase.Handle(new AtualizarCampoCommand
        {
            Key = CampoConstants.Email.Key,
            Nome = CampoConstants.CPF.Nome,
        }, default);

        // Assert
        _campoRepository.Verify(x => x.Update(It.IsAny<Campo>()), Times.Never);
    }

    private AtualizarCampoCommandHandler ObterUseCase()
    {
        _campoRepository
            .Setup(x => x.GetAsync(CampoConstants.Email.Key))
            .ReturnsAsync(CampoConstants.Email);

        return new AtualizarCampoCommandHandler(
            _notificationContext.Object,
            _campoRepository.Object,
            _unitOfWork.Object);
    }
}
