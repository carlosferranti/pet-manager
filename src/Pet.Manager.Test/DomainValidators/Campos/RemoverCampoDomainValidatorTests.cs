using Anima.Inscricao.Domain.Campos.Entities;
using Anima.Inscricao.Domain.Campos.Validators;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test._Shared.Tests;

using FluentAssertions;

namespace Anima.Inscricao.Test.DomainValidators.Campos;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class RemoverCampoDomainValidatorTests
{
    private readonly RemoverCampoDomainValidator _validator;

    public RemoverCampoDomainValidatorTests(DatabaseFixture databaseFixture)
    {
        _validator = new();
    }

    [Fact]
    public void DeveValidarQuePodeExcluirRegistro()
    {
        // Arrange
        CampoId campoId = CampoConstants.CPF.Id;

        // Act
        var resultado = _validator.Validate(campoId);

        // Assert
        resultado.Should().BeTrue();
    }
}
