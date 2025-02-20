using Anima.Inscricao.Application.UseCases.Modalidades.AtualizarModalidade;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Modalidades;

using FluentValidation.TestHelper;

using Moq;

namespace Anima.Inscricao.Test.Validators.Modalidades;

public class AtualizarModalidadeCommandValidatorTests
{
    private readonly Mock<INotificationContext> _notificationContextMock = new();
    private readonly Mock<IModalidadeRepository> _modalidadeRepositoryMock = new();
    private readonly AtualizarModalidadeCommandValidator _validationRules;

    public AtualizarModalidadeCommandValidatorTests()
    {
        _validationRules = new AtualizarModalidadeCommandValidator(
            _modalidadeRepositoryMock.Object,
            _notificationContextMock.Object);
    }

    [Fact]
    public async Task DeveValidarMensagemDeErroNomeObrigatorioAsync()
    {
        var command = new AtualizarModalidadeCommand
        {
            Nome = null!,
        };

        var result = await _validationRules.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.Nome)
           .WithErrorMessage("O nome da modalidade é obrigatório.");
    }

    [Fact]
    public async Task DeveTerErroQuandoNomeForMaiorQueLimiteMaximoAsync()
    {
        var command = new AtualizarModalidadeCommand
        {
            Nome = new string('a', 150),
        };

        var result = await _validationRules.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.Nome)
            .WithErrorMessage("O nome da modalidade deve ter no máximo 100 caracteres.");
    }

    [Fact]
    public async Task DeveValidarMensagemDeErroChaveObrigatorioAsync()
    {
        var command = new AtualizarModalidadeCommand
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
        var command = new AtualizarModalidadeCommand
        {
            Key = Guid.Empty,
        };

        var result = await _validationRules.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.Key)
           .WithErrorMessage("A chave da modalidade não foi encontrada.");
    }

    [Fact]
    public async Task DeveTerErroQuandoDescricaoForMaiorQueLimiteMaximoAsync()
    {
        var command = new AtualizarModalidadeCommand
        {
            Descricao = new string('a', 300),
        };

        var result = await _validationRules.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.Descricao)
            .WithErrorMessage("A descrição da modalidade deve ter no máximo 255 caracteres.");
    }
}

