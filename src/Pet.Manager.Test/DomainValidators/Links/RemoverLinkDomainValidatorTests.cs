using Anima.Inscricao.Domain.Links.Validators;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test._Shared.Tests;

using FluentAssertions;

namespace Anima.Inscricao.Test.DomainValidators.Links;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class RemoverLinkDomainValidatorTests
{
    private readonly RemoverLinkDomainValidator _validator;

    public RemoverLinkDomainValidatorTests(DatabaseFixture databaseFixture)
    {
        _validator = new();
    }

    [Fact]
    public void DeveValidarQuePodeExcluirRegistro()
    {
        // Arrange
        var linkId = LinkConstants.LinkEmpresa.Id;

        // Act
        var resultado = _validator.Validate(linkId);

        // Assert
        resultado.Should().BeTrue();
    }
}