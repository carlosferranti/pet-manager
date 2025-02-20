using Anima.Inscricao.Application.UseCases.Enderecos.RemoverCidade;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Enderecos;

using FluentValidation.TestHelper;

using Moq;

namespace Anima.Inscricao.Test.ApplicationValidators.Enderecos;

public class RemoverCidadeCommandValidatorTests
{
    private readonly RemoverCidadeCommandValidator _validator;
    private readonly Mock<ICidadeRepository> _cidadeRepositoryMock = new();
    private readonly Mock<INotificationContext> _notificationMock = new();

    public RemoverCidadeCommandValidatorTests()
    {
        _validator = new RemoverCidadeCommandValidator(_cidadeRepositoryMock.Object, _notificationMock.Object);
    }

    [Fact]
    public async Task DeveTerErroQuandoChaveDaCidadeForVazia()
    {
        // Arrange
        var query = new RemoverCidadeCommand { Key = Guid.Empty };

        // Act
        var result = await _validator.TestValidateAsync(query);

        // Assert
        result.ShouldHaveValidationErrorFor(x => x.Key)
            .WithErrorMessage("A chave da cidade é obrigatória.");
    }

    [Fact]
    public async Task DeveTerErroQuandoChaveDaCidadeNaoForEncontrada()
    {
        // Arrange
        var query = new RemoverCidadeCommand { Key = Guid.NewGuid() };
        _cidadeRepositoryMock
            .Setup(x => x.ExistsAsync(query.Key, CancellationToken.None))
            .ReturnsAsync(false);

        // Act
        var result = await _validator.TestValidateAsync(query);

        // Assert
        result.ShouldHaveValidationErrorFor(x => x.Key)
            .WithErrorMessage("A chave da cidade não foi encontrada.");
    }
}