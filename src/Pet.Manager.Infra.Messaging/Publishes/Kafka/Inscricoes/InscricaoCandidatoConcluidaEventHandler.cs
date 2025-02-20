using System;

using Anima.Inscricao.Application.Config;
using Anima.Inscricao.Application.DTOs.Acessibilidades;
using Anima.Inscricao.Application.DTOs.CursosExternos;
using Anima.Inscricao.Application.DTOs.Deficiencias;
using Anima.Inscricao.Application.DTOs.Escola;
using Anima.Inscricao.Application.DTOs.Inscricoes;
using Anima.Inscricao.Application.DTOs.OfertaConcursos;
using Anima.Inscricao.Application.DTOs.SistemasIntegracao;
using Anima.Inscricao.Application.Extensions;
using Anima.Inscricao.Domain.Acessibilidades;
using Anima.Inscricao.Domain.Campi;
using Anima.Inscricao.Domain.Concursos;
using Anima.Inscricao.Domain.Cupons;
using Anima.Inscricao.Domain.Cupons.Entities;
using Anima.Inscricao.Domain.Cursos;
using Anima.Inscricao.Domain.CursosExternos;
using Anima.Inscricao.Domain.CursosExternos.Entities;
using Anima.Inscricao.Domain.Deficiencias;
using Anima.Inscricao.Domain.Enderecos;
using Anima.Inscricao.Domain.Escolas;
using Anima.Inscricao.Domain.Escolas.Entities;
using Anima.Inscricao.Domain.Fichas;
using Anima.Inscricao.Domain.Fichas.Entities;
using Anima.Inscricao.Domain.FormasEntrada;
using Anima.Inscricao.Domain.Inscricoes.Events;
using Anima.Inscricao.Domain.Instituicoes;
using Anima.Inscricao.Domain.IntegracaoSistemas;
using Anima.Inscricao.Domain.Marcas;
using Anima.Inscricao.Domain.Marcas.Entities;
using Anima.Inscricao.Domain.Matriculas;
using Anima.Inscricao.Domain.Modalidades;
using Anima.Inscricao.Domain.NiveisCurso;
using Anima.Inscricao.Domain.OfertaConcursos;
using Anima.Inscricao.Domain.Ofertas;
using Anima.Inscricao.Domain.Produtos;
using Anima.Inscricao.Domain.Turnos;
using Anima.Inscricao.Infra.Messaging._Shared.Kafka;
using Anima.Inscricao.Infra.Messaging.Publishes.Shared;
using Anima.Inscricoes.Domain.Inscricoes;

using MediatR;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

using static Anima.Inscricao.Application.DTOs.Inscricoes.InscricaoOfertaConcursoDto;

namespace Anima.Inscricao.Infra.Messaging.Publishes.Kafka.Inscricoes;

public class InscricaoCandidatoConcluidaEventHandler : BaseKafkaEventHandler, INotificationHandler<InscricaoCandidatoConcluidaEvent>
{
    private readonly string _topicoConfirmacaoInscricao = null!;
    private readonly ILogger<InscricaoCandidatoConcluidaEventHandler> _logger;
    private readonly IAcessibilidadeRepository _acessibilidadeRepository;
    private readonly IDeficienciaRepository _deficienciaRepository;
    private readonly IEstadoRepository _estadoRepository;
    private readonly ICidadeRepository _cidadeRepository;
    private readonly IEscolaRepository _escolaRepository;
    private readonly IIntegracaoSistemaRepository _integracaoSistemaRepository;
    private readonly IOfertaConcursoRepository _ofertaConcursoRepository;
    private readonly IOfertaRepository _ofertaRepository;
    private readonly IProdutoRepository _produtoRepository;
    private readonly IInstituicaoRepository _instituicaoRepository;
    private readonly IInscricaoRepository _inscricaoRepository;
    private readonly IFichaRepository _fichaRepository;
    private readonly IConcursoRepository _concursoRepository;
    private readonly ITurnoRepository _turnoRepository;
    private readonly ICampusRepository _campusRepository;
    private readonly ICursoRepository _cursoRepository;
    private readonly IFormaEntradaRepository _formaEntradaRepository;
    private readonly IOfertaConcursoOpcaoAcessoRepository _ofertaConcursoOpcaoAcessoRepository;
    private readonly IMarcaRepository _marcaRepository;
    private readonly ICupomRepository _cupomRepository;
    private readonly IMatriculaRepository _matriculaRepository;
    private readonly ICursoExternoRepository _cursoExternoRepository;
    private readonly INivelCursoRepository _nivelCursoRepository;
    private readonly IModalidadeRepository _modalidadeRepository;

