using Anima.Inscricao.Application.UseCases.OfertaConcursos.ObterOfertaConcurso;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.OfertaConcursos;

using FluentValidation.TestHelper;

using Moq;

namespace Anima.Inscricao.Test.ApplicationValidators.OfertaConcursos;

public class ObterOfertaConcursoQueryValidatorTests
{
    private readonly Mock<IOfertaConcursoRepository> _ofertaConcursoRepositoryMock = new();
    private readonly ObterOfertaConcursoQueryValidator _validator;

    public ObterOfertaConcursoQueryValidatorTests()
    {
        _validator = new ObterOfertaConcursoQueryValidator(
            _ofertaConcursoRepositoryMock.Object,
            new Mock<INotificationContext>().Object);
    }

    [Fact]
    public async Task DeveTerErroQuandoChaveDaOfertaConcursoForVazia()
    {
        var query = new ObterOfertaConcursoQuery
        {
            Key = Guid.Empty,
        };

        var result = await _validator.TestValidateAsync(query);

        result.ShouldHaveValidationErrorFor(x => x.Key)
            .WithErrorMessage("A chave da ofertaConcurso é obrigatória.");
    }

    [Fact]
    public async Task DeveTerErroQuandoChaveDaOfertaConcursoNaoForEncontrada()
    {
        _ofertaConcursoRepositoryMock.Setup(repo => repo.ExistsAsync(It.IsAny<Guid>(), It.IsAny<CancellationToken>()))
            .ReturnsAsync(false);

        var query = new ObterOfertaConcursoQuery
        {
            Key = Guid.NewGuid(),
        };

        var result = await _validator.TestValidateAsync(query);

        result.ShouldHaveValidationErrorFor(x => x.Key)
            .WithErrorMessage("A chave da ofertaConcurso não foi encontrada.");
    }

    [Fact]
    public async Task NaoDeveTerErroQuandoChaveDaOfertaConcursoForValida()
    {
        _ofertaConcursoRepositoryMock.Setup(repo => repo.ExistsAsync(It.IsAny<Guid>(), It.IsAny<CancellationToken>()))
            .ReturnsAsync(true);

        var query = new ObterOfertaConcursoQuery
        {
            Key = Guid.NewGuid(),
        };

        var result = await _validator.TestValidateAsync(query);

        result.ShouldNotHaveValidationErrorFor(x => x.Key);
    }
}
