using Anima.Inscricao.Application._Shared.Commands;
using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Intakes;

namespace Anima.Inscricao.Application.UseCases.Intakes.RemoverIntake;

public class RemoverIntakeCommandHandler : ICommandHandler<RemoverIntakeCommand>
{
    public readonly INotificationContext _notificationContext;
    public readonly IIntakeRepository _intakeRepository;
    public readonly IUnitOfWork _unitOfWork;

    public RemoverIntakeCommandHandler(
        INotificationContext notificationContext,
        IIntakeRepository intakeRepository,
        IUnitOfWork unitOfWork)
    {
        _notificationContext = notificationContext;
        _intakeRepository = intakeRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task Handle(RemoverIntakeCommand request, CancellationToken cancellationToken)
    {
        var intake = await _intakeRepository.GetAsync(request.Key);

        var intakeRemovido = intake.Remover()
            .NotificarFalhas(_notificationContext)
            .IsSuccess;

        if (intakeRemovido)
        {
            _intakeRepository.Delete(intake);
            await _unitOfWork.CommitAsync(cancellationToken);
        }
    }
}