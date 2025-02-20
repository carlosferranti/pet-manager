using Anima.Inscricao.Application.UseCases.Fichas.ObterFicha;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Fichas;

using FluentValidation.TestHelper;

using Moq;

namespace Anima.Inscricao.Test.ApplicationValidators.Fichas;

public class ObterFichaQueryValidatorTests
{
    private readonly Mock<INotificationContext> _notificationContextMock = new();
    private readonly Mock<IFichaRepository> _fichaRepository = new();
    private readonly ObterFichaQueryValidator _validationRules;

    public ObterFichaQueryValidatorTests()
    {
        _validationRules = new(
            _fichaRepository.Object,
            _notificationContextMock.Object);
    }

    [Fact]
    public async Task DeveValidarMensagemDeErroChaveObrigatoriaAsync()
    {
        var command = new ObterFichaQuery
        {
            Key = Guid.Empty,
        };

        var result = await _validationRules.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.Key)
           .WithErrorMessage("A chave da ficha é obrigatória.");
    }

    [Fact]
    public async Task DeveValidarMensagemDeErroChaveNaoEncontradaAsync()
    {
        var command = new ObterFichaQuery
        {
            Key = Guid.Empty,
        };

        var result = await _validationRules.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.Key)
           .WithErrorMessage("A chave da ficha não foi encontrada.");
    }
}