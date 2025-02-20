using Anima.Inscricao.Application.UseCases.Deficiencias.CriarDeficiencia;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.IntegracaoSistemas;

using FluentValidation.TestHelper;

using Moq;

namespace Anima.Inscricao.Test.ApplicationValidators.Deficiencias;

public class CriarDeficienciaCommandValidatorTests
{
    private readonly Mock<INotificationContext> _notificationContextMock = new();
    private readonly Mock<IIntegracaoSistemaRepository> _sistemasIntegracaoRepository = new();
    private readonly CriarDeficienciaCommandValidator _validationRules;

    public CriarDeficienciaCommandValidatorTests()
    {
        _validationRules = new CriarDeficienciaCommandValidator(
            _notificationContextMock.Object,
            _sistemasIntegracaoRepository.Object);
    }

    [Fact]
    public async Task DeveValidarMensagemDeErroNomeObrigatorioAsync()
    {
        var command = new CriarDeficienciaCommand
        {
            Nome = null!,
        };

        var result = await _validationRules.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.Nome)
           .WithErrorMessage("O nome da deficiência é obrigatório.");
    }

    [Fact]
    public async Task DeveTerErroQuandoNomeForMaiorQueLimiteMaximoAsync()
    {
        var command = new CriarDeficienciaCommand
        {
            Nome = new string('a', 150),
        };

        var result = await _validationRules.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.Nome)
            .WithErrorMessage("O nome da deficiência deve ter no máximo 100 caracteres.");
    }

    [Fact]
    public async Task DeveTerErroQuandoNomeSistemaIntegracaoNaoEncontradoAsync()
    {
        var command = new CriarDeficienciaCommand
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
        var command = new CriarDeficienciaCommand
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
        var command = new CriarDeficienciaCommand
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
