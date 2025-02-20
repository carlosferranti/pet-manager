using Anima.Inscricao.Domain.ModalidadesAvaliacao.Validators;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test._Shared.Tests;

using FluentAssertions;

namespace Anima.Inscricao.Test.DomainValidators.ModalidadesAvaliacao;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class RemoverModalidadeAvaliacaoDomainValidatorTests
{
    private readonly RemoverModalidadeAvaliacaoDomainValidator _validationRules;

    public RemoverModalidadeAvaliacaoDomainValidatorTests(DatabaseFixture databaseFixture)
    {
        _validationRules = new();
    }

    [Fact]
    public void DeveValidarQuePodeExcluirRegistro()
    {
        // Arrange
        var Id = ModalidadeAvaliacaoConstants.Presencial.Id;

        // Act
        var resultado = _validationRules.Validate(Id);

        // Assert
        resultado.Should().BeTrue();
    }
}