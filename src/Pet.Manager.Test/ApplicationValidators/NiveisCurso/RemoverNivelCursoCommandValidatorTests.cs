using Anima.Inscricao.Application.UseCases.NiveisCurso.RemoverNivelCurso;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.NiveisCurso;

using FluentValidation.TestHelper;

using Moq;

namespace Anima.Inscricao.Test.ApplicationValidators.NiveisCurso;

public class RemoverNivelCursoCommandValidatorTests
{
    private readonly Mock<INotificationContext> _notificationContextMock = new();
    private readonly Mock<INivelCursoRepository> _nivelCursoRepositoryMock = new();
    private readonly RemoverNivelCursoCommandValidator _validationRules;

    public RemoverNivelCursoCommandValidatorTests()
    {
        _validationRules = new RemoverNivelCursoCommandValidator(
            _nivelCursoRepositoryMock.Object,
            _notificationContextMock.Object);
    }

    [Fact]
    public async Task DeveValidarMensagemDeErroChaveObrigatoriaAsync()
    {
        var command = new RemoverNivelCursoCommand
        {
            Key = Guid.Empty,
        };

        var result = await _validationRules.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.Key)
           .WithErrorMessage("A chave do nível do curso é obrigatória.");
    }

    [Fact]
    public async Task DeveValidarMensagemDeErroChaveNaoEncontradaAsync()
    {
        var command = new RemoverNivelCursoCommand
        {
            Key = Guid.Empty,
        };

        var result = await _validationRules.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.Key)
           .WithErrorMessage("A chave do nível do curso não foi encontrada.");
    }
}
