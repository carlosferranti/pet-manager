using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Anima.Inscricao.Application.UseCases.Enderecos.AtualizarCidade;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Enderecos;

using FluentValidation.TestHelper;

using Moq;

namespace Anima.Inscricao.Test.ApplicationValidators.Enderecos;

public class AtualizarCidadeCommandValidatorTests
{
    private readonly AtualizarCidadeCommandValidator _validator;
    private readonly Mock<ICidadeRepository> _cidadeRepositoryMock = new();
    private readonly Mock<IEstadoRepository> _estadoRepositoryMock = new();
    private readonly Mock<INotificationContext> _notificationContextMock = new();

    public AtualizarCidadeCommandValidatorTests()
    {
        _validator = new AtualizarCidadeCommandValidator(
            _notificationContextMock.Object,
            _cidadeRepositoryMock.Object,
            _estadoRepositoryMock.Object);
    }

    [Fact]
    public async Task DeveTerErroQuandoNomeDaCidadeForVazio()
    {
        // Arrange
        var command = new AtualizarCidadeCommand
        {
            Nome = string.Empty,
            EstadoKey = Guid.NewGuid(),
            Key = Guid.NewGuid()
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
        var command = new AtualizarCidadeCommand
        {
            Nome = new string('a', 101),
            EstadoKey = Guid.NewGuid(),
            Key = Guid.NewGuid()
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
        var command = new AtualizarCidadeCommand
        {
            Nome = "Cidade Teste",
            EstadoKey = Guid.Empty,
            Key = Guid.NewGuid()
        };

        // Act
        var result = await _validator.TestValidateAsync(command);

        // Assert
        result.ShouldHaveValidationErrorFor(x => x.EstadoKey)
            .WithErrorMessage("A chave do estado é obrigatória.");
    }

    [Fact]
    public async Task DeveTerErroQuandoChaveDoEstadoNaoExistir()
    {
        // Arrange
        var estadoKey = Guid.NewGuid();
        _estadoRepositoryMock.Setup(x => x.ExistsAsync(estadoKey, default)).ReturnsAsync(false);
        var command = new AtualizarCidadeCommand
        {
            Nome = "Cidade Teste",
            EstadoKey = estadoKey,
            Key = Guid.NewGuid()
        };

        // Act
        var result = await _validator.TestValidateAsync(command);

        // Assert
        result.ShouldHaveValidationErrorFor(x => x.EstadoKey)
            .WithErrorMessage("A chave do estado não foi encontrada.");
    }

    [Fact]
    public async Task DeveTerErroQuandoChaveDaCidadeForVazia()
    {
        // Arrange
        var command = new AtualizarCidadeCommand
        {
            Nome = "Cidade Teste",
            EstadoKey = Guid.NewGuid(),
            Key = Guid.Empty
        };

        // Act
        var result = await _validator.TestValidateAsync(command);

        // Assert
        result.ShouldHaveValidationErrorFor(x => x.Key)
            .WithErrorMessage("A chave da cidade é obrigatória.");
    }

    [Fact]
    public async Task DeveTerErroQuandoChaveDaCidadeNaoExistir()
    {
        // Arrange
        var cidadeKey = Guid.NewGuid();
        _cidadeRepositoryMock.Setup(x => x.ExistsAsync(cidadeKey, default)).ReturnsAsync(false);
        var command = new AtualizarCidadeCommand
        {
            Nome = "Cidade Teste",
            EstadoKey = Guid.NewGuid(),
            Key = cidadeKey
        };

        // Act
        var result = await _validator.TestValidateAsync(command);

        // Assert
        result.ShouldHaveValidationErrorFor(x => x.Key)
            .WithErrorMessage("A chave da cidade não foi encontrada.");
    }
}