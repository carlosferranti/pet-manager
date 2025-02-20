using Anima.Inscricao.Application.UseCases.Escolas.AtualizarEscola;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Enderecos;
using Anima.Inscricao.Domain.Escolas;

using FluentValidation.TestHelper;

using Moq;

namespace Anima.Inscricao.Test.ApplicationValidators.Escolas;

public class AtualizarEscolaCommandValidatorTests
{
    private readonly Mock<INotificationContext> _notificationContextMock = new();
    private readonly Mock<IEscolaRepository> _escolaRepositoryMock = new();
    private readonly Mock<ICidadeRepository> _cidadeRepositoryMock = new();
    private readonly AtualizarEscolaCommandValidator _validator;

    public AtualizarEscolaCommandValidatorTests()
    {
        _validator = new AtualizarEscolaCommandValidator(
            _notificationContextMock.Object,
            _escolaRepositoryMock.Object,
            _cidadeRepositoryMock.Object);
    }

    [Fact]
    public async Task DeveValisarMensagemDeErroChaveObrigatorioAsync()
    {
        var command = new AtualizarEscolaCommand
        {
            Key = Guid.Empty,
        };

        var result = await _validator.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.Key)
            .WithErrorMessage("A chave da escola é obrigatória.");
    }

    [Fact]
    public async Task DeveValidarMensagemDeErroChaveNaoEncontrada()
    {
        var command = new AtualizarEscolaCommand
        {
            Key = Guid.Empty,
        };

        var result = await _validator.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.Key)
            .WithErrorMessage("A chave da Escola não foi encontrada");
    }

    [Fact]
    public async Task DeveValidarMensagemDeErroNomeObrigatorioAsync()
    {
        var command = new AtualizarEscolaCommand
        {
            Nome = null!,
        };

        var result = await _validator.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.Nome)
            .WithErrorMessage("O nome da escola é obrigatório.");
    }

    [Theory]
    [InlineData(2)]
    [InlineData(201)]
    public async Task DeveValidarMensagemDeErroLimiteCaracteresNomeAsync(int numeroCaracteres)
    {
        var command = new AtualizarEscolaCommand
        {
            Nome = new string('a', numeroCaracteres),
        };

        var result = await _validator.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.Nome)
            .WithErrorMessage("O nome da escola deve ter entre 3 e 200 caracteres.");
    }

    [Fact]
    public async Task DeveValidarMensagemDeErroCidadeNaoEncontradaAsync()
    {
        var command = new AtualizarEscolaCommand
        {
            CidadeKey = Guid.Empty,
        };

        var result = await _validator.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.CidadeKey!.Value)
            .WithErrorMessage("A chave da Cidade não foi encontrada.");
    }
}
