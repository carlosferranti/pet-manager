using Anima.Inscricao.Application.UseCases.Configuracoes.ObterConfiguracao;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Configuracoes;

using FluentValidation.TestHelper;

using Moq;

namespace Anima.Inscricao.Test.ApplicationValidators.Configuracoes;

public class ObterConfiguracaoQueryValidatorTests
{
    private readonly Mock<INotificationContext> _notificationContextMock = new();
    private readonly Mock<IConfiguracaoRepository> _configuracaoRepositoryMock = new();
    private readonly ObterConfiguracaoQueryValidator _validationRules;

    public ObterConfiguracaoQueryValidatorTests()
    {
        _validationRules = new ObterConfiguracaoQueryValidator(
            _notificationContextMock.Object,
            _configuracaoRepositoryMock.Object);
    }

    [Fact]
    public async Task DeveValidarMensagemDeErroChaveObrigatoriaAsync()
    {
        var command = new ObterConfiguracaoQuery
        {
            Key = Guid.Empty,
        };

        var result = await _validationRules.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.Key)
           .WithErrorMessage("A chave da configuração é obrigatória.");
    }

    [Fact]
    public async Task DeveValidarMensagemDeErroChaveNaoEncontradaAsync()
    {
        var command = new ObterConfiguracaoQuery
        {
            Key = Guid.Empty,
        };

        var result = await _validationRules.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.Key)
           .WithErrorMessage("A chave da configuração não foi encontrada.");
    }
}
