using Anima.Inscricao.Application.UseCases.Cursos.CriarCurso;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Instituicoes;
using Anima.Inscricao.Domain.IntegracaoSistemas;
using Anima.Inscricao.Domain.Modalidades;
using Anima.Inscricao.Domain.NiveisCurso;
using Anima.Inscricao.Domain.TiposFormacao;

using FluentValidation.TestHelper;

using Moq;

namespace Anima.Inscricao.Test.ApplicationValidators.Cursos;

public class CriarCursoCommandValidatorTests
{
    private readonly Mock<INotificationContext> _notificationContextMock = new();
    private readonly Mock<IModalidadeRepository> _modalidadeRepositoryMock = new();
    private readonly Mock<ITipoFormacaoRepository> _tipoFormacaoRepositoryMock = new();
    private readonly Mock<IIntegracaoSistemaRepository> _integracaoSistemaRepositoryMock = new();
    private readonly Mock<INivelCursoRepository> _nivelCursoRepositoryMock = new();
    private readonly Mock<IInstituicaoRepository> _instituicaoRepositoryMock = new();
    private readonly CriarCursoCommandValidator _validationRules;

    public CriarCursoCommandValidatorTests()
    {
        _validationRules = new CriarCursoCommandValidator(
            _modalidadeRepositoryMock.Object,
            _tipoFormacaoRepositoryMock.Object,
            _integracaoSistemaRepositoryMock.Object,
            _nivelCursoRepositoryMock.Object,
            _instituicaoRepositoryMock.Object,
            _notificationContextMock.Object);
    }

    [Fact]
    public async Task DeveValidarMensagemDeErroNomeObrigatorioAsync()
    {
        var command = new CriarCursoCommand
        {
            Nome = null!,
        };

        var result = await _validationRules.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.Nome)
           .WithErrorMessage("O nome do curso é obrigatório.");
    }

    [Fact]
    public async Task DeveTerErroQuandoNomeForMaiorQueLimiteMaximoAsync()
    {
        var command = new CriarCursoCommand
        {
            Nome = new string('a', 150),
        };

        var result = await _validationRules.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.Nome)
            .WithErrorMessage("O nome do curso deve ter no máximo 100 caracteres.");
    }

    [Fact]
    public async Task DeveValidarMensagemDeErroChaveModalidadeVaziaAsync()
    {
        var command = new CriarCursoCommand
        {
            ModalidadeKey = Guid.Empty,
        };

        var result = await _validationRules.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.ModalidadeKey)
           .WithErrorMessage("A chave da modalidade é obrigatória.");
    }

    [Fact]
    public async Task DeveValidarMensagemDeErroChaveModalidadeNaoEncontradaAsync()
    {
        var command = new CriarCursoCommand
        {
            ModalidadeKey = Guid.NewGuid(),
        };

        var result = await _validationRules.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.ModalidadeKey)
           .WithErrorMessage("A chave da modalidade não foi encontrada.");
    }

    [Fact]
    public async Task DeveValidarMensagemDeErroChaveTipoFormacaoVaziaAsync()
    {
        var command = new CriarCursoCommand
        {
            TipoFormacaoKey = Guid.Empty,
        };

        var result = await _validationRules.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.TipoFormacaoKey)
           .WithErrorMessage("A chave do tipo de formação é obrigatória.");
    }

    [Fact]
    public async Task DeveValidarMensagemDeErroChaveTipoFormacaoNaoEncontradaAsync()
    {
        var command = new CriarCursoCommand
        {
            TipoFormacaoKey = Guid.NewGuid(),
        };

        var result = await _validationRules.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.TipoFormacaoKey)
           .WithErrorMessage("A chave do tipo de formação não foi encontrada.");
    }

    [Fact]
    public async Task DeveTerErroQuandoNomeSistemaIntegracaoNaoEncontradoAsync()
    {
        var command = new CriarCursoCommand
        {
            Integracao = new()
            {
                NomeSistema = "SistemaInexistente",
            },
        };

        var result = await _validationRules.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.Integracao!.NomeSistema)
            .WithErrorMessage("Nome do sistema de integração não encontrado.");
    }

    [Fact]
    public async Task DeveTerErroQuandoNomeSistemaIntegracaoUltrapassarLimiteAsync()
    {
        var command = new CriarCursoCommand
        {
            Integracao = new()
            {
                NomeSistema = new string('a', 150),
            },
        };

        var result = await _validationRules.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.Integracao!.NomeSistema)
            .WithErrorMessage("O nome do sistema de integração deve ter no máximo 100 caracteres.");
    }

    [Fact]
    public async Task DeveTerErroQuandoCodigoOrigemUltrapassarLimiteAsync()
    {
        var command = new CriarCursoCommand
        {
            Integracao = new()
            {
                CodigoOrigem = new string('a', 150),
            },
        };

        var result = await _validationRules.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.Integracao!.CodigoOrigem)
            .WithErrorMessage("O código de origem da integração deve ter no máximo 100 caracteres.");
    }

    [Fact]
    public async Task DeveValidarMensagemDeErroChaveNivelCursoVaziaAsync()
    {
        var command = new CriarCursoCommand
        {
            NivelCursoKey = Guid.Empty,
        };

        var result = await _validationRules.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.NivelCursoKey)
           .WithErrorMessage("A chave do nível do curso é obrigatória.");
    }

    [Fact]
    public async Task DeveValidarMensagemDeErroChaveNivelCursoNaoEncontradaAsync()
    {
        var command = new CriarCursoCommand
        {
            NivelCursoKey = Guid.NewGuid(),
        };

        var result = await _validationRules.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.NivelCursoKey)
           .WithErrorMessage("A chave do nível do curso não foi encontrada.");
    }

    [Fact]
    public async Task DeveValidarMensagemDeErroChaveInstituicaoVaziaAsync()
    {
        var command = new CriarCursoCommand
        {
            InstituicaoKey = Guid.Empty,
        };

        var result = await _validationRules.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.InstituicaoKey)
           .WithErrorMessage("A chave da instituição é obrigatória.");
    }

    [Fact]
    public async Task DeveValidarMensagemDeErroChaveInstituicaoNaoEncontradaAsync()
    {
        var command = new CriarCursoCommand
        {
            InstituicaoKey = Guid.NewGuid(),
        };

        var result = await _validationRules.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.InstituicaoKey)
           .WithErrorMessage("A chave da instituição não foi encontrada.");
    }
}
