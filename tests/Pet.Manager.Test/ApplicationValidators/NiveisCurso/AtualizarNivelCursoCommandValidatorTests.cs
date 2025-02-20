using Anima.Inscricao.Application.UseCases.NiveisCurso.AtualizarNivelCurso;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.NiveisCurso;

using FluentValidation.TestHelper;

using Moq;

namespace Anima.Inscricao.Test.ApplicationValidators.NiveisCurso;

public class AtualizarNivelCursoCommandValidatorTests
{
    private readonly Mock<INotificationContext> _notificationContextMock = new();
    private readonly Mock<INivelCursoRepository> _nivelCursoRepositoryMock = new();
    private readonly AtualizarNivelCursoCommandValidator _validationRules;

    public AtualizarNivelCursoCommandValidatorTests()
    {
        _validationRules = new AtualizarNivelCursoCommandValidator(
            _notificationContextMock.Object,
            _nivelCursoRepositoryMock.Object);
    }

    [Fact]
    public async Task DeveValidarMensagemDeErroNomeObrigatorioAsync()
    {
        var command = new AtualizarNivelCursoCommand
        {
            Nome = null!,
        };

        var result = await _validationRules.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.Nome)
           .WithErrorMessage("O nome do nível do curso é obrigatório.");
    }

    [Fact]
    public async Task DeveTerErroQuandoNomeForMaiorQueLimiteMaximoAsync()
    {
        var command = new AtualizarNivelCursoCommand
        {
            Nome = new string('a', 256),
        };

        var result = await _validationRules.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.Nome)
            .WithErrorMessage("O nome do nível do curso deve ter no máximo 255 caracteres.");
    }

    [Fact]
    public async Task DeveValidarMensagemDeErroChaveObrigatorioAsync()
    {
        var command = new AtualizarNivelCursoCommand
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
        var command = new AtualizarNivelCursoCommand
        {
            Key = Guid.NewGuid(),
        };

        _nivelCursoRepositoryMock.Setup(x => x.ExistsAsync(command.Key, default))
            .ReturnsAsync(false);

        var result = await _validationRules.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.Key)
            .WithErrorMessage("A chave do nível do curso não foi encontrada.");
    }
}
