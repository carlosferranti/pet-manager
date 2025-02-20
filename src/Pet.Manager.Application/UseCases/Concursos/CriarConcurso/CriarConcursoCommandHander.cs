using Anima.Inscricao.Application._Shared.Commands;
using Anima.Inscricao.Application._Shared.DTOs;
using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain._Shared.ValueObjects;
using Anima.Inscricao.Domain.Concursos;
using Anima.Inscricao.Domain.Concursos.Entities;
using Anima.Inscricao.Domain.FormasEntrada;
using Anima.Inscricao.Domain.IntegracaoSistemas;
using Anima.Inscricao.Domain.Modalidades;
using Anima.Inscricao.Domain.ModalidadesAvaliacao.Entities;
using Anima.Inscricao.Domain.ModalidadesAvaliacao;
using Anima.Inscricao.Domain.TiposFormacao;

namespace Anima.Inscricao.Application.UseCases.Concursos.CriarConcurso;

public class CriarConcursoCommandHander : ICommandHandler<CriarConcursoCommand, EntityKeyDto?>
{
    private readonly INotificationContext _notificationContext;
    private readonly IConcursoRepository _concursoRepository;
    private readonly IFormaEntradaRepository _formaEntradaRepository;
    private readonly ITipoFormacaoRepository _tipoFormacaoRepository;
    private readonly IIntegracaoSistemaRepository _sistemasIntegracaoRepository;
    private readonly IModalidadeRepository _modalidadeRepository;
    private readonly IModalidadeAvaliacaoRepository _modalidadeAvaliacaoRepository;
    private readonly IUnitOfWork _unitOfWork;

    public CriarConcursoCommandHander(
        INotificationContext notificationContext,
        IConcursoRepository concursoRepository,
        IFormaEntradaRepository formaEntradaRepository,
        ITipoFormacaoRepository tipoFormacaoRepository,
        IModalidadeRepository modalidadeRepository,
        IIntegracaoSistemaRepository sistemasIntegracaoRepository,
        IModalidadeAvaliacaoRepository modalidadeAvaliacaoRepository,
        IUnitOfWork unitOfWork)
    {
        _notificationContext = notificationContext;
        _concursoRepository = concursoRepository;
        _formaEntradaRepository = formaEntradaRepository;
        _tipoFormacaoRepository = tipoFormacaoRepository;
        _sistemasIntegracaoRepository = sistemasIntegracaoRepository;
        _modalidadeRepository = modalidadeRepository;
        _modalidadeAvaliacaoRepository = modalidadeAvaliacaoRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task<EntityKeyDto?> Handle(CriarConcursoCommand request, CancellationToken cancellationToken)
    {
        var tipoFormacao = await _tipoFormacaoRepository.GetAsync(request.TipoFormacaoKey);
        var modalidade = await _modalidadeRepository.GetAsync(request.ModalidadeKey);
        ModalidadeAvaliacao? modalidadeAvaliacao = null;

        if (request.ModalidadeAvaliacaoKey.HasValue)
        {
            modalidadeAvaliacao = await _modalidadeAvaliacaoRepository.GetAsync(request.ModalidadeAvaliacaoKey.Value);
        }

        var concurso = Concurso
            .Criar(request.Nome,
                request.PeriodoLetivo, 
                new Vigencia(request.InicioInscricao, request.TerminoInscricao),
                request.InicioProva, 
                request.TerminoProva,
                request.DivulgacaoResultado,
                modalidadeAvaliacao?.Id)
            .NotificarFalhas(_notificationContext)
            .ObterRetorno();

        if (concurso == null)
        {
            return null;
        }

        if (request.Integracao != null)
        {
            var sistema = await _sistemasIntegracaoRepository.GetAsync(s => s.Nome.ToUpper() == request.Integracao.NomeSistema.ToUpper());
            concurso.AdicionarIntegracao(sistema.Id, request.Integracao.CodigoOrigem);
        }

        if (request.IntegracaoFormaProva != null)
        {
            foreach (var integracaoFormaProva in request.IntegracaoFormaProva)
            {
                var sistema = await _sistemasIntegracaoRepository.GetAsync(s => s.Nome.ToUpper() == integracaoFormaProva.NomeSistema.ToUpper());
                concurso.AdicionarIntegracaoFormaProva(sistema.Id, integracaoFormaProva.CodigoOrigem);
            }
        }

        if (request.Parametros != null)
        {
            concurso.AtualizarParametros(new ConcursoParametros(
                request.Parametros.SolicitaAnoInscricaoEnem,
                request.Parametros.ExigeAceiteDeferimento,
                request.Parametros.RecebeDocumentoConclusaoEnsinoSuperior));
        }

        foreach (var formaEntradaRequest in request.FormasEntrada)
        {
            var formaEntrada = await _formaEntradaRepository.GetAsync(formaEntradaRequest.Key);
            concurso.AdicionarFormaEntrada(formaEntrada.Id);
        }

        concurso.AdicionarTipoFormacao(tipoFormacao.Id);

        concurso.AdicionarModalidade(modalidade.Id);

        await _concursoRepository.InsertAsync(concurso);

        await _unitOfWork.CommitAsync(cancellationToken);

        return new EntityKeyDto(concurso.Key);
    }
}