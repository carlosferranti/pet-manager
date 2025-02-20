using Anima.Inscricao.Application.UseCases.Links.AtualizarLink;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.FormasEntrada;
using Anima.Inscricao.Domain.Links;

using FluentValidation.TestHelper;

using Moq;

namespace Anima.Inscricao.Test.ApplicationValidators.Links;

public class AtualizarLinkCommandValidatorTests
{
    private readonly Mock<INotificationContext> _notificationContextMock = new();
    private readonly Mock<ILinkRepository> _linkRepositoryMock = new();
    private readonly Mock<IFormaEntradaRepository> _formaEntradaRepositoryMock = new();
    private readonly AtualizarLinkCommandValidator _validationRules;

    public AtualizarLinkCommandValidatorTests()
    {
        _validationRules = new(
            _notificationContextMock.Object,
            _formaEntradaRepositoryMock.Object,
            _linkRepositoryMock.Object);
    }

    [Fact]
    public async Task DeveValidarMensagemDeErroNomeObrigatorioAsync()
    {
        var command = new AtualizarLinkCommand
        {
            Nome = null!,
        };

        var result = await _validationRules.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.Nome)
           .WithErrorMessage("O nome do link é obrigatório.");
    }

    [Fact]
    public async Task DeveTerErroQuandoNomeForMaiorQueLimiteMaximoAsync()
    {
        var command = new AtualizarLinkCommand
        {
            Nome = new string('a', 350),
        };

        var result = await _validationRules.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.Nome)
            .WithErrorMessage("O nome do link deve ter no máximo 250 caracteres.");
    }

    [Fact]
    public async Task DeveTerErroQuandoChaveVaziaAsync()
    {
        var command = new AtualizarLinkCommand
        {
            Key = Guid.Empty,
        };

        var result = await _validationRules.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.Key)
           .WithErrorMessage("A chave do link é obrigatória.");
    }

    [Fact]
    public async Task DeveTerErroQuandoChaveNaoEncontradaAsync()
    {
        var command = new AtualizarLinkCommand
        {
            Key = Guid.NewGuid(),
        };

        var result = await _validationRules.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.Key)
           .WithErrorMessage("A chave do link não foi encontrada.");
    }
}