using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Produtos;
using Microsoft.Extensions.DependencyInjection;
using Anima.Inscricao.Test.Extensions;

using Moq;
using Anima.Inscricao.Application.UseCases.Produtos.RemoverProduto;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Domain.Produtos.Entities;

namespace Anima.Inscricao.Test.UseCases.Produtos;

public class RemoverProdutoCommandHandlerTests
{
    private readonly Mock<INotificationContext> _notificationContextMock = new();
    private readonly Mock<IProdutoRepository> _produtoRepositoryMock = new();
    private readonly Mock<IUnitOfWork> _unitOfWorkMock = new();

    public RemoverProdutoCommandHandlerTests()
    {
        new ServiceExtensions()
        .BuildServiceProvider(new ServiceCollection());
    }

    [Fact]
    public async Task DeveRemoverProdutoComSucessoAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        await useCase.Handle(new RemoverProdutoCommand()
        {
            Key = ProdutoConstants.ProdutoTeste1.Key,
        }, default);

        // Assert
        _produtoRepositoryMock.Verify(x => x.Delete(It.IsAny<Produto>()), Times.Once);
    }

    private RemoverProdutoCommandHandler ObterUseCase()
    {
        _produtoRepositoryMock
            .Setup(x => x.GetAsync(ProdutoConstants.ProdutoTeste1.Key))
            .ReturnsAsync(ProdutoConstants.ProdutoTeste1);

        return new(_notificationContextMock.Object,
            _produtoRepositoryMock.Object,
            _unitOfWorkMock.Object);
    }
        
}
