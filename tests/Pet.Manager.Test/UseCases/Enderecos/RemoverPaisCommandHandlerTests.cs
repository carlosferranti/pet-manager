using Anima.Inscricao.Application.UseCases.Enderecos.RemoverPais;
using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Enderecos;
using Anima.Inscricao.Domain.Enderecos.Entities;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test.Extensions;

using Microsoft.Extensions.DependencyInjection;

using Moq;

namespace Anima.Inscricao.Test.UseCases.Enderecos;

public class RemoverPaisCommandHandlerTests
{
    private readonly Mock<INotificationContext> _notificationContext = new();
    private readonly Mock<IPaisRepository> _paisRepository = new();
    private readonly Mock<IUnitOfWork> _unitOfWork = new();

    public RemoverPaisCommandHandlerTests()
    {
        new ServiceExtensions()
            .BuildServiceProvider(new ServiceCollection());
    }

    [Fact]
    public async Task DeveRemoverPaisComSucessoAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        await useCase.Handle(new RemoverPaisCommand()
        {
            Key = EnderecoConstants.PaisArgentina.Key,
        }, default);

        // Assert
        _paisRepository.Verify(x => x.Delete(It.IsAny<Pais>()), Times.Once);
    }

    private RemoverPaisCommandHandler ObterUseCase()
    {
        _paisRepository
            .Setup(x => x.GetAsync(EnderecoConstants.PaisArgentina.Key))
            .ReturnsAsync(EnderecoConstants.PaisArgentina);

        return new(
                   _notificationContext.Object,
                   _paisRepository.Object,
                   _unitOfWork.Object);
    }
}