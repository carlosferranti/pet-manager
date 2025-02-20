using Anima.Inscricao.Domain.Concursos.Validators;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test._Shared.Tests;

using FluentAssertions;

namespace Anima.Inscricao.Test.DomainValidators.Concursos;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class RemoverConcursoDomainValidatorTests
{
    private readonly RemoverConcursoDomainValidator _validator;

    public RemoverConcursoDomainValidatorTests(DatabaseFixture databaseFixture)
    {
        _validator = new();
    }

    [Fact]
    public void DeveValidarQuePodeExcluirConcurso()
    {
        // Arrange
        var concursoId = ConcursoConstants.ConcursoVestibular.Id;

        // Act
        var resultado = _validator.Validate(concursoId);

        // Assert
        resultado.Should().BeTrue();
    }
}