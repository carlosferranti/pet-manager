using Anima.Inscricao.Domain.Ofertas.Validators;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test._Shared.Tests;

using FluentAssertions;

namespace Anima.Inscricao.Test.DomainValidators.Ofertas;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class RemoverOfertaDomainValidatorTests
{
    private readonly RemoverOfertaDomainValidator _validator;

    public RemoverOfertaDomainValidatorTests(DatabaseFixture databaseFixture)
    {
        _validator = new();
    }

    [Fact]
    public void DeveValidarQuePodeExcluirOferta()
    {
        // Arrange
        var ofertaId = OfertaConstants.OfertaTeste1.Id;

        // Act
        var resultado = _validator.Validate(ofertaId);

        // Assert
        resultado.Should().BeTrue();
    }
}
