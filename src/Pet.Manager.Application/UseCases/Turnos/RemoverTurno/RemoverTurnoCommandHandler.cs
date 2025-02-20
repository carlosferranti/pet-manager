using Anima.Inscricao.Application._Shared.Commands;
using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Turnos;

namespace Anima.Inscricao.Application.UseCases.Turnos.RemoverTurno;

public class RemoverTurnoCommandHandler : ICommandHandler<RemoverTurnoCommand>
{
    public readonly INotificationContext _notificationContext;
    public readonly ITurnoRepository _turnoRepository;
    public readonly IUnitOfWork _unitOfWork;

    public RemoverTurnoCommandHandler(
        INotificationContext notificationContext, 
        ITurnoRepository turnoRepository, 
        IUnitOfWork unitOfWork)
    {
        _notificationContext = notificationContext;
        _turnoRepository = turnoRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task Handle(RemoverTurnoCommand request, CancellationToken cancellationToken)
    {
        var turno = await _turnoRepository.GetAsync(request.Key);

        var turnoRemovido = turno.Remover()
            .NotificarFalhas(_notificationContext)
            .IsSuccess;

        if (turnoRemovido)
        {
            _turnoRepository.Delete(turno);
            await _unitOfWork.CommitAsync(cancellationToken);
        }
    }
}
