using Anima.Inscricao.Application.UseCases.Enderecos.CriarPais;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.IntegracaoSistemas;

using FluentValidation.TestHelper;

using Moq;

namespace Anima.Inscricao.Test.ApplicationValidators.Enderecos;

public class CriarPaisCommandValidatorTests
{
    private readonly Mock<INotificationContext> _notificationContextMock = new();
    private readonly Mock<IIntegracaoSistemaRepository> _sistemasIntegracaoRepository = new();
    private readonly CriarPaisCommandValidator _validationRules;

    public CriarPaisCommandValidatorTests()
    {
        _validationRules = new(
            _notificationContextMock.Object,
            _sistemasIntegracaoRepository.Object);
    }

    [Fact]
    public async Task DeveValidarMensagemDeErroNomeObrigatorioAsync()
    {
        var command = new CriarPaisCommand
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
        var command = new CriarPaisCommand
        {
            Nome = new string('a', 150),
        };

        var result = await _validationRules.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.Nome)
            .WithErrorMessage("O nome do país deve ter no máximo 100 caracteres.");
    }

    [Fact]
    public async Task DeveValidarMensagemDeErroSiglaObrigatorioAsync()
    {
        var command = new CriarPaisCommand
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
        var command = new CriarPaisCommand
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
        var command = new CriarPaisCommand
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
        var command = new CriarPaisCommand
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
        var command = new CriarPaisCommand
        {
            Tipo = new string('a', 2),
        };

        var result = await _validationRules.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.Tipo)
            .WithErrorMessage("O tipo do país deve ter no máximo 1 caracter.");
    }

    [Fact]
    public async Task DeveTerErroQuandoNomeSistemaIntegracaoNaoEncontradoAsync()
    {
        var command = new CriarPaisCommand
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
        var command = new CriarPaisCommand
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
        var command = new CriarPaisCommand
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