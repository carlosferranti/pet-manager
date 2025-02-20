using Anima.Inscricao.Application.UseCases.CursosExternos.ObterCursoExterno;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.CursosExternos;

using FluentValidation.TestHelper;

using Moq;

namespace Anima.Inscricao.Test.ApplicationValidators.CursosExternos;

public class ObterCursoExternoQueryValidatorTests
{
    private readonly Mock<INotificationContext> _notificationContextMock = new();
    private readonly Mock<ICursoExternoRepository> _cursoExternoRepositoryMock = new();
    private readonly ObterCursoExternoQueryValidator _validationRules;

    public ObterCursoExternoQueryValidatorTests()
    {
        _validationRules = new ObterCursoExternoQueryValidator(
            _notificationContextMock.Object,
            _cursoExternoRepositoryMock.Object);
    }

    [Fact]
    public async Task DeveValidarMensagemDeErroChaveObrigatoriaAsync()
    {
        // Arrange
        var command = new ObterCursoExternoQuery
        {
            Key = Guid.Empty,
        };

        // Act
        var result = await _validationRules.TestValidateAsync(command);

        // Assert
        result.ShouldHaveValidationErrorFor(x => x.Key)
           .WithErrorMessage("A chave do curso externo é obrigatória.");
    }

    [Fact]
    public async Task DeveValidarMensagemDeErroChaveNaoEncontradaAsync()
    {
        // Arrange
        var command = new ObterCursoExternoQuery
        {
            Key = Guid.Empty,
        };

        // Act
        var result = await _validationRules.TestValidateAsync(command);

        // Assert
        result.ShouldHaveValidationErrorFor(x => x.Key)
           .WithErrorMessage("A chave do curso externo não foi encontrada.");
    }
}
