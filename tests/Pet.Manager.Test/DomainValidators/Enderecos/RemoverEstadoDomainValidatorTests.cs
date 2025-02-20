using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Anima.Inscricao.Domain.Enderecos.Entities;
using Anima.Inscricao.Domain.Enderecos.Validators;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test._Shared.Tests;

using FluentAssertions;

namespace Anima.Inscricao.Test.DomainValidators.Enderecos;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class RemoverEstadoDomainValidatorTests
{
    private readonly RemoverPaisDomainValidator _validator;

    public RemoverEstadoDomainValidatorTests(DatabaseFixture databaseFixture)
    {
        _validator = new();
    }

    [Fact]
    public void DeveValidarQuePodeExcluirRegistro()
    {
        // Arrange
        PaisId paisId = EnderecoConstants.PaisBrasil.Id;

        // Act
        var resultado = _validator.Validate(paisId);

        // Assert
        resultado.Should().BeTrue();
    }
}