    public InscricaoCandidatoConcluidaEventHandler(
        ILogger<InscricaoCandidatoConcluidaEventHandler> logger,
        IKafkaFactory kafkaFactory,
        IOptions<KafkaConfig> kafkaConfig,
        IAcessibilidadeRepository acessibilidadeRepository,
        IDeficienciaRepository deficienciaRepository,
        IEstadoRepository estadoRepository,
        ICidadeRepository cidadeRepository,
        IEscolaRepository escolaRepository,
        IIntegracaoSistemaRepository integracaoSistemaRepository,
        IOfertaConcursoRepository ofertaConcursoRepository,
        IOfertaRepository ofertaRepository,
        IProdutoRepository produtoRepository,
        IInstituicaoRepository instituicaoRepository,
        IFichaRepository fichaRepository,
        IConcursoRepository concursoRepository,
        ICampusRepository campusRepository,
        ITurnoRepository turnoRepository,
        ICursoRepository cursoRepository,
        IFormaEntradaRepository formaEntradaRepository,
        IInscricaoRepository inscricaoRepository,
        IOfertaConcursoOpcaoAcessoRepository ofertaConcursoOpcaoAcessoRepository,
        IMarcaRepository marcaRepository,
        ICupomRepository cupomRepository,
        IMatriculaRepository matriculaRepository,
        ICursoExternoRepository cursoExternoRepository,
        INivelCursoRepository nivelCursoRepository,
        IModalidadeRepository modalidadeRepository)
        : base(logger, kafkaFactory)
    {
        _topicoConfirmacaoInscricao = kafkaConfig.Value?.Topics?.ConfirmacaoInscricao ?? throw new ArgumentNullException(_topicoConfirmacaoInscricao);
        _logger = logger;
        _acessibilidadeRepository = acessibilidadeRepository;
        _deficienciaRepository = deficienciaRepository;
        _estadoRepository = estadoRepository;
        _cidadeRepository = cidadeRepository;
        _escolaRepository = escolaRepository;
        _integracaoSistemaRepository = integracaoSistemaRepository;
        _ofertaConcursoRepository = ofertaConcursoRepository;
        _ofertaRepository = ofertaRepository;
        _produtoRepository = produtoRepository;
        _instituicaoRepository = instituicaoRepository;
        _fichaRepository = fichaRepository;
        _concursoRepository = concursoRepository;
        _campusRepository = campusRepository;
        _turnoRepository = turnoRepository;
        _cursoRepository = cursoRepository;
        _formaEntradaRepository = formaEntradaRepository;
        _ofertaConcursoOpcaoAcessoRepository = ofertaConcursoOpcaoAcessoRepository;
        _inscricaoRepository = inscricaoRepository;
        _marcaRepository = marcaRepository;
        _cupomRepository = cupomRepository;
        _matriculaRepository = matriculaRepository;
        _cursoExternoRepository = cursoExternoRepository;
        _nivelCursoRepository = nivelCursoRepository;
        _modalidadeRepository = modalidadeRepository;
    }

