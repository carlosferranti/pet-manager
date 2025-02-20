using Anima.Inscricao.Application.UseCases.Cursos.AtualizarCurso;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Cursos;
using Anima.Inscricao.Domain.Instituicoes;
using Anima.Inscricao.Domain.Modalidades;
using Anima.Inscricao.Domain.NiveisCurso;
using Anima.Inscricao.Domain.TiposFormacao;

using FluentValidation.TestHelper;

using Moq;

namespace Anima.Inscricao.Test.ApplicationValidators.Cursos;

public class AtualizarCursoCommandValidatorTests
{
    private readonly Mock<INotificationContext> _notificationContextMock = new();
    private readonly Mock<ICursoRepository> _cursoRepositoryMock = new();
    private readonly Mock<IModalidadeRepository> _modalidadeRepositoryMock = new();
    private readonly Mock<ITipoFormacaoRepository> _tipoFormacaoRepositoryMock = new();
    private readonly Mock<INivelCursoRepository> _nivelCursoRepositoryMock = new();
    private readonly Mock<IInstituicaoRepository> _instituicaoRepositoryMock = new();
    private readonly AtualizarCursoCommandValidator _validationRules;

    public AtualizarCursoCommandValidatorTests()
    {
        _validationRules = new AtualizarCursoCommandValidator(
            _cursoRepositoryMock.Object,
            _modalidadeRepositoryMock.Object,
            _tipoFormacaoRepositoryMock.Object,
            _nivelCursoRepositoryMock.Object,
            _instituicaoRepositoryMock.Object,
            _notificationContextMock.Object);
    }

    [Fact]
    public async Task DeveValidarMensagemDeErroNomeObrigatorioAsync()
    {
        var command = new AtualizarCursoCommand
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
        var command = new AtualizarCursoCommand
        {
            Nome = new string('a', 150),
        };

        var result = await _validationRules.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.Nome)
            .WithErrorMessage("O nome do curso deve ter no máximo 100 caracteres.");
    }

    [Fact]
    public async Task DeveValidarMensagemDeErroChaveObrigatorioAsync()
    {
        var command = new AtualizarCursoCommand
        {
            Key = Guid.Empty,
        };

        var result = await _validationRules.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.Key)
           .WithErrorMessage("A chave do curso é obrigatória.");
    }

    [Fact]
    public async Task DeveValidarMensagemDeErroChaveNaoEncontradaAsync()
    {
        var command = new AtualizarCursoCommand
        {
            Key = Guid.Empty,
        };

        var result = await _validationRules.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.Key)
           .WithErrorMessage("A chave do curso não foi encontrada.");
    }

    [Fact]
    public async Task DeveValidarMensagemDeErroChaveModalidadeVaziaAsync()
    {
        var command = new AtualizarCursoCommand
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
        var command = new AtualizarCursoCommand
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
        var command = new AtualizarCursoCommand
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
        var command = new AtualizarCursoCommand
        {
            TipoFormacaoKey = Guid.NewGuid(),
        };

        var result = await _validationRules.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.TipoFormacaoKey)
           .WithErrorMessage("A chave do tipo de formação não foi encontrada.");
    }

    [Fact]
    public async Task DeveValidarMensagemDeErroChaveNivelCursoVaziaAsync()
    {
        var command = new AtualizarCursoCommand
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
        var command = new AtualizarCursoCommand
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
        var command = new AtualizarCursoCommand
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
        var command = new AtualizarCursoCommand
        {
            InstituicaoKey = Guid.NewGuid(),
        };

        var result = await _validationRules.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.InstituicaoKey)
           .WithErrorMessage("A chave da instituição não foi encontrada.");
    }
}
