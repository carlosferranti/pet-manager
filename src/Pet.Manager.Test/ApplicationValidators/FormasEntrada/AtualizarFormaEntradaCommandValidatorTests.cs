using Anima.Inscricao.Application.UseCases.FormasEntrada.AtualizarFormaEntrada;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.FormasEntrada;

using FluentValidation.TestHelper;

using Moq;

namespace Anima.Inscricao.Test.ApplicationValidators.FormasEntrada;

public class AtualizarFormaEntradaCommandValidatorTests
{
    private readonly Mock<INotificationContext> _notificationContextMock = new();
    private readonly Mock<IFormaEntradaRepository> _formaEntradaRepositoryMock = new();
    private readonly AtualizarFormaEntradaCommandValidator _validationRules;

    public AtualizarFormaEntradaCommandValidatorTests()
    {
        _validationRules = new AtualizarFormaEntradaCommandValidator(
            _formaEntradaRepositoryMock.Object,
            _notificationContextMock.Object);
    }

    [Fact]
    public async Task DeveValidarMensagemDeErroNomeObrigatorioAsync()
    {
        var command = new AtualizarFormaEntradaCommand
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
        var command = new AtualizarFormaEntradaCommand
        {
            Nome = new string('a', 150),
        };

        var result = await _validationRules.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.Nome)
            .WithErrorMessage("O nome da forma de entrada deve ter no máximo 100 caracteres.");
    }

    [Fact]
    public async Task DeveValidarMensagemDeErroChaveObrigatoriaAsync()
    {
        var command = new AtualizarFormaEntradaCommand
        {
            Key = Guid.Empty,
        };

        var result = await _validationRules.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.Key)
           .WithErrorMessage("A chave da forma de entrada é obrigatória.");
    }

    [Fact]
    public async Task DeveValidarMensagemDeErroChaveNaoEncontradaAsync()
    {
        var command = new AtualizarFormaEntradaCommand
        {
            Key = Guid.NewGuid(),
        };

        var result = await _validationRules.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.Key)
           .WithErrorMessage("A chave da forma de entrada não foi encontrada.");
    }

    [Fact]
    public async Task DeveTerErroQuandoDescricaoForMaiorQueLimiteMaximoAsync()
    {
        var command = new AtualizarFormaEntradaCommand
        {
            Descricao = new string('a', 300),
        };

        var result = await _validationRules.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.Descricao)
            .WithErrorMessage("A descrição da forma de entrada deve ter no máximo 255 caracteres.");
    }
}
