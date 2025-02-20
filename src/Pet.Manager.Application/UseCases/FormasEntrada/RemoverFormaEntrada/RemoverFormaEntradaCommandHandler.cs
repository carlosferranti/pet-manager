using Anima.Inscricao.Application._Shared.Commands;
using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.FormasEntrada;

namespace Anima.Inscricao.Application.UseCases.FormasEntrada.RemoverFormaEntrada;

public class RemoverFormaEntradaCommandHandler : ICommandHandler<RemoverFormaEntradaCommand>
{
    public readonly INotificationContext _notificationContext;
    public readonly IFormaEntradaRepository _formaEntradaRepository;
    public readonly IUnitOfWork _unitOfWork;

    public RemoverFormaEntradaCommandHandler(
        INotificationContext notificationContext,
        IFormaEntradaRepository formaEntradaRepository,
        IUnitOfWork unitOfWork)
    {
        _notificationContext = notificationContext;
        _formaEntradaRepository = formaEntradaRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task Handle(RemoverFormaEntradaCommand request, CancellationToken cancellationToken)
    {
        var formaEntrada = await _formaEntradaRepository.GetAsync(request.Key);

        var formaEntradaRemovida = formaEntrada.Remover()
            .NotificarFalhas(_notificationContext)
            .IsSuccess;

        if (formaEntradaRemovida)
        {
            _formaEntradaRepository.Delete(formaEntrada);
            await _unitOfWork.CommitAsync(cancellationToken);
        }
    }
}