    public async Task Handle(InscricaoCandidatoConcluidaEvent notification, CancellationToken cancellationToken)
    {
        try
        {
            InscricaoCandidatoEventoDto inscricaoEvento = new();

            inscricaoEvento.InscricaoKey = notification.InscricaoCandidato.Key;
            inscricaoEvento.CriadoEm = notification.InscricaoCandidato.Auditoria?.CriadoEm;
            inscricaoEvento.AlteradoEm = notification.InscricaoCandidato.Auditoria?.AlteradoEm;

            inscricaoEvento.Ficha = await ObterFichaAsync(notification.InscricaoCandidato.FichaId);

            inscricaoEvento.Marca = await ObterMarcaAsync(notification.InscricaoCandidato.MarcaId);

            inscricaoEvento.Candidato = new InscricaoCandidatoDto()
            {
                Nome = notification.InscricaoCandidato.Candidato.Nome,
                NomeSocial = notification.InscricaoCandidato.Candidato.NomeSocial,
                DataNascimento = notification.InscricaoCandidato.Candidato.DataNascimento != null ? DateOnly.FromDateTime(notification.InscricaoCandidato.Candidato.DataNascimento.Value) : null,
                NecessidadeEspecial = notification.InscricaoCandidato.Candidato.NecessidadeEspecial,
                Sexo = notification.InscricaoCandidato.Candidato.Sexo,
            };

            inscricaoEvento.Contatos = notification.InscricaoCandidato.Contatos?.Select(c => new InscricaoContatoDto()
            {
                Tipo = c.Tipo.ToString(),
                Valor = c.Valor,
            });

            inscricaoEvento.Documentos = notification.InscricaoCandidato.Documentos?.Select(d => new InscricaoDocumentoDto()
            {
                Tipo = d.Tipo.ToString(),
                Valor = d.Valor,
            });

            inscricaoEvento.Documentacoes = notification.InscricaoCandidato.Documentacao?.Select(d => new InscricaoDocumentacaoDto()
            {
                Tipo = d.Tipo.ToString(),
                Key = d.Key,
                Observacoes = d.Observacoes,
                TipoLocalArquivo = (int?)d.Arquivo?.TipoLocalArquivo,
                ChaveArquivo = d.Arquivo?.Chave,
                NomeArquivo = d.Arquivo?.Informacoes?.Nome,
                ExtensaoArquivo = d.Arquivo?.Informacoes?.Extensao,
                TamanhoArquivo = d.Arquivo?.Informacoes?.Tamanho,
            });

            inscricaoEvento.Oferta = await ObterOfertaInscicao(notification).FirstOrDefaultAsync(cancellationToken);

            inscricaoEvento.OpcaoAcesso = await ObterOpcaoAcessoInscricao(notification);

            inscricaoEvento.Acessibilidades = await ObterAcessibilidadesInscricao(notification).ToListAsync(cancellationToken);

            inscricaoEvento.Deficiencias = await ObterDeficienciasInscricao(notification).ToListAsync(cancellationToken);

            var enderecosQueryResult = await ObterEnderecoInscricao(notification).ToListAsync(cancellationToken);

            inscricaoEvento.Enderecos = notification.InscricaoCandidato.Enderecos
                .Select(e => new InscricaoEnderecoDto()
                {
                    Bairro = e.Bairro,
                    Cep = e.Cep,
                    Complemento = e.Complemento,
                    Numero = e.Numero,
                    Rua = e.Rua,
                    Estado = enderecosQueryResult.Find(q => q.Estado?.Nome == e.Estado && q.Cidade?.Nome == e.Cidade)?.Estado,
                    Cidade = enderecosQueryResult.Find(q => q.Cidade?.Nome == e.Cidade && q.Estado?.Nome == e.Estado)?.Cidade,
                });

            List<InscricaoEscolaridadeDto> escolaridades = new();
            foreach (var escolaridade in notification.InscricaoCandidato.Escolaridades)
            {
                EscolaDto? escola = null;
                CursoExternoDto? cursoExterno = null;

                if (escolaridade.EscolaId != null)
                {
                    escola = await ObterEscolaInscricao(escolaridade.EscolaId).FirstAsync(cancellationToken);
                }

                if (escolaridade.CursoExternoId != null)
                {
                    cursoExterno = await ObterCursoExternoInscricao(escolaridade.CursoExternoId).FirstAsync(cancellationToken);
                }

                escolaridades.Add(new InscricaoEscolaridadeDto()
                {
                    AnoConclusao = escolaridade.AnoConclusao,
                    Escola = new()
                    {
                        Integracao = escola?.Integracao,
                        Key = escola?.Key,
                        Nome = escola?.Nome ?? escolaridade.OutraEscola,
                    },
                    Curso = cursoExterno != null ? new()
                    {
                        Integracoes = cursoExterno?.Integracoes?.ToList(),
                        Key = cursoExterno?.Key,
                        Nome = cursoExterno?.Nome,
                    } : null,
                    Nivel = escolaridade.Nivel
                });
            }
            inscricaoEvento.Escolaridades = escolaridades;

            var sistemasOrigens = await _inscricaoRepository.ObterIntegracaoInscricao(notification.InscricaoCandidato.Key, cancellationToken);

            inscricaoEvento.InfoOrigens = sistemasOrigens
                 .Select(so => new SistemaIntegracaoDto
                 {
                     NomeSistema = so.NomeSistema,
                     CodigoOrigem = so.CodigoOrigem
                 });

            if (notification.InscricaoCandidato.Cupons != null && notification.InscricaoCandidato.Cupons.Any())
            {
                inscricaoEvento.Cupons = await ObterCupomAsync(notification.InscricaoCandidato.Cupons.Select(c => c.CupomId).ToList());
            }

            inscricaoEvento.Matriculas = await ObterMatriculasInscricao(notification).ToListAsync(cancellationToken);

            await PublishEvent(_topicoConfirmacaoInscricao, inscricaoEvento, cancellationToken);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Erro ao publicar evento de confirmação de inscrição");
        }
    }

