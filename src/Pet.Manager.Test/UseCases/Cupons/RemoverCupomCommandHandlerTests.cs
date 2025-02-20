using Anima.Inscricao.Application.UseCases.Cupons.RemoverCupom;
using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Cupons;
using Anima.Inscricao.Domain.Cupons.Entities;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test.Extensions;

using Microsoft.Extensions.DependencyInjection;

using Moq;

namespace Anima.Inscricao.Test.UseCases.Cupons;

public class RemoverCupomCommandHandlerTests
{
    private readonly Mock<INotificationContext> _notificationContext = new();
    private readonly Mock<ICupomRepository> _cupomRepository = new();
    private readonly Mock<IUnitOfWork> _unitOfWork = new();

    public RemoverCupomCommandHandlerTests()
    {
        new ServiceExtensions()
            .BuildServiceProvider(new ServiceCollection());
    }

    [Fact]
    public async Task DeveRemoverCupomComSucessoAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        await useCase.Handle(new RemoverCupomCommand()
        {
            Key = CupomConstants.CupomPablo100.Key,
        }, default);

        // Assert
        _cupomRepository.Verify(x => x.Delete(It.IsAny<Cupom>()), Times.Once);
    }

    private RemoverCupomCommandHandler ObterUseCase()
    {
        _cupomRepository
            .Setup(x => x.GetAsync(CupomConstants.CupomPablo100.Key))
            .ReturnsAsync(CupomConstants.CupomPablo100);

        return new(
                   _notificationContext.Object,
                   _cupomRepository.Object,
                   _unitOfWork.Object);
    }
}
