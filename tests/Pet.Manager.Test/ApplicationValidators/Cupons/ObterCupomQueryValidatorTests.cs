using Anima.Inscricao.Application.UseCases.Cupons.ObterCupom;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Cupons;

using FluentValidation.TestHelper;

using Moq;

namespace Anima.Inscricao.Test.ApplicationValidators.Cupons;

public class ObterCupomQueryValidatorTests
{
    private readonly Mock<INotificationContext> _notificationContextMock = new();
    private readonly Mock<ICupomRepository> _cupomRepositoryMock = new();
    private readonly ObterCupomQueryValidator _validationRules;

    public ObterCupomQueryValidatorTests()
    {
        _validationRules = new ObterCupomQueryValidator(
            _cupomRepositoryMock.Object,
            _notificationContextMock.Object);
    }

    [Fact]
    public async Task DeveValidarMensagemDeErroChaveObrigatoriaAsync()
    {
        var command = new ObterCupomQuery
        {
            Key = Guid.Empty,
        };

        var result = await _validationRules.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.Key)
           .WithErrorMessage("A chave do cupom é obrigatória.");
    }

    [Fact]
    public async Task DeveValidarMensagemDeErroChaveNaoEncontradaAsync()
    {
        var command = new ObterCupomQuery
        {
            Key = Guid.Empty,
        };

        var result = await _validationRules.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.Key)
           .WithErrorMessage("A chave do cupom não foi encontrada.");
    }
}
