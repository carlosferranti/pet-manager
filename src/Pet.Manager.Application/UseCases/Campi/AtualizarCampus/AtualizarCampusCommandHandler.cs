using Anima.Inscricao.Application._Shared.Commands;
using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Campi;

namespace Anima.Inscricao.Application.UseCases.Campi.AtualizarCampus;

public class AtualizarCampusCommandHandler : ICommandHandler<AtualizarCampusCommand>
{
    private readonly INotificationContext _notificationContext;
    private readonly ICampusRepository _campusRepository;
    private readonly IUnitOfWork _unitOfWork;

    public AtualizarCampusCommandHandler(
        INotificationContext notificationContext, 
        ICampusRepository campusRepository, 
        IUnitOfWork unitOfWork)
    {
        _notificationContext = notificationContext;
        _campusRepository = campusRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task Handle(AtualizarCampusCommand request, CancellationToken cancellationToken)
    {
        var campus = await _campusRepository.GetAsync(request.Key);

        var campusAtualizado = campus
            .AtualizarInfos(request.Nome, request.NomeComercial)
            .NotificarFalhas(_notificationContext)
            .IsSuccess;

        if (campusAtualizado)
        {
            _campusRepository.Update(campus);
            await _unitOfWork.CommitAsync(cancellationToken);
        }
    }
}
