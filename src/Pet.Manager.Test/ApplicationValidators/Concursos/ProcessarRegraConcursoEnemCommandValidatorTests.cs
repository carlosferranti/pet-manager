using Anima.Inscricao.Application.UseCases.Concursos.ProcessarRegraConcursoEnem;
using Anima.Inscricao.Domain._Shared.Notifications;

using FluentValidation.TestHelper;

using Moq;

namespace Anima.Inscricao.Test.ApplicationValidators.Concursos;

public class ProcessarRegraConcursoEnemCommandValidatorTests
{
    private readonly Mock<INotificationContext> _notificationContextMock = new();
    private readonly ProcessarRegraConcursoEnemCommandValidator _validationRules;

    public ProcessarRegraConcursoEnemCommandValidatorTests()
    {
        _validationRules = new(_notificationContextMock.Object);
    }

    [Fact]
    public async Task DeveTerErroQuandoConcurosVazioAsync()
    {
        var command = new ProcessarRegraConcursoEnemCommand
        {
            Concursos = new(),
        };

        var result = await _validationRules.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.Concursos)
           .WithErrorMessage("Os concursos precisam ser informados.");
    }

    [Fact]
    public async Task DeveTerErroQuandoCpfNaoInformadoAsync()
    {
        var command = new ProcessarRegraConcursoEnemCommand
        {
            Cpf = null!,
        };

        var result = await _validationRules.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.Cpf)
           .WithErrorMessage("O cpf não pode ser vazio.");
    }
}