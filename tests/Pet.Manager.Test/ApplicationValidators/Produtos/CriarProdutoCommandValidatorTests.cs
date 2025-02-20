using Anima.Inscricao.Application.UseCases.Produtos.CriarProduto;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Campi;
using Anima.Inscricao.Domain.Cursos;
using Anima.Inscricao.Domain.Instituicoes;
using Anima.Inscricao.Domain.IntegracaoSistemas;
using Anima.Inscricao.Domain.Produtos;
using Anima.Inscricao.Domain.Turnos;
using Moq;
using FluentValidation.TestHelper;
using Anima.Inscricao.Application.DTOs.SistemasIntegracao;

namespace Anima.Inscricao.Test.ApplicationValidators.Produtos;

public class CriarProdutoCommandValidatorTests
{
    private readonly Mock<IProdutoRepository> _produtoRepository = new();
    private readonly Mock<IInstituicaoRepository> _instituicaoRepository = new();
    private readonly Mock<ICampusRepository> _campusRepository = new();
    private readonly Mock<ICursoRepository> _cursoRepository = new();
    private readonly Mock<ITurnoRepository> _turnoRepository = new();
    private readonly Mock<IIntegracaoSistemaRepository> _integracaoSistemasRepository = new();
    private readonly Mock<INotificationContext> _notificationContext = new();

    private readonly CriarProdutoCommandValidator _validator;

    public CriarProdutoCommandValidatorTests()
    {
        _validator = new CriarProdutoCommandValidator(
            _produtoRepository.Object,
            _instituicaoRepository.Object,
            _campusRepository.Object,
            _cursoRepository.Object,
            _turnoRepository.Object,
            _integracaoSistemasRepository.Object,
            _notificationContext.Object);
    }

    [Fact]
    public async Task DeveTerErroQuandoInstituicaoKeyForVazia()
    {
        var command = new CriarProdutoCommand
        {
            InstituicaoKey = Guid.Empty,
        };

        var result = await _validator.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.InstituicaoKey)
            .WithErrorMessage("A chave da instituição é obrigatória.");
    }

    [Fact]
    public async Task DeveTerErroQuandoInstituicaoKeyNaoForEncontrada()
    {
        var command = new CriarProdutoCommand
        {
            InstituicaoKey = Guid.NewGuid(),
        };

        _instituicaoRepository.Setup(x => x.ExistsAsync(It.IsAny<Guid>(), It.IsAny<CancellationToken>()))
            .ReturnsAsync(false);

        var result = await _validator.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.InstituicaoKey)
            .WithErrorMessage("A chave da instituição não foi encontrada.");
    }

    [Fact]
    public async Task DeveTerErroQuandoCampusKeyForVazia()
    {
        var command = new CriarProdutoCommand
        {
            CampusKey = Guid.Empty,
        };

        var result = await _validator.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.CampusKey)
            .WithErrorMessage("A chave da campus é obrigatória.");
    }

    [Fact]
    public async Task DeveTerErroQuandoCampusKeyNaoForEncontrada()
    {
        var command = new CriarProdutoCommand
        {
            CampusKey = Guid.NewGuid(),
        };

        _campusRepository.Setup(x => x.ExistsAsync(It.IsAny<Guid>(), It.IsAny<CancellationToken>()))
            .ReturnsAsync(false);

        var result = await _validator.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.CampusKey)
            .WithErrorMessage("A chave da campus não foi encontrada.");
    }

    [Fact]
    public async Task DeveTerErroQuandoCursoKeyForVazia()
    {
        var command = new CriarProdutoCommand
        {
            CursoKey = Guid.Empty,
        };

        var result = await _validator.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.CursoKey)
            .WithErrorMessage("A chave da curso é obrigatória.");
    }

    [Fact]
    public async Task DeveTerErroQuandoCursoKeyNaoForEncontrada()
    {
        var command = new CriarProdutoCommand
        {
            CursoKey = Guid.NewGuid(),
        };

        _cursoRepository.Setup(x => x.ExistsAsync(It.IsAny<Guid>(), It.IsAny<CancellationToken>()))
            .ReturnsAsync(false);

        var result = await _validator.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.CursoKey)
            .WithErrorMessage("A chave da curso não foi encontrada.");
    }

    [Fact]
    public async Task DeveTerErroQuandoTurnoKeyForVazia()
    {
        var command = new CriarProdutoCommand
        {
            TurnoKey = Guid.Empty,
        };

        var result = await _validator.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.TurnoKey)
            .WithErrorMessage("A chave da turno é obrigatória.");
    }

    [Fact]
    public async Task DeveTerErroQuandoTurnoKeyNaoForEncontrada()
    {
        var command = new CriarProdutoCommand
        {
            TurnoKey = Guid.NewGuid(),
        };

        _turnoRepository.Setup(x => x.ExistsAsync(It.IsAny<Guid>(), It.IsAny<CancellationToken>()))
            .ReturnsAsync(false);

        var result = await _validator.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.TurnoKey)
            .WithErrorMessage("A chave da turno não foi encontrada.");
    }

    [Fact]
    public async Task DeveTerErroQuandoSkuExcederLimiteMaximo()
    {
        var command = new CriarProdutoCommand
        {
            Sku = new string('a', 256),
        };

        var result = await _validator.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.Sku)
            .WithErrorMessage("O sku deve ter no máximo 255 caracteres.");
    }

    [Fact]
    public async Task DeveTerErroQuandoNomeSistemaIntegracaoExcederLimiteMaximo()
    {
        var command = new CriarProdutoCommand
        {
            Integracao = new SistemaIntegracaoDto
            {
                NomeSistema = new string('a', 101),
            }
        };

        var result = await _validator.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.Integracao.NomeSistema)
            .WithErrorMessage("O nome do sistema de integração deve ter no máximo 100 caracteres.");
    }

    [Fact]
    public async Task DeveTerErroQuandoCodigoOrigemIntegracaoExcederLimiteMaximo()
    {
        var command = new CriarProdutoCommand
        {
            Integracao = new SistemaIntegracaoDto
            {
                CodigoOrigem = new string('a', 101),
            }
        };

        var result = await _validator.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.Integracao.CodigoOrigem)
            .WithErrorMessage("O código de origem da integração deve ter no máximo 100 caracteres.");
    }
}
