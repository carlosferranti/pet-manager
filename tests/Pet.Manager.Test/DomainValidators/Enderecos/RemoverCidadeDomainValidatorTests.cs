using Anima.Inscricao.Domain.Enderecos.Entities;
using Anima.Inscricao.Domain.Enderecos.Validators;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test._Shared.Tests;

using FluentAssertions;

namespace Anima.Inscricao.Test.DomainValidators.Enderecos;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class RemoverCidadeDomainValidatorTests
{
    private readonly RemoverCidadeDomainValidator _validator;

    public RemoverCidadeDomainValidatorTests(DatabaseFixture databaseFixture)
    {
        _validator = new();
    }

    [Fact]
    public void DeveValidarQuePodeExcluirRegistro()
    {
        // Arrange
        CidadeId cidadeId = EnderecoConstants.CidadeCampinas.Id;

        // Act
        var resultado = _validator.Validate(cidadeId);

        // Assert
        resultado.Should().BeTrue();
    }
}