    private IQueryable<AcessibilidadeDto> ObterAcessibilidadesInscricao(InscricaoCandidatoConcluidaEvent notification)
    {
        var acessibilidades = notification.InscricaoCandidato.Acessibilidades.Select(a => a.AcessibilidadeId).ToList();

        return from acessibilidade in _acessibilidadeRepository.GetQueryable()
               from integracao in _integracaoSistemaRepository.GetQueryable()
                 .Where(i => i.Id == acessibilidade.IntegracaoAcessibilidade!.IntegracaoSistemaId).DefaultIfEmpty()
               where acessibilidades.Contains(acessibilidade.Id)
               select new AcessibilidadeDto()
               {
                   Nome = acessibilidade.Nome,
                   Key = acessibilidade.Key,
                   Integracao = acessibilidade.IntegracaoAcessibilidade != null ? new SistemaIntegracaoDto()
                   {
                       CodigoOrigem = acessibilidade.IntegracaoAcessibilidade.CodigoOrigem,
                       NomeSistema = integracao.Nome,
                   } : null,
               };
    }

    private IQueryable<DeficienciaDto> ObterDeficienciasInscricao(InscricaoCandidatoConcluidaEvent notification)
    {
        var deficiencias = notification.InscricaoCandidato.Deficiencias.Select(d => d.DeficienciaId).ToList();

        return from deficiencia in _deficienciaRepository.GetQueryable()
               from integracao in _integracaoSistemaRepository.GetQueryable()
                   .Where(i => i.Id == deficiencia.IntegracaoDeficiencia!.IntegracaoSistemaId).DefaultIfEmpty()
               where deficiencias.Contains(deficiencia.Id)
               select new DeficienciaDto()
               {
                   Nome = deficiencia.Nome,
                   Key = deficiencia.Key,
                   Integracao = deficiencia.IntegracaoDeficiencia != null ? new SistemaIntegracaoDto()
                   {
                       CodigoOrigem = deficiencia.IntegracaoDeficiencia.CodigoOrigem,
                       NomeSistema = integracao.Nome,
                   } : null,
               };
    }

