using Anima.Inscricao.Application.Config;
using Anima.Inscricao.Application.DTOs.Concursos;
using Anima.Inscricao.Application.DTOs.Cursos;
using Anima.Inscricao.Application.DTOs.Inscricoes;
using Anima.Inscricao.Application.DTOs.Marcas;
using Anima.Inscricao.Application.DTOs.SistemasIntegracao;
using Anima.Inscricao.Application.DTOs.Turnos;
using Anima.Inscricao.Domain._Shared.Enums;
using Anima.Inscricao.Domain.FormasEntrada;
using Anima.Inscricao.Domain.Inscricoes.Entities;
using Anima.Inscricao.Domain.Inscricoes.Enums;
using Anima.Inscricao.Domain.Inscricoes.Events;
using Anima.Inscricao.Infra.Messaging._Shared.Kafka;
using Anima.Inscricao.Infra.Messaging.Publishes.Shared;
using Anima.Inscricoes.Domain.Inscricoes;

using MediatR;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

using static Anima.Inscricao.Application.DTOs.Inscricoes.InscricaoCandidatoDocumentacaoAtualizacaoEventoDto;
using static Anima.Inscricao.Application.DTOs.Inscricoes.InscricaoCandidatoDocumentacaoAtualizacaoEventoDto.InscricaoCandidatoDocumentacaoInfosOfertaDto;

namespace Anima.Inscricao.Infra.Messaging.Publishes.Kafka.Inscricoes;

public class DocumentacaoInscricaoCriadaEventHandler : BaseKafkaEventHandler, INotificationHandler<DocumentacaoInscricaoCriadaEvent>
{
    private readonly IInscricaoRepository _inscricaoRepository;
    private readonly IFormaEntradaRepository _formaEntradaRepository;
    private readonly string _topicoAtualizacaoInscricao = null!;

    public DocumentacaoInscricaoCriadaEventHandler(
    ILogger<BaseKafkaEventHandler> logger,
    IKafkaFactory kafkaFactory,
    IOptions<KafkaConfig> kafkaConfig,
    IInscricaoRepository inscricaoRepository,
    IFormaEntradaRepository formaEntradaRepository)
    : base(logger, kafkaFactory)
    {
        _inscricaoRepository = inscricaoRepository;
        _formaEntradaRepository = formaEntradaRepository;
        _topicoAtualizacaoInscricao = kafkaConfig.Value?.Topics?.AtualizacaoInscricao ?? throw new ArgumentNullException(_topicoAtualizacaoInscricao);
    }

    public async Task Handle(DocumentacaoInscricaoCriadaEvent notification, CancellationToken cancellationToken)
    {
        var mensagem = new InscricaoCandidatoDocumentacaoAtualizacaoEventoDto();

        mensagem.InscricaoKey = notification.InscricaoCandidatoKey;
        mensagem.NumeroInscricao = notification.InscricaoCandidatoId;

        mensagem.InfosDocumentacao = new List<InscricaoCandidatoDocumentacaoInfosDocumentacaoDto>()
        {
            new InscricaoCandidatoDocumentacaoInfosDocumentacaoDto()
            {
                Acao = TipoAcaoRegistro.Criar,
                ChaveArquivo = notification.ChaveArquivo,
                ExtensaoArquivo = notification.ExtensaoArquivo,
                Key = notification.Key,
                NomeArquivo = notification.NomeArquivo,
                Observacoes = notification.Observacoes,
                TamanhoArquivo = notification.TamanhoArquivo,
                Tipo = notification.Tipo.ToString(),
                TipoLocalArquivo = notification.TipoLocalArquivo
            }
        };

        var documentos = await _inscricaoRepository.ObterDocumentosCandidatoInscricaoAsync(notification.InscricaoCandidatoId, cancellationToken);
        mensagem.InfosDocumento = documentos?.Select(x => new InscricaoCandidatoDocumentacaoInfosDocumentoDto()
        {
            Tipo = x.Tipo,
            Valor = x.Valor
        }).ToList();

        var infoCandidato = await _inscricaoRepository.ObterInfoCandidatoInscricaoAsync(notification.InscricaoCandidatoId, cancellationToken);
        mensagem.InfosPessoais = new InscricaoCandidatoDocumentacaoInfosPessoaisDto()
        {
            DataNascimento = infoCandidato?.DataNascimento,
            Nome = infoCandidato?.Nome,
            NomeSocial = infoCandidato?.NomeSocial,
            NecessidadeEspecial = infoCandidato?.NecessidadeEspecial,
            Sexo = infoCandidato?.Sexo
        };

        var marca = await _inscricaoRepository.ObterMarcaInscricaoAsync(notification.InscricaoCandidatoId, cancellationToken);
        mensagem.InfoMarca = new MarcaDto()
        {
            Nome = marca.Nome,
            Sigla = marca.Sigla,
            Key = marca.Key,
        };

        var infoCurso = await _inscricaoRepository.ObterCursoInscricaoAsync(notification.InscricaoCandidatoId, cancellationToken);
        var infoTurno = await _inscricaoRepository.ObterTurnoInscricaoAsync(notification.InscricaoCandidatoId, cancellationToken);
        var infoConcurso = await _inscricaoRepository.ObterConcursoInscricaoAsync(notification.InscricaoCandidatoId, cancellationToken);
        var infosFormaEntrada = await ObterFormaEntradaInscricaoAsync(notification.InscricaoCandidatoId);

        mensagem.InfosOferta = new InscricaoCandidatoDocumentacaoInfosOfertaDto()
        {
            Curso = infoCurso != null ? new CursoDto()
            {
                Nome = infoCurso.Nome,
                Key = infoCurso.Key,
            } : null,
            Turno = infoTurno != null ? new TurnoDto()
            {
                Nome = infoTurno.Nome,
                Key = infoTurno.Key,
            } : null,
            Concurso = infoConcurso != null ? new ConcursoEventoDto()
            {
                Nome = infoConcurso.Nome,
                Key = infoConcurso.Key,
                Integracao = new SistemaIntegracaoDto()
                {
                    CodigoOrigem = infoConcurso.IntegracaoConcurso?.CodigoOrigem ?? string.Empty,
                },
            } : null,
            FormasEntrada = infosFormaEntrada,
        };

        await PublishEvent(_topicoAtualizacaoInscricao, mensagem, cancellationToken);
    }

    private async Task<IEnumerable<InscricaoFormaEntradaDto>> ObterFormaEntradaInscricaoAsync(InscricaoCandidatoId inscricaoCandidatoId)
    {
        var query = from inscricao in _inscricaoRepository.GetQueryable().AsNoTracking()
                    from formaEntradaInscricao in inscricao.FormasEntrada
                    join formaEntrada in _formaEntradaRepository.GetQueryable().AsNoTracking()
                    on formaEntradaInscricao.FormaEntradaId equals formaEntrada.Id
                    where inscricao.Id == inscricaoCandidatoId
                    select new InscricaoFormaEntradaDto()
                    {
                        CodigoTipoSelecao = formaEntradaInscricao.CodigoTipoSelecao.ToString(),
                        FormaEntradaKey = formaEntrada.Key,
                        FormaEntradaNome = formaEntrada.Nome,
                        TipoSelecao = formaEntradaInscricao.CodigoTipoSelecao,
                    };

        return await query.ToListAsync();
    }
}