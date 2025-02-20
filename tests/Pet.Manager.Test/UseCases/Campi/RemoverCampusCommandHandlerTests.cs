using Anima.Inscricao.Application.UseCases.Campi.RemoverCampus;
using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Campi;
using Anima.Inscricao.Domain.Campi.Entities;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test.Extensions;

using Microsoft.Extensions.DependencyInjection;

using Moq;

namespace Anima.Inscricao.Test.UseCases.Campi;

public class RemoverCampusCommandHandlerTests
{
    private readonly Mock<INotificationContext> _notificationContext = new();
    private readonly Mock<ICampusRepository> _campusRepository = new();
    private readonly Mock<IUnitOfWork> _unitOfWork = new();

    public RemoverCampusCommandHandlerTests()
    {
        new ServiceExtensions()
            .BuildServiceProvider(new ServiceCollection());
    }

    [Fact]
    public async Task DeveRemoverCampusComSucessoAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        await useCase.Handle(new RemoverCampusCommand()
        {
            Key = CampusConstants.CampusRecife.Key,
        }, default);

        // Assert
        _campusRepository.Verify(x => x.Delete(It.IsAny<Campus>()), Times.Once);
    }

    private RemoverCampusCommandHandler ObterUseCase()
    {
        _campusRepository
            .Setup(x => x.GetAsync(CampusConstants.CampusRecife.Key))
            .ReturnsAsync(CampusConstants.CampusRecife);

        return new(
                   _notificationContext.Object,
                   _campusRepository.Object,
                   _unitOfWork.Object);
    }
}
