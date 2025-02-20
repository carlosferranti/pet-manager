using Anima.Inscricao.Domain.Campi.Entities;
using Anima.Inscricao.Domain.Campi.Validators;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test._Shared.Tests;

using FluentAssertions;

namespace Anima.Inscricao.Test.DomainValidators.Campi;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class RemoverCampusDomainValidatorTests
{
    private readonly RemoverCampusDomainValidator _validator;

    public RemoverCampusDomainValidatorTests(DatabaseFixture databaseFixture)
    {
        _validator = new();
    }

    [Fact]
    public void DeveValidarQuePodeExcluirRegistro()
    {
        // Arrange
        CampusId campusId = CampusConstants.CampusRecife.Id;

        // Act
        var resultado = _validator.Validate(campusId);

        // Assert
        resultado.Should().BeTrue();
    }
}
