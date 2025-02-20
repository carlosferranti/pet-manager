using Anima.Inscricao.Domain.OfertaConcursos;
using Anima.Inscricao.Domain.OfertaConcursos.Validators;
using Anima.Inscricao.Test._Shared.Tests;
using Anima.Inscricao.Test._Shared.Constants;
using Microsoft.Extensions.DependencyInjection;
using FluentAssertions;

namespace Anima.Inscricao.Test.DomainValidators.OfertaConcursos;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class AtualizarOfertaConcursoDomainValidatorTests
{
    private readonly IOfertaConcursoRepository _ofertaConcursoRepository;
    private readonly AtualizacaoOfertaConcursoDomainValidator _validator;

    public AtualizarOfertaConcursoDomainValidatorTests(DatabaseFixture databaseFixture)
    {
        _ofertaConcursoRepository = databaseFixture.ServiceProvider.GetRequiredService<IOfertaConcursoRepository>();
        _validator = new(_ofertaConcursoRepository);
    }

    [Fact]
    public void DeveValidarOfertaConcursoUnica()
    {
        // Arrange
        var ofertaConcursoId = OfertaConcursoConstants.Oferta2ConcursoEnem.Id;
        var ofertaId = OfertaConcursoConstants.Oferta2ConcursoVestibular.OfertaId;
        var concursoId = OfertaConcursoConstants.Oferta2ConcursoVestibular.ConcursoId;

        // Act
        var resultado = _validator.Validate(ofertaConcursoId, concursoId, ofertaId);

        // Assert
        resultado.Should().BeFalse();
    }

    [Fact]
    public void DevePermitirAtualizarSeForOfertaConcursoDiferente()
    {
        // Arrange
        var ofertaConcursoId = OfertaConcursoConstants.OfertaConcursoTeste1.Id;
        var ofertaId = OfertaConcursoConstants.OfertaConcursoTeste1.OfertaId;
        var concursoId = OfertaConcursoConstants.OfertaConcursoTeste1.ConcursoId;

        // Act
        var resultado = _validator.Validate(ofertaConcursoId, concursoId, ofertaId);

        // Assert
        resultado.Should().BeTrue();
    }
}
