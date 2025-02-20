using Anima.Inscricao.Application._Shared.Queries;
using Anima.Inscricao.Application.DTOs.Candidatos;
using Anima.Inscricao.Application.DTOs.Concursos;
using Anima.Inscricao.Application.DTOs.Instituicao;
using Anima.Inscricao.Application.DTOs.OfertaConcursos;
using Anima.Inscricao.Application.DTOs.Ofertas;
using Anima.Inscricao.Application.DTOs.SistemasIntegracao;
using Anima.Inscricao.Application.Extensions;
using Anima.Inscricao.Application.Interfaces.Repositories;
using Anima.Inscricao.Application.UseCases.Concursos.ProcessarRegraConcursoDestrancamentoReopcao;
using Anima.Inscricao.Application.UseCases.Concursos.ProcessarRegraConcursoEnem;
using Anima.Inscricao.Application.UseCases.Concursos.ProcessarRegraConcursoInscricaoAtiva;
using Anima.Inscricao.Application.UseCases.Concursos.ProcessarRegraConcursoReopcao;
using Anima.Inscricao.Application.UseCases.Concursos.ProcessarRegraConcursoSegundaGraduacao;
using Anima.Inscricao.Application.UseCases.Concursos.ProcessarRegraTransferencia;
using Anima.Inscricao.Domain._Shared.ValueObjects;
using Anima.Inscricao.Domain.Concursos;
using Anima.Inscricao.Domain.Cursos;
using Anima.Inscricao.Domain.FormasEntrada;
using Anima.Inscricao.Domain.Instituicoes;
using Anima.Inscricao.Domain.Intakes;
using Anima.Inscricao.Domain.IntegracaoSistemas;
using Anima.Inscricao.Domain.Links;
using Anima.Inscricao.Domain.Marcas;
using Anima.Inscricao.Domain.Modalidades;
using Anima.Inscricao.Domain.ModalidadesAvaliacao;
using Anima.Inscricao.Domain.OfertaConcursos;
using Anima.Inscricao.Domain.Ofertas;
using Anima.Inscricao.Domain.Produtos;

using MediatR;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Anima.Inscricao.Application.UseCases.Concursos.PesquisarConcursoPorOferta;

public class PesquisarConcursoPorOfertaQueryHandler : IQueryHandler<PesquisarConcursoPorOfertaQuery, List<ConcursosPorOfertaDto>>
{
    private readonly IMediator _mediator;
    private readonly IOfertaConcursoRepository _ofertaConcursoRepository;
    private readonly IConcursoRepository _concursoRepository;
    private readonly IFormaEntradaRepository _formaEntradaRepository;
    private readonly IOfertaRepository _ofertaRepository;
    private readonly IModalidadeRepository _modalidadeRepository;
    private readonly ICandidatoRepository _candidatoRepository;
    private readonly IIntakeRepository _intakeRepository;
    private readonly IProdutoRepository _produtoRepository;
    private readonly IInstituicaoRepository _instituicaoRepository;
    private readonly IMarcaRepository _marcaRepository;
    private readonly IIntegracaoSistemaRepository _integracaoSistemaRepository;
    private readonly IModalidadeAvaliacaoRepository _modalidadeAvaliacaoRepository;
    private readonly ILinkRepository _linkRepository;
    private readonly ICursoRepository _cursoRepository;
    private readonly ILogger<PesquisarConcursoPorOfertaQueryHandler> _logger;

