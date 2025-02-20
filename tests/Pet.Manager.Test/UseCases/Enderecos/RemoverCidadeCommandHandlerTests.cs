using Anima.Inscricao.Application.UseCases.Enderecos.RemoverCidade;
using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Enderecos;
using Anima.Inscricao.Domain.Enderecos.Entities;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test.Extensions;

using Microsoft.Extensions.DependencyInjection;

using Moq;

namespace Anima.Inscricao.Test.UseCases.Enderecos;

public class RemoverCidadeCommandHandlerTests
{
    private readonly Mock<INotificationContext> _notificationContext = new();
    private readonly Mock<ICidadeRepository> _cidadeRepository = new();
    private readonly Mock<IUnitOfWork> _unitOfWork = new();

    public RemoverCidadeCommandHandlerTests()
    {
        new ServiceExtensions()
            .BuildServiceProvider(new ServiceCollection());
    }

    [Fact]
    public async Task DeveRemoverCidadeComSucessoAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        await useCase.Handle(new RemoverCidadeCommand()
        {
            Key = EnderecoConstants.CidadeSaoPaulo.Key,
        }, default);

        // Assert
        _cidadeRepository.Verify(x => x.Delete(It.IsAny<Cidade>()), Times.Once);
    }

    private RemoverCidadeCommandHandler ObterUseCase()
    {
        _cidadeRepository
            .Setup(x => x.GetAsync(EnderecoConstants.CidadeSaoPaulo.Key))
            .ReturnsAsync(EnderecoConstants.CidadeSaoPaulo);

        return new(
                   _notificationContext.Object,
                   _cidadeRepository.Object,
                   _unitOfWork.Object);
    }
}