using Anima.Inscricao.Application._Shared.Commands;
using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Ofertas;

namespace Anima.Inscricao.Application.UseCases.Ofertas.RemoverOferta;

public class RemoverOfertaCommandHandler : ICommandHandler<RemoverOfertaCommand>
{
    public readonly INotificationContext _notificationContext;
    public readonly IOfertaRepository _ofertaRepository;
    public readonly IUnitOfWork _unitOfWork;

    public RemoverOfertaCommandHandler(
        INotificationContext notificationContext, 
        IOfertaRepository ofertaRepository, 
        IUnitOfWork unitOfWork)
    {
        _notificationContext = notificationContext;
        _ofertaRepository = ofertaRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task Handle(RemoverOfertaCommand request, CancellationToken cancellationToken)
    {
        var oferta = await _ofertaRepository.GetAsync(request.Key);

        var ofertaRemovida = oferta.Remover()
            .NotificarFalhas(_notificationContext)
            .IsSuccess;
        if(ofertaRemovida)
        {
            _ofertaRepository.Delete(oferta);
            await _unitOfWork.CommitAsync(cancellationToken);
        }
    }
}
