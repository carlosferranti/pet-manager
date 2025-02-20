using Anima.Inscricao.Domain.Empresas.Entities;
using Anima.Inscricao.Domain.Empresas.Validators;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test._Shared.Tests;

using FluentAssertions;

namespace Anima.Inscricao.Test.DomainValidators.Empresas;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class RemoverEmpresaDomainValidatorTests
{
    private readonly RemoverEmpresaDomainValidator _validator;

    public RemoverEmpresaDomainValidatorTests(DatabaseFixture databaseFixture)
    {
        _validator = new();
    }

    [Fact]
    public void DeveValidarQuePodeExcluirRegistro()
    {
        // Arrange
        EmpresaId empresaId = EmpresaConstants.Compass.Id;

        // Act
        var resultado = _validator.Validate(empresaId);

        // Assert
        resultado.Should().BeTrue();
    }
}