using Anima.Inscricao.Application._Shared.Commands;
using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Enderecos;

namespace Anima.Inscricao.Application.UseCases.Enderecos.RemoverEstado;

public class RemoverEstadoCommandHandler : ICommandHandler<RemoverEstadoCommand>
{
    public readonly INotificationContext _notificationContext;
    public readonly IEstadoRepository _estadoRepository;
    public readonly IUnitOfWork _unitOfWork;

    public RemoverEstadoCommandHandler(
        INotificationContext notificationContext,
        IEstadoRepository estadoRepository,
        IUnitOfWork unitOfWork)
    {
        _notificationContext = notificationContext;
        _estadoRepository = estadoRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task Handle(RemoverEstadoCommand request, CancellationToken cancellationToken)
    {
        var estado = await _estadoRepository.GetAsync(request.Key);

        var estadoRemovido = estado.Remover()
            .NotificarFalhas(_notificationContext)
            .IsSuccess;

        if (estadoRemovido)
        {
            _estadoRepository.Delete(estado);
            await _unitOfWork.CommitAsync(cancellationToken);
        }
    }
}

