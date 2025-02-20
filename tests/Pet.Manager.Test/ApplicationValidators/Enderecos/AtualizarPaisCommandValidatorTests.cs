using Anima.Inscricao.Application.UseCases.Enderecos.AtualizarPais;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Enderecos;

using FluentValidation.TestHelper;

using Moq;

namespace Anima.Inscricao.Test.ApplicationValidators.Enderecos;

public class AtualizarPaisCommandValidatorTests
{
    private readonly Mock<INotificationContext> _notificationContextMock = new();
    private readonly Mock<IPaisRepository> _paisRepositoryMock = new();
    private readonly AtualizarPaisCommandValidator _validationRules;

    public AtualizarPaisCommandValidatorTests()
    {
        _validationRules = new (
            _notificationContextMock.Object,
            _paisRepositoryMock.Object);
    }

    [Fact]
    public async Task DeveValidarMensagemDeErroNomeObrigatorioAsync()
    {
        var command = new AtualizarPaisCommand
        {
            Nome = null!,
        };

        var result = await _validationRules.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.Nome)
           .WithErrorMessage("O nome do país é obrigatório.");
    }

    [Fact]
    public async Task DeveTerErroQuandoNomeForMaiorQueLimiteMaximoAsync()
    {
        var command = new AtualizarPaisCommand
        {
            Nome = new string('a', 150),
        };

        var result = await _validationRules.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.Nome)
            .WithErrorMessage("O nome do país deve ter no máximo 100 caracteres.");
    }

    [Fact]
    public async Task DeveValidarMensagemDeErroChaveObrigatorioAsync()
    {
        var command = new AtualizarPaisCommand
        {
            Key = Guid.Empty,
        };

        var result = await _validationRules.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.Key)
            .WithErrorMessage("A chave do país é obrigatória.");
    }

    [Fact]
    public async Task DeveValidarMensagemDeErroChaveNaoEncontradaAsync()
    {
        var command = new AtualizarPaisCommand
        {
            Key = Guid.Empty,
        };

        var result = await _validationRules.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.Key)
            .WithErrorMessage("A chave do país não foi encontrada.");
    }

    [Fact]
    public async Task DeveValidarMensagemDeErroSiglaObrigatorioAsync()
    {
        var command = new AtualizarPaisCommand
        {
            Sigla = null!,
        };

        var result = await _validationRules.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.Sigla)
           .WithErrorMessage("A sigla do país é obrigatório.");
    }

    [Fact]
    public async Task DeveTerErroQuandoSiglaForMaiorQueLimiteMaximoAsync()
    {
        var command = new AtualizarPaisCommand
        {
            Sigla = new string('a', 150),
        };

        var result = await _validationRules.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.Sigla)
            .WithErrorMessage("A sigla do país deve ter no máximo 10 caracteres.");
    }

    [Fact]
    public async Task DeveValidarMensagemDeErroSiglaAbreviadaObrigatorioAsync()
    {
        var command = new AtualizarPaisCommand
        {
            SiglaAbreviada = null!,
        };

        var result = await _validationRules.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.SiglaAbreviada)
           .WithErrorMessage("A sigla abreviada do país é obrigatório.");
    }

    [Fact]
    public async Task DeveTerErroQuandoSiglaAbreviadaForMaiorQueLimiteMaximoAsync()
    {
        var command = new AtualizarPaisCommand
        {
            SiglaAbreviada = new string('a', 150),
        };

        var result = await _validationRules.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.SiglaAbreviada)
            .WithErrorMessage("A sigla abreviada do país deve ter no máximo 10 caracteres.");
    }

    [Fact]
    public async Task DeveTerErroQuandoTipoForMaiorQueLimiteMaximoAsync()
    {
        var command = new AtualizarPaisCommand
        {
            Tipo = new string('a', 2),
        };

        var result = await _validationRules.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.Tipo)
            .WithErrorMessage("O tipo do país deve ter no máximo 1 caracter.");
    }
}
