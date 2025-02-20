using Anima.Inscricao.Application.UseCases.Enderecos.RemoverEstado;
using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Enderecos;
using Anima.Inscricao.Domain.Enderecos.Entities;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test.Extensions;

using Microsoft.Extensions.DependencyInjection;

using Moq;

namespace Anima.Inscricao.Test.UseCases.Enderecos;

public class RemoverEstadoCommandHandlerTests
{
    private readonly Mock<INotificationContext> _notificationContext = new();
    private readonly Mock<IEstadoRepository> _estadoRepository = new();
    private readonly Mock<IUnitOfWork> _unitOfWork = new();

    public RemoverEstadoCommandHandlerTests()
    {
        new ServiceExtensions()
            .BuildServiceProvider(new ServiceCollection());
    }

    [Fact]
    public async Task DeveRemoverEstadoComSucessoAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        await useCase.Handle(new RemoverEstadoCommand()
        {
            Key = EnderecoConstants.EstadoSP.Key,
        }, default);

        // Assert
        _estadoRepository.Verify(x => x.Delete(It.IsAny<Estado>()), Times.Once);
    }

    private RemoverEstadoCommandHandler ObterUseCase()
    {
        _estadoRepository
            .Setup(x => x.GetAsync(EnderecoConstants.EstadoSP.Key))
            .ReturnsAsync(EnderecoConstants.EstadoSP);

        return new(
                   _notificationContext.Object,
                   _estadoRepository.Object,
                   _unitOfWork.Object);
    }
}
