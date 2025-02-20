using Anima.Inscricao.Application._Shared.Commands;
using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Turnos;

namespace Anima.Inscricao.Application.UseCases.Turnos.AtualizarTurno;

public class AtualizarTurnoCommandHandler : ICommandHandler<AtualizarTurnoCommand>
{
    private readonly INotificationContext _notificationContext;
    private readonly ITurnoRepository _turnoRepository;
    private readonly IUnitOfWork _unitOfWork;

    public AtualizarTurnoCommandHandler(
        INotificationContext notificationContext, 
        ITurnoRepository turnoRepository, 
        IUnitOfWork unitOfWork)
    {
        _notificationContext = notificationContext;
        _turnoRepository = turnoRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task Handle(AtualizarTurnoCommand request, CancellationToken cancellationToken)
    {
        var turno = await _turnoRepository.GetAsync(request.Key);

        var turnoAtualizado = turno.AtualizarInformacoes(request.Nome)
            .NotificarFalhas(_notificationContext)
            .IsSuccess;

        if (turnoAtualizado)
        {
            _turnoRepository.Update(turno);
            await _unitOfWork.CommitAsync(cancellationToken);
        }
    }
}
