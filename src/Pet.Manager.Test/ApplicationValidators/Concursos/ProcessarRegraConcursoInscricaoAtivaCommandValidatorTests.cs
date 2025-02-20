using Anima.Inscricao.Application.UseCases.Concursos.ProcessarRegraConcursoInscricaoAtiva;
using Anima.Inscricao.Domain._Shared.Notifications;

using FluentValidation.TestHelper;

using Moq;

namespace Anima.Inscricao.Test.ApplicationValidators.Concursos;

public class ProcessarRegraConcursoInscricaoAtivaCommandValidatorTests
{
    private readonly Mock<INotificationContext> _notificationContextMock = new();
    private readonly ProcessarRegraConcursoInscricaoAtivaCommandValidator _validationRules;

    public ProcessarRegraConcursoInscricaoAtivaCommandValidatorTests()
    {
        _validationRules = new(_notificationContextMock.Object);
    }

    [Fact]
    public async Task DeveTerErroQuandoConcurosVazioAsync()
    {
        var command = new ProcessarRegraConcursoInscricaoAtivaCommand
        {
            FormasEntrada = new(),
        };

        var result = await _validationRules.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.FormasEntrada)
           .WithErrorMessage("As formas de entrada precisam ser informadas.");
    }

    [Fact]
    public async Task DeveTerErroQuandoCpfNaoInformadoAsync()
    {
        var command = new ProcessarRegraConcursoInscricaoAtivaCommand
        {
            Cpf = null!,
        };

        var result = await _validationRules.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.Cpf)
           .WithErrorMessage("O cpf é obrigatório.");
    }

    [Fact]
    public async Task DeveTerErroQuandoIntakeNaoInformadoAsync()
    {
        var command = new ProcessarRegraConcursoInscricaoAtivaCommand
        {
            IntakeKey = Guid.Empty,
        };

        var result = await _validationRules.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.IntakeKey)
           .WithErrorMessage("A chave do intake é obrigatória.");
    }

    [Fact]
    public async Task DeveTerErroQuandoMarcaNaoInformadoAsync()
    {
        var command = new ProcessarRegraConcursoInscricaoAtivaCommand
        {
            MarcaKey = Guid.Empty,
        };

        var result = await _validationRules.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.MarcaKey)
           .WithErrorMessage("A chave da marca é obrigatória.");
    }
}
