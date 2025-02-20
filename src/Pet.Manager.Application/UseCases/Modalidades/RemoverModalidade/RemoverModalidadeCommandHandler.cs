using Anima.Inscricao.Application._Shared.Commands;
using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Modalidades;

namespace Anima.Inscricao.Application.UseCases.Modalidades.RemoverModalidade;

public class RemoverModalidadeCommandHandler : ICommandHandler<RemoverModalidadeCommand>
{
    public readonly INotificationContext _notificationContext;
    public readonly IModalidadeRepository _modalidadeRepository;
    public readonly IUnitOfWork _unitOfWork;

    public RemoverModalidadeCommandHandler(
        INotificationContext notificationContext,
        IModalidadeRepository modalidadeRepository,
        IUnitOfWork unitOfWork)
    {
        _notificationContext = notificationContext;
        _modalidadeRepository = modalidadeRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task Handle(RemoverModalidadeCommand request, CancellationToken cancellationToken)
    {
        var modalidade = await _modalidadeRepository.GetAsync(request.Key);

        var modalidadeRemovida = modalidade.Remover()
            .NotificarFalhas(_notificationContext)
            .IsSuccess;

        if (modalidadeRemovida)
        {
            _modalidadeRepository.Delete(modalidade);
            await _unitOfWork.CommitAsync(cancellationToken);
        }
    }
}
