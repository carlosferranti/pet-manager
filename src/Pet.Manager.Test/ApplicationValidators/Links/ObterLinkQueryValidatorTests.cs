using Anima.Inscricao.Application.UseCases.Links.ObterLink;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Links;

using FluentValidation.TestHelper;

using Moq;

namespace Anima.Inscricao.Test.ApplicationValidators.Links;

public class ObterLinkQueryValidatorTests
{
    private readonly Mock<INotificationContext> _notificationContextMock = new();
    private readonly Mock<ILinkRepository> _linkRepositoryMock = new();
    private readonly ObterLinkQueryValidator _validationRules;

    public ObterLinkQueryValidatorTests()
    {
        _validationRules = new ObterLinkQueryValidator(
            _linkRepositoryMock.Object,
            _notificationContextMock.Object);
    }

    [Fact]
    public async Task DeveValidarMensagemDeErroChaveObrigatoriaAsync()
    {
        var command = new ObterLinkQuery
        {
            Key = Guid.Empty,
        };

        var result = await _validationRules.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.Key)
           .WithErrorMessage("A chave do link é obrigatória.");
    }

    [Fact]
    public async Task DeveValidarMensagemDeErroChaveNaoEncontradaAsync()
    {
        var command = new ObterLinkQuery
        {
            Key = Guid.NewGuid(),
        };

        var result = await _validationRules.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.Key)
           .WithErrorMessage("A chave do link não foi encontrada.");
    }
}