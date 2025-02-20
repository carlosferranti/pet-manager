using Anima.Inscricao.Domain.Intakes.Validators;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test._Shared.Tests;

using FluentAssertions;

namespace Anima.Inscricao.Test.DomainValidators.Intakes;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class RemoverIntakeDomainValidatorTests
{
    private readonly RemoverIntakeDomainValidator _validator;

    public RemoverIntakeDomainValidatorTests(DatabaseFixture databaseFixture)
    {
        _validator = new();
    }

    [Fact]
    public void DeveValidarQuePodeExcluirRegistro()
    {
        // Arrange
        var intakeId = IntakeConstants.IntakePrimeiroSemestre.Id;

        // Act
        var resultado = _validator.Validate(intakeId);

        // Assert
        resultado.Should().BeTrue();
    }
}
