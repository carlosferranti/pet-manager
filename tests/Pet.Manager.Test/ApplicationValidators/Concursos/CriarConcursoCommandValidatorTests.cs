using Anima.Inscricao.Application._Shared.DTOs;
using Anima.Inscricao.Application.DTOs.SistemasIntegracao;
using Anima.Inscricao.Application.UseCases.Concursos.CriarConcurso;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.FormasEntrada;
using Anima.Inscricao.Domain.IntegracaoSistemas;
using Anima.Inscricao.Domain.Modalidades;
using Anima.Inscricao.Domain.ModalidadesAvaliacao;
using Anima.Inscricao.Domain.TiposFormacao;

using FluentValidation.TestHelper;

using Moq;

namespace Anima.Inscricao.Test.ApplicationValidators.Concursos;

public class CriarConcursoCommandValidatorTests
{
    private readonly CriarConcursoCommandValidator _validator;
    private readonly Mock<IFormaEntradaRepository> _formaEntradaRepositoryMock = new();
    private readonly Mock<ITipoFormacaoRepository> _tipoFormacaoRepositoryMock = new();
    private readonly Mock<IIntegracaoSistemaRepository> _integracaoSistemaRepositoryMock = new();
    private readonly Mock<IModalidadeRepository> _modalidadeRepositoryMock = new();
    private readonly Mock<INotificationContext> _notificationContextMock = new();
    private readonly Mock<IModalidadeAvaliacaoRepository> _modalidadeAvaliacaoRepositoryMock = new();
    public CriarConcursoCommandValidatorTests()
    {
        _validator = new CriarConcursoCommandValidator(
            _formaEntradaRepositoryMock.Object,
            _tipoFormacaoRepositoryMock.Object,
            _integracaoSistemaRepositoryMock.Object,
            _modalidadeRepositoryMock.Object,
            _modalidadeAvaliacaoRepositoryMock.Object,
            _notificationContextMock.Object);
    }

    [Fact]
    public async Task DeveTerErroQuandoNomeDoConcursoForNulo()
    {
        // Arrange
        var command = new CriarConcursoCommand 
        { 
            Nome = null!, 
        };

        // Act
        var result = await _validator.TestValidateAsync(command);

        // Assert
        result.ShouldHaveValidationErrorFor(x => x.Nome)
            .WithErrorMessage("O nome do concurso é obrigatório.");
    }

    [Fact]
    public async Task DeveTerErroQuandoNomeDoConcursoExcederLimiteMaximo()
    {
        // Arrange
        var command = new CriarConcursoCommand
        {
            Nome = new string('a', 200),
        };

        // Act
        var result = await _validator.TestValidateAsync(command);

        // Assert
        result.ShouldHaveValidationErrorFor(x => x.Nome)
            .WithErrorMessage("O nome do concurso deve ter no máximo 100 caracteres.");
    }

    [Fact]
    public async Task DeveTerErroQuandoPeriodoLetivoForNulo()
    {
        // Arrange
        var command = new CriarConcursoCommand
        { 
            PeriodoLetivo = null!,
        };

        // Act
        var result = await _validator.TestValidateAsync(command);

        // Assert
        result.ShouldHaveValidationErrorFor(x => x.PeriodoLetivo)
            .WithErrorMessage("O período letivo é obrigatório.");
    }

    [Fact]
    public async Task DeveTerErroQuandoPeriodoLetivoExcederLimiteMaximo()
    {
        // Arrange
        var command = new CriarConcursoCommand 
        { 
            PeriodoLetivo = "2022.1.1.1.1",
        };

        // Act
        var result = await _validator.TestValidateAsync(command);

        // Assert
        result.ShouldHaveValidationErrorFor(x => x.PeriodoLetivo)
            .WithErrorMessage("O período letivo deve ter no máximo 10 caracteres.");
    }

    [Fact]
    public async Task DeveTerErroQuandoInicioInscricaoForVazio()
    {
        // Arrange
        var command = new CriarConcursoCommand 
        { 
            InicioInscricao = DateTime.MinValue,
        };

        // Act
        var result = await _validator.TestValidateAsync(command);

        // Assert
        result.ShouldHaveValidationErrorFor(x => x.InicioInscricao)
            .WithErrorMessage("Data de inicio da incrição inválida.");
    }

    [Fact]
    public async Task DeveTerErroQuandoTerminoInscricaoForVazio()
    {
        // Arrange
        var command = new CriarConcursoCommand 
        { 
            TerminoInscricao = DateTime.MinValue,
        };

        // Act
        var result = await _validator.TestValidateAsync(command);

        // Assert
        result.ShouldHaveValidationErrorFor(x => x.TerminoInscricao)
            .WithErrorMessage("Data de término da inscrição inválida.");
    }

