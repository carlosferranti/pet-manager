using Anima.Inscricao.Application._Shared.Commands;
using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Marcas;

namespace Anima.Inscricao.Application.UseCases.Marcas.RemoverMarca;

public class RemoverMarcaCommandHandler : ICommandHandler<RemoverMarcaCommand>
{
    private readonly INotificationContext _notificationContext;
    private readonly IMarcaRepository _marcaRepository;
    private readonly IUnitOfWork _unitOfWork;

    public RemoverMarcaCommandHandler(
        INotificationContext notificationContext, 
        IMarcaRepository marcaRepository, 
        IUnitOfWork unitOfWork)
    {
        _notificationContext = notificationContext;
        _marcaRepository = marcaRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task Handle(RemoverMarcaCommand request, CancellationToken cancellationToken)
    {
        var marca = await _marcaRepository.GetAsync(request.Key);

        var marcaRemovida = marca.Remover()
            .NotificarFalhas(_notificationContext)
            .IsSuccess;

        if (marcaRemovida)
        {
            _marcaRepository.Delete(marca);
            await _unitOfWork.CommitAsync(cancellationToken);
        }
    }
}
