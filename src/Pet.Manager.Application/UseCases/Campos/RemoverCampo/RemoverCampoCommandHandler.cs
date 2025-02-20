using Anima.Inscricao.Application._Shared.Commands;
using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Campos;

namespace Anima.Inscricao.Application.UseCases.Campos.RemoverCampo;

public class RemoverCampoCommandHandler : ICommandHandler<RemoverCampoCommand>
{
    public readonly INotificationContext _notificationContext;
    public readonly ICampoRepository _campoRepository;
    public readonly IUnitOfWork _unitOfWork;

    public RemoverCampoCommandHandler(
        INotificationContext notificationContext,
        ICampoRepository campoRepository,
        IUnitOfWork unitOfWork)
    {
        _notificationContext = notificationContext;
        _campoRepository = campoRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task Handle(RemoverCampoCommand request, CancellationToken cancellationToken)
    {
        var campo = await _campoRepository.GetAsync(request.Key);

        var campoRemovido = campo.Remover()
            .NotificarFalhas(_notificationContext)
            .IsSuccess;

        if (campoRemovido)
        {
            _campoRepository.Delete(campo);
            await _unitOfWork.CommitAsync(cancellationToken);
        }
    }
}
