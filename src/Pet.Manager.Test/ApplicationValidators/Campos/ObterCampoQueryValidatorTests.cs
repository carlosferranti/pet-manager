using Anima.Inscricao.Application.UseCases.Campos.ObterCampo;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Campos;

using FluentValidation.TestHelper;

using Moq;

namespace Anima.Inscricao.Test.ApplicationValidators.Campos;

public class ObterCampoQueryValidatorTests
{
    private readonly Mock<INotificationContext> _notificationContextMock = new();
    private readonly Mock<ICampoRepository> _campoRepositoryMock = new();
    private readonly ObterCampoQueryValidator _validationRules;

    public ObterCampoQueryValidatorTests()
    {
        _validationRules = new ObterCampoQueryValidator(
            _campoRepositoryMock.Object,
            _notificationContextMock.Object);
    }

    [Fact]
    public async Task DeveValidarMensagemDeErroChaveObrigatoriaAsync()
    {
        var command = new ObterCampoQuery
        {
            Key = Guid.Empty,
        };

        var result = await _validationRules.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.Key)
           .WithErrorMessage("A chave do campo é obrigatória.");
    }

    [Fact]
    public async Task DeveValidarMensagemDeErroChaveNaoEncontradaAsync()
    {
        var command = new ObterCampoQuery
        {
            Key = Guid.Empty,
        };

        var result = await _validationRules.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.Key)
           .WithErrorMessage("A chave do campo não foi encontrada.");
    }
}
