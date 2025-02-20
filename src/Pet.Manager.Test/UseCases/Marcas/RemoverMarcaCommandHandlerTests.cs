using Anima.Inscricao.Application.UseCases.Marcas.RemoverMarca;
using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Marcas;
using Anima.Inscricao.Domain.Marcas.Entities;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test.Extensions;

using Microsoft.Extensions.DependencyInjection;

using Moq;

namespace Anima.Inscricao.Test.UseCases.Marcas;

public class RemoverMarcaCommandHandlerTests
{
    private readonly Mock<INotificationContext> _notificationContext = new();
    private readonly Mock<IMarcaRepository> _marcaRepository = new();
    private readonly Mock<IUnitOfWork> _unitOfWork = new();

    public RemoverMarcaCommandHandlerTests()
    {
        new ServiceExtensions()
            .BuildServiceProvider(new ServiceCollection());
    }

    [Fact]
    public async Task DeveRemoverMarcaComSucessoAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        await useCase.Handle(new RemoverMarcaCommand()
        {
            Key = MarcaConstants.Una.Key,
        }, default);

        // Assert
        _marcaRepository.Verify(x => x.Delete(It.IsAny<Marca>()), Times.Once);
    }


    private RemoverMarcaCommandHandler ObterUseCase()
    {
        _marcaRepository
            .Setup(x => x.GetAsync(MarcaConstants.Una.Key))
            .ReturnsAsync(MarcaConstants.Una);

        return new(
                   _notificationContext.Object,
                   _marcaRepository.Object,
                   _unitOfWork.Object);
    }
}
