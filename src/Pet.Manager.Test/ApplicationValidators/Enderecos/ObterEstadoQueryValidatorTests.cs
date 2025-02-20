using Anima.Inscricao.Application.UseCases.Enderecos.ObterEstado;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Enderecos;

using FluentValidation.TestHelper;

using Moq;

namespace Anima.Inscricao.Test.ApplicationValidators.Enderecos;

public class ObterEstadoQueryValidatorTests
{
    private readonly ObterEstadoQueryValidator _validator;
    private readonly Mock<IEstadoRepository> _estadoRepositoryMock = new();
    private readonly Mock<INotificationContext> _notificationMock = new();

    public ObterEstadoQueryValidatorTests()
    {
        _validator = new ObterEstadoQueryValidator(_estadoRepositoryMock.Object, _notificationMock.Object);
    }

    [Fact]
    public async Task DeveTerErroQuandoChaveDoEstadoForVazia()
    {
        // Arrange
        var query = new ObterEstadoQuery { Key = Guid.Empty };

        // Act
        var result = await _validator.TestValidateAsync(query);

        // Assert
        result.ShouldHaveValidationErrorFor(x => x.Key)
            .WithErrorMessage("A chave do estado é obrigatória.");
    }

    [Fact]
    public async Task DeveTerErroQuandoChaveDoEstadoNaoForEncontrada()
    {
        // Arrange
        var query = new ObterEstadoQuery { Key = Guid.NewGuid() };
        _estadoRepositoryMock
            .Setup(x => x.ExistsAsync(query.Key, CancellationToken.None))
            .ReturnsAsync(false);

        // Act
        var result = await _validator.TestValidateAsync(query);

        // Assert
        result.ShouldHaveValidationErrorFor(x => x.Key)
            .WithErrorMessage("A chave do estado não foi encontrada.");
    }
}