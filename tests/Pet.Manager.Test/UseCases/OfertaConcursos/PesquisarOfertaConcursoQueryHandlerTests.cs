using Anima.Inscricao.Application.UseCases.OfertaConcursos.PesquisarOfertaConcurso;
using Anima.Inscricao.Domain.Concursos;
using Anima.Inscricao.Domain.OfertaConcursos;
using Anima.Inscricao.Domain.Ofertas;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test.Extensions;

using FluentAssertions;

using Microsoft.Extensions.DependencyInjection;

namespace Anima.Inscricao.Test.UseCases.OfertaConcursos;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class PesquisarOfertaConcursoQueryHandlerTests
{
    private readonly IOfertaConcursoRepository _ofertaConcursoRepository;
    private readonly IOfertaRepository _ofertaRepository;
    private readonly IConcursoRepository _concursoRepository;

    public PesquisarOfertaConcursoQueryHandlerTests()
    {
        var serviceProvider = new ServiceExtensions()
        .BuildServiceProvider(new ServiceCollection());

        _ofertaConcursoRepository = serviceProvider.GetRequiredService<IOfertaConcursoRepository>();
        _ofertaRepository = serviceProvider.GetRequiredService<IOfertaRepository>();
        _concursoRepository = serviceProvider.GetRequiredService<IConcursoRepository>();
    }

    [Fact]
    public async Task DeveRetornarListaDeOfertaConcursoComSucessoAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        var resultado = await useCase.Handle(new PesquisarOfertaConcursoQuery
        {
            Paginacao = new()
            {
                NumeroPagina = 1,
                QuantidadeRegistros = 10,
            },
        }, default);

        // Assert
        resultado.Should().NotBeNull();
        resultado.TotalRegistros.Should().Be(7);
    }

    [Fact]
    public async Task DeveRetornarListaDeOfertaConcursoFiltrandoComSucessoAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        var resultado = await useCase.Handle(new PesquisarOfertaConcursoQuery
        {
            Filtros = new(null, ConcursoConstants.ConcursoReopcao.Key),
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

    private PesquisarOfertaConcursoQueryHandler ObterUseCase()
    {
        return new(
         _ofertaConcursoRepository,
             _ofertaRepository,
             _concursoRepository);
    }
}
