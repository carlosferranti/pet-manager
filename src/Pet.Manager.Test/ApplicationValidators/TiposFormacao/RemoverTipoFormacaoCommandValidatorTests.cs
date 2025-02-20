using Anima.Inscricao.Application.UseCases.TiposFormacao.RemoverTipoFormacao;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.TiposFormacao;

using FluentValidation.TestHelper;

using Moq;

namespace Anima.Inscricao.Test.ApplicationValidators.TiposFormacao;

public class RemoverTipoFormacaoCommandValidatorTests
{
    private readonly Mock<INotificationContext> _notificationContextMock = new();
    private readonly Mock<ITipoFormacaoRepository> _tipoFormacaoRepositoryMock = new();
    private readonly RemoverTipoFormacaoCommandValidator _validationRules;

    public RemoverTipoFormacaoCommandValidatorTests()
    {
        _validationRules = new RemoverTipoFormacaoCommandValidator(
            _tipoFormacaoRepositoryMock.Object,
            _notificationContextMock.Object);
    }

    [Fact]
    public async Task DeveValidarMensagemDeErroChaveObrigatoriaAsync()
    {
        var command = new RemoverTipoFormacaoCommand
        {
            Key = Guid.Empty,
        };

        var result = await _validationRules.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.Key)
           .WithErrorMessage("A chave do tipo de formação é obrigatório.");
    }

    [Fact]
    public async Task DeveValidarMensagemDeErroChaveNaoEncontradaAsync()
    {
        var command = new RemoverTipoFormacaoCommand
        {
            Key = Guid.Empty,
        };

        var result = await _validationRules.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.Key)
           .WithErrorMessage("A chave do tipo de formação não foi encontrado.");
    }
}
