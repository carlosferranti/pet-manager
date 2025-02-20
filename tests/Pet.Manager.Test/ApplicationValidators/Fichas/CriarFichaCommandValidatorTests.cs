using Anima.Inscricao.Application.UseCases.Fichas.CriarFicha;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Etapas;

using FluentValidation.TestHelper;

using Moq;

using static Anima.Inscricao.Application.UseCases.Fichas.CriarFicha.CriarFichaCommand;

namespace Anima.Inscricao.Test.ApplicationValidators.Fichas;

public class CriarFichaCommandValidatorTests
{
    private readonly CriarFichaCommandValidator _validator;
    private readonly Mock<IEtapaTemplateRepository> _etapaTemplateRepositoryMock = new();
    private readonly Mock<INotificationContext> _notificationContextMock = new();

    public CriarFichaCommandValidatorTests()
    {
        _validator = new CriarFichaCommandValidator(_notificationContextMock.Object, _etapaTemplateRepositoryMock.Object);
    }

    [Fact]
    public async Task DeveTerErroQuandoNomeDaFichaForVazio()
    {
        // Arrange
        var command = new CriarFichaCommand
        {
            Nome = string.Empty,
            Descricao = "Descrição da ficha",
            Etapas = new List<CriarEtapaFichaCommand>()
            {
                new CriarEtapaFichaCommand(Guid.NewGuid(), 1),
            }
        };

        // Act
        var result = await _validator.TestValidateAsync(command);

        // Assert
        result.ShouldHaveValidationErrorFor(x => x.Nome)
            .WithErrorMessage("O nome da ficha é obrigatório.");
    }

    [Fact]
    public async Task DeveTerErroQuandoNomeDaFichaExcederLimiteMaximo()
    {
        // Arrange
        var command = new CriarFichaCommand
        {
            Nome = new string('A', 101),
            Descricao = "Descrição da ficha",
            Etapas = new List<CriarEtapaFichaCommand>()
            {
                new CriarEtapaFichaCommand(Guid.NewGuid(), 1),
            }
        };

        // Act
        var result = await _validator.TestValidateAsync(command);

        // Assert
        result.ShouldHaveValidationErrorFor(x => x.Nome)
            .WithErrorMessage("O nome da ficha deve ter no máximo 100 caracteres.");
    }

    [Fact]
    public async Task DeveTerErroQuandoDescricaoDaFichaForVazia()
    {
        // Arrange
        var command = new CriarFichaCommand
        {
            Nome = "Nome da ficha",
            Descricao = string.Empty,
            Etapas = new List<CriarEtapaFichaCommand>()
            {
                new CriarEtapaFichaCommand(Guid.NewGuid(), 1),
            }
        };

        // Act
        var result = await _validator.TestValidateAsync(command);

        // Assert
        result.ShouldHaveValidationErrorFor(x => x.Descricao)
            .WithErrorMessage("A descrição da ficha é obrigatória.");
    }

    [Fact]
    public async Task DeveTerErroQuandoDescricaoDaFichaExcederLimiteMaximo()
    {
        // Arrange
        var command = new CriarFichaCommand
        {
            Nome = "Nome da ficha",
            Descricao = new string('A', 201),
            Etapas = new List<CriarEtapaFichaCommand>()
            {
                new CriarEtapaFichaCommand(Guid.NewGuid(), 1),
            }
        };

        // Act
        var result = await _validator.TestValidateAsync(command);

        // Assert
        result.ShouldHaveValidationErrorFor(x => x.Descricao)
            .WithErrorMessage("A descrição da ficha deve ter no máximo 200 caracteres.");
    }

    [Fact]
    public async Task DeveTerErroQuandoEtapasDaFichaForemVazias()
    {
        // Arrange
        var command = new CriarFichaCommand
        {
            Nome = "Nome da ficha",
            Descricao = "Descrição da ficha",
            Etapas = new List<CriarEtapaFichaCommand>()
        };

        // Act
        var result = await _validator.TestValidateAsync(command);

        // Assert
        result.ShouldHaveValidationErrorFor(x => x.Etapas)
            .WithErrorMessage("As etapas da ficha são obrigatórias.");
    }

    [Fact]
    public async Task DeveTerErroQuandoSequenciaDaEtapaForVazia()
    {
        // Arrange
        var command = new CriarFichaCommand
        {
            Nome = "Nome da ficha",
            Descricao = "Descrição da ficha",
            Etapas = new List<CriarEtapaFichaCommand>()
            {
                new CriarEtapaFichaCommand(Guid.NewGuid(), 0),
            }
        };

        // Act
        var result = await _validator.TestValidateAsync(command);

        // Assert
        result.ShouldHaveValidationErrorFor("Etapas[0].Sequencia")
            .WithErrorMessage("A sequencia da etapa é obrigatória.");
    }

    [Fact]
    public async Task DeveTerErroQuandoChaveDaEtapaForVazia()
    {
        // Arrange
        var command = new CriarFichaCommand
        {
            Nome = "Nome da ficha",
            Descricao = "Descrição da ficha",
            Etapas = new List<CriarEtapaFichaCommand>()
            {
                new CriarEtapaFichaCommand(Guid.Empty, 1),
            }
        };

        // Act
        var result = await _validator.TestValidateAsync(command);

        // Assert
        result.ShouldHaveValidationErrorFor("Etapas[0].EtapaKey")
            .WithErrorMessage("A chave da etapa é obrigatória.");
    }

    [Fact]
    public async Task DeveTerErroQuandoChaveDaEtapaNaoForEncontrada()
    {
        // Arrange
        var etapaKey = Guid.NewGuid();
        _etapaTemplateRepositoryMock.Setup(x => x.ExistsAsync(etapaKey, default)).ReturnsAsync(false);

        var command = new CriarFichaCommand
        {
            Nome = "Nome da ficha",
            Descricao = "Descrição da ficha",
            Etapas = new List<CriarEtapaFichaCommand>()
            {
                new CriarEtapaFichaCommand(etapaKey, 1),
            }
        };

        // Act
        var result = await _validator.TestValidateAsync(command);

        // Assert
        result.ShouldHaveValidationErrorFor("Etapas[0].EtapaKey")
            .WithErrorMessage("Chave da etapa não encontrada.");
    }
}