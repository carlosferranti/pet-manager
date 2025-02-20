using Anima.Inscricao.Application.UseCases.FormasEntrada.CriarFormaEntrada;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.IntegracaoSistemas;

using FluentValidation.TestHelper;

using Moq;

namespace Anima.Inscricao.Test.ApplicationValidators.FormasEntrada;

public class CriarFormaEntradaCommandValidatorTests
{
    private readonly Mock<INotificationContext> _notificationContextMock = new();
    private readonly Mock<IIntegracaoSistemaRepository> _integracaoSistemaRepositoryMock = new();
    private readonly CriarFormaEntradaCommandValidator _validationRules;

    public CriarFormaEntradaCommandValidatorTests()
    {
        _validationRules = new CriarFormaEntradaCommandValidator(
            _notificationContextMock.Object,
            _integracaoSistemaRepositoryMock.Object);
    }

    [Fact]
    public async Task DeveValidarMensagemDeErroNomeObrigatorioAsync()
    {
        var command = new CriarFormaEntradaCommand
        {
            Nome = null!,
        };

        var result = await _validationRules.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.Nome)
           .WithErrorMessage("O nome da forma de entrada é obrigatório.");
    }

    [Fact]
    public async Task DeveTerErroQuandoNomeForMaiorQueLimiteMaximoAsync()
    {
        var command = new CriarFormaEntradaCommand
        {
            Nome = new string('a', 150),
        };

        var result = await _validationRules.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.Nome)
            .WithErrorMessage("O nome da forma de entrada deve ter no máximo 100 caracteres.");
    }

    [Fact]
    public async Task DeveTerErroQuandoNomeSistemaIntegracaoNaoEncontradoAsync()
    {
        var command = new CriarFormaEntradaCommand
        {
            Integracao = new()
            {
                new()
                {
                    NomeSistema = "SistemaInexistente",
                }
            },
        };

        var result = await _validationRules.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor("Integracao[0].NomeSistema")
            .WithErrorMessage("Nome do sistema de integração não encontrado.");
    }

    [Fact]
    public async Task DeveTerErroQuandoNomeSistemaIntegracaoUltrapassarLimiteAsync()
    {
        var command = new CriarFormaEntradaCommand
        {
            Integracao = new()
            {
                new()
                {
                    NomeSistema = new string('a', 150),
                }
            },
        };

        var result = await _validationRules.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor("Integracao[0].NomeSistema")
            .WithErrorMessage("O nome do sistema de integração deve ter no máximo 100 caracteres.");
    }

    [Fact]
    public async Task DeveTerErroQuandoCodigoOrigemUltrapassarLimiteAsync()
    {
        var command = new CriarFormaEntradaCommand
        {
            Integracao = new()
            {
                new ()
                {
                    CodigoOrigem = new string('a', 150),
                }
            },
        };

        var result = await _validationRules.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor("Integracao[0].CodigoOrigem")
            .WithErrorMessage("O código de origem da integração deve ter no máximo 100 caracteres.");
    }

    [Fact]
    public async Task DeveRetornarErroQuandoExederLimiteDeCaracteres()
    {
        var command = new CriarFormaEntradaCommand
        {
            Nome = "Nome",
            Descricao = new string('a', 300),
        };

        var result = await _validationRules.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.Descricao)
            .WithErrorMessage("A descrição da forma de entrada deve ter no máximo 255 caracteres.");
    }
}
