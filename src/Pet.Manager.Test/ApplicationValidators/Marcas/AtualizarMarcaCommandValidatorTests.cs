using Anima.Inscricao.Application.UseCases.Marcas.AtualizarMarca;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Marcas;

using FluentValidation.TestHelper;

using Moq;

namespace Anima.Inscricao.Test.ApplicationValidators.Marcas;

public class AtualizarMarcaCommandValidatorTests
{
    private readonly Mock<INotificationContext> _notificationContextMock = new();
    private readonly Mock<IMarcaRepository> _marcaRepositoryMock = new();
    private readonly AtualizarMarcaCommandValidator _validationRules;

    public AtualizarMarcaCommandValidatorTests()
    {
        _validationRules = new AtualizarMarcaCommandValidator(
            _notificationContextMock.Object,
            _marcaRepositoryMock.Object);
    }

    [Fact]
    public async Task DeveValidarMensagemDeErroNomeObrigatorioAsync()
    {
        var command = new AtualizarMarcaCommand
        {
            Nome = null!,
        };

        var result = await _validationRules.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.Nome)
            .WithErrorMessage("O nome da marca é obrigatório.");
    }

    [Fact]
    public async Task DeveTerErroQuandoNomeForMaiorQueLimiteMaximoAsync()
    {
        var command = new AtualizarMarcaCommand
        {
            Nome = new string('a', 150),
        };

        var result = await _validationRules.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.Nome)
            .WithErrorMessage("O nome da marca deve ter no máximo 100 caracteres.");
    }

    [Fact]
    public async Task DeveValidarMensagemDeErroSiglaObrigatorioAsync()
    {
        var command = new AtualizarMarcaCommand
        {
            Sigla = string.Empty,
        };

        var result = await _validationRules.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.Sigla)
            .WithErrorMessage("A sigla da marca deve conter um valor valido.");
    }

    [Fact]
    public async Task DeveTerErroQuandoSiglaForMaiorQueLimiteMaximoAsync()
    {
        var command = new AtualizarMarcaCommand
        {
            Sigla = new string('a', 150),
        };

        var result = await _validationRules.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.Sigla)
            .WithErrorMessage("A sigla da marca deve ter no máximo 50 caracteres.");
    }

    [Fact]
    public async Task DeveValidarMensagemDeErroChaveObrigatorioAsync()
    {
        var command = new AtualizarMarcaCommand
        {
            Key = Guid.Empty,
        };

        var result = await _validationRules.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.Key)
            .WithErrorMessage("A chave da marca é obrigatória.");
    }

    [Fact]
    public async Task DeveValidarMensagemDeErroChaveNaoEncontradaAsync()
    {
        var command = new AtualizarMarcaCommand
        {
            Key = Guid.Empty,
        };

        var result = await _validationRules.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.Key)
            .WithErrorMessage("A chave da marca não foi encontrada.");
    }
}
