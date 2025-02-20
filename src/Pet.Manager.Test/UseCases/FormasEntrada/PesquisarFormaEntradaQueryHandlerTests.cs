using Anima.Inscricao.Application.UseCases.FormasEntrada.PesquisarFormaEntrada;
using Anima.Inscricao.Domain.FormasEntrada;
using Anima.Inscricao.Domain.IntegracaoSistemas;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test._Shared.Tests;

using FluentAssertions;

using Microsoft.Extensions.DependencyInjection;

namespace Anima.Inscricao.Test.UseCases.FormasEntrada;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class PesquisarFormaEntradaQueryHandlerTests
{
    private readonly IFormaEntradaRepository _formaEntradaRepository;
    private readonly IIntegracaoSistemaRepository _integracaoSistemaRepository;

    public PesquisarFormaEntradaQueryHandlerTests(DatabaseFixture databaseFixture)
    {
        _formaEntradaRepository = databaseFixture.ServiceProvider.GetRequiredService<IFormaEntradaRepository>();
        _integracaoSistemaRepository = databaseFixture.ServiceProvider.GetRequiredService<IIntegracaoSistemaRepository>();
    }

    [Fact]
    public async Task DeveRetornarFormasDeEntradaComSucessoAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        var resultado = await useCase.Handle(new PesquisarFormaEntradaQuery()
        {
            Paginacao = new()
            {
                NumeroPagina = 1,
                QuantidadeRegistros = 10,
            },
        }, default);

        // Assert
        resultado.Should().NotBeNull();
        resultado.TotalRegistros.Should().Be(8);
        resultado.Data.Should().HaveCount(8);
    }

    [Fact]
    public async Task DeveRetornarFormasDeEntradaFiltrandoPorNomeComSucessoAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        var resultado = await useCase.Handle(new PesquisarFormaEntradaQuery()
        {
            Filtros = new(FormaEntradaConstants.FormaEntradaEnem.Nome),
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

    private PesquisarFormaEntradaQueryHandler ObterUseCase()
    {
        return new(_formaEntradaRepository, _integracaoSistemaRepository);
    }
}