    public PesquisarConcursoPorOfertaQueryHandler(
        IMediator mediator,
        IOfertaConcursoRepository ofertaConcursoRepository,
        IConcursoRepository concursoRepository,
        IFormaEntradaRepository formaEntradaRepository,
        IOfertaRepository ofertaRepository,
        IModalidadeRepository modalidadeRepository,
        ICandidatoRepository candidatoRepository,
        IIntakeRepository intakeRepository,
        IProdutoRepository produtoRepository,
        IInstituicaoRepository instituicaoRepository,
        IMarcaRepository marcaRepository,
        IIntegracaoSistemaRepository integracaoSistemaRepository,
        IModalidadeAvaliacaoRepository modalidadeAvaliacaoRepository,
        ILinkRepository linkRepository,
        ICursoRepository cursoRepository,
        ILogger<PesquisarConcursoPorOfertaQueryHandler> logger)
    {
        _mediator = mediator;
        _ofertaConcursoRepository = ofertaConcursoRepository;
        _concursoRepository = concursoRepository;
        _formaEntradaRepository = formaEntradaRepository;
        _ofertaRepository = ofertaRepository;
        _modalidadeRepository = modalidadeRepository;
        _candidatoRepository = candidatoRepository;
        _intakeRepository = intakeRepository;
        _produtoRepository = produtoRepository;
        _instituicaoRepository = instituicaoRepository;
        _marcaRepository = marcaRepository;
        _integracaoSistemaRepository = integracaoSistemaRepository;
        _modalidadeAvaliacaoRepository = modalidadeAvaliacaoRepository;
        _linkRepository = linkRepository;
        _cursoRepository = cursoRepository;
        _logger = logger;
    }

