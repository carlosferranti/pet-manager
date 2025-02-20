using Anima.Inscricao.Application._Shared.Commands;
using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain._Shared.ValueObjects;
using Anima.Inscricao.Domain.Concursos;
using Anima.Inscricao.Domain.Concursos.Entities;
using Anima.Inscricao.Domain.FormasEntrada;
using Anima.Inscricao.Domain.IntegracaoSistemas;
using Anima.Inscricao.Domain.Modalidades;
using Anima.Inscricao.Domain.ModalidadesAvaliacao;
using Anima.Inscricao.Domain.ModalidadesAvaliacao.Entities;
using Anima.Inscricao.Domain.TiposFormacao;

namespace Anima.Inscricao.Application.UseCases.Concursos.AtualizarConcurso;

public class AtualizarConcursoCommandHandler : ICommandHandler<AtualizarConcursoCommand>
{
    private readonly INotificationContext _notificationContext;
    private readonly IConcursoRepository _concursoRepository;
    private readonly IFormaEntradaRepository _formaEntradaRepository;
    private readonly ITipoFormacaoRepository _tipoFormacaoRepository;
    private readonly IModalidadeRepository _modalidadeRepository;
    private readonly IIntegracaoSistemaRepository _sistemasIntegracaoRepository;
    private readonly IModalidadeAvaliacaoRepository _modalidadeAvaliacaoRepository;
    private readonly IUnitOfWork _unitOfWork;

    public AtualizarConcursoCommandHandler(
        INotificationContext notificationContext,
        IConcursoRepository concursoRepository,
        IFormaEntradaRepository formaEntradaRepository,
        ITipoFormacaoRepository tipoFormacaoRepository,
        IModalidadeRepository modalidadeRepository,
        IIntegracaoSistemaRepository integracaoSistemaRepository,
        IModalidadeAvaliacaoRepository modalidadeAvaliacaoRepository,
        IUnitOfWork unitOfWork)
    {
        _notificationContext = notificationContext;
        _concursoRepository = concursoRepository;
        _formaEntradaRepository = formaEntradaRepository;
        _tipoFormacaoRepository = tipoFormacaoRepository;
        _modalidadeRepository = modalidadeRepository;
        _sistemasIntegracaoRepository = integracaoSistemaRepository;
        _modalidadeAvaliacaoRepository = modalidadeAvaliacaoRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task Handle(AtualizarConcursoCommand request, CancellationToken cancellationToken)
    {
        var tipoFormacao = await _tipoFormacaoRepository.GetAsync(request.TipoFormacaoKey);
        var modalidade = await _modalidadeRepository.GetAsync(request.ModalidadeKey);
        var concurso = await _concursoRepository.GetAsync(request.Key);
        ModalidadeAvaliacao? modalidadeAvaliacao = null;

        if(request.ModalidadeAvaliacaoKey.HasValue)
        {
            modalidadeAvaliacao = await _modalidadeAvaliacaoRepository.GetAsync(request.ModalidadeAvaliacaoKey.Value);
        }

        var concursoAtualizado = concurso.AtualizarInfos(
            request.Nome,
            request.PeriodoLetivo,
            new Vigencia(request.InicioInscricao, request.TerminoInscricao),
            request.InicioProva, 
            request.TerminoProva,
            request.DivulgacaoResultado,
            modalidadeAvaliacao?.Id)
           .NotificarFalhas(_notificationContext)
           .IsSuccess;

        if (!concursoAtualizado)
        {
            return;
        }

        if (request.Parametros != null)
        {
            concurso.AtualizarParametros(new ConcursoParametros(
                request.Parametros.SolicitaAnoInscricaoEnem,
                request.Parametros.ExigeAceiteDeferimento,
                request.Parametros.RecebeDocumentoConclusaoEnsinoSuperior));
        }

        var formasEntradaConcursoPersistido = concurso.FormasEntrada.Select(f => f.FormaEntradaId).ToList();
        foreach (var formaEntradaId in formasEntradaConcursoPersistido)
        {
            var formaEntrada = await _formaEntradaRepository.GetAsync(formaEntradaId);
            if(!request.FormasEntrada.Exists(x => x.Key == formaEntrada.Key))
            {
                concurso.RemoverFormaEntrada(formaEntradaId);
            }
        }

        foreach (var formaEntradaRequest in request.FormasEntrada)
        {
            var formaEntrada = await _formaEntradaRepository.GetAsync(formaEntradaRequest.Key);
            if (!concurso.FormasEntrada.Any(x => x.FormaEntradaId == formaEntrada.Id))
            {
                concurso.AdicionarFormaEntrada(formaEntrada.Id);
            }
        }

        if (!concurso.TiposFormacao.Any(x => x.TipoFormacaoId == tipoFormacao.Id))
        {
            concurso.RemoverTipoFormacao(concurso.TiposFormacao[0].TipoFormacaoId);
            concurso.AdicionarTipoFormacao(tipoFormacao.Id);
        }

        if (!concurso.Modalidades.Any(x => x.ModalidadeId == modalidade.Id))
        {
            concurso.RemoverModalidade(concurso.Modalidades[0].ModalidadeId);
            concurso.AdicionarModalidade(modalidade.Id);
        }

        if (request.IntegracaoFormaProva != null)
        {
            var integracoesFormaProvaPersistido = concurso.IntegracoesFormaProva.ToList();
            foreach (var integracaoFormaProva in integracoesFormaProvaPersistido)
            {
                var sistema = await _sistemasIntegracaoRepository.GetAsync(s => s.Id == integracaoFormaProva.IntegracaoSistemaId);
                if (!request.IntegracaoFormaProva.Exists(x => x.NomeSistema == sistema.Nome && x.CodigoOrigem == integracaoFormaProva.CodigoOrigem))
                {
                    concurso.RemoverIntegracaoFormaProva(integracaoFormaProva.Id);
                }
            }

            foreach (var integracaoFormaProva in request.IntegracaoFormaProva)
            {
                var sistema = await _sistemasIntegracaoRepository.GetAsync(s => s.Nome.ToUpper() == integracaoFormaProva.NomeSistema.ToUpper());
                
                if(!concurso.IntegracoesFormaProva.Any(x => x.IntegracaoSistemaId == sistema.Id && 
                x.CodigoOrigem == integracaoFormaProva.CodigoOrigem))
                {
                    concurso.AdicionarIntegracaoFormaProva(sistema.Id, integracaoFormaProva.CodigoOrigem);
                }
            }
        }

        _concursoRepository.Update(concurso);

        await _unitOfWork.CommitAsync(cancellationToken);
    }
}