using Anima.Inscricao.Application.UseCases.Configuracoes.RemoverConfiguracao;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Configuracoes;

using FluentValidation.TestHelper;

using Moq;

namespace Anima.Inscricao.Test.ApplicationValidators.Configuracoes;

public class RemoverConfiguracaoCommandValidatorTests
{
    private readonly Mock<INotificationContext> _notificationContextMock = new();
    private readonly Mock<IConfiguracaoRepository> _configuracaoRepositoryMock = new();
    private readonly RemoverConfiguracaoCommandValidator _validationRules;

    public RemoverConfiguracaoCommandValidatorTests()
    {
        _validationRules = new RemoverConfiguracaoCommandValidator(
            _notificationContextMock.Object,
            _configuracaoRepositoryMock.Object);
    }

    [Fact]
    public async Task DeveValidarMensagemDeErroChaveObrigatoriaAsync()
    {
        var command = new RemoverConfiguracaoCommand
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
        var command = new RemoverConfiguracaoCommand
        {
            Key = Guid.Empty,
        };

        var result = await _validationRules.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.Key)
           .WithErrorMessage("A chave da configuração não foi encontrada.");
    }
}
