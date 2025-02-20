using Anima.Inscricao.Domain.FormasEntrada.Validators;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test._Shared.Tests;

using FluentAssertions;

namespace Anima.Inscricao.Test.DomainValidators.FormasEntrada;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class RemoverFormaEntradaDomainValidatorTests
{
    private readonly RemoverFormaEntradaDomainValidator _validator;

    public RemoverFormaEntradaDomainValidatorTests(DatabaseFixture databaseFixture)
    {
        _validator = new();
    }

    [Fact]
    public void DeveValidarQuePodeExcluirRegistro()
    {
        // Arrange
        var formaEntradaId = FormaEntradaConstants.FormaEntradaVestibular.Id;

        // Act
        var resultado = _validator.Validate(formaEntradaId);

        // Assert
        resultado.Should().BeTrue();
    }
}
