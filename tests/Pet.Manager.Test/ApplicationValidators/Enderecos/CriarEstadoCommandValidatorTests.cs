using Anima.Inscricao.Application.DTOs.SistemasIntegracao;
using Anima.Inscricao.Application.UseCases.Enderecos.CriarEstado;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Enderecos;
using Anima.Inscricao.Domain.IntegracaoSistemas;

using FluentValidation.TestHelper;

using Moq;

namespace Anima.Inscricao.Test.ApplicationValidators.Enderecos;

public class CriarEstadoCommandValidatorTests
{
    private readonly CriarEstadoCommandValidator _validator;
    private readonly Mock<IIntegracaoSistemaRepository> _sistemasIntegracaoRepositoryMock = new();
    private readonly Mock<IPaisRepository> _paisRepositoryMock = new();
    private readonly Mock<INotificationContext> _notificationContextMock = new();

    public CriarEstadoCommandValidatorTests()
    {
        _validator = new CriarEstadoCommandValidator(
            _notificationContextMock.Object,
            _sistemasIntegracaoRepositoryMock.Object,
            _paisRepositoryMock.Object);
    }

    [Fact]
    public async Task DeveTerErroQuandoNomeEstadoForVazio()
    {
        // Arrange
        var command = new CriarEstadoCommand
        {
            Nome = string.Empty,
            Sigla = "SP",
            PaisKey = Guid.NewGuid(),
            Integracao = null
        };

        // Act
        var result = await _validator.TestValidateAsync(command);

        // Assert
        result.ShouldHaveValidationErrorFor(x => x.Nome)
            .WithErrorMessage("O nome do estado é obrigatório.");
    }

    [Fact]
    public async Task DeveTerErroQuandoNomeEstadoExcederLimiteCaracteres()
    {
        // Arrange
        var command = new CriarEstadoCommand
        {
            Nome = new string('a', 200), 
            Sigla = "SP",
            PaisKey = Guid.NewGuid(),
            Integracao = null
        };

        // Act
        var result = await _validator.TestValidateAsync(command);

        // Assert
        result.ShouldHaveValidationErrorFor(x => x.Nome)
            .WithErrorMessage("O nome do estado deve ter no máximo 100 caracteres.");
    }

    [Fact]
    public async Task DeveTerErroQuandoSiglaEstadoForVazia()
    {
        // Arrange
        var command = new CriarEstadoCommand
        {
            Nome = "São Paulo",
            Sigla = string.Empty,
            PaisKey = Guid.NewGuid(),
            Integracao = null
        };

        // Act
        var result = await _validator.TestValidateAsync(command);

        // Assert
        result.ShouldHaveValidationErrorFor(x => x.Sigla)
            .WithErrorMessage("A sigla do estado é obrigatória.");
    }

    [Fact]
    public async Task DeveTerErroQuandoSiglaEstadoExcederLimiteCaracteres()
    {
        // Arrange
        var command = new CriarEstadoCommand
        {
            Nome = "São Paulo",
            Sigla = new string('a', 11),
            PaisKey = Guid.NewGuid(),
            Integracao = null
        };

        // Act
        var result = await _validator.TestValidateAsync(command);

        // Assert
        result.ShouldHaveValidationErrorFor(x => x.Sigla)
            .WithErrorMessage("A sigla do estado deve ter no máximo 10 caracteres.");
    }

    [Fact]
    public async Task DeveTerErroQuandoChavePaisForVazia()
    {
        // Arrange
        var command = new CriarEstadoCommand
        {
            Nome = "São Paulo",
            Sigla = "SP",
            PaisKey = Guid.Empty,
            Integracao = null
        };

        // Act
        var result = await _validator.TestValidateAsync(command);

        // Assert
        result.ShouldHaveValidationErrorFor(x => x.PaisKey)
            .WithErrorMessage("A chave do país é obrigatória.");
    }

    [Fact]
    public async Task DeveTerErroQuandoChavePaisNaoExistir()
    {
        // Arrange
        var command = new CriarEstadoCommand
        {
            Nome = "São Paulo",
            Sigla = "SP",
            PaisKey = Guid.NewGuid(),
            Integracao = null
        };

        _paisRepositoryMock.Setup(x => x.ExistsAsync(It.IsAny<Guid>(), default))
            .ReturnsAsync(false);

        // Act
        var result = await _validator.TestValidateAsync(command);

        // Assert
        result.ShouldHaveValidationErrorFor(x => x.PaisKey)
            .WithErrorMessage("A chave do país não foi encontrada.");
    }

    [Fact]
    public async Task DeveTerErroQuandoNomeSistemaIntegracaoExcederLimiteCaracteres()
    {
        // Arrange
        var command = new CriarEstadoCommand
        {
            Nome = "São Paulo",
            Sigla = "SP",
            PaisKey = Guid.NewGuid(),
            Integracao = new SistemaIntegracaoDto
            {
                NomeSistema = new string('a', 200),
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
    public async Task DeveTerErroQuandoNomeSistemaIntegracaoNaoExistir()
    {
        // Arrange
        var command = new CriarEstadoCommand
        {
            Nome = "São Paulo",
            Sigla = "SP",
            PaisKey = Guid.NewGuid(),
            Integracao = new SistemaIntegracaoDto
            {
                NomeSistema = "SistemaInexistente",
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
    public async Task DeveTerErroQuandoCodigoOrigemIntegracaoExcederLimiteCaracteres()
    {
        // Arrange
        var command = new CriarEstadoCommand
        {
            Nome = "São Paulo",
            Sigla = "SP",
            PaisKey = Guid.NewGuid(),
            Integracao = new SistemaIntegracaoDto
            {
                NomeSistema = "Sistema",
                CodigoOrigem = new string('a', 200)
            }
        };

        // Act
        var result = await _validator.TestValidateAsync(command);

        // Assert
        result.ShouldHaveValidationErrorFor(x => x.Integracao!.CodigoOrigem)
            .WithErrorMessage("O código de origem da integração deve ter no máximo 100 caracteres.");
    }
}