using Anima.Inscricao.Application.Enums;
using Anima.Inscricao.Application.UseCases.Cupons.AtualizarCupom;
using Anima.Inscricao.Application.UseCases.Cupons.CriarCupom;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Concursos;
using Anima.Inscricao.Domain.Cupons;

using FluentValidation.TestHelper;

using Moq;

namespace Anima.Inscricao.Test.ApplicationValidators.Cupons;

public class AtualizarCupomCommandValidatorTests
{
    private readonly Mock<INotificationContext> _notificationContextMock = new();
    private readonly Mock<ICupomRepository> _cupomRepositoryMock = new();
    private readonly Mock<IConcursoRepository> _concursoRepositoryMock = new();
    private readonly AtualizarCupomCommandValidator _validationRules;

    public AtualizarCupomCommandValidatorTests()
    {
        _validationRules = new AtualizarCupomCommandValidator(
            _notificationContextMock.Object,
            _cupomRepositoryMock.Object,
            _concursoRepositoryMock.Object);
    }

    [Fact]
    public async Task DeveValidarMensagemDeErroChaveCupomObrigatorioAsync()
    {
        var command = new AtualizarCupomCommand
        {
            Key = Guid.Empty,
        };

        var result = await _validationRules.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.Key)
            .WithErrorMessage("A chave do cupom é obrigatória.");
    }

    [Fact]
    public async Task DeveValidarMensagemDeErroChaveCupomNaoEncontradoAsync()
    {
        var command = new AtualizarCupomCommand
        {
            Key = Guid.NewGuid(),
        };

        var result = await _validationRules.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.Key)
            .WithErrorMessage("Cupom não encontrado.");
    }

    [Fact]
    public async Task DeveValidarMensagemDeErroChaveConcursoObrigatorioAsync()
    {
        var command = new AtualizarCupomCommand
        {
            ConcursoKey = Guid.Empty,
        };

        var result = await _validationRules.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.ConcursoKey)
            .WithErrorMessage("A chave do concurso é obrigatória.");
    }

    [Fact]
    public async Task DeveValidarMensagemDeErroChaveConcursoNaoEncontradoAsync()
    {
        var command = new AtualizarCupomCommand
        {
            ConcursoKey = Guid.NewGuid(),
        };

        var result = await _validationRules.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.ConcursoKey)
            .WithErrorMessage("Concurso não encontrado.");
    }

    [Fact]
    public async Task DeveValidarMensagemDeErroCodigoObrigatorioAsync()
    {
        var command = new AtualizarCupomCommand
        {
            Codigo = null!,
        };

        var result = await _validationRules.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.Codigo)
            .WithErrorMessage("O código do cupom é obrigatório.");
    }

    [Fact]
    public async Task DeveTerErroQuandoCodigoForMaiorQueLimiteMaximoAsync()
    {
        var command = new AtualizarCupomCommand
        {
            Codigo = new string('a', 150),
        };

        var result = await _validationRules.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.Codigo)
            .WithErrorMessage("O código do cupom deve ter no máximo 100 caracteres.");
    }

    [Fact]
    public async Task DeveValidarMensagemDeErroDescricaoObrigatorioAsync()
    {
        var command = new AtualizarCupomCommand
        {
            Descricao = null!,
        };

        var result = await _validationRules.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.Descricao)
            .WithErrorMessage("A descrição do cupom é obrigatória.");
    }

    [Fact]
    public async Task DeveTerErroQuandoDescricaoForMaiorQueLimiteMaximoAsync()
    {
        var command = new AtualizarCupomCommand
        {
            Descricao = new string('a', 1500),
        };

        var result = await _validationRules.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.Descricao)
            .WithErrorMessage("A descrição do cupom deve ter no máximo 500 caracteres.");
    }

    [Fact]
    public async Task DeveValidarMensagemDeErroValorDescontoMenorQueZeroAsync()
    {
        var command = new AtualizarCupomCommand
        {
            TipoDesconto = (int)TipoDesconto.Valor,
            ValorDesconto = -1,
        };

        var result = await _validationRules.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.ValorDesconto)
            .WithErrorMessage("O valor do desconto deve ser maior ou igual a zero.");
    }

    [Fact]
    public async Task DeveValidarMensagemDeErroTipoDescontoObrigatorioAsync()
    {
        var command = new AtualizarCupomCommand
        {
            TipoDesconto = 0,
        };

        var result = await _validationRules.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.TipoDesconto)
            .WithErrorMessage("O tipo de desconto é obrigatório.");
    }

    [Fact]
    public async Task DeveValidarMensagemDeErroTipoDescontoInvalidoAsync()
    {
        var command = new AtualizarCupomCommand
        {
            TipoDesconto = 10,
        };

        var result = await _validationRules.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.TipoDesconto)
            .WithErrorMessage("Tipo de desconto inválido.");
    }

    [Theory]
    [InlineData(101)]
    [InlineData(-10)]
    public async Task DeveValidarMensagemDeErroValorDescontoDeveSerEntreZeroCemParaTipoPorcentagemAsync(float valorDesconto)
    {
        var command = new AtualizarCupomCommand
        {
            TipoDesconto = (int)TipoDesconto.Porcentagem,
            ValorDesconto = valorDesconto,
        };

        var result = await _validationRules.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.ValorDesconto)
            .WithErrorMessage("O valor do desconto deve ser entre 0 e 100.");
    }
}
