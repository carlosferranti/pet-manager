using Anima.Inscricao.Domain.Cupons.Entities;
using Anima.Inscricao.Domain.Cupons.Validators;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test._Shared.Tests;

using FluentAssertions;

namespace Anima.Inscricao.Test.DomainValidators.Cupons;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class RemoverCupomDomainValidatorTests
{
    private readonly RemoverCupomDomainValidator _validator;

    public RemoverCupomDomainValidatorTests(DatabaseFixture databaseFixture)
    {
        _validator = new();
    }

    [Fact]
    public void DeveValidarQuePodeExcluirRegistro()
    {
        // Arrange
        CupomId cupomId = CupomConstants.CupomPablo100.Id;

        // Act
        var resultado = _validator.Validate(cupomId);

        // Assert
        resultado.Should().BeTrue();
    }
}
