using Anima.Inscricao.Application.UseCases.OfertaConcursos.CriarOfertaConcurso;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Concursos;
using Anima.Inscricao.Domain.IntegracaoSistemas;
using Anima.Inscricao.Domain.Ofertas;

using FluentValidation.TestHelper;

using Moq;

namespace Anima.Inscricao.Test.ApplicationValidators.OfertaConcursos;

public class CriarOfertaConcursoCommandValidatorTests
{
    private readonly Mock<IOfertaRepository> _ofertaRepositoryMock = new();
    private readonly Mock<IConcursoRepository> _concursoRepositorMock = new();
    private readonly Mock<IIntegracaoSistemaRepository> _integracaoSistemasRepository = new();
    private readonly Mock<INotificationContext> _notificationContext = new()    ;

    private readonly CriarOfertaConcursoCommandValidator _validator;

    public CriarOfertaConcursoCommandValidatorTests()
    {
        _validator = new CriarOfertaConcursoCommandValidator(
            _ofertaRepositoryMock.Object,
            _concursoRepositorMock.Object,
            _integracaoSistemasRepository.Object,
            _notificationContext.Object);
    }

    [Fact]
    public async Task DeveTerErroQuandoChaveDoOfertaForVazia()
    {
        var command = new CriarOfertaConcursoCommand
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

        var command = new CriarOfertaConcursoCommand
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
        var command = new CriarOfertaConcursoCommand
        {
            ConcursoKey = Guid.Empty,
        };

        var result = await _validator.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.ConcursoKey)
            .WithErrorMessage("A chave do concurso é obrigatória.");
    }

    [Fact]
    public async Task DeveTerErroQuandoChaveDoIntakeNaoForEncontrada()
    {
        _concursoRepositorMock.Setup(x => x.ExistsAsync(It.IsAny<Guid>(), It.IsAny<CancellationToken>()))
            .ReturnsAsync(false);

        var command = new CriarOfertaConcursoCommand
        {
            ConcursoKey = Guid.NewGuid(),
        };

        var result = await _validator.TestValidateAsync(command);

        result.ShouldHaveValidationErrorFor(x => x.ConcursoKey)
            .WithErrorMessage("A chave do concurso não foi encontrada.");
    }
}
