using Anima.Inscricao.Application.UseCases.Acessibilidades.ObterAcessibilidade;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Acessibilidades;

using FluentValidation.TestHelper;

using Moq;

namespace Anima.Inscricao.Test.ApplicationValidators.Acessibilidades;

public class ObterAcessibilidadeQueryValidatorTests
{
    private readonly Mock<INotificationContext> _notificationContextMock = new();
    private readonly Mock<IAcessibilidadeRepository> _acessibilidadeRepositoryMock = new();
    private readonly ObterAcessibilidadeQueryValidator _validationRules;

    public ObterAcessibilidadeQueryValidatorTests()
    {
        _validationRules = new ObterAcessibilidadeQueryValidator(
            _acessibilidadeRepositoryMock.Object,
            _notificationContextMock.Object);
    }

    [Fact]
    public async Task DeveValidarMensagemDeErroChaveObrigatoriaAsync()
    {
        var command = new ObterAcessibilidadeQuery
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
        var command = new ObterAcessibilidadeQuery
        {
            Key = Guid.Empty,
        };

        var result = await _validationRules.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.Key)
           .WithErrorMessage("A acessibilidade não foi encontrada.");
    }
}
