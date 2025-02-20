using Anima.Inscricao.Application.UseCases.Ofertas.PesquisarOferta;
using Anima.Inscricao.Application.UseCases.Produtos.PesquisarProduto;
using Anima.Inscricao.Domain.Intakes;
using Anima.Inscricao.Domain.Ofertas;
using Anima.Inscricao.Domain.Produtos;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test.Extensions;

using FluentAssertions;

using Microsoft.Extensions.DependencyInjection;

namespace Anima.Inscricao.Test.UseCases.Ofertas;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class PesquisarOfertaQueryHandlerTests
{
    private readonly IOfertaRepository _ofertaRepository;
    private readonly IProdutoRepository _produtoRepository;
    private readonly IIntakeRepository _intakeRepository;

    public PesquisarOfertaQueryHandlerTests()
    {
        var serviceProvider = new ServiceExtensions()
        .BuildServiceProvider(new ServiceCollection());

        _ofertaRepository = serviceProvider.GetRequiredService<IOfertaRepository>();
        _produtoRepository = serviceProvider.GetRequiredService<IProdutoRepository>();
        _intakeRepository = serviceProvider.GetRequiredService<IIntakeRepository>();
    }

    [Fact]
    public async Task DeveRetornarListaDeOfertaComSucessoAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        var resultado = await useCase.Handle(new PesquisarOfertaQuery
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
    }

    [Fact]
    public async Task DeveRetornarListaDeOfertaFiltrandoComSucessoAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        var resultado = await useCase.Handle(new PesquisarOfertaQuery
        {
            Filtros = new(null, IntakeConstants.IntakeSegundoSemestre.Key),
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

    private PesquisarOfertaQueryHandler ObterUseCase()
    {
        return new(_ofertaRepository,
            _produtoRepository,
            _intakeRepository);
    }
}
