using Anima.Inscricao.Domain.Acessibilidades.Entities;
using Anima.Inscricao.Domain.Acessibilidades.Validators;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test._Shared.Tests;

using FluentAssertions;

namespace Anima.Inscricao.Test.DomainValidators.Acessibilidades;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class RemoverAcessibilidadeDomainValidatorTests
{
    private readonly RemoverAcessibilidadeDomainValidator _validator;

    public RemoverAcessibilidadeDomainValidatorTests(DatabaseFixture databaseFixture)
    {
        _validator = new();
    }

    [Fact]
    public void DeveValidarQuePodeExcluirRegistro()
    {
        // Arrange
        AcessibilidadeId acessibilidadeId = AcessibilidadeConstants.ProvaBraile.Id;

        // Act
        var resultado = _validator.Validate(acessibilidadeId);

        // Assert
        resultado.Should().BeTrue();
    }
}
