using Anima.Inscricao.Application._Shared.DTOs;
using Anima.Inscricao.Application.UseCases.Concursos.AtualizarConcurso;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Concursos;
using Anima.Inscricao.Domain.FormasEntrada;
using Anima.Inscricao.Domain.IntegracaoSistemas;
using Anima.Inscricao.Domain.Modalidades;
using Anima.Inscricao.Domain.ModalidadesAvaliacao;
using Anima.Inscricao.Domain.TiposFormacao;

using FluentValidation.TestHelper;

using Moq;

namespace Anima.Inscricao.Test.ApplicationValidators.Concursos;

public class AtualizarConcursoCommandValidatorTests
{
    private readonly Mock<IConcursoRepository> _concursoRepository = new();
    private readonly Mock<IModalidadeRepository> _modalidadeRepository = new();
    private readonly Mock<ITipoFormacaoRepository> _tipoFormacaoRepository = new();
    private readonly Mock<IFormaEntradaRepository> _formaEntradaRepository = new();
    private readonly Mock<INotificationContext> _notificationContext = new();
    private readonly Mock<IIntegracaoSistemaRepository> _integracaoSistemaRepository = new();
    private readonly Mock<IModalidadeAvaliacaoRepository> _modalidadeAvaliacaoRepository = new();

    private readonly AtualizarConcursoCommandValidator _validator;

    public AtualizarConcursoCommandValidatorTests()
    {
        _validator = new AtualizarConcursoCommandValidator(
            _concursoRepository.Object,
            _formaEntradaRepository.Object,
            _tipoFormacaoRepository.Object,
            _modalidadeRepository.Object,
            _notificationContext.Object,
            _integracaoSistemaRepository.Object,
            _modalidadeAvaliacaoRepository.Object);
    }

    [Fact]
    public async Task DeveTerErroQuandoChaveDoConcursoForVazia()
    {
        var command = new AtualizarConcursoCommand
        {
            Key = Guid.Empty,
        };

        var result = await _validator.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.Key)
            .WithErrorMessage("A chave do concurso é obrigatória.");
    }

    [Fact]
    public async Task DeveTerErroQuandoChaveDoConcursoNaoForEncontrada()
    {
        var command = new AtualizarConcursoCommand
        {
            Key = Guid.NewGuid(),
        };

        var result = await _validator.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.Key)
            .WithErrorMessage("A chave do concurso não foi encontrada.");
    }

    [Fact]
    public async Task DeveTerErroQuandoNomeDoConcursoForNulo()
    {
        var command = new AtualizarConcursoCommand
        {
            Nome = null!,
        };

        var result = await _validator.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.Nome)
            .WithErrorMessage("O nome do concurso é obrigatório.");
    }

    [Fact]
    public async Task DeveTerErroQuandoNomeDoConcursoExcederLimiteMaximo()
    {
        var command = new AtualizarConcursoCommand
        {
            Nome = new string('a', 200),
        };

        var result = await _validator.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.Nome)
            .WithErrorMessage("O nome do concurso deve ter no máximo 100 caracteres.");
    }

    [Fact]
    public async Task DeveTerErroQuandoPeriodoLetivoForNulo()
    {
        var command = new AtualizarConcursoCommand
        {
            PeriodoLetivo = null!,
        };

        var result = await _validator.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.PeriodoLetivo)
            .WithErrorMessage("O período letivo é obrigatório.");
    }

    [Fact]
    public async Task DeveTerErroQuandoPeriodoLetivoExcederLimiteMaximo()
    {
        var command = new AtualizarConcursoCommand
        {
            PeriodoLetivo = "2022/000001",
        };

        var result = await _validator.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.PeriodoLetivo)
            .WithErrorMessage("O período letivo deve ter no máximo 10 caracteres.");
    }

    [Fact]
    public async Task DeveTerErroQuandoInicioInscricaoForVazio()
    {
        var command = new AtualizarConcursoCommand
        {
            InicioInscricao = DateTime.MinValue,
        };

        var result = await _validator.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.InicioInscricao)
            .WithErrorMessage("Data de inicio da incrição inválida.");
    }

    [Fact]
    public async Task DeveTerErroQuandoTerminoInscricaoForVazio()
    {
        var command = new AtualizarConcursoCommand
        {
            TerminoInscricao = DateTime.MinValue,
        };

        var result = await _validator.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.TerminoInscricao)
            .WithErrorMessage("Data de término da inscrição inválida.");
    }

    [Fact]
    public async Task DeveTerErroQuandoChaveDaFormaDeEntradaForVazia()
    {
        var command = new AtualizarConcursoCommand
        {
            FormasEntrada = new List<EntityKeyDto>() { new EntityKeyDto(Guid.Empty) },
        };

        var result = await _validator.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor("FormasEntrada[0].Key")
            .WithErrorMessage("A chave da forma de entrada é obrigatória.");
    }

    [Fact]
    public async Task DeveTerErroQuandoChaveDaFormaDeEntradaNaoForEncontrada()
    {
        var command = new AtualizarConcursoCommand
        {
            FormasEntrada = new List<EntityKeyDto>() { new EntityKeyDto(Guid.NewGuid()) },
        };

        var result = await _validator.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor("FormasEntrada[0].Key")
            .WithErrorMessage("A chave da forma de entrada não foi encontrada.");
    }

    [Fact]
    public async Task DeveTerErroQuandoChaveDoTipoDeFormacaoForVazia()
    {
        var command = new AtualizarConcursoCommand
        {
            TipoFormacaoKey = Guid.Empty,
        };

        var result = await _validator.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.TipoFormacaoKey)
            .WithErrorMessage("A chave do tipo de formação é obrigatória.");
    }

    [Fact]
    public async Task DeveTerErroQuandoChaveDoTipoDeFormacaoNaoForEncontrada()
    {
        var command = new AtualizarConcursoCommand
        {
            TipoFormacaoKey = Guid.NewGuid(),
        };

        var result = await _validator.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.TipoFormacaoKey)
            .WithErrorMessage("A chave do tipo de formação não foi encontrada.");
    }

    [Fact]
    public async Task DeveTerErroQuandoChaveDaModalidadeForVazia()
    {
        var command = new AtualizarConcursoCommand
        {
            ModalidadeKey = Guid.Empty,
        };

        var result = await _validator.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.ModalidadeKey)
            .WithErrorMessage("A chave da modalidade é obrigatória.");
    }

    [Fact]
    public async Task DeveTerErroQuandoChaveDaModalidadeNaoForEncontrada()
    {
        var command = new AtualizarConcursoCommand
        {
            ModalidadeKey = Guid.NewGuid(),
        };

        var result = await _validator.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.ModalidadeKey)
            .WithErrorMessage("A chave da modalidade não foi encontrada.");
    }
}