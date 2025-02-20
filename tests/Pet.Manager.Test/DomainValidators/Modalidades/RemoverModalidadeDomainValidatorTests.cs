using Anima.Inscricao.Domain.Modalidades.Entities;
using Anima.Inscricao.Domain.Modalidades.Validators;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test._Shared.Tests;

using FluentAssertions;

namespace Anima.Inscricao.Test.DomainValidators.Modalidades;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class RemoverModalidadeDomainValidatorTests
{
    private readonly RemoverModalidadeDomainValidator _validator;

    public RemoverModalidadeDomainValidatorTests(DatabaseFixture databaseFixture)
    {
        _validator = new();
    }

    [Fact]
    public void DeveValidarQuePodeExcluirRegistro()
    {
        // Arrange
        ModalidadeId modalidadeId = ModalidadeConstants.ModalidadePresencial.Id;

        // Act
        var resultado = _validator.Validate(modalidadeId);

        // Assert
        resultado.Should().BeTrue();
    }
}
