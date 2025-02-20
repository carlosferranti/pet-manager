using Anima.Inscricao.Application.UseCases.Concursos.ProcessarRegraConcursoSegundaGraduacao;
using Anima.Inscricao.Domain._Shared.Notifications;

using FluentValidation.TestHelper;

using Moq;

namespace Anima.Inscricao.Test.ApplicationValidators.Concursos;

public class ProcessarRegraConcursoSegundaGraduacaoCommandValidatorTests
{
    private readonly Mock<INotificationContext> _notificationContextMock = new();
    private readonly ProcessarRegraConcursoSegundaGraduacaoCommandValidator _validationRules;

    public ProcessarRegraConcursoSegundaGraduacaoCommandValidatorTests()
    {
        _validationRules = new(_notificationContextMock.Object);
    }

    [Fact]
    public async Task DeveTerErroQuandoConcurosVazioAsync()
    {
        var command = new ProcessarRegraConcursoSegundaGraduacaoCommand
        {
            Concursos = new(),
        };

        var result = await _validationRules.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.Concursos)
           .WithErrorMessage("Os concursos precisam ser informados.");
    }

    [Fact]
    public async Task DeveTerErroQuandoIntakeNaoInformadoAsync()
    {
        var command = new ProcessarRegraConcursoSegundaGraduacaoCommand
        {
            VigenciaIntake = null!,
        };

        var result = await _validationRules.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.VigenciaIntake)
           .WithErrorMessage("A vigência do intake precisa ser informada.");
    }
}