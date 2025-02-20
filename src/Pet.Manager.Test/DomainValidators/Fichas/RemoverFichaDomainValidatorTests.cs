using Anima.Inscricao.Domain.Fichas.Validators;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test._Shared.Tests;

using FluentAssertions;

namespace Anima.Inscricao.Test.DomainValidators.Fichas;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class RemoverFichaDomainValidatorTests
{
    private readonly RemoverFichaDomainValidator _validator;

    public RemoverFichaDomainValidatorTests(DatabaseFixture databaseFixture)
    {
        _validator = new();
    }

    [Fact]
    public void DeveValidarQuePodeExcluirRegistro()
    {
        // Arrange
        var fichaId = FichaConstants.FichaPadrao.Id;

        // Act
        var resultado = _validator.Validate(fichaId);

        // Assert
        resultado.Should().BeTrue();
    }
}