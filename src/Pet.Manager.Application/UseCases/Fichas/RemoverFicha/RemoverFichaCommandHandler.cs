using Anima.Inscricao.Application._Shared.Commands;
using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Fichas;

namespace Anima.Inscricao.Application.UseCases.Fichas.RemoverFicha;

public class RemoverFichaCommandHandler : ICommandHandler<RemoverFichaCommand>
{
    public readonly INotificationContext _notificationContext;
    public readonly IFichaRepository _fichaRepository;
    public readonly IUnitOfWork _unitOfWork;

    public RemoverFichaCommandHandler(
        INotificationContext notificationContext,
        IFichaRepository fichaRepository,
        IUnitOfWork unitOfWork)
    {
        _notificationContext = notificationContext;
        _fichaRepository = fichaRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task Handle(RemoverFichaCommand request, CancellationToken cancellationToken)
    {
        var ficha = await _fichaRepository.GetAsync(request.Key);

        var fichaRemovida = ficha.Remover()
            .NotificarFalhas(_notificationContext)
            .IsSuccess;

        if (fichaRemovida)
        {
            _fichaRepository.Delete(ficha);
            await _unitOfWork.CommitAsync(cancellationToken);
        }
    }
}
