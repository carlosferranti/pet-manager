using Anima.Inscricao.Application.UseCases.Produtos.AtualizarProduto;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Campi;
using Anima.Inscricao.Domain.Cursos;
using Anima.Inscricao.Domain.Instituicoes;
using Anima.Inscricao.Domain.Produtos;
using Anima.Inscricao.Domain.Turnos;
using FluentValidation.TestHelper;

using Moq;

namespace Anima.Inscricao.Test.ApplicationValidators.Produtos;

public class AtualizarProdutoCommandValidatorTests
{
    private readonly Mock<IProdutoRepository> _produtoRepository = new();
    private readonly Mock<IInstituicaoRepository> _instituicaoRepository = new();
    private readonly Mock<ICampusRepository> _campusRepository = new();
    private readonly Mock<ICursoRepository> _cursoRepository = new();
    private readonly Mock<ITurnoRepository> _turnoRepository = new();
    private readonly Mock<INotificationContext> _notificationContext = new();

    private readonly AtualizarProdutoCommandValidator _validator;

    public AtualizarProdutoCommandValidatorTests()
    {
        _validator = new AtualizarProdutoCommandValidator(
            _produtoRepository.Object,
            _instituicaoRepository.Object,
            _campusRepository.Object,
            _cursoRepository.Object,
            _turnoRepository.Object,
            _notificationContext.Object);
    }

    [Fact]
    public async Task DeveTerErroQuandoChaveDoProdutoForVazia()
    {
        var command = new AtualizarProdutoCommand
        {
            Key = Guid.Empty,
        };

        var result = await _validator.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.Key)
            .WithErrorMessage("A chave do produto é obrigatória.");
    }

    [Fact]
    public async Task DeveTerErroQuandoChaveDoProdutoNaoForEncontrada()
    {
        _produtoRepository.Setup(x => x.ExistsAsync(It.IsAny<Guid>(), It.IsAny<CancellationToken>()))
            .ReturnsAsync(false);

        var command = new AtualizarProdutoCommand
        {
            Key = Guid.NewGuid(),
        };

        var result = await _validator.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.Key)
            .WithErrorMessage("A chave do produto não foi encontrada.");
    }

    [Fact]
    public async Task DeveTerErroQuandoChaveDaInstituicaoForVazia()
    {
        var command = new AtualizarProdutoCommand
        {
            InstituicaoKey = Guid.Empty,
        };

        var result = await _validator.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.InstituicaoKey)
            .WithErrorMessage("A chave da instituição é obrigatória.");
    }

    [Fact]
    public async Task DeveTerErroQuandoChaveDaInstituicaoNaoForEncontrada()
    {
        _instituicaoRepository.Setup(x => x.ExistsAsync(It.IsAny<Guid>(), It.IsAny<CancellationToken>()))
            .ReturnsAsync(false);

        var command = new AtualizarProdutoCommand
        {
            InstituicaoKey = Guid.NewGuid(),
        };

        var result = await _validator.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.InstituicaoKey)
            .WithErrorMessage("A chave da instituição não foi encontrada.");
    }

    [Fact]
    public async Task DeveTerErroQuandoChaveDoCampusForVazia()
    {
        var command = new AtualizarProdutoCommand
        {
            CampusKey = Guid.Empty,
        };

        var result = await _validator.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.CampusKey)
            .WithErrorMessage("A chave da campus é obrigatória.");
    }

    [Fact]
    public async Task DeveTerErroQuandoChaveDoCampusNaoForEncontrada()
    {
        _campusRepository.Setup(x => x.ExistsAsync(It.IsAny<Guid>(), It.IsAny<CancellationToken>()))
            .ReturnsAsync(false);

        var command = new AtualizarProdutoCommand
        {
            CampusKey = Guid.NewGuid(),
        };

        var result = await _validator.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.CampusKey)
            .WithErrorMessage("A chave da campus não foi encontrada.");
    }

    [Fact]
    public async Task DeveTerErroQuandoChaveDoCursoForVazia()
    {
        var command = new AtualizarProdutoCommand
        {
            CursoKey = Guid.Empty,
        };

        var result = await _validator.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.CursoKey)
            .WithErrorMessage("A chave da curso é obrigatória.");
    }

    [Fact]
    public async Task DeveTerErroQuandoChaveDoCursoNaoForEncontrada()
    {
        _cursoRepository.Setup(x => x.ExistsAsync(It.IsAny<Guid>(), It.IsAny<CancellationToken>()))
            .ReturnsAsync(false);

        var command = new AtualizarProdutoCommand
        {
            CursoKey = Guid.NewGuid(),
        };

        var result = await _validator.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.CursoKey)
            .WithErrorMessage("A chave da curso não foi encontrada.");
    }

    [Fact]
    public async Task DeveTerErroQuandoChaveDoTurnoForVazia()
    {
        var command = new AtualizarProdutoCommand
        {
            TurnoKey = Guid.Empty,
        };

        var result = await _validator.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.TurnoKey)
            .WithErrorMessage("A chave da turno é obrigatória.");
    }

    [Fact]
    public async Task DeveTerErroQuandoChaveDoTurnoNaoForEncontrada()
    {
        _turnoRepository.Setup(x => x.ExistsAsync(It.IsAny<Guid>(), It.IsAny<CancellationToken>()))
            .ReturnsAsync(false);

        var command = new AtualizarProdutoCommand
        {
            TurnoKey = Guid.NewGuid(),
        };

        var result = await _validator.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.TurnoKey)
            .WithErrorMessage("A chave da turno não foi encontrada.");
    }

    [Fact]
    public async Task DeveTerErroQuandoSkuForVazio()
    {
        var command = new AtualizarProdutoCommand
        {
            Sku = string.Empty,
        };

        var result = await _validator.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.Sku)
            .WithErrorMessage("O sku é obrigatório.");
    }

    [Fact]
    public async Task DeveTerErroQuandoSkuExcederLimiteMaximo()
    {
        var command = new AtualizarProdutoCommand
        {
            Sku = new string('a', 256),
        };

        var result = await _validator.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.Sku)
            .WithErrorMessage("O sku deve ter no máximo 255 caracteres.");
    }
}
