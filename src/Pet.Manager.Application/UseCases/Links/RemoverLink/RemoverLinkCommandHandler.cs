using Anima.Inscricao.Application._Shared.Commands;
using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Links;

namespace Anima.Inscricao.Application.UseCases.Links.RemoverLink;

public class RemoverLinkCommandHandler : ICommandHandler<RemoverLinkCommand>
{
    public readonly INotificationContext _notificationContext;
    public readonly ILinkRepository _linkRepository;
    public readonly IUnitOfWork _unitOfWork;

    public RemoverLinkCommandHandler(
        INotificationContext notificationContext,
        ILinkRepository linkRepository,
        IUnitOfWork unitOfWork)
    {
        _notificationContext = notificationContext;
        _linkRepository = linkRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task Handle(RemoverLinkCommand request, CancellationToken cancellationToken)
    {
        var link = await _linkRepository.GetAsync(request.Key);

        var linkRemovido = link.Remover()
            .NotificarFalhas(_notificationContext)
            .IsSuccess;

        if (linkRemovido)
        {
            _linkRepository.Delete(link);
            await _unitOfWork.CommitAsync(cancellationToken);
        }
    }
}