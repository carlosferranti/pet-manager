using Anima.Inscricao.Application._Shared.Commands;
using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain._Shared.ValueObjects;
using Anima.Inscricao.Domain.Intakes;

namespace Anima.Inscricao.Application.UseCases.Intakes.AtualizarIntake;

public class AtualizarIntakeCommandHandler : ICommandHandler<AtualizarIntakeCommand>
{
    private readonly INotificationContext _notificationContext;
    private readonly IIntakeRepository _intakeRepository;
    private readonly IUnitOfWork _unitOfWork;

    public AtualizarIntakeCommandHandler(
        INotificationContext notificationContext,
        IIntakeRepository intakeRepository,
        IUnitOfWork unitOfWork)
    {
        _notificationContext = notificationContext;
        _intakeRepository = intakeRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task Handle(AtualizarIntakeCommand request, CancellationToken cancellationToken)
    {
        var intake = await _intakeRepository.GetAsync(request.Key);

        var intakeAtualizado = intake.AtualizarInfos(request.Nome, new Vigencia(request.VigenciaInicio, request.VigenciaTermino))
            .NotificarFalhas(_notificationContext)
            .IsSuccess;

        if (intakeAtualizado)
        {
            _intakeRepository.Update(intake);
            await _unitOfWork.CommitAsync(cancellationToken);
        }
    }
}