using Anima.Inscricao.Application.UseCases.Intakes.AtualizarIntake;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Intakes;

using FluentValidation.TestHelper;

using Moq;

namespace Anima.Inscricao.Test.ApplicationValidators.Intakes;

public class AtualizarIntakeCommandValidatorTests
{
    private readonly Mock<INotificationContext> _notificationContextMock = new();
    private readonly Mock<IIntakeRepository> _intakeRepositoryMock = new();
    private readonly AtualizarIntakeCommandValidator _validationRules;

    public AtualizarIntakeCommandValidatorTests()
    {
        _validationRules = new (
            _intakeRepositoryMock.Object,
            _notificationContextMock.Object);
    }

    [Fact]
    public async Task DeveValidarMensagemDeErroNomeObrigatorioAsync()
    {
        var command = new AtualizarIntakeCommand
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
        var command = new AtualizarIntakeCommand
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
        var command = new AtualizarIntakeCommand
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
        var command = new AtualizarIntakeCommand
        {
            VigenciaTermino = default(DateTime),
        };

        var result = await _validationRules.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.VigenciaTermino)
            .WithErrorMessage("Data de término da vigência inválida.");
    }

    [Fact]
    public async Task DeveTerErroQuandoChaveVaziaAsync()
    {
        var command = new AtualizarIntakeCommand
        {
            Key = Guid.Empty,
        };

        var result = await _validationRules.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.Key)
           .WithErrorMessage("A chave do intake é obrigatória.");
    }

    [Fact]
    public async Task DeveTerErroQuandoChaveNaoEncontradaAsync()
    {
        var command = new AtualizarIntakeCommand
        {
            Key = Guid.NewGuid(),
        };

        var result = await _validationRules.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.Key)
           .WithErrorMessage("A chave do intake não foi encontrada.");
    }
}