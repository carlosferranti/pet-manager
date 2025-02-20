using Anima.Inscricao.Application.UseCases.Intakes.CriarIntake;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.IntegracaoSistemas;

using FluentValidation.TestHelper;

using Moq;

namespace Anima.Inscricao.Test.ApplicationValidators.Intakes;

public class CriarIntakeCommandValidatorTests
{
    private readonly Mock<INotificationContext> _notificationContextMock = new();
    private readonly Mock<IIntegracaoSistemaRepository> _integracaoSistemaRepositoryMock = new();
    private readonly CriarIntakeCommandValidator _validationRules;

    public CriarIntakeCommandValidatorTests()
    {
        _validationRules = new CriarIntakeCommandValidator(
            _notificationContextMock.Object,
            _integracaoSistemaRepositoryMock.Object);
    }

    [Fact]
    public async Task DeveValidarMensagemDeErroNomeObrigatorioAsync()
    {
        var command = new CriarIntakeCommand
        {
            Nome = null!,
        };

        var result = await _validationRules.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.Nome)
           .WithErrorMessage("O nome do intake é obrigatório.");
    }

    [Fact]
    public async Task DeveTerErroQuandoNomeForMaiorQueLimiteMaximoAsync()
    {
        var command = new CriarIntakeCommand
        {
            Nome = new string('a', 150),
        };

        var result = await _validationRules.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.Nome)
            .WithErrorMessage("O nome do intake deve ter no máximo 100 caracteres.");
    }

    [Fact]
    public async Task DeveTerErroQuandoInicioVigenciaForDefaultAsync()
    {
        var command = new CriarIntakeCommand
        {
            VigenciaInicio = default(DateTime),
        };

        var result = await _validationRules.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.VigenciaInicio)
            .WithErrorMessage("Data de inicio da vigência inválida.");
    }

    [Fact]
    public async Task DeveTerErroQuandoTerminoVigenciaForDefaultAsync()
    {
        var command = new CriarIntakeCommand
        {
            VigenciaTermino = default(DateTime),
        };

        var result = await _validationRules.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.VigenciaTermino)
            .WithErrorMessage("Data de término da vigência inválida.");
    }

    [Fact]
    public async Task DeveTerErroQuandoNomeSistemaIntegracaoNaoEncontradoAsync()
    {
        var command = new CriarIntakeCommand
        {
            Integracao = new()
            {
                NomeSistema = "SistemaInexistente",
            },
        };

        var result = await _validationRules.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.Integracao!.NomeSistema)
            .WithErrorMessage("Nome do sistema de integração não encontrado.");
    }

    [Fact]
    public async Task DeveTerErroQuandoNomeSistemaIntegracaoUltrapassarLimiteAsync()
    {
        var command = new CriarIntakeCommand
        {
            Integracao = new()
            {
                NomeSistema = new string('a', 150),
            },
        };

        var result = await _validationRules.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.Integracao!.NomeSistema)
            .WithErrorMessage("O nome do sistema de integração deve ter no máximo 100 caracteres.");
    }

    [Fact]
    public async Task DeveTerErroQuandoCodigoOrigemUltrapassarLimiteAsync()
    {
        var command = new CriarIntakeCommand
        {
            Integracao = new()
            {
                CodigoOrigem = new string('a', 150),
            },
        };

        var result = await _validationRules.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.Integracao!.CodigoOrigem)
            .WithErrorMessage("O código de origem da integração deve ter no máximo 100 caracteres.");
    }
}
