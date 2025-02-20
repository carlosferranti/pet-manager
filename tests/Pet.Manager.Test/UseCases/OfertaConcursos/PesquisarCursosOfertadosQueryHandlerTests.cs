using Anima.Inscricao.Application.Config;
using Anima.Inscricao.Application.DTOs.OfertaConcursos;
using Anima.Inscricao.Application.UseCases.OfertaConcursos.PesquisarCursosOfertados;
using Anima.Inscricao.Domain.Concursos;
using Anima.Inscricao.Domain.Cursos;
using Anima.Inscricao.Domain.FormasEntrada;
using Anima.Inscricao.Domain.Instituicoes;
using Anima.Inscricao.Domain.Intakes;
using Anima.Inscricao.Domain.Links;
using Anima.Inscricao.Domain.Marcas;
using Anima.Inscricao.Domain.NiveisCurso;
using Anima.Inscricao.Domain.OfertaConcursos;
using Anima.Inscricao.Domain.Ofertas;
using Anima.Inscricao.Domain.Produtos;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test.Builder;
using Anima.Inscricao.Test.Extensions;

using FluentAssertions;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

using static Anima.Inscricao.Application.UseCases.OfertaConcursos.PesquisarCursosOfertados.PesquisarCursosOfertadosQuery;

namespace Anima.Inscricao.Test.UseCases.OfertaConcursos;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class PesquisarCursosOfertadosQueryHandlerTests
{
    private readonly IOfertaConcursoRepository _ofertaConcursoRepository;
    private readonly IOfertaRepository _ofertaRepository;
    private readonly IConcursoRepository _concursoRepository;
    private readonly IIntakeRepository _intakeRepository;
    private readonly IProdutoRepository _produtoRepository;
    private readonly ICursoRepository _cursoRepository;
    private readonly IMarcaRepository _marcaRepository;
    private readonly INivelCursoRepository _nivelCursoRepository;
    private readonly IInstituicaoRepository _instituicaoRepository;
    private readonly ILinkRepository _linkRepository;
    private readonly IFormaEntradaRepository _formaEntradaRepository;

    public PesquisarCursosOfertadosQueryHandlerTests()
    {
        var serviceProvider = new ServiceExtensions()
            .BuildServiceProvider(new ServiceCollection());

        _ofertaConcursoRepository = serviceProvider.GetRequiredService<IOfertaConcursoRepository>();
        _ofertaRepository = serviceProvider.GetRequiredService<IOfertaRepository>();
        _concursoRepository = serviceProvider.GetRequiredService<IConcursoRepository>();
        _intakeRepository = serviceProvider.GetRequiredService<IIntakeRepository>();
        _produtoRepository = serviceProvider.GetRequiredService<IProdutoRepository>();
        _cursoRepository = serviceProvider.GetRequiredService<ICursoRepository>();
        _marcaRepository = serviceProvider.GetRequiredService<IMarcaRepository>();
        _nivelCursoRepository = serviceProvider.GetRequiredService<INivelCursoRepository>();
        _instituicaoRepository = serviceProvider.GetRequiredService<IInstituicaoRepository>();
        _linkRepository = serviceProvider.GetRequiredService<ILinkRepository>();
        _formaEntradaRepository = serviceProvider.GetRequiredService<IFormaEntradaRepository>();
    }

    [Fact]
    public async Task DeveRetornarListaDeCursosOfertadosComSucessoAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        var resultado = await useCase.Handle(new PesquisarCursosOfertadosQuery
        {
            Filtros = new PesquisarCursoOfertadoFiltros
            {
                MarcaKey = MarcaConstants.Una.Key,
                LinkKey = null,
            }
        }, default);

        // Assert
        resultado.Should().NotBeEmpty();
        resultado.Count.Should().Be(1);
    }

    private PesquisarCursosOfertadosQueryHandler ObterUseCase()
    {
        var cacheBuilder = new SemCacheBuilder<PesquisarCursoOfertadoFiltros, List<CursoOfertadoDto>>();
        var cacheConfig = new CacheConfig();

        return new(_ofertaConcursoRepository,
            _ofertaRepository,
            _concursoRepository,
            _intakeRepository,
            _produtoRepository,
            _cursoRepository,
            _marcaRepository,
            _nivelCursoRepository,
            _instituicaoRepository,
            _linkRepository,
            _formaEntradaRepository,
            Options.Create(cacheConfig),
            cacheBuilder);
    }
}
