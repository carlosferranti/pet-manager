using Anima.Inscricao.Application._Shared.DTOs;
using Anima.Inscricao.Application.UseCases.Links.CriarLink;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.FormasEntrada;

using FluentValidation.TestHelper;

using Moq;

namespace Anima.Inscricao.Test.ApplicationValidators.Links;

public class CriarLinkCommandValidatorTests
{
    private readonly Mock<INotificationContext> _notificationContextMock = new();
    private readonly Mock<IFormaEntradaRepository> _formaEntradaRepositoryMock = new();
    private readonly CriarLinkCommandValidator _validationRules;

    public CriarLinkCommandValidatorTests()
    {
        _validationRules = new CriarLinkCommandValidator(
            _notificationContextMock.Object,
            _formaEntradaRepositoryMock.Object);
    }

    [Fact]
    public async Task DeveValidarMensagemDeErroNomeObrigatorioAsync()
    {
        var command = new CriarLinkCommand
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
        var command = new CriarLinkCommand
        {
            Nome = new string('a', 350),
        };

        var result = await _validationRules.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.Nome)
            .WithErrorMessage("O nome do link deve ter no máximo 250 caracteres.");
    }

    [Fact]
    public async Task DeveTerErroQuandoFormaDeEntradaNaoPreenchidaAsync()
    {
        var command = new CriarLinkCommand
        {
            FormasEntrada = null!,
        };

        var result = await _validationRules.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor("FormasEntrada")
           .WithErrorMessage("As chaves das formas de entrada são obrigatórias.");
    }

    [Fact]
    public async Task DeveTerErroQuandoChaveVaziaAsync()
    {
        var command = new CriarLinkCommand
        {
            FormasEntrada = new List<EntityKeyDto>()
            {
                new EntityKeyDto()
                {
                    Key = Guid.Empty,
                }
            },
        };

        var result = await _validationRules.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor("FormasEntrada[0].Key")
           .WithErrorMessage("A chave da forma de entrada é obrigatória.");
    }

    [Fact]
    public async Task DeveTerErroQuandoChaveNaoEncontradaAsync()
    {
        var command = new CriarLinkCommand
        {
            FormasEntrada = new List<EntityKeyDto>()
            {
                new EntityKeyDto()
                {
                    Key = Guid.NewGuid(),
                }
            }
        };

        var result = await _validationRules.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor("FormasEntrada[0].Key")
           .WithErrorMessage("A chave da forma de entrada não foi encontrada.");
    }
}