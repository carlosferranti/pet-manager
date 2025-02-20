using Anima.Inscricao.Application.UseCases.Escolas.ObterEscola;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Escolas;

using FluentValidation;
using FluentValidation.TestHelper;

using Moq;

namespace Anima.Inscricao.Test.ApplicationValidators.Escolas;

public class ObterEscolaQueryValidatorTests
{
    private readonly Mock<IEscolaRepository> _escolaRepository = new();
    private readonly Mock<INotificationContext> _notificationContext = new();
    private readonly ObterEscolaQueryValidator _validations;

    public ObterEscolaQueryValidatorTests()
    {
        _validations = new ObterEscolaQueryValidator(
            _notificationContext.Object,
            _escolaRepository.Object);
    }

    [Fact]
    public async Task DeveValidarMensagemDeErroChaveObrigatoriaAsync()
    {
        var command = new ObterEscolaQuery()
        {
            Key = Guid.Empty,
        };

        var result = await _validations.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.Key)
           .WithErrorMessage("A chave da escola é obrigatória.");
    }

    [Fact]
    public async Task DeveValidarMensagemDeErroChaveNaoEncontradaAsync()
    {
        var command = new ObterEscolaQuery()
        {
            Key = Guid.Empty,
        };

        var result = await _validations.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.Key)
           .WithErrorMessage("A chave da escola não foi encontrada.");
    }
}
