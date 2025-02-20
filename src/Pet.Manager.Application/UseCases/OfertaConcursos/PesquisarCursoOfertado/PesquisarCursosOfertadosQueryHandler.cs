using Anima.Inscricao.Application._Shared.Queries;
using Anima.Inscricao.Application.Cache.Persistence;
using Anima.Inscricao.Application.Config;
using Anima.Inscricao.Application.DTOs.OfertaConcursos;
using Anima.Inscricao.Application.Enums;
using Anima.Inscricao.Domain.Concursos;
using Anima.Inscricao.Domain.Concursos.Entities;
using Anima.Inscricao.Domain.Cursos;
using Anima.Inscricao.Domain.FormasEntrada;
using Anima.Inscricao.Domain.FormasEntrada.Entities;
using Anima.Inscricao.Domain.Instituicoes;
using Anima.Inscricao.Domain.Intakes;
using Anima.Inscricao.Domain.Links;
using Anima.Inscricao.Domain.Marcas;
using Anima.Inscricao.Domain.NiveisCurso;
using Anima.Inscricao.Domain.OfertaConcursos;
using Anima.Inscricao.Domain.Ofertas;
using Anima.Inscricao.Domain.Produtos;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

using static Anima.Inscricao.Application.UseCases.OfertaConcursos.PesquisarCursosOfertados.PesquisarCursosOfertadosQuery;

namespace Anima.Inscricao.Application.UseCases.OfertaConcursos.PesquisarCursosOfertados;

public class PesquisarCursosOfertadosQueryHandler : IQueryHandler<PesquisarCursosOfertadosQuery, List<CursoOfertadoDto>>
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
    private readonly IFormaEntradaRepository _formaEntradaRepository;
    private readonly ILinkRepository _linkRepository;
    private readonly ICache<PesquisarCursoOfertadoFiltros, List<CursoOfertadoDto>> _cache;

    public PesquisarCursosOfertadosQueryHandler(
        IOfertaConcursoRepository ofertaConcursoRepository,
        IOfertaRepository ofertaRepository,
        IConcursoRepository concursoRepository,
        IIntakeRepository intakeRepository,
        IProdutoRepository produtoRepository,
        ICursoRepository cursoRepository,
        IMarcaRepository marcaRepository,
        INivelCursoRepository nivelCursoRepository,
        IInstituicaoRepository instituicaoRepository,
        ILinkRepository linkRepository,
        IFormaEntradaRepository formaEntradaRepository,
        IOptions<CacheConfig> cacheConfig,
        ICacheBuilder<PesquisarCursoOfertadoFiltros, List<CursoOfertadoDto>> cacheBuilder)
    {
        _ofertaConcursoRepository = ofertaConcursoRepository;
        _ofertaRepository = ofertaRepository;
        _concursoRepository = concursoRepository;
        _intakeRepository = intakeRepository;
        _produtoRepository = produtoRepository;
        _cursoRepository = cursoRepository;
        _marcaRepository = marcaRepository;
        _nivelCursoRepository = nivelCursoRepository;
        _instituicaoRepository = instituicaoRepository;
        _linkRepository = linkRepository;
        _formaEntradaRepository = formaEntradaRepository;

        int tempoExpiracao = cacheConfig.Value.TtlEmSegundos ?? 0;

        _cache = cacheBuilder
        .ComIdentificadorCache(IdentificadorCache.PesquisaCursosOfertados)
        .ComFuncaoDeBusca(FuncaoDeBuscaAsync)
        .ComTempoDeExpiracaoEmSegundos((config) => tempoExpiracao)
        .Build();
    }

    public async Task<List<CursoOfertadoDto>> Handle(PesquisarCursosOfertadosQuery request, CancellationToken cancellationToken)
    {
        return await _cache.BuscarAsync(request.Filtros!) ??
            Enumerable.Empty<CursoOfertadoDto>().ToList();
    }

    private async ValueTask<ResultadoBuscaCache<List<CursoOfertadoDto>>> FuncaoDeBuscaAsync(PesquisarCursoOfertadoFiltros filtros)
    {
        var dataAtual = DateTime.Now;

        var query = from ofertaConcurso in _ofertaConcursoRepository.GetQueryable()
                    join oferta in _ofertaRepository.GetQueryable()
                        on ofertaConcurso.OfertaId equals oferta.Id
                    join produto in _produtoRepository.GetQueryable()
                        on oferta.ProdutoId equals produto.Id
                    join curso in _cursoRepository.GetQueryable()
                        on produto.CursoId equals curso.Id
                    join nivel in _nivelCursoRepository.GetQueryable()
                        on curso.NivelCursoId equals nivel.Id
                    join instituicao in _instituicaoRepository.GetQueryable()
                        on produto.InstituicaoId equals instituicao.Id
                    join marca in _marcaRepository.GetQueryable()
                        on instituicao.MarcaId equals marca.Id
                    join intake in _intakeRepository.GetQueryable()
                        on oferta.IntakeId equals intake.Id
                    join concurso in _concursoRepository.GetQueryable()
                        on ofertaConcurso.ConcursoId equals concurso.Id
                    from concursoFormaEntrada in concurso.FormasEntrada
                    join formaEntrada in _formaEntradaRepository.GetQueryable()
                        on concursoFormaEntrada.FormaEntradaId equals formaEntrada.Id
                    from link in _linkRepository.GetQueryable().Where(l => l.FormasEntrada.Any(x => x.FormaEntradaId == formaEntrada.Id))
                    where intake.Status.Ativo &&
                    concurso.Status.Ativo &&
                    concurso.VigenciaInscricao.Inicio < dataAtual &&
                    concurso.VigenciaInscricao.Termino > dataAtual
                    select new CursoOfertadoDto
                    {
                        CursoNome = curso.NomeComercial,
                        NivelCursoKey = nivel.Key,
                        NivelCursoNome = nivel.Nome,
                        IntakeKey = intake.Key,
                        IntakeNome = intake.Nome,
                        MarcaKey = marca.Key,
                        MarcaNome = marca.Nome,
                        LinkKey = link.Key
                    };

        if (filtros?.MarcaKey != null)
        {
            query = query.Where(o => o.MarcaKey == filtros!.MarcaKey.Value);
        }

        if (filtros?.LinkKey != null)
        {
            query = query.Where(o => o.LinkKey == filtros!.LinkKey.Value);
        }

        var queryResult = query
            .Distinct()
        .OrderBy(o => o.CursoNome);

        var resultado = await queryResult.ToListAsync();

        return new(resultado.Any(), resultado);
    }
}