using Anima.Inscricao.Application.UseCases.Instituicoes.AtualizarInstituicao;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Instituicoes;
using Anima.Inscricao.Domain.Marcas;

using FluentValidation.TestHelper;

using Moq;

namespace Anima.Inscricao.Test.ApplicationValidators.Instituicao;

public class AtualizarInstituicaoCommandValidatorTests
{
    private readonly Mock<INotificationContext> _notificationContextMock = new();
    private readonly Mock<IInstituicaoRepository> _instituicaoRepositoryMock = new();
    private readonly Mock<IMarcaRepository> _marcaRepositoryMock = new();
    private readonly AtualizarInstituicaoCommandValidator _validationRules;

    public AtualizarInstituicaoCommandValidatorTests()
    {
        _validationRules = new AtualizarInstituicaoCommandValidator(
            _notificationContextMock.Object,
            _instituicaoRepositoryMock.Object,
            _marcaRepositoryMock.Object);
    }

    [Fact]
    public async Task DeveValidarMensagemDeErroNomeObrigatorioAsync()
    {
        var command = new AtualizarInstituicaoCommand
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
        var command = new AtualizarInstituicaoCommand
        {
            Nome = new string('a', 150),
        };

        var result = await _validationRules.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.Nome)
            .WithErrorMessage("O nome da instituição deve ter no máximo 100 caracteres.");
    }

    [Fact]
    public async Task DeveValidarMensagemDeErroSiglaObrigatorioAsync()
    {
        var command = new AtualizarInstituicaoCommand
        {
            Sigla = string.Empty,
        };

        var result = await _validationRules.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.Sigla)
            .WithErrorMessage("A sigla da instituição deve conter um valor valido.");
    }

    [Fact]
    public async Task DeveTerErroQuandoSiglaForMaiorQueLimiteMaximoAsync()
    {
        var command = new AtualizarInstituicaoCommand
        {
            Sigla = new string('a', 150),
        };

        var result = await _validationRules.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.Sigla)
            .WithErrorMessage("A sigla da instituição deve ter no máximo 50 caracteres.");
    }

    [Fact]
    public async Task DeveValidarMensagemDeErroChaveObrigatorioAsync()
    {
        var command = new AtualizarInstituicaoCommand
        {
            Key = Guid.Empty,
        };

        var result = await _validationRules.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.Key)
            .WithErrorMessage("A chave da instituição é obrigatória.");
    }

    [Fact]
    public async Task DeveValidarMensagemDeErroChaveNaoEncontradaAsync()
    {
        var command = new AtualizarInstituicaoCommand
        {
            Key = Guid.Empty,
        };

        var result = await _validationRules.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.Key)
            .WithErrorMessage("A chave da instituição não foi encontrada.");
    }
}
