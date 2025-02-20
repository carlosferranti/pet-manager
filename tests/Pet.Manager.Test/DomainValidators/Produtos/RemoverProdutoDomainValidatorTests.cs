using Anima.Inscricao.Domain.Concursos.Validators;
using Anima.Inscricao.Domain.Produtos.Validators;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test._Shared.Tests;

using FluentAssertions;

namespace Anima.Inscricao.Test.DomainValidators.Produtos;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class RemoverProdutoDomainValidatorTests
{
    private readonly RemoverProdutoDomainValidator _validator;

    public RemoverProdutoDomainValidatorTests(DatabaseFixture databaseFixture)
    {
        _validator = new();
    }

    [Fact]
    public void DeveValidarQuePodeExcluirProduto()
    {
        // Arrange
        var produtoId = ProdutoConstants.ProdutoTeste1.Id;

        // Act
        var resultado = _validator.Validate(produtoId);

        // Assert
        resultado.Should().BeTrue();
    }
}
