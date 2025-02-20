using Anima.Inscricao.Application._Shared.Queries;
using Anima.Inscricao.Application.Cache.Persistence;
using Anima.Inscricao.Application.Config;
using Anima.Inscricao.Application.DTOs.OfertaConcursos;
using Anima.Inscricao.Application.Enums;
using Anima.Inscricao.Domain.Campi;
using Anima.Inscricao.Domain.Concursos;
using Anima.Inscricao.Domain.Cursos;
using Anima.Inscricao.Domain.FormasEntrada;
using Anima.Inscricao.Domain.FormasEntrada.Entities;
using Anima.Inscricao.Domain.Instituicoes;
using Anima.Inscricao.Domain.Intakes;
using Anima.Inscricao.Domain.Links;
using Anima.Inscricao.Domain.Links.Entities;
using Anima.Inscricao.Domain.Marcas;
using Anima.Inscricao.Domain.Modalidades;
using Anima.Inscricao.Domain.NiveisCurso;
using Anima.Inscricao.Domain.OfertaConcursos;
using Anima.Inscricao.Domain.Ofertas;
using Anima.Inscricao.Domain.Produtos;
using Anima.Inscricao.Domain.TiposFormacao;
using Anima.Inscricao.Domain.Turnos;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

using static Anima.Inscricao.Application.UseCases.OfertaConcursos.PesquisarCursoOfertadoDetalhe.PesquisarCursoOfertadoDetalheQuery;

namespace Anima.Inscricao.Application.UseCases.OfertaConcursos.PesquisarCursoOfertadoDetalhe;

public class PesquisarCursoOfertadoDetalheQueryHandler : IQueryHandler<PesquisarCursoOfertadoDetalheQuery, List<CursoOfertadoDetalheDto>>
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
    private readonly IFormaEntradaRepository _formaEntradaRepository;
    private readonly ILinkRepository _linkRepository;
    private readonly ICache<PesquisarCursoOfertadoDetalheFiltros, List<CursoOfertadoDetalheDto>> _cache;

    public PesquisarCursoOfertadoDetalheQueryHandler(
        IOfertaConcursoRepository ofertaConcursoRepository,
        IOfertaRepository ofertaRepository,
        IConcursoRepository concursoRepository,
        IIntakeRepository intakeRepository,
        IProdutoRepository produtoRepository,
        ICursoRepository cursoRepository,
        IMarcaRepository marcaRepository,
        INivelCursoRepository nivelCursoRepository,
        IInstituicaoRepository instituicaoRepository,
        ICampusRepository campusRepository,
        IModalidadeRepository modalidadeRepository,
        ITurnoRepository turnoRepository,
        ITipoFormacaoRepository tipoFormacaoRepository,
        ILinkRepository linkRepository,
        IFormaEntradaRepository formaEntradaRepository,
        IOptions<CacheConfig> cacheConfig,
        ICacheBuilder<PesquisarCursoOfertadoDetalheFiltros, List<CursoOfertadoDetalheDto>> cacheBuilder)
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
        _campusRepository = campusRepository;
        _modalidadeRepository = modalidadeRepository;
        _turnoRepository = turnoRepository;
        _tipoFormacaoRepository = tipoFormacaoRepository;
        _linkRepository = linkRepository;
        _formaEntradaRepository = formaEntradaRepository;

        int tempoExpiracao = cacheConfig.Value.TtlEmSegundos ?? 0;

        _cache = cacheBuilder
        .ComIdentificadorCache(IdentificadorCache.PesquisaCursosOfertadosDetalhe)
        .ComFuncaoDeBusca(FuncaoDeBuscaAsync)
        .ComTempoDeExpiracaoEmSegundos((config) => tempoExpiracao)
        .Build();
    }

    public async Task<List<CursoOfertadoDetalheDto>> Handle(PesquisarCursoOfertadoDetalheQuery request, CancellationToken cancellationToken)
    {
        return await _cache.BuscarAsync(request.Filtros!) ??
                    Enumerable.Empty<CursoOfertadoDetalheDto>().ToList();
    }

    private async ValueTask<ResultadoBuscaCache<List<CursoOfertadoDetalheDto>>> FuncaoDeBuscaAsync(PesquisarCursoOfertadoDetalheFiltros filtros)
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
                    join campus in _campusRepository.GetQueryable()
                        on produto.CampusId equals campus.Id
                    join turno in _turnoRepository.GetQueryable()
                        on produto.TurnoId equals turno.Id
                    from modalidade in _modalidadeRepository.GetQueryable()
                    from tipoFormacao in _tipoFormacaoRepository.GetQueryable()
                    from concursoFormaEntrada in concurso.FormasEntrada
                    join formaEntrada in _formaEntradaRepository.GetQueryable()
                        on concursoFormaEntrada.FormaEntradaId equals formaEntrada.Id
                    from link in _linkRepository.GetQueryable().Where(l => l.FormasEntrada.Any(x => x.FormaEntradaId == formaEntrada.Id))
                    where intake.Status.Ativo &&
                    concurso.Status.Ativo &&
                    concurso.Modalidades.Any(x => x.ModalidadeId == modalidade.Id) &&
                    concurso.TiposFormacao.Any(x => x.TipoFormacaoId == tipoFormacao.Id) &&
                    concurso.VigenciaInscricao.Inicio < dataAtual &&
                    concurso.VigenciaInscricao.Termino > dataAtual
                    select new CursoOfertadoDetalheDto
                    {
                        CampusKey = campus.Key,
                        CampusNome = !string.IsNullOrEmpty(campus.NomeComercial) ? campus.NomeComercial : campus.Nome,
                        IntakeKey = intake.Key,
                        NivelKey = nivel.Key,
                        NivelNome = nivel.Nome,
                        ModalidadeKey = modalidade.Key,
                        ModalidadeNome = modalidade.Nome,
                        ModalidadeDescricao = modalidade.Descricao ?? string.Empty,
                        OfertaKey = oferta.Key,
                        ProdutoKey = produto.Key,
                        TurnoKey = turno.Key,
                        TurnoNome = turno.Nome,
                        TipoFormacaoKey = tipoFormacao.Key,
                        TipoFormacaoNome = tipoFormacao.Nome,
                        MarcaKey = marca.Key,
                        CursoNome = curso.NomeComercial,
                        IntakeNome = intake.Nome,
                        LinkKey = link.Key
                    };

        if (filtros?.MarcaKey != null)
        {
            query = query.Where(o => o.MarcaKey == filtros!.MarcaKey.Value);
        }

        if (filtros?.IntakeKey != null)
        {
            query = query.Where(o => o.IntakeKey == filtros!.IntakeKey.Value);
        }

        if (filtros?.NivelCursoKey != null)
        {
            query = query.Where(o => o.NivelKey == filtros!.NivelCursoKey.Value);
        }

        if (!string.IsNullOrWhiteSpace(filtros?.CursoNome))
        {
            query = query.Where(o => o.CursoNome.ToUpper() == filtros!.CursoNome.ToUpper());
        }

        if (filtros?.OfertaKey != null)
        {
            query = query.Where(o => o.OfertaKey == filtros!.OfertaKey.Value);
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