using Anima.Inscricao.Application.UseCases.Links.RemoverLink;
using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Links;
using Anima.Inscricao.Domain.Links.Entities;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test.Extensions;

using Microsoft.Extensions.DependencyInjection;

using Moq;

namespace Anima.Inscricao.Test.UseCases.Links;

public class RemoverLinkCommandHandlerTests
{
    private readonly Mock<INotificationContext> _notificationContext = new();
    private readonly Mock<ILinkRepository> _linkRepository = new();
    private readonly Mock<IUnitOfWork> _unitOfWork = new();

    public RemoverLinkCommandHandlerTests()
    {
        new ServiceExtensions()
            .BuildServiceProvider(new ServiceCollection());
    }

    [Fact]
    public async Task DeveRemoverLinkComSucessoAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        await useCase.Handle(new RemoverLinkCommand()
        {
            Key = LinkConstants.LinkPadrao.Key,
        }, default);

        // Assert
        _linkRepository.Verify(x => x.Delete(It.IsAny<Link>()), Times.Once);
    }

    private RemoverLinkCommandHandler ObterUseCase()
    {
        _linkRepository
            .Setup(x => x.GetAsync(LinkConstants.LinkPadrao.Key))
            .ReturnsAsync(LinkConstants.LinkPadrao);

        return new(
                   _notificationContext.Object,
                   _linkRepository.Object,
                   _unitOfWork.Object);
    }
}