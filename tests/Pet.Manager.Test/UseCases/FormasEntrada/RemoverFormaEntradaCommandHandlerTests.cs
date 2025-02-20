using Anima.Inscricao.Application.UseCases.FormasEntrada.RemoverFormaEntrada;
using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.FormasEntrada;
using Anima.Inscricao.Domain.FormasEntrada.Entities;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test.Extensions;

using Microsoft.Extensions.DependencyInjection;

using Moq;

namespace Anima.Inscricao.Test.UseCases.FormasEntrada;

public class RemoverFormaEntradaCommandHandlerTests
{
    private readonly Mock<INotificationContext> _notificationContext = new();
    private readonly Mock<IFormaEntradaRepository> _formaEntradaRepository = new();
    private readonly Mock<IUnitOfWork> _unitOfWork = new();

    public RemoverFormaEntradaCommandHandlerTests()
    {
        new ServiceExtensions()
            .BuildServiceProvider(new ServiceCollection());
    }

    [Fact]
    public async Task DeveRemoverFormaDeEntradaComSucessoAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        await useCase.Handle(new RemoverFormaEntradaCommand()
        {
            Key = FormaEntradaConstants.FormaEntradaVestibular.Key,
        }, default);

        // Assert
        _formaEntradaRepository.Verify(x => x.Delete(It.IsAny<FormaEntrada>()), Times.Once);
    }

    private RemoverFormaEntradaCommandHandler ObterUseCase()
    {
        _formaEntradaRepository
            .Setup(x => x.GetAsync(FormaEntradaConstants.FormaEntradaVestibular.Key))
            .ReturnsAsync(FormaEntradaConstants.FormaEntradaVestibular);

        return new(
                   _notificationContext.Object,
                   _formaEntradaRepository.Object,
                   _unitOfWork.Object);
    }
}
