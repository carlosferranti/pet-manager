using Anima.Inscricao.Domain.Escolas.Entities;
using Anima.Inscricao.Domain.Escolas.Validators;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test._Shared.Tests;

using FluentAssertions;

namespace Anima.Inscricao.Test.DomainValidators.Escolas;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class RemoverEscolaDomainValidatorTests
{
    private readonly RemoverEscolaDomainValidator _validator;

    public RemoverEscolaDomainValidatorTests(DatabaseFixture databaseFixture)
    {
        _validator = new();
    }

    [Fact]
    public void DeveValidarQuePodeExcluirRegistro()
    {
        // Arrange
        EscolaId escolaId = EscolaConstants.ColegioVitoria.Id;

        // Act
        var resultado = _validator.Validate(escolaId);

        // Assert
        resultado.Should().BeTrue();
    }
}
