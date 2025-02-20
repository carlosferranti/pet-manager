﻿using Anima.Inscricao.Domain.Produtos.Validators;
using Anima.Inscricao.Domain.Produtos;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test._Shared.Tests;

using FluentAssertions;

using Microsoft.Extensions.DependencyInjection;

namespace Anima.Inscricao.Test.DomainValidators.Produtos;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class NovoProdutoDomainValidatorTests
{
    private readonly IProdutoRepository _produtoRepositoryMock;
    private readonly NovoProdutoDomainValidator _validator;

    public NovoProdutoDomainValidatorTests(DatabaseFixture databaseFixture)
    {
        _produtoRepositoryMock = databaseFixture.ServiceProvider.GetRequiredService<IProdutoRepository>();
        _validator = new(_produtoRepositoryMock);
    }

    [Fact]
    public void DeveValidarProdutosUnicosNoCadastro()
    {
        // Arrange
        var instituicaoId = ProdutoConstants.ProdutoTeste1.InstituicaoId;
        var campusId = ProdutoConstants.ProdutoTeste1.CampusId;
        var cursoId = ProdutoConstants.ProdutoTeste1.CursoId;
        var turnoId = ProdutoConstants.ProdutoTeste1.TurnoId;
        var sku = ProdutoConstants.ProdutoTeste1.Sku;

        // Act
        var resultado = _validator.Validate(instituicaoId, campusId, cursoId, turnoId, sku);

        // Assert
        resultado.Should().BeFalse();
    }

}
