using Anima.Inscricao.Application._Shared.Commands;
using Anima.Inscricao.Application._Shared.DTOs;
using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Concursos;
using Anima.Inscricao.Domain.IntegracaoSistemas;
using Anima.Inscricao.Domain.OfertaConcursos;
using Anima.Inscricao.Domain.OfertaConcursos.Entities;
using Anima.Inscricao.Domain.Ofertas;

namespace Anima.Inscricao.Application.UseCases.OfertaConcursos.CriarOfertaConcurso;

public class CriarOfertaConcursoCommandHandler : ICommandHandler<CriarOfertaConcursoCommand, EntityKeyDto?>
{
    private readonly INotificationContext _notificationContext;
    private readonly IOfertaConcursoRepository _ofertaConcursoRepository;
    private readonly IOfertaRepository _ofertaRepository;
    private readonly IConcursoRepository _concursoRepository;
    private readonly IIntegracaoSistemaRepository _integracaoSistemasRepository;
    private readonly IUnitOfWork _unitOfWork;

    public CriarOfertaConcursoCommandHandler(
        INotificationContext notificationContext, 
        IOfertaConcursoRepository ofertaConcursoRepository, 
        IOfertaRepository ofertaRepository, 
        IConcursoRepository concursoRepository, 
        IIntegracaoSistemaRepository integracaoSistemasRepository, 
        IUnitOfWork unitOfWork)
    {
        _notificationContext = notificationContext;
        _ofertaConcursoRepository = ofertaConcursoRepository;
        _ofertaRepository = ofertaRepository;
        _concursoRepository = concursoRepository;
        _integracaoSistemasRepository = integracaoSistemasRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task<EntityKeyDto?> Handle(CriarOfertaConcursoCommand request, CancellationToken cancellationToken)
    {
        var concurso = await _concursoRepository.GetAsync(request.ConcursoKey);

        var oferta = await _ofertaRepository.GetAsync(request.OfertaKey);

        var ofertaConcursoCriada = OfertaConcurso.Criar(concurso.Id, oferta.Id)
            .NotificarFalhas(_notificationContext)
            .ObterRetorno();

        if (ofertaConcursoCriada == null)
        {
            return null;
        }

        if(request.Integracao != null)
        {
            var sistema = await _integracaoSistemasRepository.GetAsync(s => s.Nome.ToUpper() == request.Integracao.NomeSistema.ToUpper());
            ofertaConcursoCriada.AdicionarIntegracao(sistema.Id, request.Integracao.CodigoOrigem);
        }

        if(request.OpcaoAcesso != null && request.OpcaoAcesso.Any())
        {
            foreach (var opcaoAcesso in request.OpcaoAcesso)
            {
                ofertaConcursoCriada.AdicionarOpcaoAcesso(opcaoAcesso);
            }
        }

        await _ofertaConcursoRepository.InsertAsync(ofertaConcursoCriada);

        await _unitOfWork.CommitAsync(cancellationToken);

        return new EntityKeyDto(ofertaConcursoCriada.Key);
    }
}
