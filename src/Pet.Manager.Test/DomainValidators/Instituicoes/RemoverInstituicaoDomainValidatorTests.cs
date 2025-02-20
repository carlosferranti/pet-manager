using Anima.Inscricao.Domain.Instituicoes.Entities;
using Anima.Inscricao.Domain.Instituicoes.Validators;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test._Shared.Tests;

using FluentAssertions;

namespace Anima.Inscricao.Test.DomainValidators.Instituicoes;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class RemoverInstituicaoDomainValidatorTests
{
    private readonly RemoverInstituicaoDomainValidator _validator;

    public RemoverInstituicaoDomainValidatorTests(DatabaseFixture databaseFixture)
    {
        _validator = new();
    }

    [Fact]
    public void DeveValidarQuePodeExcluirRegistro()
    {
        // Arrange
        InstituicaoId instituicaoId = InstituicaoConstants.Unibh.Id;

        // Act
        var resultado = _validator.Validate(instituicaoId);

        // Assert
        resultado.Should().BeTrue();
    }
}