    public async Task<List<ConcursosPorOfertaDto>> Handle(PesquisarConcursoPorOfertaQuery request, CancellationToken cancellationToken)
    {
        var ofertaProdutoQuery = from oferta in _ofertaRepository.GetQueryable()
                                 join produto in _produtoRepository.GetQueryable()
                                     on oferta.ProdutoId equals produto.Id
                                 join intake in _intakeRepository.GetQueryable()
                                     on oferta.IntakeId equals intake.Id
                                 join instituicao in _instituicaoRepository.GetQueryable()
                                     on produto.InstituicaoId equals instituicao.Id
                                 join marca in _marcaRepository.GetQueryable()
                                     on instituicao.MarcaId equals marca.Id
                                 join curso in _cursoRepository.GetQueryable()
                                     on produto.CursoId equals curso.Id
                                 join modalidade in _modalidadeRepository.GetQueryable()
                                     on curso.ModalidadeId equals modalidade.Id
                                 where oferta.Key == request.OfertaKey
                                 select new OfertaComProdutoDto()
                                 {
                                     Key = oferta.Key,
                                     ProdutoKey = produto.Key,
                                     IntakeKey = intake.Key,
                                     Intake = new()
                                     {
                                         Key = intake.Key,
                                         Nome = intake.Nome,
                                         VigenciaInicio = intake.Vigencia.Inicio,
                                         VigenciaTermino = intake.Vigencia.Termino,
                                     },
                                     Marca = new()
                                     {
                                         Key = marca.Key,
                                         Nome = marca.Nome,
                                         IntegracaoSistema = (from integracaoMarca in marca.IntegracoesMarcas
                                                              join sistema in _integracaoSistemaRepository.GetQueryable()
                                                                  on integracaoMarca.IntegracaoSistemaId equals sistema.Id into integracaoJoin
                                                              from integracaoSistema in integracaoJoin.DefaultIfEmpty()
                                                              select new SistemaIntegracaoDto()
                                                              {
                                                                  NomeSistema = integracaoSistema.Nome,
                                                                  CodigoOrigem = integracaoMarca.CodigoOrigem,
                                                              }).ToList(),
                                     },
                                     Instituicao = new()
                                     {
                                         Key = instituicao.Key,
                                         Nome = instituicao.Nome,
                                         Integracoes = (from integracaoInstituicao in instituicao.IntegracaoInstituicao
                                                        join sistema in _integracaoSistemaRepository.GetQueryable()
                                                            on integracaoInstituicao.IntegracaoSistemaId equals sistema.Id into integracaoJoin
                                                        from integracaoSistema in integracaoJoin.DefaultIfEmpty()
                                                        select new SistemaIntegracaoDto()
                                                        {
                                                            NomeSistema = integracaoSistema.Nome,
                                                            CodigoOrigem = integracaoInstituicao.CodigoOrigem,
                                                        }).ToList(),
                                     },
                                     Modalidade = new()
                                     {
                                         Key = modalidade.Key,
                                     },
                                 };

        var ofertaProduto = await ofertaProdutoQuery.SingleAsync(cancellationToken);

        var dataAtual = DateTime.Now;

        var query = from ofertaConcurso in _ofertaConcursoRepository.GetQueryable().Include(x => x.OpcaoAcessos)
                    join concurso in _concursoRepository.GetQueryable()
                        on ofertaConcurso.ConcursoId equals concurso.Id
                    from concursoFormaEntrada in concurso.FormasEntrada
                    join formaEntrada in _formaEntradaRepository.GetQueryable()
                        on concursoFormaEntrada.FormaEntradaId equals formaEntrada.Id
                    join oferta in _ofertaRepository.GetQueryable()
                        on ofertaConcurso.OfertaId equals oferta.Id
                    from modalidade in _modalidadeRepository.GetQueryable()
                    join modalidadeAvaliacao in _modalidadeAvaliacaoRepository.GetQueryable().DefaultIfEmpty()
                        on concurso.ModalidadeAvaliacaoId equals modalidadeAvaliacao.Id into modalidadeAvaliacaoGroup
                    from modalidadeAvaliacao in modalidadeAvaliacaoGroup.DefaultIfEmpty()
                    from link in _linkRepository.GetQueryable().Where(l => l.FormasEntrada.Any(x => x.FormaEntradaId == formaEntrada.Id))
                    where ofertaConcurso.OfertaId == oferta.Id &&
                    oferta.Key == request.OfertaKey &&
                    concurso.Modalidades.Any(x => x.ModalidadeId == modalidade.Id) &&
                    concurso.VigenciaInscricao.Inicio < dataAtual &&
                    concurso.VigenciaInscricao.Termino > dataAtual &&
                    link.Key == request.LinkKey
                    select new
                    {
                        FormaEntradaKey = formaEntrada.Key,
                        NomeFormaEntrada = formaEntrada.Nome,
                        OfertaConcursoKey = ofertaConcurso.Key,
                        NomeConcurso = concurso.Nome,
                        InicioProva = concurso.InicioProva,
                        TerminoProva = concurso.TerminoProva,
                        Modalidade = modalidade.Nome,
                        DescricaoFormaEntrada = formaEntrada.Descricao,
                        OpcoesAcesso = ofertaConcurso.OpcaoAcessos,
                        OrdemExibicao = formaEntrada.OrdemExibicao,
                        NomeModalidadeAvaliacao = modalidadeAvaliacao.Nome,
                        ConcursoKey = concurso.Key,
                    };

        var queryGroup = query
            .GroupBy(x => new { x.OrdemExibicao, x.FormaEntradaKey, x.NomeFormaEntrada, x.DescricaoFormaEntrada })
            .Select(x => new ConcursosPorOfertaDto()
            {
                OrdemExibicao = x.Key.OrdemExibicao,
                FormaEntradaKey = x.Key.FormaEntradaKey,
                NomeFormaEntrada = x.Key.NomeFormaEntrada,
                DescricaoFormaEntrada = x.Key.DescricaoFormaEntrada,
                Concursos = x.Select(c => new ConcursosPorOfertaDto.ConcursosFormaEntradaDto()
                {
                    ConcursoKey = c.ConcursoKey,
                    OfertaConcursoKey = c.OfertaConcursoKey,
                    NomeConcurso = c.NomeConcurso,
                    DataInicioProva = c.InicioProva,
                    HoraInicioProva = c.InicioProva.HasValue ? c.InicioProva.Value.ToString("HH\"h\"mm").Replace("h00", "h") : null,
                    DataTerminoProva = c.TerminoProva,
                    HoraTerminoProva = c.TerminoProva.HasValue ? c.TerminoProva.Value.ToString("HH\"h\"mm").Replace("h00", "h") : null,
                    Modalidade = c.Modalidade,
                    NomeModalidadeAvaliacao = c.NomeModalidadeAvaliacao,
                    OpcaoAcessos = c.OpcoesAcesso.Any() ? c.OpcoesAcesso.Select(o => new OpcaoAcessoDto()
                    {
                        Key = o.Key,
                        Tipo = (int)o.TipoOpcaoAcesso,
                        Nome = o.TipoOpcaoAcesso.Description(),
                    }).ToList() : null,
                }).ToList(),
            });

        if (request.FormaEntradaKey.HasValue)
        {
            queryGroup = queryGroup.Where(x => x.FormaEntradaKey == request.FormaEntradaKey);
        }

        var formaEntradaConcursosOfertados = await queryGroup
            .OrderBy(o => o.OrdemExibicao)
            .ToListAsync(cancellationToken);

        IEnumerable<CandidatoVinculoDto> vinculosAnima = Enumerable.Empty<CandidatoVinculoDto>();
        IEnumerable<InstituicaoAssociadaVestibDto> instituicoesAssociadas = Enumerable.Empty<InstituicaoAssociadaVestibDto>();

        try
        {
            vinculosAnima = await _candidatoRepository.PesquisarVinculoCandidatoAsync(request.Cpf, null);

            instituicoesAssociadas = await _candidatoRepository.BuscarInstituicoesAssociadasAsync(null);

            formaEntradaConcursosOfertados = await _mediator.Send(new ProcessarRegraConcursoTransferenciaCommand()
            {
                VinculosAnima = vinculosAnima?.ToList(),
                Concursos = formaEntradaConcursosOfertados,
                Instituicao = ofertaProduto.Instituicao,
                VigenciaIntake = new Vigencia(ofertaProduto.Intake.VigenciaInicio, ofertaProduto.Intake.VigenciaTermino),
            }, cancellationToken);

            formaEntradaConcursosOfertados = await _mediator.Send(new ProcessarRegraConcursoDestrancamentoRetornoCommand()
            {
                VinculosAnima = vinculosAnima?.ToList(),
                Concursos = formaEntradaConcursosOfertados,
                Instituicao = ofertaProduto.Instituicao,
            }, cancellationToken);

            formaEntradaConcursosOfertados = await _mediator.Send(new ProcessarRegraConcursoReopcaoCommand()
            {
                VinculosAnima = vinculosAnima?.ToList(),
                Concursos = formaEntradaConcursosOfertados,
                Instituicao = ofertaProduto.Instituicao,
                Cpf = request.Cpf,
                VigenciaIntake = new Vigencia(ofertaProduto.Intake.VigenciaInicio, ofertaProduto.Intake.VigenciaTermino),
                InstituicaoAssociadas = instituicoesAssociadas.ToList(),
            }, cancellationToken);

            formaEntradaConcursosOfertados = await _mediator.Send(new ProcessarRegraConcursoSegundaGraduacaoCommand()
            {
                VinculosAnima = vinculosAnima?.ToList(),
                Concursos = formaEntradaConcursosOfertados,
                Cpf = request.Cpf,
                VigenciaIntake = new Vigencia(ofertaProduto.Intake.VigenciaInicio, ofertaProduto.Intake.VigenciaTermino),
            }, cancellationToken);

            formaEntradaConcursosOfertados = await _mediator.Send(new ProcessarRegraConcursoEnemCommand()
            {
                Concursos = formaEntradaConcursosOfertados,
                Cpf = request.Cpf,
                ModalidadeKey = ofertaProduto.Modalidade!.Key,
                IntakeKey = ofertaProduto.IntakeKey,
                MarcaKey = ofertaProduto.Marca.Key,
            }, cancellationToken);

            formaEntradaConcursosOfertados = await _mediator.Send(new ProcessarRegraConcursoInscricaoAtivaCommand()
            {
                FormasEntrada = formaEntradaConcursosOfertados,
                Cpf = request.Cpf,
                IntakeKey = ofertaProduto.IntakeKey,
                MarcaKey = ofertaProduto.Marca.Key,
            }, cancellationToken);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Erro ao buscar os vinculos do candidato. {@Request}", request);
        }

        return formaEntradaConcursosOfertados;
    }
}