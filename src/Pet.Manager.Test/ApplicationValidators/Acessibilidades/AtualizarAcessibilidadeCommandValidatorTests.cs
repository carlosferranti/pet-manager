using Anima.Inscricao.Application.UseCases.Acessibilidades.AtualizarAcessibilidade;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Acessibilidades;

using FluentValidation.TestHelper;

using Moq;

namespace Anima.Inscricao.Test.ApplicationValidators.Acessibilidades;

public class AtualizarAcessibilidadeCommandValidatorTests
{
    private readonly Mock<INotificationContext> _notificationContextMock = new();
    private readonly Mock<IAcessibilidadeRepository> _acessibilidadeRepositoryMock = new();
    private readonly AtualizarAcessibilidadeCommandValidator _validationRules;

    public AtualizarAcessibilidadeCommandValidatorTests()
    {
        _validationRules = new AtualizarAcessibilidadeCommandValidator(
            _notificationContextMock.Object,
            _acessibilidadeRepositoryMock.Object);
    }

    [Fact]
    public async Task DeveValidarMensagemDeErroNomeObrigatorioAsync()
    {
        var command = new AtualizarAcessibilidadeCommand
        {
            Nome = null!,
        };

        var result = await _validationRules.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.Nome)
           .WithErrorMessage("O nome da acessibilidade é obrigatório.");
    }

    [Fact]
    public async Task DeveTerErroQuandoNomeForMaiorQueLimiteMaximoAsync()
    {
        var command = new AtualizarAcessibilidadeCommand
        {
            Nome = new string('a', 150),
        };

        var result = await _validationRules.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.Nome)
            .WithErrorMessage("O nome da acessibilidade deve ter no máximo 100 caracteres.");
    }

    [Fact]
    public async Task DeveValidarMensagemDeErroChaveObrigatorioAsync()
    {
        var command = new AtualizarAcessibilidadeCommand
        {
            Key = Guid.Empty,
        };

        var result = await _validationRules.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.Key)
            .WithErrorMessage("A chave da acessibilidade é obrigatória.");
    }

    [Fact]
    public async Task DeveValidarMensagemDeErroChaveNaoEncontradaAsync()
    {
        var command = new AtualizarAcessibilidadeCommand
        {
            Key = Guid.NewGuid(),
        };

        var result = await _validationRules.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.Key)
            .WithErrorMessage("A acessibilidade não foi encontrada.");
    }
}
