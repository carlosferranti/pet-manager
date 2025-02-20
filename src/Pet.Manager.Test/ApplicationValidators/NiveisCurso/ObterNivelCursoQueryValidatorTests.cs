using Anima.Inscricao.Application.UseCases.NiveisCurso.ObterNivelCurso;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.NiveisCurso;

using FluentValidation.TestHelper;

using Moq;

namespace Anima.Inscricao.Test.ApplicationValidators.NiveisCurso;

public class ObterNivelCursoQueryValidatorTests
{
    private readonly Mock<INotificationContext> _notificationContextMock = new();
    private readonly Mock<INivelCursoRepository> _nivelCursoRepositoryMock = new();
    private readonly ObterNivelCursoQueryValidator _validationRules;

    public ObterNivelCursoQueryValidatorTests()
    {
        _validationRules = new ObterNivelCursoQueryValidator(
            _notificationContextMock.Object,
            _nivelCursoRepositoryMock.Object);
    }

    [Fact]
    public async Task DeveValidarMensagemDeErroChaveObrigatoriaAsync()
    {
        var command = new ObterNivelCursoQuery
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
        var command = new ObterNivelCursoQuery
        {
            Key = Guid.Empty,
        };

        var result = await _validationRules.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.Key)
           .WithErrorMessage("A chave do nível do curso não foi encontrada.");
    }
}
