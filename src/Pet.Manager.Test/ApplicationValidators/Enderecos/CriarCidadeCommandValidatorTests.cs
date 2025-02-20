using Anima.Inscricao.Application.DTOs.SistemasIntegracao;
using Anima.Inscricao.Application.UseCases.Enderecos.CriarCidade;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Enderecos;
using Anima.Inscricao.Domain.IntegracaoSistemas;

using FluentValidation.TestHelper;

using Moq;

namespace Anima.Inscricao.Test.ApplicationValidators.Enderecos;

public class CriarCidadeCommandValidatorTests
{
    private readonly CriarCidadeCommandValidator _validator;
    private readonly Mock<IIntegracaoSistemaRepository> _sistemasIntegracaoRepositoryMock;
    private readonly Mock<IEstadoRepository> _estadoRepositoryMock;

    public CriarCidadeCommandValidatorTests()
    {
        var notificationContextMock = new Mock<INotificationContext>();
        _sistemasIntegracaoRepositoryMock = new Mock<IIntegracaoSistemaRepository>();
        _estadoRepositoryMock = new Mock<IEstadoRepository>();

        _validator = new CriarCidadeCommandValidator(
            notificationContextMock.Object,
            _sistemasIntegracaoRepositoryMock.Object,
            _estadoRepositoryMock.Object);
    }

    [Fact]
    public async Task DeveTerErroQuandoNomeDaCidadeForVazio()
    {
        // Arrange
        var command = new CriarCidadeCommand
        {
            Nome = string.Empty,
            EstadoKey = Guid.NewGuid(),
            Integracao = null
        };

        // Act
        var result = await _validator.TestValidateAsync(command);

        // Assert
        result.ShouldHaveValidationErrorFor(x => x.Nome)
            .WithErrorMessage("O nome da cidade é obrigatório.");
    }

    [Fact]
    public async Task DeveTerErroQuandoNomeDaCidadeExcederLimiteDeCaracteres()
    {
        // Arrange
        var command = new CriarCidadeCommand
        {
            Nome = new string('A', 101),
            EstadoKey = Guid.NewGuid(),
            Integracao = null
        };

        // Act
        var result = await _validator.TestValidateAsync(command);

        // Assert
        result.ShouldHaveValidationErrorFor(x => x.Nome)
            .WithErrorMessage("O nome da cidade deve ter no máximo 100 caracteres.");
    }

    [Fact]
    public async Task DeveTerErroQuandoChaveDoEstadoForVazia()
    {
        // Arrange
        var command = new CriarCidadeCommand
        {
            Nome = "Cidade",
            EstadoKey = Guid.Empty,
            Integracao = null
        };

        // Act
        var result = await _validator.TestValidateAsync(command);

        // Assert
        result.ShouldHaveValidationErrorFor(x => x.EstadoKey)
            .WithErrorMessage("A chave do estado é obrigatória.");
    }

    [Fact]
    public async Task DeveTerErroQuandoChaveDoEstadoNaoForEncontrada()
    {
        // Arrange
        var estadoKey = Guid.NewGuid();
        _estadoRepositoryMock.Setup(x => x.ExistsAsync(estadoKey, default)).ReturnsAsync(false);

        var command = new CriarCidadeCommand
        {
            Nome = "Cidade",
            EstadoKey = estadoKey,
            Integracao = null
        };

        // Act
        var result = await _validator.TestValidateAsync(command);

        // Assert
        result.ShouldHaveValidationErrorFor(x => x.EstadoKey)
            .WithErrorMessage("A chave do estado não foi encontrada.");
    }

    [Fact]
    public async Task DeveTerErroQuandoNomeDoSistemaDeIntegracaoExcederLimiteDeCaracteres()
    {
        // Arrange
        var command = new CriarCidadeCommand
        {
            Nome = "Cidade",
            EstadoKey = Guid.NewGuid(),
            Integracao = new SistemaIntegracaoDto
            {
                NomeSistema = new string('A', 101),
                CodigoOrigem = "123"
            }
        };

        // Act
        var result = await _validator.TestValidateAsync(command);

        // Assert
        result.ShouldHaveValidationErrorFor(x => x.Integracao!.NomeSistema)
            .WithErrorMessage("O nome do sistema de integração deve ter no máximo 100 caracteres.");
    }

    [Fact]
    public async Task DeveTerErroQuandoNomeDoSistemaDeIntegracaoNaoForEncontrado()
    {
        // Arrange
        var nomeSistema = "Sistema";

        var command = new CriarCidadeCommand
        {
            Nome = "Cidade",
            EstadoKey = Guid.NewGuid(),
            Integracao = new SistemaIntegracaoDto
            {
                NomeSistema = nomeSistema,
                CodigoOrigem = "123"
            }
        };

        // Act
        var result = await _validator.TestValidateAsync(command);

        // Assert
        result.ShouldHaveValidationErrorFor(x => x.Integracao!.NomeSistema)
            .WithErrorMessage("Nome do sistema de integração não encontrado.");
    }

    [Fact]
    public async Task DeveTerErroQuandoCodigoDeOrigemDaIntegracaoExcederLimiteDeCaracteres()
    {
        // Arrange
        var command = new CriarCidadeCommand
        {
            Nome = "Cidade",
            EstadoKey = Guid.NewGuid(),
            Integracao = new SistemaIntegracaoDto
            {
                NomeSistema = "Sistema",
                CodigoOrigem = new string('A', 101)
            }
        };

        // Act
        var result = await _validator.TestValidateAsync(command);

        // Assert
        result.ShouldHaveValidationErrorFor(x => x.Integracao!.CodigoOrigem)
            .WithErrorMessage("O código de origem da integração deve ter no máximo 100 caracteres.");
    }
}