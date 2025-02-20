using Anima.Inscricao.Application.UseCases.Cupons.ValidarCupom;
using Anima.Inscricao.Domain.Cupons;
using Anima.Inscricao.Domain.OfertaConcursos;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test._Shared.Tests;

using FluentAssertions;

using Microsoft.Extensions.DependencyInjection;

namespace Anima.Inscricao.Test.UseCases.Cupons;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class ValidarCupomQueryHandlerTests
{
    private readonly ICupomRepository _cupomRepository;
    private readonly IOfertaConcursoRepository _ofertaConcursoRepository;

    public ValidarCupomQueryHandlerTests(DatabaseFixture databaseFixture)
    {
        _cupomRepository = databaseFixture.ServiceProvider.GetRequiredService<ICupomRepository>();
        _ofertaConcursoRepository = databaseFixture.ServiceProvider.GetRequiredService<IOfertaConcursoRepository>();
    }

    [Fact]
    public async Task DeveRetornarFalhaQuandoCupomNaoExistir()
    {
        // Arrange
        var ofertaConcurso = OfertaConcursoConstants.Oferta2ConcursoEnem;
        var (queryHandler, query) = ObterUseCase("Codigo Inválido!", ofertaConcurso.Key);

        // Act
        var resultado = await queryHandler.Handle(query, default);

        // Assert
        resultado.Should().NotBeNull();
        resultado.Valido.Should().BeFalse();
        resultado.Mensagem.Should().Be("Cupom não encontrado.");
    }

    [Fact]
    public async Task DeveValidarCupomComSucesso()
    {
        // Arrange
        var cupom = CupomConstants.CupomPablo25;
        var ofertaConcurso = OfertaConcursoConstants.Oferta2ConcursoEnem;

        var (queryHandler, query) = ObterUseCase(cupom.Codigo, ofertaConcurso.Key);

        // Act
        var resultado = await queryHandler.Handle(query, default);

        // Assert
        resultado.Should().NotBeNull();
        resultado.Valido.Should().BeTrue();
        resultado.Mensagem.Should().Be("Cupom válido!");
    }

    [Fact]
    public async Task DeveRetornarFalhaQuandoCupomEstiverExpirado()
    {
        // Arrange
        var cupomExpirado = CupomConstants.CupomPablo10Expirado;
        var ofertaConcurso = OfertaConcursoConstants.Oferta2ConcursoEnem;

        var (queryHandler, query) = ObterUseCase(cupomExpirado.Codigo, ofertaConcurso.Key);

        // Act
        var resultado = await queryHandler.Handle(query, default);

        // Assert
        resultado.Should().NotBeNull();
        resultado.Valido.Should().BeFalse();
        resultado.Mensagem.Should().Be("O cupom está expirado.");
    }


    private (ValidarCupomQueryHandler handler, ValidarCupomQuery query) ObterUseCase(string codigoCupom, Guid ofertaConcursoKey)
    {
        var handler = new ValidarCupomQueryHandler(_cupomRepository, _ofertaConcursoRepository);
        var query = new ValidarCupomQuery(codigoCupom, ofertaConcursoKey);
        return (handler, query);
    }
}
