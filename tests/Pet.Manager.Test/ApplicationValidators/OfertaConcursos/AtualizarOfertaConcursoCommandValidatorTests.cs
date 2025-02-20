using Anima.Inscricao.Application.UseCases.OfertaConcursos.AtualizarOfertaConcurso;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Concursos;
using Anima.Inscricao.Domain.OfertaConcursos;
using Anima.Inscricao.Domain.Ofertas;

using FluentValidation.TestHelper;

using Moq;

namespace Anima.Inscricao.Test.ApplicationValidators.OfertaConcursos;

public class AtualizarOfertaConcursoCommandValidatorTests
{
    private readonly Mock<IOfertaConcursoRepository> _ofertaConcursoRepositoryMock = new();
    private readonly Mock<IOfertaRepository> _ofertaRepositoryMock = new();
    private readonly Mock<IConcursoRepository> _concursoRepositorMock = new();
    private readonly Mock<INotificationContext> _notificationContext = new();

    private readonly AtualizarOfertaConcursoCommandValidator _validator;

    public AtualizarOfertaConcursoCommandValidatorTests()
    {
        _validator = new AtualizarOfertaConcursoCommandValidator(
            _ofertaConcursoRepositoryMock.Object,
            _ofertaRepositoryMock.Object,
            _concursoRepositorMock.Object,
            _notificationContext.Object);
    }

    [Fact]
    public async Task DeveTerErroQuandoChaveDoOfertaConcursoForVazia()
    {
        var command = new AtualizarOfertaConcursoCommand
        {
            Key = Guid.Empty,
        };

        var result = await _validator.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.Key)
            .WithErrorMessage("A chave da ofertaConcurso é obrigatória.");
    }

    [Fact]
    public async Task DeveTerErroQuandoChaveDaOfertaConcursoNaoForEncontrada()
    {
        _ofertaRepositoryMock.Setup(x => x.ExistsAsync(It.IsAny<Guid>(), It.IsAny<CancellationToken>()))
            .ReturnsAsync(false);

        var command = new AtualizarOfertaConcursoCommand
        {
            Key = Guid.NewGuid(),
        };

        var result = await _validator.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.Key)
            .WithErrorMessage("A chave da ofertaConcurso não foi encontrada.");
    }

    [Fact]
    public async Task DeveTerErroQuandoChaveDoOfertaForVazia()
    {
        var command = new AtualizarOfertaConcursoCommand
        {
            OfertaKey = Guid.Empty,
        };

        var result = await _validator.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.OfertaKey)
            .WithErrorMessage("A chave da oferta é obrigatória.");
    }

    [Fact]
    public async Task DeveTerErroQuandoChaveDoOfertaNaoForEncontrada()
    {
        _ofertaRepositoryMock.Setup(x => x.ExistsAsync(It.IsAny<Guid>(), It.IsAny<CancellationToken>()))
            .ReturnsAsync(false);

        var command = new AtualizarOfertaConcursoCommand
        {
            OfertaKey = Guid.NewGuid(),
        };

        var result = await _validator.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.OfertaKey)
            .WithErrorMessage("A chave da oferta não foi encontrada.");
    }

    [Fact]
    public async Task DeveTerErroQuandoChaveDoConcursoForVazia()
    {
        var command = new AtualizarOfertaConcursoCommand
        {
            ConcursoKey = Guid.Empty,
        };

        var result = await _validator.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.ConcursoKey)
            .WithErrorMessage("A chave do concurso é obrigatória.");
    }

    [Fact]
    public async Task DeveTerErroQuandoChaveDoConcursoNaoForEncontrada()
    {
        _concursoRepositorMock.Setup(x => x.ExistsAsync(It.IsAny<Guid>(), It.IsAny<CancellationToken>()))
            .ReturnsAsync(false);

        var command = new AtualizarOfertaConcursoCommand
        {
            ConcursoKey = Guid.NewGuid(),
        };

        var result = await _validator.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.ConcursoKey)
            .WithErrorMessage("A chave do concurso não foi encontrada.");
    }
}
