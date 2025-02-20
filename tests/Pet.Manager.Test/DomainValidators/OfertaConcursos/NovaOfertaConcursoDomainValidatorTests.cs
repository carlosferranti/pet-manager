using Anima.Inscricao.Domain.OfertaConcursos;
using Anima.Inscricao.Domain.OfertaConcursos.Validators;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test._Shared.Tests;

using Microsoft.Extensions.DependencyInjection;
using FluentAssertions;

namespace Anima.Inscricao.Test.DomainValidators.OfertaConcursos;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class NovaOfertaConcursoDomainValidatorTests
{
    private readonly IOfertaConcursoRepository _ofertaConcursoRepository;
    private readonly NovaOfertaConcursoDomainValidator _ofertaConcursoDomainValidator;

    public NovaOfertaConcursoDomainValidatorTests(DatabaseFixture databaseFixture)
    {
        _ofertaConcursoRepository = databaseFixture.ServiceProvider.GetRequiredService<IOfertaConcursoRepository>();
        _ofertaConcursoDomainValidator = new(_ofertaConcursoRepository);
    }

    [Fact]
    public void DeveValidarOfertaConcursosUnicosNoCadastro()
    {
        // Arrange
        var ofertaId = OfertaConcursoConstants.Oferta2ConcursoVestibular.OfertaId;
        var concursoId = OfertaConcursoConstants.Oferta2ConcursoVestibular.ConcursoId;

        // Act
        var resultado = _ofertaConcursoDomainValidator.Validate(concursoId, ofertaId);
        // Assert
        resultado.Should().BeFalse();
    }
}
