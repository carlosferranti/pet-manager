using Anima.Inscricao.Application.UseCases.Produtos.ObterProduto;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Produtos;

using FluentValidation.TestHelper;

using Moq;

namespace Anima.Inscricao.Test.ApplicationValidators.Produtos;

public class ObterProdutoQueryValidatorTests
{
    private readonly Mock<IProdutoRepository> _produtoRepository = new();
    private readonly ObterProdutoQueryValidator _validator;

    public ObterProdutoQueryValidatorTests()
    {
        _validator = new ObterProdutoQueryValidator(
            _produtoRepository.Object,
            new Mock<INotificationContext>().Object);
    }

    [Fact]
    public async Task DeveTerErroQuandoChaveDoProdutoForVazia()
    {
        var query = new ObterProdutoQuery
        {
            Key = Guid.Empty,
        };

        var result = await _validator.TestValidateAsync(query);

        result.ShouldHaveValidationErrorFor(x => x.Key)
            .WithErrorMessage("A chave do produto é obrigatória.");
    }

    [Fact]
    public async Task DeveTerErroQuandoChaveDoProdutoNaoForEncontrada()
    {
        _produtoRepository.Setup(repo => repo.ExistsAsync(It.IsAny<Guid>(), It.IsAny<CancellationToken>()))
            .ReturnsAsync(false);

        var query = new ObterProdutoQuery
        {
            Key = Guid.NewGuid(),
        };

        var result = await _validator.TestValidateAsync(query);

        result.ShouldHaveValidationErrorFor(x => x.Key)
            .WithErrorMessage("A chave do produto não foi encontrada.");
    }

    [Fact]
    public async Task NaoDeveTerErroQuandoChaveDoProdutoForValida()
    {
        _produtoRepository.Setup(repo => repo.ExistsAsync(It.IsAny<Guid>(), It.IsAny<CancellationToken>()))
            .ReturnsAsync(true);

        var query = new ObterProdutoQuery
        {
            Key = Guid.NewGuid(),
        };

        var result = await _validator.TestValidateAsync(query);

        result.ShouldNotHaveValidationErrorFor(x => x.Key);
    }
}
