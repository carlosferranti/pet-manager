using Anima.Inscricao.Application.Config;
using Anima.Inscricao.Application.DTOs.Escola;
using Anima.Inscricao.Application.DTOs.Inscricoes;
using Anima.Inscricao.Application.DTOs.Marcas;
using Anima.Inscricao.Application.DTOs.SistemasIntegracao;
using Anima.Inscricao.Application.UseCases.Inscricoes.AtualizarInscricaoCandidato;
using Anima.Inscricao.Domain.Campi;
using Anima.Inscricao.Domain.Concursos;
using Anima.Inscricao.Domain.Cupons;
using Anima.Inscricao.Domain.Cursos;
using Anima.Inscricao.Domain.Enderecos;
using Anima.Inscricao.Domain.Escolas;
using Anima.Inscricao.Domain.Etapas;
using Anima.Inscricao.Domain.Fichas;
using Anima.Inscricao.Domain.FormasEntrada;
using Anima.Inscricao.Domain.Inscricoes.Events;
using Anima.Inscricao.Domain.IntegracaoSistemas;
using Anima.Inscricao.Domain.Marcas;
using Anima.Inscricao.Domain.OfertaConcursos;
using Anima.Inscricao.Domain.Ofertas;
using Anima.Inscricao.Domain.Produtos;
using Anima.Inscricao.Domain.Turnos;
using Anima.Inscricao.Infra.Messaging._Shared.Kafka;
using Anima.Inscricao.Infra.Messaging.Publishes.Shared;
using Anima.Inscricoes.Domain.Inscricoes;

using AutoMapper;

using MediatR;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

using static Anima.Inscricao.Application.DTOs.Inscricoes.InfoInscricaoCandidatoAtualizacaoEventoDto;

namespace Anima.Inscricao.Infra.Messaging.Publishes.Kafka.Inscricoes;

