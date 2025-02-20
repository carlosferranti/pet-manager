using Anima.Inscricao.Application.UseCases.Marcas.PesquisarMarca;
using Anima.Inscricao.Domain.Marcas;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test._Shared.Tests;

using FluentAssertions;

using Microsoft.Extensions.DependencyInjection;

namespace Anima.Inscricao.Test.UseCases.Marcas;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class PesquisarMarcaQueryHandlerTests
{
    private readonly IMarcaRepository _marcaRepository;

    public PesquisarMarcaQueryHandlerTests(DatabaseFixture databaseFixture)
    {
        _marcaRepository = databaseFixture.ServiceProvider.GetRequiredService<IMarcaRepository>();
    }

    [Fact]
    public async Task DeveRetornarMarcasComSucessoAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        var resultado = await useCase.Handle(new PesquisarMarcaQuery()
        {
            Paginacao = new()
            {
                NumeroPagina = 1,
                QuantidadeRegistros = 10,
            },
        }, default);

        // Assert
        resultado.Should().NotBeNull();
        resultado.TotalRegistros.Should().Be(3);
        resultado.Data.Should().HaveCount(3);
    }

    [Fact]
    public async Task DeveRetornarMarcasFiltrandoPorNomeComSucessoAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        var resultado = await useCase.Handle(new PesquisarMarcaQuery()
        {
            Filtros = new(MarcaConstants.Unibh.Nome),
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

    private PesquisarMarcaQueryHandler ObterUseCase()
    {
        return new(_marcaRepository);
    }
}
