using System;

using Anima.Inscricao.Application.Config;
using Anima.Inscricao.Application.DTOs.Escola;
using Anima.Inscricao.Application.DTOs.Fichas;
using Anima.Inscricao.Application.DTOs.Inscricoes;
using Anima.Inscricao.Application.DTOs.Marcas;
using Anima.Inscricao.Application.DTOs.SistemasIntegracao;
using Anima.Inscricao.Domain.Escolas;
using Anima.Inscricao.Domain.Escolas.Entities;
using Anima.Inscricao.Domain.Etapas;
using Anima.Inscricao.Domain.Fichas;
using Anima.Inscricao.Domain.Fichas.Entities;
using Anima.Inscricao.Domain.Inscricoes.Events;
using Anima.Inscricao.Domain.IntegracaoSistemas;
using Anima.Inscricao.Domain.Marcas;
using Anima.Inscricao.Domain.Marcas.Entities;
using Anima.Inscricao.Infra.Messaging._Shared.Kafka;
using Anima.Inscricao.Infra.Messaging.Publishes.Shared;

using MediatR;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace Anima.Inscricao.Infra.Messaging.Publishes.Kafka.Inscricoes;

public class InscricaoCandidatoCriadoEventHandler : BaseKafkaEventHandler, INotificationHandler<InscricaoCandidatoCriadoEvent>
{
    private readonly string _topicCriacaoInscricao = null!;

    private readonly ILogger<InscricaoCandidatoCriadoEventHandler> _logger;
    private readonly IMarcaRepository _marcaRepository;
    private readonly IIntegracaoSistemaRepository _integracaoSistemaRepository;
    private readonly IFichaRepository _fichaRepository;
    private readonly IEtapaTemplateRepository _etapaTemplateRepository;
    private readonly IEscolaRepository _escolaRepository;

    public InscricaoCandidatoCriadoEventHandler(
        IMarcaRepository marcaRepository,
        IIntegracaoSistemaRepository integracaoSistemaRepository,
        IFichaRepository fichaRepository,
        IEtapaTemplateRepository etapaTemplateRepository,
        IEscolaRepository escolaRepository,
        ILogger<InscricaoCandidatoCriadoEventHandler> logger,
        IOptions<KafkaConfig> kafkaConfig,
        IKafkaFactory kafkaFactory) 
        : base(logger, kafkaFactory)
    {
        _logger = logger;
        _marcaRepository = marcaRepository;
        _integracaoSistemaRepository = integracaoSistemaRepository;
        _fichaRepository = fichaRepository;
        _etapaTemplateRepository = etapaTemplateRepository;
        _escolaRepository = escolaRepository;
        _topicCriacaoInscricao = kafkaConfig.Value?.Topics?.CriacaoInscricao ?? throw new ArgumentNullException(_topicCriacaoInscricao);
    }

