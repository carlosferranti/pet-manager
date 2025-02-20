using Anima.Inscricao.Application.UseCases.Empresas.RemoverEmpresa;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Empresas;

using FluentValidation.TestHelper;

using Moq;

namespace Anima.Inscricao.Test.ApplicationValidators.Empresas;

public class RemoverEmpresaCommandValidatorTests
{
    private readonly Mock<INotificationContext> _notificationContextMock = new();
    private readonly Mock<IEmpresaRepository> _empresaRepositoryMock = new();
    private readonly RemoverEmpresaCommandValidator _validationRules;

    public RemoverEmpresaCommandValidatorTests()
    {
        _validationRules = new(
            _empresaRepositoryMock.Object,
            _notificationContextMock.Object);
    }

    [Fact]
    public async Task DeveValidarMensagemDeErroChaveObrigatoriaAsync()
    {
        var command = new RemoverEmpresaCommand
        {
            Key = Guid.Empty,
        };

        var result = await _validationRules.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.Key)
           .WithErrorMessage("A chave da empresa é obrigatória.");
    }

    [Fact]
    public async Task DeveValidarMensagemDeErroChaveNaoEncontradaAsync()
    {
        var command = new RemoverEmpresaCommand
        {
            Key = Guid.Empty,
        };

        var result = await _validationRules.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.Key)
           .WithErrorMessage("A chave da empresa não foi encontrada.");
    }
}
