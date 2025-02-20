using Anima.Inscricao.Domain.OfertaConcursos.Validators;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test._Shared.Tests;

using FluentAssertions;

namespace Anima.Inscricao.Test.DomainValidators.OfertaConcursos;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class RemoverOfertaConcursoDomainValidatorTests
{
    private readonly RemoverOfertaConcursoDomainValidator _validator;

    public RemoverOfertaConcursoDomainValidatorTests(DatabaseFixture databaseFixture)
    {
        _validator = new ();
    }

    [Fact]
    public void DeveValidarQuePodeExcluirOfertaConcurso()
    {
        // Arrange
        var ofertaConcursoId = OfertaConcursoConstants.OfertaConcursoTeste1.Id;

        // Act
        var resultado = _validator.Validate(ofertaConcursoId);

        // Assert
        resultado.Should().BeTrue();
    }
}
