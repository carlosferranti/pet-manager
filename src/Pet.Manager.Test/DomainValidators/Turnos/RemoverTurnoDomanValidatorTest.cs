using Anima.Inscricao.Domain.Turnos.Entities;
using Anima.Inscricao.Domain.Turnos.Validators;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test._Shared.Tests;

using FluentAssertions;

namespace Anima.Inscricao.Test.DomainValidators.Turnos;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class RemoverTurnoDomanValidatorTest
{
    private readonly RemoverTurnoDomainValidator _validator;

    public RemoverTurnoDomanValidatorTest(DatabaseFixture databaseFixture)
    {
        _validator = new();
    }

    [Fact]
    public void DeveValidarQuePodeExcluirRegistro()
    {
        // Arrange
        TurnoId turnoId = TurnoConstants.TurnoTarde.Id;

        // Act
        var resultado = _validator.Validate(turnoId);

        // Assert
        resultado.Should().BeTrue();
    }
}