    private IQueryable<InscricaoEnderecoDto> ObterEnderecoInscricao(InscricaoCandidatoConcluidaEvent notification)
    {
        var cidades = notification.InscricaoCandidato.Enderecos.Select(e => e.Cidade).ToList();

        return from estado in _estadoRepository.GetQueryable()
               join cidade in _cidadeRepository.GetQueryable()
               on estado.Id equals cidade.EstadoId
               from integracaoEstado in _integracaoSistemaRepository.GetQueryable()
                   .Where(i => i.Id == estado.IntegracaoEstado!.IntegracaoSistemaId).DefaultIfEmpty()
               from integracaoCidade in _integracaoSistemaRepository.GetQueryable()
                   .Where(i => i.Id == cidade.IntegracaoCidade!.IntegracaoSistemaId).DefaultIfEmpty()
               where cidades.Contains(cidade.Nome)
               select new InscricaoEnderecoDto()
               {
                   Cidade = new()
                   {
                       Nome = cidade.Nome,
                       Key = cidade.Key,
                       Integracao = cidade.IntegracaoCidade != null ? new SistemaIntegracaoDto()
                       {
                           CodigoOrigem = cidade.IntegracaoCidade!.CodigoOrigem,
                           NomeSistema = integracaoCidade.Nome,
                       } : null,
                   },
                   Estado = new()
                   {
                       Nome = estado.Nome,
                       Key = estado.Key,
                       Integracao = estado.IntegracaoEstado != null ? new SistemaIntegracaoDto()
                       {
                           CodigoOrigem = estado.IntegracaoEstado!.CodigoOrigem,
                           NomeSistema = integracaoEstado.Nome,
                       } : null,
                   },
               };
    }

