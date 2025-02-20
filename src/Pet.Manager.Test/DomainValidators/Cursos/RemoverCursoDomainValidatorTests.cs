using Anima.Inscricao.Domain.Cursos.Validators;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test._Shared.Tests;

using FluentAssertions;

namespace Anima.Inscricao.Test.DomainValidators.Cursos;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class RemoverCursoDomainValidatorTests
{
    private readonly RemoverCursoDomainValidator _validator;

    public RemoverCursoDomainValidatorTests(DatabaseFixture databaseFixture)
    {
        _validator = new();
    }

    [Fact]
    public void DeveValidarQuePodeExcluirRegistro()
    {
        // Arrange
        var cursoId = CursoConstants.CursoDireito.Id;

        // Act
        var resultado = _validator.Validate(cursoId);

        // Assert
        resultado.Should().BeTrue();
    }
}