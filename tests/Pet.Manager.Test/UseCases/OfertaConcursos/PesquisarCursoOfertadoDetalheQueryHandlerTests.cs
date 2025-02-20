using Anima.Inscricao.Application.Config;
using Anima.Inscricao.Application.DTOs.OfertaConcursos;
using Anima.Inscricao.Application.UseCases.OfertaConcursos.PesquisarCursoOfertadoDetalhe;
using Anima.Inscricao.Domain.Campi;
using Anima.Inscricao.Domain.Concursos;
using Anima.Inscricao.Domain.Cursos;
using Anima.Inscricao.Domain.FormasEntrada;
using Anima.Inscricao.Domain.Instituicoes;
using Anima.Inscricao.Domain.Intakes;
using Anima.Inscricao.Domain.Links;
using Anima.Inscricao.Domain.Marcas;
using Anima.Inscricao.Domain.Modalidades;
using Anima.Inscricao.Domain.NiveisCurso;
using Anima.Inscricao.Domain.OfertaConcursos;
using Anima.Inscricao.Domain.Ofertas;
using Anima.Inscricao.Domain.Produtos;
using Anima.Inscricao.Domain.TiposFormacao;
using Anima.Inscricao.Domain.Turnos;
using Anima.Inscricao.Test._Shared.Constants;
using Anima.Inscricao.Test.Builder;
using Anima.Inscricao.Test.Extensions;

using FluentAssertions;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

using static Anima.Inscricao.Application.UseCases.OfertaConcursos.PesquisarCursoOfertadoDetalhe.PesquisarCursoOfertadoDetalheQuery;

namespace Anima.Inscricao.Test.UseCases.OfertaConcursos;

[Collection(DatabaseCollectionConstants.ServicoInscricao)]
public class PesquisarCursoOfertadoDetalheQueryHandlerTests
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
    private readonly ICampusRepository _campusRepository;
    private readonly IModalidadeRepository _modalidadeRepository;
    private readonly ITurnoRepository _turnoRepository;
    private readonly ITipoFormacaoRepository _tipoFormacaoRepository;
    private readonly ILinkRepository _linkRepository;
    private readonly IFormaEntradaRepository _formaEntradaRepository;

    public PesquisarCursoOfertadoDetalheQueryHandlerTests()
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
        _campusRepository = serviceProvider.GetRequiredService<ICampusRepository>();
        _modalidadeRepository = serviceProvider.GetRequiredService<IModalidadeRepository>();
        _turnoRepository = serviceProvider.GetRequiredService<ITurnoRepository>();
        _tipoFormacaoRepository = serviceProvider.GetRequiredService<ITipoFormacaoRepository>();
        _linkRepository = serviceProvider.GetRequiredService<ILinkRepository>();
        _formaEntradaRepository = serviceProvider.GetRequiredService<IFormaEntradaRepository>();
    }

    [Fact]
    public async Task DeveRetornarListaDeCursosOfertadosComDetalhesComSucessoAsync()
    {
        // Arrange
        var useCase = ObterUseCase();

        // Act
        var resultado = await useCase.Handle(new PesquisarCursoOfertadoDetalheQuery
        {
            Filtros = new PesquisarCursoOfertadoDetalheFiltros
            {
                MarcaKey = MarcaConstants.Una.Key,
                IntakeKey = IntakeConstants.IntakePrimeiroSemestre.Key,
                NivelCursoKey = NivelCursoConstants.Bacharelado.Key,
                LinkKey = LinkConstants.LinkPadrao.Key,
                CursoNome = CursoConstants.CursoAdministracao.NomeComercial
            }
        }, default);

        // Assert
        resultado.Should().NotBeEmpty();
        resultado.Count.Should().Be(1);
    }

    private PesquisarCursoOfertadoDetalheQueryHandler ObterUseCase()
    {
        var cacheBuilder = new SemCacheBuilder<PesquisarCursoOfertadoDetalheFiltros, List<CursoOfertadoDetalheDto>>();
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
            _campusRepository,
            _modalidadeRepository,
            _turnoRepository,
            _tipoFormacaoRepository,
            _linkRepository,
            _formaEntradaRepository,
            Options.Create(cacheConfig),
            cacheBuilder);
    }
}