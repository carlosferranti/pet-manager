using Anima.Inscricao.Application._Shared.Commands;
using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Etapas;

namespace Anima.Inscricao.Application.UseCases.Etapas.RemoverEtapaTemplate;

public class RemoverEtapaTemplateCommandHandler : ICommandHandler<RemoverEtapaTemplateCommand>
{
    public readonly INotificationContext _notificationContext;
    public readonly IEtapaTemplateRepository _etapaTemplateRepository;
    public readonly IUnitOfWork _unitOfWork;

    public RemoverEtapaTemplateCommandHandler(
        INotificationContext notificationContext,
        IEtapaTemplateRepository etapaTemplateRepository,
        IUnitOfWork unitOfWork)
    {
        _notificationContext = notificationContext;
        _etapaTemplateRepository = etapaTemplateRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task Handle(RemoverEtapaTemplateCommand request, CancellationToken cancellationToken)
    {
        var etapa = await _etapaTemplateRepository.GetAsync(request.Key);

        var etapaRemovida = etapa.Remover()
            .NotificarFalhas(_notificationContext)
            .IsSuccess;

        if (etapaRemovida)
        {
            _etapaTemplateRepository.Delete(etapa);
            await _unitOfWork.CommitAsync(cancellationToken);
        }
    }
}