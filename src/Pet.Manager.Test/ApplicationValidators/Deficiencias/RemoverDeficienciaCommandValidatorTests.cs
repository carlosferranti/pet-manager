using Anima.Inscricao.Application.UseCases.Deficiencias.RemoverDeficiencia;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Deficiencias;

using FluentValidation.TestHelper;

using Moq;

namespace Anima.Inscricao.Test.ApplicationValidators.Deficiencias;

public class RemoverDeficienciaCommandValidatorTests
{
    private readonly Mock<INotificationContext> _notificationContextMock = new();
    private readonly Mock<IDeficienciaRepository> _deficienciaRepositoryMock = new();
    private readonly RemoverDeficienciaCommandValidator _validationRules;

    public RemoverDeficienciaCommandValidatorTests()
    {
        _validationRules = new(
            _deficienciaRepositoryMock.Object,
            _notificationContextMock.Object);
    }

    [Fact]
    public async Task DeveValidarMensagemDeErroChaveObrigatoriaAsync()
    {
        var command = new RemoverDeficienciaCommand
        {
            Key = Guid.Empty,
        };

        var result = await _validationRules.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.Key)
           .WithErrorMessage("A chave da deficiência é obrigatória.");
    }

    [Fact]
    public async Task DeveValidarMensagemDeErroChaveNaoEncontradaAsync()
    {
        var command = new RemoverDeficienciaCommand
        {
            Key = Guid.Empty,
        };

        var result = await _validationRules.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.Key)
           .WithErrorMessage("A chave da deficiência não foi encontrada.");
    }
}
