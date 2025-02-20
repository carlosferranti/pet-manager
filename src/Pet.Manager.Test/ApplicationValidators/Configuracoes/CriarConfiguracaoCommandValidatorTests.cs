using Anima.Inscricao.Application.UseCases.Configuracoes.CriarConfiguracao;
using Anima.Inscricao.Domain._Shared.Notifications;

using FluentValidation.TestHelper;

using Moq;

namespace Anima.Inscricao.Test.ApplicationValidators.Configuracoes;

public class CriarConfiguracaoCommandValidatorTests
{
    private readonly Mock<INotificationContext> _notificationContextMock = new();
    private readonly CriarConfiguracaoCommandValidator _validationRules;

    public CriarConfiguracaoCommandValidatorTests()
    {
        _validationRules = new CriarConfiguracaoCommandValidator(
            _notificationContextMock.Object);
    }

    [Fact]
    public async Task DeveValidarMensagemDeErroChaveGenericaObrigatorioAsync()
    {
        var command = new CriarConfiguracaoCommand
        {
            ChaveGenerica = null!,
        };

        var result = await _validationRules.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.ChaveGenerica)
           .WithErrorMessage("A chave genérica da configuração é obrigatória.");
    }

    [Fact]
    public async Task DeveTerErroQuandoChaveGenericaForMaiorQueLimiteMaximoAsync()
    {
        var command = new CriarConfiguracaoCommand
        {
            ChaveGenerica = new string('a', 151),
        };

        var result = await _validationRules.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.ChaveGenerica)
            .WithErrorMessage("A chave genérica da configuração deve ter entre 3 e 150 caracteres.");
    }

    [Fact]
    public async Task DeveTerErroQuandoChaveGenericaForMenorQueLimiteMinimoAsync()
    {
        var command = new CriarConfiguracaoCommand
        {
            ChaveGenerica = new string('a', 2),
        };

        var result = await _validationRules.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.ChaveGenerica)
            .WithErrorMessage("A chave genérica da configuração deve ter entre 3 e 150 caracteres.");
    }

    [Fact]
    public async Task DeveValidarMensagemDeErroValorObrigatorioAsync()
    {
        var command = new CriarConfiguracaoCommand
        {
            Valor = null!,
        };

        var result = await _validationRules.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.Valor)
           .WithErrorMessage("O valor da configuração é obrigatório.");
    }

    [Fact]
    public async Task DeveTerErroQuandoValorForMaiorQueLimiteMaximoAsync()
    {
        var command = new CriarConfiguracaoCommand
        {
            Valor = new string('a', 501),
        };

        var result = await _validationRules.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.Valor)
            .WithErrorMessage("O valor da configuração deve ter entre 1 e 500 caracteres.");
    }

    [Fact]
    public async Task DeveTerErroQuandoValorForMenorQueLimiteMinimoAsync()
    {
        var command = new CriarConfiguracaoCommand
        {
            Valor = string.Empty,
        };

        var result = await _validationRules.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.Valor)
            .WithErrorMessage("O valor da configuração deve ter entre 1 e 500 caracteres.");
    }
}
