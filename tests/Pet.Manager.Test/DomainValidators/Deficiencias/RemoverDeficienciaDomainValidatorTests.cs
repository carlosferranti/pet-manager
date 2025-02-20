using Anima.Inscricao.Domain.Deficiencias.Entities;
using Anima.Inscricao.Domain.Deficiencias.Validators;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test._Shared.Tests;

using FluentAssertions;

namespace Anima.Inscricao.Test.DomainValidators.Deficiencias;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class RemoverDeficienciaDomainValidatorTests
{
    private readonly RemoverDeficienciaDomainValidator _validator;

    public RemoverDeficienciaDomainValidatorTests(DatabaseFixture databaseFixture)
    {
        _validator = new();
    }

    [Fact]
    public void DeveValidarQuePodeExcluirRegistro()
    {
        // Arrange
        DeficienciaId deficienciaId = DeficienciaConstants.Cegueira.Id;

        // Act
        var resultado = _validator.Validate(deficienciaId);

        // Assert
        resultado.Should().BeTrue();
    }
}
