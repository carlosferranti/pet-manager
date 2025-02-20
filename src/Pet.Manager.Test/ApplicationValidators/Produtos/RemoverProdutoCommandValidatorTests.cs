using Anima.Inscricao.Application.UseCases.Produtos.RemoverProduto;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Produtos;

using FluentValidation.TestHelper;

using Moq;

namespace Anima.Inscricao.Test.ApplicationValidators.Produtos;

public class RemoverProdutoCommandValidatorTests
{
    private readonly Mock<INotificationContext> _notificationContextMock = new();
    private readonly Mock<IProdutoRepository> _produtoRepositoryMock = new();
    private readonly RemoverProdutoCommandValidator _validationRules;

    public RemoverProdutoCommandValidatorTests()
    {
        _validationRules = new(
            _produtoRepositoryMock.Object,
            _notificationContextMock.Object);
    }

    [Fact]
    public async Task DeveValidarMensagemDeErroChaveObrigatoriaAsync()
    {
        var command = new RemoverProdutoCommand
        {
            Key = Guid.Empty,
        };

        var result = await _validationRules.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.Key)
            .WithErrorMessage("A chave do produto é obrigatória.");
    }

    [Fact]
    public async Task DeveValidarMensagemDeErroChaveNaoEncontradaAsync()
    {
        _produtoRepositoryMock.Setup(x => x.ExistsAsync(It.IsAny<Guid>(), It.IsAny<CancellationToken>()))
            .ReturnsAsync(false);

        var command = new RemoverProdutoCommand
        {
            Key = Guid.NewGuid(),
        };

        var result = await _validationRules.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.Key)
            .WithErrorMessage("A chave do produto não foi encontrada.");
    }
}
