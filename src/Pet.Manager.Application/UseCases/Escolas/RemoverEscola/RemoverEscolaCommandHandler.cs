using Anima.Inscricao.Application._Shared.Commands;
using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Escolas;

namespace Anima.Inscricao.Application.UseCases.Escolas.RemoverEscola;

public class RemoverEscolaCommandHandler : ICommandHandler<RemoverEscolaCommand>
{
    private readonly IEscolaRepository _escolaRepository;
    private readonly INotificationContext _notificationContext;
    private readonly IUnitOfWork _unitOfWork;

    public RemoverEscolaCommandHandler(
        IEscolaRepository escolaRepository, 
        INotificationContext notificationContext, 
        IUnitOfWork unitOfWork)
    {
        _escolaRepository = escolaRepository;
        _notificationContext = notificationContext;
        _unitOfWork = unitOfWork;
    }

    public async Task Handle(RemoverEscolaCommand request, CancellationToken cancellationToken)
    {
        var escola = await _escolaRepository.GetAsync(request.Key);

        var escolaRemovida = escola.Remover()
            .NotificarFalhas(_notificationContext)
            .IsSuccess;

        if (escolaRemovida)
        {
            _escolaRepository.Delete(escola);
            await _unitOfWork.CommitAsync(cancellationToken);
        }
    }
}
