using Anima.Inscricao.Domain.CursosExternos.Entities;
using Anima.Inscricao.Domain.CursosExternos.Validators;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test._Shared.Tests;

using FluentAssertions;

namespace Anima.Inscricao.Test.DomainValidators.CursosExternos;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class RemoverCursoExternoDomainValidatorTests
{
    private readonly RemoverCursoExternoDomainValidator _validator;

    public RemoverCursoExternoDomainValidatorTests(DatabaseFixture databaseFixture)
    {
        _validator = new();
    }

    [Fact]
    public void DeveValidarQuePodeExcluirRegistro()
    {
        // Arrange
        CursoExternoId cursoId = CursoExternoConstants.Radialismo.Id;

        // Act
        var resultado = _validator.Validate(cursoId);

        // Assert
        resultado.Should().BeTrue();
    }
}
