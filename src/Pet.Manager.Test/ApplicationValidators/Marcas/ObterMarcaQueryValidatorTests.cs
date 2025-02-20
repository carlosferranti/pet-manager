using Anima.Inscricao.Application.UseCases.Marcas.ObterMarca;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Marcas;

using FluentValidation.TestHelper;

using Moq;

namespace Anima.Inscricao.Test.ApplicationValidators.Marcas;

public class ObterMarcaQueryValidatorTests
{
    private readonly Mock<INotificationContext> _notificationContextMock = new();
    private readonly Mock<IMarcaRepository> _marcaRepositoryMock = new();
    private readonly ObterMarcaQueryValidator _validationRules;

    public ObterMarcaQueryValidatorTests()
    {
        _validationRules = new ObterMarcaQueryValidator(
            _marcaRepositoryMock.Object,
            _notificationContextMock.Object );
    }

    [Fact]
    public async Task DeveValidarMensagemDeErroChaveObrigatoriaAsync()
    {
        var command = new ObterMarcaQuery
        {
            Key = Guid.Empty,
        };

        var result = await _validationRules.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.Key)
           .WithErrorMessage("A chave da marca é obrigatória.");
    }

    [Fact]
    public async Task DeveValidarMensagemDeErroChaveNaoEncontradaAsync()
    {
        var command = new ObterMarcaQuery
        {
            Key = Guid.Empty,
        };

        var result = await _validationRules.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.Key)
           .WithErrorMessage("A chave da marca não foi encontrada.");
    }
}
