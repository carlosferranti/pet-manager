using Anima.Inscricao.Application.UseCases.Campi.ObterCampus;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Campi;

using FluentValidation.TestHelper;

using Moq;

namespace Anima.Inscricao.Test.ApplicationValidators.Campi;

public class ObterCampusQueryValidatorTests
{
    private readonly Mock<INotificationContext> _notificationContextMock = new();
    private readonly Mock<ICampusRepository> _campusRepositoryMock = new();
    private readonly ObterCampusQueryValidator _validationRules;

    public ObterCampusQueryValidatorTests()
    {
        _validationRules = new ObterCampusQueryValidator(
            _campusRepositoryMock.Object,
            _notificationContextMock.Object);
    }

    [Fact]
    public async Task DeveValidarMensagemDeErroChaveObrigatoriaAsync()
    {
        var command = new ObterCampusQuery
        {
            Key = Guid.Empty,
        };

        var result = await _validationRules.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.Key)
           .WithErrorMessage("A chave do campus é obrigatória.");
    }

    [Fact]
    public async Task DeveValidarMensagemDeErroChaveNaoEncontradaAsync()
    {
        var command = new ObterCampusQuery
        {
            Key = Guid.Empty,
        };

        var result = await _validationRules.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.Key)
           .WithErrorMessage("A chave do campus não foi encontrada.");
    }
}
