using Anima.Inscricao.Application.UseCases.Concursos.ProcessarRegraConcursoDestrancamentoReopcao;
using Anima.Inscricao.Domain._Shared.Notifications;

using FluentValidation.TestHelper;

using Moq;

namespace Anima.Inscricao.Test.ApplicationValidators.Concursos;

public class ProcessarRegraConcursoDestrancamentoRetornoCommandValidatorTests
{
    private readonly Mock<INotificationContext> _notificationContextMock = new();
    private readonly ProcessarRegraConcursoDestrancamentoRetornoCommandValidator _validationRules;

    public ProcessarRegraConcursoDestrancamentoRetornoCommandValidatorTests()
    {
        _validationRules = new(_notificationContextMock.Object);
    }

    [Fact]
    public async Task DeveTerErroQuandoConcurosVazioAsync()
    {
        var command = new ProcessarRegraConcursoDestrancamentoRetornoCommand
        {
            Concursos = new(),
        };

        var result = await _validationRules.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.Concursos)
           .WithErrorMessage("Os concursos precisam ser informados.");
    }

    [Fact]
    public async Task DeveTerErroQuandoMarcaNaoInformadaAsync()
    {
        var command = new ProcessarRegraConcursoDestrancamentoRetornoCommand
        {
            Instituicao = null!,
        };

        var result = await _validationRules.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.Instituicao)
           .WithErrorMessage("A instituição precisa ser informada.");
    }
}