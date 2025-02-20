using Anima.Inscricao.Application.UseCases.Inscricoes.CriarIntegracaoInscricaoCandidato;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.IntegracaoSistemas;
using Anima.Inscricoes.Domain.Inscricoes;

using FluentValidation.TestHelper;

using Moq;

namespace Anima.Inscricao.Test.ApplicationValidators.Inscricoes;

public class CriarIntegracaoInscricaoCandidatoCommandValidatorTests
{
    private readonly Mock<INotificationContext> _notificationContextMock = new();
    private readonly Mock<IIntegracaoSistemaRepository> _integracaoSistemaRepositoryMock = new();
    private readonly Mock<IInscricaoRepository> _inscricaoRepositoryMock = new();
    private readonly CriarIntegracaoInscricaoCandidatoCommandValidator _validationRules;

    public CriarIntegracaoInscricaoCandidatoCommandValidatorTests()
    {
        _validationRules = new CriarIntegracaoInscricaoCandidatoCommandValidator(
            _notificationContextMock.Object,
            _integracaoSistemaRepositoryMock.Object,
            _inscricaoRepositoryMock.Object);
    }

    [Fact]
    public async Task DeveTerErroQuandoNomeSistemaIntegracaoNaoEncontradoAsync()
    {
        var command = new CriarIntegracaoInscricaoCandidatoCommand
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
        var command = new CriarIntegracaoInscricaoCandidatoCommand
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
        var command = new CriarIntegracaoInscricaoCandidatoCommand
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

    [Fact]
    public async Task DeveTerErroQuandoInscricaoNaoEncontradaAsync()
    {
        var command = new CriarIntegracaoInscricaoCandidatoCommand
        {
            InscricaoCandidatoKey = Guid.NewGuid(),
        };

        var result = await _validationRules.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.InscricaoCandidatoKey)
            .WithErrorMessage("A chave da inscrição não foi encontrada.");
    }

    [Fact]
    public async Task DeveTerErroQuandoInscricaoNaoPreenchidaAsync()
    {
        var command = new CriarIntegracaoInscricaoCandidatoCommand
        {
            InscricaoCandidatoKey = Guid.Empty,
        };

        var result = await _validationRules.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.InscricaoCandidatoKey)
            .WithErrorMessage("A chave da inscrição é obrigatória.");
    }
}