public class InscricaoCandidatoAtualizacaoEventHandler : BaseKafkaEventHandler,
    INotificationHandler<InfoInscricaoCandidatoAtualizadaEvent<AtualizarInscricaoCandidatoCommand>>
{
    private readonly string _topicoAtualizacaoInscricao = null!;
    private readonly ILogger<InscricaoCandidatoAtualizacaoEventHandler> _logger;
    private readonly IInscricaoRepository _inscricaoRepository;
    private readonly IIntegracaoSistemaRepository _integracaoSistemaRepository;
    private readonly IMarcaRepository _marcaRepository;
    private readonly IOfertaRepository _ofertaRepository;
    private readonly IProdutoRepository _produtoRepository;
    private readonly ICampusRepository _campusRepository;
    private readonly ICursoRepository _cursoRepository;
    private readonly ITurnoRepository _turnoRepository;
    private readonly ICidadeRepository _cidadeRepository;
    private readonly ICupomRepository _cupomRepository;
    private readonly IOfertaConcursoRepository _ofertaConcursoRepository;
    private readonly IConcursoRepository _concursoRepository;
    private readonly IEstadoRepository _estadoRepository;
    private readonly IPaisRepository _paisRepository;
    private readonly IEscolaRepository _escolaRepository;
    private readonly IFichaRepository _fichaRepository;
    private readonly IEtapaTemplateRepository _etapaTemplateRepository;
    private readonly IMapper _mapper;
    private readonly IFormaEntradaRepository _formaEntradaRepository;

    public InscricaoCandidatoAtualizacaoEventHandler(
        ILogger<InscricaoCandidatoAtualizacaoEventHandler> logger,
        IKafkaFactory kafkaFactory,
        IOptions<KafkaConfig> kafkaConfig,
        IInscricaoRepository inscricaoRepository,
        IIntegracaoSistemaRepository integracaoSistemaRepository,
        IMarcaRepository marcaRepository,
        IOfertaRepository ofertaRepository,
        IProdutoRepository produtoRepository,
        ICampusRepository campusRepository,
        ICursoRepository cursoRepository,
        ITurnoRepository turnoRepository,
        ICidadeRepository cidadeRepository,
        ICupomRepository cupomRepository,
        IOfertaConcursoRepository ofertaConcursoRepository,
        IConcursoRepository concursoRepository,
        IEstadoRepository estadoRepository,
        IPaisRepository paisRepository,
        IEscolaRepository escolaRepository,
        IFichaRepository fichaRepository,
        IEtapaTemplateRepository etapaTemplateRepository,
        IMapper mapper,
        IFormaEntradaRepository formaEntradaRepository)
        : base(logger, kafkaFactory)
    {
        _topicoAtualizacaoInscricao = kafkaConfig.Value?.Topics?.AtualizacaoInscricao ?? throw new ArgumentNullException(_topicoAtualizacaoInscricao);
        _logger = logger;
        _inscricaoRepository = inscricaoRepository;
        _integracaoSistemaRepository = integracaoSistemaRepository;
        _marcaRepository = marcaRepository;
        _ofertaRepository = ofertaRepository;
        _produtoRepository = produtoRepository;
        _campusRepository = campusRepository;
        _cursoRepository = cursoRepository;
        _turnoRepository = turnoRepository;
        _cidadeRepository = cidadeRepository;
        _cupomRepository = cupomRepository;
        _ofertaConcursoRepository = ofertaConcursoRepository;
        _concursoRepository = concursoRepository;
        _estadoRepository = estadoRepository;
        _paisRepository = paisRepository;
        _escolaRepository = escolaRepository;
        _fichaRepository = fichaRepository;
        _etapaTemplateRepository = etapaTemplateRepository;
        _mapper = mapper;
        _formaEntradaRepository = formaEntradaRepository;
    }

    public async Task Handle(InfoInscricaoCandidatoAtualizadaEvent<AtualizarInscricaoCandidatoCommand> notification,
        CancellationToken cancellationToken)
    {
        try
        {
            var inscricaoAtualizadaEvento = _mapper.Map<InfoInscricaoCandidatoAtualizacaoEventoDto>(notification.AtualizacaoInscricao);

            if (notification.InscricaoCandidato.MarcaId != null)
            {
                inscricaoAtualizadaEvento.InfoMarca = await ObterMarca(notification.InscricaoCandidato.MarcaId);
            }

            if (notification.AtualizacaoInscricao.InfosOferta?.OfertaKey != null)
            {
                inscricaoAtualizadaEvento.InfosOferta = await ObterOferta(notification.AtualizacaoInscricao.InfosOferta.OfertaKey);
            }

            if (notification.AtualizacaoInscricao.InfosOferta?.OfertaConcursoKey != null)
            {
                inscricaoAtualizadaEvento.InfosConcurso = await ObterConcurso(notification.AtualizacaoInscricao.InfosOferta.OfertaConcursoKey);
            }

            if (inscricaoAtualizadaEvento.InfosCupons != null && inscricaoAtualizadaEvento.InfosCupons.Any())
            {
                inscricaoAtualizadaEvento.InfosCupons = await ObterCupons(inscricaoAtualizadaEvento.InfosCupons);
            }

            List<AtualizarInfosContatoDto> contatos = new();

            foreach (var contato in notification.InscricaoCandidato.Contatos)
            {
                contatos.Add(new AtualizarInfosContatoDto()
                {
                    Tipo = contato.Tipo.ToString(),
                    Valor = contato.Valor
                });
            }

            inscricaoAtualizadaEvento.InfosContato = contatos;

            List<AtualizarInfosEscolaridadeDto> escolaridades = new();

            foreach (var escolaridade in inscricaoAtualizadaEvento.InfosEscolaridade)
            {
                string? cidadeNome = null;

                if (escolaridade.CidadeKey != null)
                {
                    cidadeNome = await ObterNomeCidade(escolaridade.CidadeKey);
                }

                if (escolaridade.EscolaKey != null)
                {
                    var escola = await ObterEscolaInscricao(escolaridade.EscolaKey).FirstAsync(cancellationToken);

                    escolaridades.Add(new AtualizarInfosEscolaridadeDto()
                    {
                        AnoConclusao = escolaridade.AnoConclusao,
                        Escola = new()
                        {
                            Integracao = escola.Integracao,
                            Key = escola.Key,
                            Nome = escola.Nome,
                        },
                        Nivel = escolaridade.Nivel,
                        CidadeNome = cidadeNome
                    });
                }
                else
                {
                    escolaridades.Add(new AtualizarInfosEscolaridadeDto()
                    {
                        AnoConclusao = escolaridade.AnoConclusao,
                        Escola = new()
                        {
                            Integracao = null,
                            Key = null,
                            Nome = escolaridade.OutraEscola,
                        },
                        Nivel = escolaridade.Nivel,
                        CidadeNome = cidadeNome
                    });
                }
            }

            inscricaoAtualizadaEvento.InfosEscolaridade = escolaridades;

            if (inscricaoAtualizadaEvento.InfosEndereco != null)
            {
                foreach (var endereco in inscricaoAtualizadaEvento.InfosEndereco)
                {
                    endereco.Pais = await (from cidade in _cidadeRepository.GetQueryable()
                                           join estado in _estadoRepository.GetQueryable()
                                               on cidade.EstadoId equals estado.Id
                                           join pais in _paisRepository.GetQueryable()
                                               on estado.PaisId equals pais.Id
                                           where
                                               cidade.Nome == endereco.Cidade && estado.Nome == endereco.Estado
                                           select pais.Nome).FirstOrDefaultAsync();
                }
            }

            var sistemasOrigens = await _inscricaoRepository.ObterIntegracaoInscricao(notification.InscricaoCandidato.Key, cancellationToken);

            inscricaoAtualizadaEvento.InfoOrigens = sistemasOrigens
                .Select(so => new SistemaIntegracaoDto
                {
                    NomeSistema = so.NomeSistema,
                    CodigoOrigem = so.CodigoOrigem
                });

            if (notification.InscricaoCandidato.Etapas.Any(x => x.Atual))
            {
                inscricaoAtualizadaEvento.InfosEtapa = await RecuperarEtapaAsync(notification);
            }

            if (notification.InscricaoCandidato.FormasEntrada.Any(x => x.Atual))
            {
                inscricaoAtualizadaEvento.InfosFormaEntrada = await RecuperarFormaEntradaAsync(notification);
            }

            await PublishEvent(_topicoAtualizacaoInscricao, inscricaoAtualizadaEvento, cancellationToken);

        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Erro ao publicar evento de atualização de inscrição");
        }
    }

    private async Task<InfoFormaEntradaDto> RecuperarFormaEntradaAsync(InfoInscricaoCandidatoAtualizadaEvent<AtualizarInscricaoCandidatoCommand> notification)
    {
        var formaEntradaId = notification.InscricaoCandidato.FormasEntrada.First(x => x.Atual).FormaEntradaId;

        var formaEntrada = await _formaEntradaRepository.GetAsync(formaEntradaId);

        return new InfoFormaEntradaDto
        {
            Key = formaEntrada.Key,
            Nome = formaEntrada.Nome
        };
    }

    private async Task<AtualizarEtapaDto> RecuperarEtapaAsync(InfoInscricaoCandidatoAtualizadaEvent<AtualizarInscricaoCandidatoCommand> notification)
    {
        var etapaAtual = notification.InscricaoCandidato.Etapas.First(x => x.Atual);

        var query = from ficha in _fichaRepository.GetQueryable()
                    join etapa in _etapaTemplateRepository.GetQueryable()
                        on ficha.Etapas.FirstOrDefault(x => x.Id == etapaAtual.EtapaFichaId)!.EtapaTemplateId equals etapa.Id
                    select new AtualizarEtapaDto()
                    {
                        Key = etapa.Key,
                        Nome = etapa.Nome,
                        Sequencia = ficha.Etapas.FirstOrDefault(x => x.Id == etapaAtual.EtapaFichaId)!.Sequencia
                    };

        return await query.SingleAsync();
    }

    private async Task<List<AtualizarInfosCupomDto>> ObterCupons(List<AtualizarInfosCupomDto> infosCupons)
    {
        foreach (var cupom in infosCupons)
        {
            var query = from cupomRepo in _cupomRepository.GetQueryable()
                        join sistemaIntegracao in _integracaoSistemaRepository.GetQueryable()
                            on cupomRepo.IntegracaoCupom.IntegracaoSistemaId equals sistemaIntegracao.Id
                        where cupomRepo.Codigo == cupom.Codigo
                        select new
                        {
                            Codigo = cupom.Codigo,
                            SistemaIntegracao = new SistemaIntegracaoDto
                            {
                                NomeSistema = sistemaIntegracao.Nome,
                                CodigoOrigem = cupomRepo.IntegracaoCupom.CodigoOrigem
                            }
                        };

            var groupedResult = await query
                .GroupBy(x => new { x.Codigo })
                .Select(g => new AtualizarInfosCupomDto
                {
                    Codigo = g.Key.Codigo,
                    SistemaIntegracao = g.Select(x => x.SistemaIntegracao).ToList()
                }).FirstOrDefaultAsync();

            cupom.Codigo = groupedResult.Codigo;
            cupom.SistemaIntegracao = groupedResult.SistemaIntegracao;
        }

        return infosCupons;
    }

    private async Task<MarcaDto> ObterMarca(int marcaId)
    {
        var query = from marca in _marcaRepository.GetQueryable()
                    from integracaoMarca in marca.IntegracoesMarcas
                    join sistemaIntegracao in _integracaoSistemaRepository.GetQueryable()
                        on integracaoMarca.IntegracaoSistemaId equals sistemaIntegracao.Id
                    where marca.Id == marcaId
                    select new
                    {
                        Marca = marca,
                        SistemaIntegracao = new SistemaIntegracaoDto
                        {
                            NomeSistema = sistemaIntegracao.Nome,
                            CodigoOrigem = integracaoMarca.CodigoOrigem
                        }
                    };

        var groupedResult = await query
            .GroupBy(x => new { x.Marca.Key, x.Marca.Nome, x.Marca.Sigla })
            .Select(g => new MarcaDto
            {
                Key = g.Key.Key,
                Nome = g.Key.Nome,
                Sigla = g.Key.Sigla,
                IntegracaoSistema = g.Select(x => x.SistemaIntegracao).ToList()
            })
            .ToListAsync();

        return groupedResult.FirstOrDefault() ?? new();
    }
    private async Task<AtualizarInfosOfertaDto> ObterOferta(Guid? ofertaKey)
    {
        var query = from oferta in _ofertaRepository.GetQueryable()
                    join produto in _produtoRepository.GetQueryable()
                        on oferta.ProdutoId equals produto.Id
                    join campus in _campusRepository.GetQueryable()
                        on produto.CampusId equals campus.Id
                    join curso in _cursoRepository.GetQueryable()
                        on produto.CursoId equals curso.Id
                    join sistemaIntegracao in _integracaoSistemaRepository.GetQueryable()
                        on curso.IntegracaoCurso.IntegracaoSistemaId equals sistemaIntegracao.Id into sistemaIntegracaoGroup
                    from sistemaIntegracao in sistemaIntegracaoGroup.DefaultIfEmpty()
                    join turno in _turnoRepository.GetQueryable()
                        on produto.TurnoId equals turno.Id
                    where oferta.Key == ofertaKey
                    select new
                    {
                        Key = oferta.Key,
                        Produto = new
                        {
                            Campus = campus.Nome,
                            Turno = turno.Nome,
                            Curso = new
                            {
                                Nome = curso.Nome,
                                SistemaIntegracao = new SistemaIntegracaoDto
                                {
                                    NomeSistema = sistemaIntegracao.Nome,
                                    CodigoOrigem = curso.IntegracaoCurso.CodigoOrigem
                                }
                            }
                        }
                    };

        var groupedResult = await query
            .GroupBy(x => new { x.Key, x.Produto.Campus, x.Produto.Turno, x.Produto.Curso.Nome })
            .Select(g => new AtualizarInfosOfertaDto
            {
                OfertaKey = g.Key.Key,
                Produto = new AtualizarInfosProdutoDto
                {
                    Campus = g.Key.Campus,
                    Turno = g.Key.Turno,
                    Curso = new AtualizarInfosCursoDto
                    {
                        Nome = g.Key.Nome,
                        SistemaIntegracao = g.Select(x => x.Produto.Curso.SistemaIntegracao).ToList(),
                    },
                },
            })
            .ToListAsync();

        return groupedResult.FirstOrDefault() ?? new();
    }

    private async Task<AtualizarInfosConcursoDto> ObterConcurso(Guid? ofertaConcursoKey)
    {
        var query = from ofertaConcurso in _ofertaConcursoRepository.GetQueryable()
                    join concurso in _concursoRepository.GetQueryable()
                        on ofertaConcurso.ConcursoId equals concurso.Id
                    join sistemaIntegracao in _integracaoSistemaRepository.GetQueryable()
                        on concurso.IntegracaoConcurso.IntegracaoSistemaId equals sistemaIntegracao.Id into sistemaIntegracaoGroup
                    from sistemaIntegracao in sistemaIntegracaoGroup.DefaultIfEmpty()
                    where ofertaConcurso.Key == ofertaConcursoKey
                    select new
                    {
                        Nome = concurso.Nome,
                        SistemaIntegracao = new SistemaIntegracaoDto()
                        {
                            NomeSistema = sistemaIntegracao.Nome,
                            CodigoOrigem = concurso.IntegracaoConcurso.CodigoOrigem
                        }
                    };

        var groupedResult = await query
            .GroupBy(x => new { x.Nome })
            .Select(g => new AtualizarInfosConcursoDto
            {
                Nome = g.Key.Nome,
                SistemaIntegracao = g.Select(x => x.SistemaIntegracao).ToList(),
            })
            .ToListAsync();

        return groupedResult.FirstOrDefault() ?? new();
    }

    private IQueryable<EscolaDto> ObterEscolaInscricao(Guid? escolaKey)
    {
        return from escola in _escolaRepository.GetQueryable()
               from integracaoEscola in _integracaoSistemaRepository.GetQueryable()
                     .Where(i => i.Id == escola.IntegracaoEscola!.IntegracaoSistemaId).DefaultIfEmpty()
               where escola.Key == escolaKey
               select new EscolaDto()
               {
                   Nome = escola.Nome,
                   Key = escola.Key,
                   Integracao = escola.IntegracaoEscola != null ? new SistemaIntegracaoDto()
                   {
                       CodigoOrigem = escola.IntegracaoEscola!.CodigoOrigem,
                       NomeSistema = integracaoEscola.Nome,
                   } : null,
               };
    }

    private async Task<string?> ObterNomeCidade(Guid? cidadeKey)
    {
        return await _cidadeRepository.GetQueryable().Where(c => c.Key == cidadeKey).Select(c => c.Nome).FirstOrDefaultAsync();
    }
}
