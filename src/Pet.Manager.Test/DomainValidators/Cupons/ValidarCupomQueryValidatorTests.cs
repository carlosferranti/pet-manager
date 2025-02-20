using Anima.Inscricao.Application.UseCases.Cupons.ValidarCupom;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.OfertaConcursos;

using FluentAssertions;

using Moq;

namespace Anima.Inscricao.Test.DomainValidators.Cupons;

public class ValidarCupomQueryValidatorTests
{
    private readonly Mock<IOfertaConcursoRepository> _ofertaConcursoRepositoryMock;
    private readonly ValidarCupomQueryValidator _validator;

    public ValidarCupomQueryValidatorTests()
    {
        _ofertaConcursoRepositoryMock = new Mock<IOfertaConcursoRepository>();
        var notificationContext = new NotificationContext(); 
        _validator = new ValidarCupomQueryValidator(_ofertaConcursoRepositoryMock.Object, notificationContext);
    }

    [Fact]
    public async Task DeveRetornarErroQuandoCodigoCupomEstiverVazio()
    {
        // Arrange
        var query = new ValidarCupomQuery(string.Empty, Guid.NewGuid());

        // Act
        var result = await _validator.ValidateAsync(query);

        // Assert
        result.Errors.Should().ContainSingle(e => e.ErrorMessage == "A chave do cupom é obrigatória.")
                      .Which.PropertyName.Should().Be("CodigoCupom");
    }

    [Fact]
    public async Task DeveRetornarErroQuandoOfertaConcursoKeyEstiver_Vazio()
    {
        // Arrange
        var query = new ValidarCupomQuery("CUPOM_TESTE", Guid.Empty);

        // Act
        var result = await _validator.ValidateAsync(query);

        // Assert
        result.Errors.Should().ContainSingle(e => e.ErrorMessage == "A chave da ofertaConcurso é obrigatória.")
                      .Which.PropertyName.Should().Be("OfertaConcursoKey");
    }

    [Fact]
    public async Task DeveRetornarErroQuandoOfertaConcursoNaoExistir()
    {
        // Arrange
        var query = new ValidarCupomQuery("CUPOM_TESTE", Guid.NewGuid());
        _ofertaConcursoRepositoryMock.Setup(repo => repo.ExistsAsync(It.IsAny<Guid>(), It.IsAny<CancellationToken>()))
                                      .ReturnsAsync(false);

        // Act
        var result = await _validator.ValidateAsync(query);

        // Assert
        result.Errors.Should().ContainSingle(e => e.ErrorMessage == "A chave da ofertaConcurso não foi encontrada.");
    }

    [Fact]
    public async Task NaoDeveRetornarErroQuandoOfertaConcursoExistir()
    {
        // Arrange
        var query = new ValidarCupomQuery("CUPOM_TESTE", Guid.NewGuid());
        _ofertaConcursoRepositoryMock.Setup(repo => repo.ExistsAsync(It.IsAny<Guid>(), It.IsAny<CancellationToken>()))
                                      .ReturnsAsync(true);

        // Act
        var result = await _validator.ValidateAsync(query);

        // Assert
        result.Errors.Should().BeEmpty();
    }
}
