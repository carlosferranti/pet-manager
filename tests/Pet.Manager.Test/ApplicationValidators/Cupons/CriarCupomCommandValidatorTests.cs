using Anima.Inscricao.Application.DTOs.SistemasIntegracao;
using Anima.Inscricao.Application.Enums;
using Anima.Inscricao.Application.UseCases.Cupons.CriarCupom;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Concursos;
using Anima.Inscricao.Domain.IntegracaoSistemas;

using FluentValidation.TestHelper;

using Moq;

namespace Anima.Inscricao.Test.ApplicationValidators.Cupons;

public class CriarCupomCommandValidatorTests
{
    private readonly Mock<INotificationContext> _notificationContextMock = new();
    private readonly Mock<IConcursoRepository> _concursoRepositoryMock = new();
    private readonly Mock<IIntegracaoSistemaRepository> _integracaoSistemasRepository = new();
    private readonly CriarCupomCommandValidator _validationRules;

    public CriarCupomCommandValidatorTests()
    {
        _validationRules = new CriarCupomCommandValidator(
            _notificationContextMock.Object,
            _concursoRepositoryMock.Object,
            _integracaoSistemasRepository.Object);
    }

    [Fact]
    public async Task DeveValidarMensagemDeErroCodigoCupomObrigatorioAsync()
    {
        var command = new CriarCupomCommand
        {
            Codigo = string.Empty,
        };

        var result = await _validationRules.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.Codigo)
            .WithErrorMessage("O código do cupom é obrigatório.");
    }

    [Fact]
    public async Task DeveValidarMensagemDeErroLimiteCaracteresCodigoCupomAsync()
    {
        var command = new CriarCupomCommand
        {
            Codigo = new string('a', 101),
        };

        var result = await _validationRules.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.Codigo)
            .WithErrorMessage("O código do cupom deve ter no máximo 100 caracteres.");
    }

    [Fact]
    public async Task DeveValidarMensagemDeErroDescricaoCupomObrigatorioAsync()
    {
        var command = new CriarCupomCommand
        {
            Descricao = string.Empty,
        };

        var result = await _validationRules.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.Descricao)
            .WithErrorMessage("A descrição do cupom é obrigatória.");
    }

    [Fact]
    public async Task DeveValidarMensagemDeErroConcursoKeyObrigatorioAsync()
    {
        var command = new CriarCupomCommand
        {
            ConcursoKey = Guid.Empty,
        };

        var result = await _validationRules.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.ConcursoKey)
            .WithErrorMessage("A chave do concurso é obrigatória.");
    }

    [Fact]
    public async Task DeveValidarMensagemDeErroConcursoNaoEncontradoAsync()
    {
        var command = new CriarCupomCommand
        {
            ConcursoKey = Guid.Empty,
        };

        var result = await _validationRules.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.ConcursoKey)
            .WithErrorMessage("Concurso não encontrado.");
    }

    [Fact]
    public async Task DeveValidarMensagemDeErroTipoDescontoObrigatorioAsync()
    {
        var command = new CriarCupomCommand
        {
            TipoDesconto = 0,
        };

        var result = await _validationRules.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.TipoDesconto)
            .WithErrorMessage("Tipo de desconto inválido.");
    }

    [Fact]
    public async Task DeveValidarMensagemDeErroValorDescontoDeveSerMaiorQueZeroAsync()
    {
        var command = new CriarCupomCommand
        {
            TipoDesconto = (int)TipoDesconto.Valor,
            ValorDesconto = -1,
        };

        var result = await _validationRules.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.ValorDesconto)
            .WithErrorMessage("O valor do desconto deve ser maior ou igual a zero.");
    }

    [Fact]
    public async Task DeveValidarMensagemDeErroNomeSistemaIntegracaoObrigatorioAsync()
    {
        var command = new CriarCupomCommand
        {
            Integracao = new SistemaIntegracaoDto
            {
                NomeSistema = string.Empty,
            },
        };

        var result = await _validationRules.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.Integracao!.NomeSistema)
            .WithErrorMessage("Nome do sistema de integração não encontrado.");
    }

    [Fact]
    public async Task DeveValidarMensagemDeErroLimiteCaracteresCodigoOrigemIntegracaoAsync()
    {
        var command = new CriarCupomCommand
        {
            Integracao = new SistemaIntegracaoDto
            {
                CodigoOrigem = new string('a', 101)
            },
        };

        var result = await _validationRules.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.Integracao!.CodigoOrigem)
            .WithErrorMessage("O código de origem da integração deve ter no máximo 100 caracteres.");
    }

    [Theory]
    [InlineData(101)]
    [InlineData(-10)]
    public async Task DeveValidarMensagemDeErroValorDescontoDeveSerEntreZeroCemAsync(float valorDesconto)
    {
        var command = new CriarCupomCommand
        {
            TipoDesconto = (int)TipoDesconto.Porcentagem,
            ValorDesconto = valorDesconto,
        };

        var result = await _validationRules.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.ValorDesconto)
            .WithErrorMessage("O valor do desconto deve ser entre 0 e 100.");
    }
}
