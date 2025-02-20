using Anima.Inscricao.Application._Shared.Commands;
using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Campi;

namespace Anima.Inscricao.Application.UseCases.Campi.RemoverCampus;

public class RemoverCampusCommandHandler : ICommandHandler<RemoverCampusCommand>
{
    public readonly INotificationContext _notificationContext;
    public readonly ICampusRepository _campusRepository;
    public readonly IUnitOfWork _unitOfWork;

    public RemoverCampusCommandHandler(
        INotificationContext notificationContext,
        ICampusRepository campusRepository,
        IUnitOfWork unitOfWork)
    {
        _notificationContext = notificationContext;
        _campusRepository = campusRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task Handle(RemoverCampusCommand request, CancellationToken cancellationToken)
    {
        var campus = await _campusRepository.GetAsync(request.Key);

        var campusRemovido = campus.Remover()
            .NotificarFalhas(_notificationContext)
            .IsSuccess;

        if (campusRemovido)
        {
            _campusRepository.Delete(campus);
            await _unitOfWork.CommitAsync(cancellationToken);
        }
    }
}