    public async Task Handle(InscricaoCandidatoCriadoEvent notification, CancellationToken cancellationToken)
    {
        try
        {
            var eventoNotification = new InscricaoCandidatoCriadaEventDto();

            eventoNotification.InscricaoKey = notification.InscricaoCandidato.Key;

            eventoNotification.InscricaoFicha = await ObterFichaAsync(notification.InscricaoCandidato.FichaId);

            foreach (var documento in notification.InscricaoCandidato.Documentos)
            {
                eventoNotification.InfosDocumento.Add(new InscricaoDocumentoDto()
                {
                    Tipo = documento.Tipo.ToString(),
                    Valor = documento.Valor,
                });
            }

            // informações contato
            foreach (var contato in notification.InscricaoCandidato.Contatos)
            {
                eventoNotification.InscricaoContatos.Add(new InscricaoContatoDto()
                {
                    Tipo = contato.Tipo.ToString(),
                    Valor = contato.Valor
                });
            }

            // informações pessoais
            var infosPessoais = new InscricaoCandidatoDto()
            {
                Nome = notification.InscricaoCandidato.Candidato.Nome,
                NomeSocial = notification.InscricaoCandidato.Candidato.NomeSocial,
                DataNascimento = notification.InscricaoCandidato.Candidato.DataNascimento != null ? DateOnly.FromDateTime(notification.InscricaoCandidato.Candidato.DataNascimento.Value) : null,
                Sexo = notification.InscricaoCandidato.Candidato.Sexo,
                NecessidadeEspecial = notification.InscricaoCandidato.Candidato.NecessidadeEspecial
            };

            eventoNotification.InscricaoCandidato = infosPessoais;

            // informações Marca
            eventoNotification.InscricaoMarca = await RecuperarMarcaComIntegracaoAsync(notification.InscricaoCandidato.MarcaId);

            // informações Origem
            var infoOrigem = new InscricaoOrigemDto()
            {
                Tipo = notification.InscricaoCandidato.Origem.Tipo,
                Url = notification.InscricaoCandidato.Origem.Url,
            };
            eventoNotification.InscricaoOrigem = infoOrigem;

            // informações etapa
            if(notification.InscricaoCandidato.Etapas.Any(x => x.Atual))
            {
                eventoNotification.InscricaoEtapa = await RecuperarEtapaAsync(notification);
            }

            List<InscricaoEscolaridadeDto> escolaridades = new();

            foreach (var escolaridade in notification.InscricaoCandidato.Escolaridades)
            {
                if (escolaridade.EscolaId != null)
                {
                    var escola = await ObterEscolaInscricao(escolaridade.EscolaId).FirstAsync(cancellationToken);
                    escolaridades.Add(new InscricaoEscolaridadeDto()
                    {
                        AnoConclusao = escolaridade.AnoConclusao,
                        Escola = new()
                        {
                            Integracao = escola.Integracao,
                            Key = escola.Key,
                            Nome = escola.Nome,
                        },
                        Nivel = escolaridade.Nivel
                    });
                }
                else
                {
                    escolaridades.Add(new InscricaoEscolaridadeDto()
                    {
                        AnoConclusao = escolaridade.AnoConclusao,
                        Escola = new()
                        {
                            Integracao = null,
                            Key = null,
                            Nome = escolaridade.OutraEscola,
                        },
                        Nivel = escolaridade.Nivel
                    });
                }
            }

            eventoNotification.Escolaridades = escolaridades;

            await PublishEvent(_topicCriacaoInscricao, eventoNotification, cancellationToken);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Erro ao publicar evento de criação de inscrição");
        }
    }

    private async Task<EtapaFichaDto> RecuperarEtapaAsync(InscricaoCandidatoCriadoEvent notification)
    {
        var etapaAtual = notification.InscricaoCandidato.Etapas.First(x => x.Atual);

        var query = from ficha in _fichaRepository.GetQueryable()
                    join etapa in _etapaTemplateRepository.GetQueryable()
                        on ficha.Etapas.FirstOrDefault(x => x.Id == etapaAtual.EtapaFichaId)!.EtapaTemplateId equals etapa.Id
                    select new EtapaFichaDto()
                    {
                        Key = etapa.Key,
                        Nome = etapa.Nome,
                        Sequencia = ficha.Etapas.FirstOrDefault(x => x.Id == etapaAtual.EtapaFichaId)!.Sequencia
                    };

        return await query.SingleAsync();
    }

    private async Task<MarcaDto> RecuperarMarcaComIntegracaoAsync(MarcaId marcaId)
    {
        var query = from marca in _marcaRepository.GetQueryable()
                    where marca.Id == marcaId
                    select new MarcaDto()
                    {
                        Key = marca.Key,
                        Nome = marca.Nome,
                        Sigla = marca.Sigla,
                        IntegracaoSistema = (from integracaoMarca in marca.IntegracoesMarcas.DefaultIfEmpty()
                                             join sistemaIntegracao in _integracaoSistemaRepository.GetQueryable()
                                             on integracaoMarca.IntegracaoSistemaId equals sistemaIntegracao.Id into sistemaIntegracaoGroup
                                             from sistemaIntegracao in sistemaIntegracaoGroup.DefaultIfEmpty()
                                             select new SistemaIntegracaoDto
                                             {
                                                 NomeSistema = sistemaIntegracao.Nome,
                                                 CodigoOrigem = integracaoMarca.CodigoOrigem
                                             }).ToList()
                    };

        return await query.SingleAsync();
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

    private IQueryable<EscolaDto> ObterEscolaInscricao(EscolaId? escolaId)
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
}
