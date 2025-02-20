using Anima.Inscricao.Application.UseCases.Campos.PesquisarCampo;
using Anima.Inscricao.Domain.Campos;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test._Shared.Tests;

using FluentAssertions;

using Microsoft.Extensions.DependencyInjection;

namespace Anima.Inscricao.Test.UseCases.Campos;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class PesquisarCampoQueryHandlerTests
{
    private readonly ICampoRepository _campoRepository;

    public PesquisarCampoQueryHandlerTests(DatabaseFixture databaseFixture)
    {
        _campoRepository = databaseFixture.ServiceProvider.GetRequiredService<ICampoRepository>();
    }

    [Fact]
    public async Task DeveRetornarCampoComSucessoAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        var resultado = await useCase.Handle(new PesquisarCampoQuery()
        {
            Paginacao = new()
            {
                NumeroPagina = 1,
                QuantidadeRegistros = 10,
            },
        }, default);

        // Assert
        resultado.Should().NotBeNull();
        resultado.TotalRegistros.Should().Be(58);
        resultado.Data.Should().HaveCount(10);
    }

    [Fact]
    public async Task DeveRetornarCampoFiltrandoPorNomeComSucessoAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        var resultado = await useCase.Handle(new PesquisarCampoQuery()
        {
            Filtros = new(CampoConstants.CPF.Nome),
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

    private PesquisarCampoQueryHandler ObterUseCase()
    {
        return new PesquisarCampoQueryHandler(_campoRepository);
    }
}
