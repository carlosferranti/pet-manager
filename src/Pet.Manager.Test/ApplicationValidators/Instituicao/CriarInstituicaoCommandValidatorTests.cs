using System.Linq.Expressions;

using Anima.Inscricao.Application.UseCases.Campi.CriarCampus;
using Anima.Inscricao.Application.UseCases.Instituicoes.CriarInstituicao;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Instituicoes;
using Anima.Inscricao.Domain.IntegracaoSistemas;
using Anima.Inscricao.Domain.IntegracaoSistemas.Entities;
using Anima.Inscricao.Domain.Marcas;

using FluentValidation.TestHelper;

using Moq;

namespace Anima.Inscricao.Test.ApplicationValidators.Instituicao;

public class CriarInstituicaoCommandValidatorTests
{
    private readonly Mock<INotificationContext> _notificationContextMock = new();
    private readonly Mock<IMarcaRepository> _marcaRepositoryMock = new();
    private readonly Mock<IIntegracaoSistemaRepository> _sistemasIntegracaoRepository = new();
    private readonly CriarInstituicaoCommandValidator _validationRules;

    public CriarInstituicaoCommandValidatorTests()
    {
        _validationRules = new CriarInstituicaoCommandValidator(
             _marcaRepositoryMock.Object,
            _notificationContextMock.Object,
            _sistemasIntegracaoRepository.Object);
    }

    [Fact]
    public async Task DeveValidarMensagemDeErroNomeObrigatorioAsync()
    {
        var command = new CriarInstituicaoCommand
        {
            Nome = null!,
        };

        var result = await _validationRules.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.Nome)
            .WithErrorMessage("O nome da instituição é obrigatório.");
    }

    [Fact]
    public async Task DeveTerErroQuandoNomeForMaiorQueLimiteMaximoAsync()
    {
        var command = new CriarInstituicaoCommand
        {
            Nome = new string('a', 101),
        };

        var result = await _validationRules.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.Nome)
            .WithErrorMessage("O nome da instituição deve ter no máximo 100 caracteres.");
    }

    [Fact]
    public async Task DeveValidarMensagemDeErroSiglaDeveConterUmvalorValidoAsync()
    {
        var command = new CriarInstituicaoCommand
        {
            Sigla = null!,
        };

        var result = await _validationRules.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.Sigla)
            .WithErrorMessage("A sigla da instituição é obrigatória.");
    }

    [Fact]
    public async Task DeveTerErroQuandoSiglaForMaiorQueLimiteMaximoAsync()
    {
        var command = new CriarInstituicaoCommand
        {
            Sigla = new string('a', 51),
        };

        var result = await _validationRules.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.Sigla)
            .WithErrorMessage("A sigla da instituição deve ter no máximo 50 caracteres.");
    }

    [Fact]
    public async Task DeveTerErroQuandoNomeSistemaIntegracaoNaoEncontradoAsync()
    {
        var command = new CriarInstituicaoCommand
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
        var command = new CriarInstituicaoCommand
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
        var command = new CriarInstituicaoCommand
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
