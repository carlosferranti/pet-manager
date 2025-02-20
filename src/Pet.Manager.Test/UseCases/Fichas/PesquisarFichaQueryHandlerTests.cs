using Anima.Inscricao.Application.UseCases.Fichas.PesquisarFicha;
using Anima.Inscricao.Domain.Campos;
using Anima.Inscricao.Domain.Etapas;
using Anima.Inscricao.Domain.Fichas;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test.Extensions;

using FluentAssertions;

using Microsoft.Extensions.DependencyInjection;

namespace Anima.Inscricao.Test.UseCases.Fichas;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class PesquisarFichaQueryHandlerTests
{
    private readonly IEtapaTemplateRepository _etapaTemplateRepository;
    private readonly IFichaRepository _fichaRepository;
    private readonly ICampoRepository _campoRepository;

    public PesquisarFichaQueryHandlerTests()
    {
        var serviceProvider = new ServiceExtensions()
            .BuildServiceProvider(new ServiceCollection());

        _etapaTemplateRepository = serviceProvider.GetRequiredService<IEtapaTemplateRepository>();
        _fichaRepository = serviceProvider.GetRequiredService<IFichaRepository>();
        _campoRepository = serviceProvider.GetRequiredService<ICampoRepository>();
    }

    [Fact]
    public async Task DeveRetornarListaDeFichasComSucessoAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        var resultado = await useCase.Handle(new PesquisarFichaQuery
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
    }

    [Fact]
    public async Task DeveRetornarListaDeFichasPesquisandoPorNomeComSucessoAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        var resultado = await useCase.Handle(new PesquisarFichaQuery
        {
            Filtros = new PesquisarFichaQuery.PesquisarFichaFiltros(FichaConstants.FichaPadrao.Nome),
            Paginacao = new()
            {
                NumeroPagina = 1,
                QuantidadeRegistros = 10,
            },
        }, default);

        // Assert
        resultado.Should().NotBeNull();
        resultado.TotalRegistros.Should().Be(1);
    }

    [Fact]
    public async Task DeveRetornarFichaSemCampoEEtapaComSucessoAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        var resultado = await useCase.Handle(new PesquisarFichaQuery
        {
            Filtros = new PesquisarFichaQuery.PesquisarFichaFiltros(FichaConstants.FichaVazia.Nome),
            Paginacao = new()
            {
                NumeroPagina = 1,
                QuantidadeRegistros = 10,
            },
        }, default);

        // Assert
        resultado.Should().NotBeNull();
        resultado.TotalRegistros.Should().Be(1);
    }

    private PesquisarFichaQueryHandler ObterUseCase()
    {
        return new(
            _fichaRepository,
            _etapaTemplateRepository,
            _campoRepository);
    }
}