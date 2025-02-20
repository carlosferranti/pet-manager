using Anima.Inscricao.Application.UseCases.Enderecos.AtualizarEstado;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Enderecos;

using FluentValidation.TestHelper;

using Moq;

namespace Anima.Inscricao.Test.ApplicationValidators.Enderecos;

public class AtualizarEstadoCommandValidatorTests
{
    private readonly AtualizarEstadoCommandValidator _validator;
    private readonly Mock<IPaisRepository> _paisRepositoryMock;
    private readonly Mock<IEstadoRepository> _estadoRepositoryMock;

    public AtualizarEstadoCommandValidatorTests()
    {
        var notificationContextMock = new Mock<INotificationContext>();
        _paisRepositoryMock = new Mock<IPaisRepository>();
        _estadoRepositoryMock = new Mock<IEstadoRepository>();

        _validator = new AtualizarEstadoCommandValidator(
            notificationContextMock.Object,
            _paisRepositoryMock.Object,
            _estadoRepositoryMock.Object);
    }

    [Fact]
    public async Task DeveTerErroQuandoChaveDoEstadoForVazia()
    {
        // Arrange
        var command = new AtualizarEstadoCommand
        {
            Key = Guid.Empty,
            Nome = "São Paulo",
            Sigla = "SP",
            PaisKey = Guid.NewGuid()
        };

        // Act
        var result = await _validator.TestValidateAsync(command);

        // Assert
        result.ShouldHaveValidationErrorFor(x => x.Key)
            .WithErrorMessage("A chave do estado é obrigatória.");
    }

    [Fact]
    public async Task DeveTerErroQuandoEstadoNaoExistir()
    {
        // Arrange
        var command = new AtualizarEstadoCommand
        {
            Key = Guid.NewGuid(),
            Nome = "São Paulo",
            Sigla = "SP",
            PaisKey = Guid.NewGuid()
        };

        _estadoRepositoryMock.Setup(x => x.ExistsAsync(command.Key, CancellationToken.None))
            .ReturnsAsync(false);

        // Act
        var result = await _validator.TestValidateAsync(command);

        // Assert
        result.ShouldHaveValidationErrorFor(x => x.Key)
            .WithErrorMessage("A chave do estado não foi encontrada.");
    }

    [Fact]
    public async Task DeveTerErroQuandoNomeDoEstadoForVazio()
    {
        // Arrange
        var command = new AtualizarEstadoCommand
        {
            Key = Guid.NewGuid(),
            Nome = string.Empty,
            Sigla = "SP",
            PaisKey = Guid.NewGuid()
        };

        // Act
        var result = await _validator.TestValidateAsync(command);

        // Assert
        result.ShouldHaveValidationErrorFor(x => x.Nome)
            .WithErrorMessage("O nome do estado é obrigatório.");
    }

    [Fact]
    public async Task DeveTerErroQuandoNomeDoEstadoExcederLimiteDeCaracteres()
    {
        // Arrange
        var command = new AtualizarEstadoCommand
        {
            Key = Guid.NewGuid(),
            Nome = new string('a', 101),
            Sigla = "SP",
            PaisKey = Guid.NewGuid()
        };

        // Act
        var result = await _validator.TestValidateAsync(command);

        // Assert
        result.ShouldHaveValidationErrorFor(x => x.Nome)
            .WithErrorMessage("O nome do estado deve ter no máximo 100 caracteres.");
    }

    [Fact]
    public async Task DeveTerErroQuandoSiglaDoEstadoForVazia()
    {
        // Arrange
        var command = new AtualizarEstadoCommand
        {
            Key = Guid.NewGuid(),
            Nome = "São Paulo",
            Sigla = string.Empty,
            PaisKey = Guid.NewGuid()
        };

        // Act
        var result = await _validator.TestValidateAsync(command);

        // Assert
        result.ShouldHaveValidationErrorFor(x => x.Sigla)
            .WithErrorMessage("A sigla do estado é obrigatória.");
    }

    [Fact]
    public async Task DeveTerErroQuandoSiglaDoEstadoExcederLimiteDeCaracteres()
    {
        // Arrange
        var command = new AtualizarEstadoCommand
        {
            Key = Guid.NewGuid(),
            Nome = "São Paulo",
            Sigla = new string('a', 11),
            PaisKey = Guid.NewGuid()
        };

        // Act
        var result = await _validator.TestValidateAsync(command);

        // Assert
        result.ShouldHaveValidationErrorFor(x => x.Sigla)
            .WithErrorMessage("A sigla do estado deve ter no máximo 10 caracteres.");
    }

    [Fact]
    public async Task DeveTerErroQuandoChaveDoPaisForVazia()
    {
        // Arrange
        var command = new AtualizarEstadoCommand
        {
            Key = Guid.NewGuid(),
            Nome = "São Paulo",
            Sigla = "SP",
            PaisKey = Guid.Empty
        };

        // Act
        var result = await _validator.TestValidateAsync(command);

        // Assert
        result.ShouldHaveValidationErrorFor(x => x.PaisKey)
            .WithErrorMessage("A chave do país é obrigatória.");
    }

    [Fact]
    public async Task DeveTerErroQuandoPaisNaoExistir()
    {
        // Arrange
        var command = new AtualizarEstadoCommand
        {
            Key = Guid.NewGuid(),
            Nome = "São Paulo",
            Sigla = "SP",
            PaisKey = Guid.NewGuid()
        };

        _paisRepositoryMock.Setup(x => x.ExistsAsync(command.PaisKey, CancellationToken.None))
            .ReturnsAsync(false);

        // Act
        var result = await _validator.TestValidateAsync(command);

        // Assert
        result.ShouldHaveValidationErrorFor(x => x.PaisKey)
            .WithErrorMessage("A chave do país não foi encontrada.");
    }
}
