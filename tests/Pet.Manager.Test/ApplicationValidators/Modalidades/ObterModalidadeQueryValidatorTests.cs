using Anima.Inscricao.Application.UseCases.Modalidades.ObterModalidade;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Modalidades;

using FluentValidation.TestHelper;

using Moq;

namespace Anima.Inscricao.Test.Validators.Modalidades;

public class ObterModalidadeQueryValidatorTests
{
    private readonly Mock<INotificationContext> _notificationContextMock = new();
    private readonly Mock<IModalidadeRepository> _modalidadeRepositoryMock = new();
    private readonly ObterModalidadeQueryValidator _validationRules;

    public ObterModalidadeQueryValidatorTests()
    {
        _validationRules = new ObterModalidadeQueryValidator(
            _modalidadeRepositoryMock.Object,
            _notificationContextMock.Object);
    }

    [Fact]
    public async Task DeveValidarMensagemDeErroChaveObrigatoriaAsync()
    {
        var command = new ObterModalidadeQuery
        {
            Key = Guid.Empty,
        };

        var result = await _validationRules.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.Key)
           .WithErrorMessage("A chave da modalidade é obrigatória.");
    }

    [Fact]
    public async Task DeveValidarMensagemDeErroChaveNaoEncontradaAsync()
    {
        var command = new ObterModalidadeQuery
        {
            Key = Guid.Empty,
        };

        var result = await _validationRules.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.Key)
           .WithErrorMessage("A chave da modalidade não foi encontrada.");
    }
}

