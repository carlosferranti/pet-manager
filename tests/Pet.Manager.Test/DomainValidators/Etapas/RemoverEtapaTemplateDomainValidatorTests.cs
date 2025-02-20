using Anima.Inscricao.Domain.Etapas.Validators;
using Anima.Inscricao.Domain.FormasEntrada.Validators;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test._Shared.Tests;

using FluentAssertions;

namespace Anima.Inscricao.Test.DomainValidators.Etapas;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class RemoverEtapaTemplateDomainValidatorTests
{
    private readonly RemoverEtapaTemplateDomainValidator _validator;

    public RemoverEtapaTemplateDomainValidatorTests(DatabaseFixture databaseFixture)
    {
        _validator = new();
    }

    [Fact]
    public void DeveValidarQuePodeExcluirRegistro()
    {
        // Arrange
        var etapaId = EtapaConstants.EtapaDadosContato.Id;

        // Act
        var resultado = _validator.Validate(etapaId);

        // Assert
        resultado.Should().BeTrue();
    }
}