    [Fact]
    public async Task DeveTerErroQuandoChaveFormaEntradaForVazia()
    {
        // Arrange
        var command = new CriarConcursoCommand 
        { 
            FormasEntrada = new List<EntityKeyDto>() { new EntityKeyDto(Guid.Empty) },
        };

        // Act
        var result = await _validator.TestValidateAsync(command);

        // Assert
        result.ShouldHaveValidationErrorFor("FormasEntrada[0].Key")
            .WithErrorMessage("A chave da forma de entrada é obrigatória.");
    }

    [Fact]
    public async Task DeveTerErroQuandoChaveFormaEntradaNaoExistir()
    {
        // Arrange
        var command = new CriarConcursoCommand
        {
            FormasEntrada = new List<EntityKeyDto>() { new EntityKeyDto(Guid.NewGuid()) },
        };

        // Act
        var result = await _validator.TestValidateAsync(command);

        // Assert
        result.ShouldHaveValidationErrorFor("FormasEntrada[0].Key")
            .WithErrorMessage("A chave da forma de entrada não foi encontrada.");
    }

    [Fact]
    public async Task DeveTerErroQuandoChaveTipoFormacaoForVazia()
    {
        // Arrange
        var command = new CriarConcursoCommand 
        { 
            TipoFormacaoKey = Guid.Empty,
        };

        // Act
        var result = await _validator.TestValidateAsync(command);

        // Assert
        result.ShouldHaveValidationErrorFor(x => x.TipoFormacaoKey)
            .WithErrorMessage("A chave do tipo de formação é obrigatória.");
    }

    [Fact]
    public async Task DeveTerErroQuandoChaveTipoFormacaoNaoExistir()
    {
        // Arrange
        var command = new CriarConcursoCommand 
        { 
            TipoFormacaoKey = Guid.NewGuid(),
        };

        _tipoFormacaoRepositoryMock.Setup(x => x.ExistsAsync(command.TipoFormacaoKey, default)).ReturnsAsync(false);

        // Act
        var result = await _validator.TestValidateAsync(command);

        // Assert
        result.ShouldHaveValidationErrorFor(x => x.TipoFormacaoKey)
            .WithErrorMessage("A chave do tipo de formação não foi encontrada.");
    }

    [Fact]
    public async Task DeveTerErroQuandoChaveModalidadeForVazia()
    {
        // Arrange
        var command = new CriarConcursoCommand 
        { 
            ModalidadeKey = Guid.Empty,
        };

        // Act
        var result = await _validator.TestValidateAsync(command);

        // Assert
        result.ShouldHaveValidationErrorFor(x => x.ModalidadeKey)
            .WithErrorMessage("A chave da modalidade é obrigatória.");
    }

    [Fact]
    public async Task DeveTerErroQuandoChaveModalidadeNaoExistir()
    {
        // Arrange
        var command = new CriarConcursoCommand 
        { 
            ModalidadeKey = Guid.NewGuid(),
        };

        _modalidadeRepositoryMock.Setup(x => x.ExistsAsync(command.ModalidadeKey, default)).ReturnsAsync(false);

        // Act
        var result = await _validator.TestValidateAsync(command);

        // Assert
        result.ShouldHaveValidationErrorFor(x => x.ModalidadeKey)
            .WithErrorMessage("A chave da modalidade não foi encontrada.");
    }

    [Fact]
    public async Task DeveTerErroQuandoNomeSistemaIntegracaoExcederLimiteMaximo()
    {
        // Arrange
        var command = new CriarConcursoCommand
        {
            Integracao = new SistemaIntegracaoDto
            {
                NomeSistema = new string('a', 200),
            }
        };

        // Act
        var result = await _validator.TestValidateAsync(command);

        // Assert
        result.ShouldHaveValidationErrorFor(x => x.Integracao!.NomeSistema)
            .WithErrorMessage("O nome do sistema de integração deve ter no máximo 100 caracteres.");
    }

    [Fact]
    public async Task DeveTerErroQuandoNomeSistemaIntegracaoNaoExistir()
    {
        // Arrange
        var command = new CriarConcursoCommand
        {
            Integracao = new SistemaIntegracaoDto
            {
                NomeSistema = "SistemaInexistente"
            }
        };

        // Act
        var result = await _validator.TestValidateAsync(command);

        // Assert
        result.ShouldHaveValidationErrorFor(x => x.Integracao!.NomeSistema)
            .WithErrorMessage("Nome do sistema de integração não encontrado.");
    }

    [Fact]
    public async Task DeveTerErroQuandoCodigoOrigemIntegracaoExcederLimiteMaximo()
    {
        // Arrange
        var command = new CriarConcursoCommand
        {
            Integracao = new SistemaIntegracaoDto
            {
                CodigoOrigem = new string('a', 200),
            }
        };

        // Act
        var result = await _validator.TestValidateAsync(command);

        // Assert
        result.ShouldHaveValidationErrorFor(x => x.Integracao!.CodigoOrigem)
            .WithErrorMessage("O código de origem da integração deve ter no máximo 100 caracteres.");
    }
}
