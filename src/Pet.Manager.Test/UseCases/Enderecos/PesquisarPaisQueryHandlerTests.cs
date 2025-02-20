using Anima.Inscricao.Application.UseCases.Enderecos.PesquisarPais;
using Anima.Inscricao.Domain.Enderecos;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test._Shared.Tests;

using FluentAssertions;

using Microsoft.Extensions.DependencyInjection;

namespace Anima.Inscricao.Test.UseCases.Enderecos;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class PesquisarPaisQueryHandlerTests
{
    private readonly IPaisRepository _paisRepository;

    public PesquisarPaisQueryHandlerTests(DatabaseFixture databaseFixture)
    {
        _paisRepository = databaseFixture.ServiceProvider.GetRequiredService<IPaisRepository>();
    }

    [Fact]
    public async Task DeveRetornarPaisesComSucessoAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        var resultado = await useCase.Handle(new PesquisarPaisQuery()
        {
            Paginacao = new()
            {
                NumeroPagina = 1,
                QuantidadeRegistros = 10,
            },
        }, default);

        // Assert
        resultado.Should().NotBeNull();
        resultado.TotalRegistros.Should().Be(2);
        resultado.Data.Should().HaveCount(2);
    }

    [Fact]
    public async Task DeveRetornarPaisesFiltrandoPorNomeComSucessoAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        var resultado = await useCase.Handle(new PesquisarPaisQuery()
        {
            Filtros = new(EnderecoConstants.PaisBrasil.Nome, null),
            Paginacao = new()
            {
                NumeroPagina = 1,
                QuantidadeRegistros = 10,
            },
        }, default);

        // Assert
        resultado.Should().NotBeNull();
        resultado.TotalRegistros.Should().Be(1);
        resultado.Data.Should().HaveCount(1);
    }

    [Fact]
    public async Task DeveRetornarPaisesFiltrandoPorSiglaComSucessoAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        var resultado = await useCase.Handle(new PesquisarPaisQuery()
        {
            Filtros = new(null, EnderecoConstants.PaisBrasil.Sigla),
            Paginacao = new()
            {
                NumeroPagina = 1,
                QuantidadeRegistros = 10,
            },
        }, default);

        // Assert
        resultado.Should().NotBeNull();
        resultado.TotalRegistros.Should().Be(1);
        resultado.Data.Should().HaveCount(1);
    }

    private PesquisarPaisQueryHandler ObterUseCase()
    {
        return new(_paisRepository);
    }
}