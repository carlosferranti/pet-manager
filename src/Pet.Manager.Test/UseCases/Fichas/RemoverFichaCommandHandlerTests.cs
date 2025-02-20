using Anima.Inscricao.Application.UseCases.Fichas.RemoverFicha;
using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Fichas;
using Anima.Inscricao.Domain.Fichas.Entities;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test.Extensions;

using Microsoft.Extensions.DependencyInjection;

using Moq;

namespace Anima.Inscricao.Test.UseCases.Fichas;

public class RemoverFichaCommandHandlerTests
{
    private readonly Mock<INotificationContext> _notificationContext = new();
    private readonly Mock<IFichaRepository> _fichaRepository = new();
    private readonly Mock<IUnitOfWork> _unitOfWork = new();

    public RemoverFichaCommandHandlerTests()
    {
        new ServiceExtensions()
            .BuildServiceProvider(new ServiceCollection());
    }

    [Fact]
    public async Task DeveRemoverFichaComSucessoAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        await useCase.Handle(new RemoverFichaCommand()
        {
            Key = FichaConstants.FichaPadrao.Key,
        }, default);

        // Assert
        _fichaRepository.Verify(x => x.Delete(It.IsAny<Ficha>()), Times.Once);
    }

    private RemoverFichaCommandHandler ObterUseCase()
    {
        _fichaRepository
            .Setup(x => x.GetAsync(FichaConstants.FichaPadrao.Key))
            .ReturnsAsync(FichaConstants.FichaPadrao);

        return new(
                   _notificationContext.Object,
                   _fichaRepository.Object,
                   _unitOfWork.Object);
    }
}