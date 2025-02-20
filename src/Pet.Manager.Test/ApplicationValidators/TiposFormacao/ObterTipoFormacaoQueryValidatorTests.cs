using Anima.Inscricao.Application.UseCases.TiposFormacao.ObterTipoFormacao;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.TiposFormacao;

using FluentValidation.TestHelper;

using Moq;

namespace Anima.Inscricao.Test.ApplicationValidators.TiposFormacao;

public class ObterTipoFormacaoQueryValidatorTests
{
    private readonly Mock<INotificationContext> _notificationContextMock = new();
    private readonly Mock<ITipoFormacaoRepository> _tipoFormacaoRepository = new();
    private readonly ObterTipoFormacaoQueryValidator _validationRules;

    public ObterTipoFormacaoQueryValidatorTests()
    {
        _validationRules = new ObterTipoFormacaoQueryValidator(
            _tipoFormacaoRepository.Object,
            _notificationContextMock.Object);
    }

    [Fact]
    public async Task DeveValidarMensagemDeErroChaveObrigatoriaAsync()
    {
        var command = new ObterTipoFormacaoQuery
        {
            Key = Guid.Empty,
        };

        var result = await _validationRules.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.Key)
           .WithErrorMessage("A chave do tipo de formação é obrigatória.");
    }

    [Fact]
    public async Task DeveValidarMensagemDeErroChaveNaoEncontradaAsync()
    {
        var command = new ObterTipoFormacaoQuery
        {
            Key = Guid.Empty,
        };

        var result = await _validationRules.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.Key)
           .WithErrorMessage("A chave do tipo de formação não foi encontrada.");
    }
}