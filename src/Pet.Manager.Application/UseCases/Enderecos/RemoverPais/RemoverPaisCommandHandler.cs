using Anima.Inscricao.Application._Shared.Commands;
using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Enderecos;

namespace Anima.Inscricao.Application.UseCases.Enderecos.RemoverPais;

public class RemoverPaisCommandHandler : ICommandHandler<RemoverPaisCommand>
{
    public readonly INotificationContext _notificationContext;
    public readonly IPaisRepository _paisRepository;
    public readonly IUnitOfWork _unitOfWork;

    public RemoverPaisCommandHandler(
        INotificationContext notificationContext,
        IPaisRepository paisRepository,
        IUnitOfWork unitOfWork)
    {
        _notificationContext = notificationContext;
        _paisRepository = paisRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task Handle(RemoverPaisCommand request, CancellationToken cancellationToken)
    {
        var pais = await _paisRepository.GetAsync(request.Key);

        var paisRemovido = pais.Remover()
            .NotificarFalhas(_notificationContext)
            .IsSuccess;

        if (paisRemovido)
        {
            _paisRepository.Delete(pais);
            await _unitOfWork.CommitAsync(cancellationToken);
        }
    }
}
