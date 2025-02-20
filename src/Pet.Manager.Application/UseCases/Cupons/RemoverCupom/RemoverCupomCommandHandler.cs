using Anima.Inscricao.Application._Shared.Commands;
using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Cupons;

namespace Anima.Inscricao.Application.UseCases.Cupons.RemoverCupom;

public class RemoverCupomCommandHandler : ICommandHandler<RemoverCupomCommand>
{
    private readonly INotificationContext _notificationContext;
    private readonly ICupomRepository _cupomRepository;
    private readonly IUnitOfWork _unitOfWork;

    public RemoverCupomCommandHandler(
        INotificationContext notificationContext, 
        ICupomRepository cupomRepository, 
        IUnitOfWork unitOfWork)
    {
        _notificationContext = notificationContext;
        _cupomRepository = cupomRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task Handle(RemoverCupomCommand request, CancellationToken cancellationToken)
    {
        var cupom = await _cupomRepository.GetAsync(request.Key);

        var cupomRemovido = cupom.Remover()
            .NotificarFalhas(_notificationContext)
            .IsSuccess;

        if (cupomRemovido)
        {
            _cupomRepository.Delete(cupom);
            await _unitOfWork.CommitAsync(cancellationToken);
        }
    }
}