    private IQueryable<EscolaDto> ObterEscolaInscricao(EscolaId escolaId)
    {
        return from escola in _escolaRepository.GetQueryable()
               from integracaoEscola in _integracaoSistemaRepository.GetQueryable()
                     .Where(i => i.Id == escola.IntegracaoEscola!.IntegracaoSistemaId).DefaultIfEmpty()
               where escola.Id == escolaId
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

    private IQueryable<InscricaoOfertaDto> ObterOfertaInscicao(InscricaoCandidatoConcluidaEvent notification)
    {
        var inscricaoId = notification.InscricaoCandidato.Id;

        return from inscricao in _inscricaoRepository.GetQueryable()
               join ofertaConcurso in _ofertaConcursoRepository.GetQueryable().Include(x => x.OpcaoAcessos)
                on inscricao.Oferta.OfertaConcursoId equals ofertaConcurso.Id
               join oferta in _ofertaRepository.GetQueryable()
                 on ofertaConcurso.OfertaId equals oferta.Id
               join produto in _produtoRepository.GetQueryable()
                 on oferta.ProdutoId equals produto.Id
               join instituicao in _instituicaoRepository.GetQueryable()
                 on produto.InstituicaoId equals instituicao.Id
               join campus in _campusRepository.GetQueryable()
                 on produto.CampusId equals campus.Id
               join turno in _turnoRepository.GetQueryable()
                 on produto.TurnoId equals turno.Id
               join curso in _cursoRepository.GetQueryable()
                 on produto.CursoId equals curso.Id
               join nivel in _nivelCursoRepository.GetQueryable()
                 on curso.NivelCursoId equals nivel.Id
               join modalidade in _modalidadeRepository.GetQueryable()
                 on curso.ModalidadeId equals modalidade.Id
               join concurso in _concursoRepository.GetQueryable()
                 on ofertaConcurso.ConcursoId equals concurso.Id
               from integracaoInstituicao in instituicao.IntegracaoInstituicao.DefaultIfEmpty()
               from integracaoConcurso in _integracaoSistemaRepository.GetQueryable()
                 .Where(i => i.Id == concurso.IntegracaoConcurso!.IntegracaoSistemaId).DefaultIfEmpty()
               from integracaoTurno in _integracaoSistemaRepository.GetQueryable()
                 .Where(i => i.Id == turno.IntegracaoTurno!.IntegracaoSistemaId).DefaultIfEmpty()
               from integracaoCampus in _integracaoSistemaRepository.GetQueryable()
                 .Where(i => i.Id == campus.IntegracaoCampus!.IntegracaoSistemaId).DefaultIfEmpty()
               from integracaoCurso in _integracaoSistemaRepository.GetQueryable()
                 .Where(i => i.Id == curso.IntegracaoCurso!.IntegracaoSistemaId).DefaultIfEmpty()
               from integracaoOfertaConcurso in _integracaoSistemaRepository.GetQueryable()
                 .Where(i => i.Id == ofertaConcurso.IntegracaoOfertaConcurso!.IntegracaoSistemaId).DefaultIfEmpty()
               from integracaoNivel in _integracaoSistemaRepository.GetQueryable()
                 .Where(i => i.Id == nivel.IntegracaoNivelCurso!.IntegracaoSistemaId).DefaultIfEmpty()
               from integracaoModalidade in _integracaoSistemaRepository.GetQueryable()
                 .Where(i => i.Id == modalidade.IntegracaoModalidade!.IntegracaoSistemaId).DefaultIfEmpty()
               where inscricao.Id == inscricaoId
               select new InscricaoOfertaDto()
               {
                   Instituicao = new()
                   {
                       Nome = instituicao.Nome,
                       Key = instituicao.Key,
                       Integracoes = (from integ in instituicao.IntegracaoInstituicao.DefaultIfEmpty()
                                      join sistemaIntegracao in _integracaoSistemaRepository.GetQueryable()
                                      on integ.IntegracaoSistemaId equals sistemaIntegracao.Id into sistemaIntegracoes
                                      from sistema in sistemaIntegracoes.DefaultIfEmpty()
                                      select new SistemaIntegracaoDto
                                      {
                                          CodigoOrigem = integ.CodigoOrigem,
                                          NomeSistema = sistema != null ? sistema.Nome : string.Empty
                                      }).ToList() ?? new List<SistemaIntegracaoDto>()
                   },
                   Concurso = new()
                   {
                       Nome = concurso.Nome,
                       Key = concurso.Key,
                       Integracao = concurso.IntegracaoConcurso != null ? new SistemaIntegracaoDto()
                       {
                           CodigoOrigem = concurso.IntegracaoConcurso!.CodigoOrigem,
                           NomeSistema = integracaoConcurso.Nome,
                       } : null,
                       OpcaoAcesso = ofertaConcurso.OpcaoAcessos.Any() ? ofertaConcurso.OpcaoAcessos.Select(op => new OpcaoAcessoDto()
                       {
                           Key = op.Key,
                           Nome = op.TipoOpcaoAcesso.Description(),
                           Tipo = (int)op.TipoOpcaoAcesso,
                       }).ToList() : null,
                       IntegracaoFormaProva = (from concursoIntegracaoFormaProva in concurso.IntegracoesFormaProva.DefaultIfEmpty()
                                               join sistema in _integracaoSistemaRepository.GetQueryable()
                                                   on concursoIntegracaoFormaProva.IntegracaoSistemaId equals sistema.Id into sistemas
                                               from integracoes in sistemas.DefaultIfEmpty()
                                               select new SistemaIntegracaoDto()
                                               {
                                                   CodigoOrigem = concursoIntegracaoFormaProva.CodigoOrigem,
                                                   NomeSistema = integracoes.Nome,
                                               }).ToList(),
                       Prova = new InscricaoConcursoDataProvaDto()
                       {
                           DataInicioProva = concurso.InicioProva,
                           HoraInicioProva = concurso.InicioProva.HasValue ? concurso.InicioProva!.Value.ToString("HH:mm") : null,
                           DataTerminoProva = concurso.TerminoProva,
                           HoraTerminoProva = concurso.TerminoProva.HasValue ? concurso.TerminoProva!.Value.ToString("HH:mm") : null,
                           DivulgacaoResultado = concurso.DivulgacaoResultado,
                       },                       
                   },
                   Turno = new()
                   {
                       Nome = turno.Nome,
                       Key = turno.Key,
                       Integracao = turno.IntegracaoTurno != null ? new SistemaIntegracaoDto()
                       {
                           CodigoOrigem = turno.IntegracaoTurno!.CodigoOrigem,
                           NomeSistema = integracaoTurno.Nome,
                       } : null,
                   },
                   Campus = new()
                   {
                       Nome = campus.Nome,
                       Key = campus.Key,
                       Integracao = campus.IntegracaoCampus != null ? new SistemaIntegracaoDto()
                       {
                           CodigoOrigem = campus.IntegracaoCampus!.CodigoOrigem,
                           NomeSistema = integracaoCampus.Nome,
                       } : null,
                   },
                   Curso = new()
                   {
                       Nome = curso.Nome,
                       Key = curso.Key,
                       Integracoes = new List<SistemaIntegracaoDto>()
                       {
                           curso.IntegracaoCurso != null ? new SistemaIntegracaoDto()
                           {
                                CodigoOrigem = curso.IntegracaoCurso!.CodigoOrigem,
                                NomeSistema = integracaoCurso.Nome,
                           } : new SistemaIntegracaoDto(),
                           ofertaConcurso.IntegracaoOfertaConcurso != null ? new SistemaIntegracaoDto()
                           {
                                CodigoOrigem = ofertaConcurso.IntegracaoOfertaConcurso!.CodigoOrigem,
                                NomeSistema = integracaoOfertaConcurso.Nome,
                           } : new SistemaIntegracaoDto(),
                       },
                       Nivel = new()
                       {
                           Key = nivel.Key,
                           Nome = nivel.Nome,
                           Integracao = nivel.IntegracaoNivelCurso != null ? new SistemaIntegracaoDto()
                           {
                               CodigoOrigem = nivel.IntegracaoNivelCurso!.CodigoOrigem,
                               NomeSistema = integracaoNivel.Nome,
                           } : null,
                       },
                       Modalidade = new()
                       {
                           Key = modalidade.Key,
                           Nome = modalidade.Nome,
                           Descricao = modalidade.Descricao,
                           Integracao = modalidade.IntegracaoModalidade != null ? new SistemaIntegracaoDto()
                           {
                               CodigoOrigem = modalidade.IntegracaoModalidade!.CodigoOrigem,
                               NomeSistema = integracaoModalidade.Nome,
                           } : null,
                       }
                   },
                   PeriodoLetivo = concurso.PeriodoLetivo,
                   FormasEntrada = (from inscricaoFormaEntrada in inscricao.FormasEntrada
                                    join formaEntrada in _formaEntradaRepository.GetQueryable()
                                       on inscricaoFormaEntrada.FormaEntradaId equals formaEntrada.Id
                                    where inscricaoFormaEntrada.Atual
                                    select new InscricaoFormaEntradaDto()
                                    {
                                        FormaEntradaKey = formaEntrada.Key,
                                        FormaEntradaNome = formaEntrada.Nome,
                                        TipoSelecao = inscricaoFormaEntrada.CodigoTipoSelecao,
                                        CodigoTipoSelecao = inscricaoFormaEntrada.CodigoTipoSelecao.ToString(),
                                        Integracoes = (from integracao in formaEntrada.IntegracoesFormaEntrada.DefaultIfEmpty()
                                                       join sistema in _integracaoSistemaRepository.GetQueryable().DefaultIfEmpty()
                                                           on integracao!.IntegracaoSistemaId equals sistema.Id into integracaoJoin
                                                       from integracaoSistema in integracaoJoin.DefaultIfEmpty()
                                                       select new SistemaIntegracaoDto()
                                                       {
                                                           CodigoOrigem = integracao!.CodigoOrigem,
                                                           NomeSistema = integracaoSistema!.Nome
                                                       }).ToList()
                                    }).ToList(),
               };
    }

    private Task<InscricaoFichaDto?> ObterFichaAsync(FichaId fichaId)
    {
        var query = from ficha in _fichaRepository.GetQueryable()
                    where ficha.Id == fichaId
                    select new InscricaoFichaDto()
                    {
                        Nome = ficha.Nome,
                        Key = ficha.Key,
                    };

        return query.FirstOrDefaultAsync();
    }

    private async Task<IEnumerable<InscricaoOpcaoAcessoDto>> ObterOpcaoAcessoInscricao(InscricaoCandidatoConcluidaEvent notification)
    {
        var opcoesInscricao = notification.InscricaoCandidato.OpcoesAcesso.ToList();

        var opcoesAcessoOferta = from ofertaConcursoOpcaoAcesso in _ofertaConcursoOpcaoAcessoRepository.GetQueryable()
                                 where opcoesInscricao.Select(x => x.OfertaConcursoOpcaoAcessoId).Contains(ofertaConcursoOpcaoAcesso.Id)
                                 select ofertaConcursoOpcaoAcesso;

        var resultList = await opcoesAcessoOferta.ToListAsync();

        return resultList
            .Select(opcaoAcesso => new InscricaoOpcaoAcessoDto()
            {
                Key = opcoesInscricao.First(op => op.OfertaConcursoOpcaoAcessoId == opcaoAcesso.Id).Key,
                Nome = opcaoAcesso.TipoOpcaoAcesso.Description(),
                Tipo = (int)opcaoAcesso.TipoOpcaoAcesso,
                Percentual = opcoesInscricao.First(op => op.OfertaConcursoOpcaoAcessoId == opcaoAcesso.Id).Percentual,
            }).ToList();
    }

    private async Task<InscricaoMarcaDto?> ObterMarcaAsync(MarcaId marcaId)
    {
        var query = from marca in _marcaRepository.GetQueryable()
                    where marca.Id == marcaId
                    select new InscricaoMarcaDto()
                    {
                        Nome = marca.Nome,
                        Key = marca.Key,
                        Sigla = marca.Sigla,
                        Integracoes = (from integracao in marca.IntegracoesMarcas.DefaultIfEmpty()
                                             join sistema in _integracaoSistemaRepository.GetQueryable()
                                                 on integracao.IntegracaoSistemaId equals sistema.Id
                                             select new SistemaIntegracaoDto()
                                             {
                                                 CodigoOrigem = integracao.CodigoOrigem,
                                                 NomeSistema = sistema.Nome,
                                             }).ToList(),
                    };

        return await query.SingleOrDefaultAsync();
    }

    private async Task<List<InscricaoCupomDto>?> ObterCupomAsync(List<CupomId> cupons)
    {
        var query = from cupom in _cupomRepository.GetQueryable()
                    where cupons.Contains(cupom.Id)
                    select new InscricaoCupomDto()
                    {
                        Codigo = cupom.Codigo,
                        Key = cupom.Key,
                    };
                    
        return await query.ToListAsync();
    }

    private IQueryable<InscricaoMatriculaDto> ObterMatriculasInscricao(InscricaoCandidatoConcluidaEvent notification)
    {
        var matriculasInscricao = notification.InscricaoCandidato.Matriculas.Select(a => a.MatriculaId).ToList();

        return from matricula in _matriculaRepository.GetQueryable()
               where matriculasInscricao.Contains(matricula.Id)
               select new InscricaoMatriculaDto()
               {
                   CodigoAluno = matricula.CodigoAluno,
                   Ra = matricula.Ra,
                   Key = matricula.Key,
                   StatusMatricula = matricula.StatusMatricula,
               };
    }

    private IQueryable<CursoExternoDto> ObterCursoExternoInscricao(CursoExternoId cursoExternoId)
    {
        return from curso in _cursoExternoRepository.GetQueryable().AsNoTracking()
               where curso.Id == cursoExternoId
               select new CursoExternoDto()
               {
                   Nome = curso.Nome,
                   Key = curso.Key,
                   Integracoes = (from integracao in curso.IntegracoesCursoExterno.DefaultIfEmpty()
                                  join sistema in _integracaoSistemaRepository.GetQueryable().AsNoTracking()
                                      on integracao.IntegracaoSistemaId equals sistema.Id
                                  select new SistemaIntegracaoDto()
                                  {
                                      CodigoOrigem = integracao.CodigoOrigem,
                                      NomeSistema = sistema.Nome,
                                  }).ToList(),
               };
    }
}