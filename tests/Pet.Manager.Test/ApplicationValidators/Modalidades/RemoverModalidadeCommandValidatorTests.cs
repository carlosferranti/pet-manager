using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Anima.Inscricao.Application.UseCases.Modalidades.ObterModalidade;
using Anima.Inscricao.Application.UseCases.Modalidades.RemoverModalidade;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Modalidades;
using FluentValidation.TestHelper;

using Moq;

namespace Anima.Inscricao.Test.Validators.Modalidades;

public class RemoverModalidadeCommandValidatorTests
{
    private readonly Mock<INotificationContext> _notificationContextMock = new();
    private readonly Mock<IModalidadeRepository> _modalidadeRepositoryMock = new();
    private readonly RemoverModalidadeCommandValidator _validationRules;

    public RemoverModalidadeCommandValidatorTests()
    {
        _validationRules = new RemoverModalidadeCommandValidator(
            _modalidadeRepositoryMock.Object,
            _notificationContextMock.Object);
    }

    [Fact]
    public async Task DeveValidarMensagemDeErroChaveObrigatoriaAsync()
    {
        var command = new RemoverModalidadeCommand
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
        var command = new RemoverModalidadeCommand
        {
            Key = Guid.Empty,
        };

        var result = await _validationRules.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.Key)
           .WithErrorMessage("A chave da modalidade não foi encontrada.");
    }
}

