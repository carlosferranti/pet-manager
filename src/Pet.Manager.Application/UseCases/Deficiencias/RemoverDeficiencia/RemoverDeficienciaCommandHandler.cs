using Anima.Inscricao.Application._Shared.Commands;
using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Deficiencias;

namespace Anima.Inscricao.Application.UseCases.Deficiencias.RemoverDeficiencia;

public class RemoverDeficienciaCommandHandler : ICommandHandler<RemoverDeficienciaCommand>
{
    public readonly INotificationContext _notificationContext;
    public readonly IDeficienciaRepository _deficienciaRepository;
    public readonly IUnitOfWork _unitOfWork;

    public RemoverDeficienciaCommandHandler(
        INotificationContext notificationContext,
        IDeficienciaRepository deficienciaRepository,
        IUnitOfWork unitOfWork)
    {
        _notificationContext = notificationContext;
        _deficienciaRepository = deficienciaRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task Handle(RemoverDeficienciaCommand request, CancellationToken cancellationToken)
    {
        var deficiencia = await _deficienciaRepository.GetAsync(request.Key);

        var deficienciaRemovida = deficiencia.Remover()
            .NotificarFalhas(_notificationContext)
            .IsSuccess;

        if (deficienciaRemovida)
        {
            _deficienciaRepository.Delete(deficiencia);
            await _unitOfWork.CommitAsync(cancellationToken);
        }
    }
}
