using Anima.Inscricao.Domain.Marcas.Entities;
using Anima.Inscricao.Domain.Marcas.Validators;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test._Shared.Tests;

using FluentAssertions;

namespace Anima.Inscricao.Test.DomainValidators.Marcas;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class RemoverMarcaDomainValidatorTests
{
    private readonly RemoverMarcaDomainValidator _validationRules;

    public RemoverMarcaDomainValidatorTests(DatabaseFixture databaseFixture)
    {
        _validationRules = new();
    }

    [Fact]
    public void DeveValidarQuePodeExcluirRegistro()
    {
        // Arrange
        MarcaId marcaId = MarcaConstants.Unibh.Id;

        // Act
        var resultado = _validationRules.Validate(marcaId);

        // Assert
        resultado.Should().BeTrue();
    }
}
