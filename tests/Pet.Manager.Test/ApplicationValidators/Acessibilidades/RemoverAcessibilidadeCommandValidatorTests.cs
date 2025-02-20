using Anima.Inscricao.Application.UseCases.Acessibilidades.RemoverAcessibilidade;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Acessibilidades;

using FluentValidation.TestHelper;

using Moq;

namespace Anima.Inscricao.Test.ApplicationValidators.Acessibilidades;

public class RemoverAcessibilidadeCommandValidatorTests
{
    private readonly Mock<INotificationContext> _notificationContextMock = new();
    private readonly Mock<IAcessibilidadeRepository> _acessibilidadeRepositoryMock = new();
    private readonly RemoverAcessibilidadeCommandValidator _validationRules;

    public RemoverAcessibilidadeCommandValidatorTests()
    {
        _validationRules = new RemoverAcessibilidadeCommandValidator(
            _notificationContextMock.Object, 
            _acessibilidadeRepositoryMock.Object);
    }

    [Fact]
    public async Task DeveValidarMensagemDeErroChaveObrigatoriaAsync()
    {
        var command = new RemoverAcessibilidadeCommand
        {
            Key = Guid.Empty,
        };

        var result = await _validationRules.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.Key)
            .WithErrorMessage("A chave da acessibilidade é obrigatória.");
    }

    [Fact]
    public async Task DeveValidarMensagemDeErroChaveNaoEncontradaAsync()
    {
        var command = new RemoverAcessibilidadeCommand
        {
            Key = Guid.Empty,
        };

        var result = await _validationRules.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.Key)
            .WithErrorMessage("Acessibilidade não encontrada.");
    }
}
