using Anima.Inscricao.Application.UseCases.Configuracoes.AtualizarConfiguracao;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Configuracoes;

using FluentValidation.TestHelper;

using Moq;

namespace Anima.Inscricao.Test.ApplicationValidators.Configuracoes;

public class AtualizarConfiguracaoCommandValidatorTests
{
    private readonly Mock<INotificationContext> _notificationContextMock = new();
    private readonly Mock<IConfiguracaoRepository> _configuracaoRepositoryMock = new();
    private readonly AtualizarConfiguracaoCommandValidator _validationRules;

    public AtualizarConfiguracaoCommandValidatorTests()
    {
        _validationRules = new AtualizarConfiguracaoCommandValidator(
            _notificationContextMock.Object,
            _configuracaoRepositoryMock.Object);
    }

    [Fact]
    public async Task DeveValidarMensagemDeErroChaveGenericaObrigatorioAsync()
    {
        var command = new AtualizarConfiguracaoCommand
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
        var command = new AtualizarConfiguracaoCommand
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
        var command = new AtualizarConfiguracaoCommand
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
        var command = new AtualizarConfiguracaoCommand
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
        var command = new AtualizarConfiguracaoCommand
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
        var command = new AtualizarConfiguracaoCommand
        {
            Valor = string.Empty,
        };

        var result = await _validationRules.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.Valor)
            .WithErrorMessage("O valor da configuração deve ter entre 1 e 500 caracteres.");
    }

    [Fact]
    public async Task DeveValidarMensagemDeErroChaveNaoEncontradaAsync()
    {
        var command = new AtualizarConfiguracaoCommand
        {
            Key = Guid.Empty,
        };

        var result = await _validationRules.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.Key)
            .WithErrorMessage("A chave da configuração não foi encontrada.");
    }
}
