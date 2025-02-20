using Anima.Inscricao.Domain.TiposFormacao.Entities;
using Anima.Inscricao.Domain.TiposFormacao.Validators;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test._Shared.Tests;

using FluentAssertions;

namespace Anima.Inscricao.Test.DomainValidators.TiposFormacao;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class RemoverTipoFormacaoDomainValidatorTests
{
    private readonly RemoverTipoFormacaoDomainValidator _validator;

    public RemoverTipoFormacaoDomainValidatorTests(DatabaseFixture databaseFixture)
    {
        _validator = new();
    }

    [Fact]
    public void DeveValidarQuePodeExcluirRegistro()
    {
        // Arrange
        TipoFormacaoId tipoFormacaoId = TipoFormacaoConstants.TipoFormacaoGraduacao.Id;

        // Act
        var resultado = _validator.Validate(tipoFormacaoId);

        // Assert
        resultado.Should().BeTrue();
    }
}