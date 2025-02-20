using Anima.Inscricao.Application.UseCases.Campos.RemoverCampo;
using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Campos;
using Anima.Inscricao.Domain.Campos.Entities;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test.Extensions;

using Microsoft.Extensions.DependencyInjection;

using Moq;

namespace Anima.Inscricao.Test.UseCases.Campos;

public class RemoverCampoCommandHandlerTests
{
    private readonly Mock<INotificationContext> _notificationContext = new();
    private readonly Mock<ICampoRepository> _campoRepository = new();
    private readonly Mock<IUnitOfWork> _unitOfWork = new();

    public RemoverCampoCommandHandlerTests()
    {
        new ServiceExtensions()
            .BuildServiceProvider(new ServiceCollection());
    }

    [Fact]
    public async Task DeveRemoverCampoComSucessoAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        await useCase.Handle(new RemoverCampoCommand()
        {
            Key = CampoConstants.Email.Key,
        }, default);

        // Assert
        _campoRepository.Verify(x => x.Delete(It.IsAny<Campo>()), Times.Once);
    }

    private RemoverCampoCommandHandler ObterUseCase()
    {
        _campoRepository
            .Setup(x => x.GetAsync(CampoConstants.Email.Key))
            .ReturnsAsync(CampoConstants.Email);

        return new(
                   _notificationContext.Object,
                   _campoRepository.Object,
                   _unitOfWork.Object);
    }
}
