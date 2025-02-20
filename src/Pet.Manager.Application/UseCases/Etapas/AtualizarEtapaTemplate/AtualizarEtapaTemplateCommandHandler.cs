using Anima.Inscricao.Application._Shared.Commands;
using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Etapas;

namespace Anima.Inscricao.Application.UseCases.Etapas.AtualizarEtapaTemplate;

public class AtualizarEtapaTemplateCommandHandler : ICommandHandler<AtualizarEtapaTemplateCommand>
{
    private readonly INotificationContext _notificationContext;
    private readonly IEtapaTemplateRepository _etapaTemplateRepository;
    private readonly IUnitOfWork _unitOfWork;

    public AtualizarEtapaTemplateCommandHandler(
        INotificationContext notificationContext,
        IEtapaTemplateRepository etapaTemplateRepository,
        IUnitOfWork unitOfWork)
    {
        _notificationContext = notificationContext;
        _etapaTemplateRepository = etapaTemplateRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task Handle(AtualizarEtapaTemplateCommand request, CancellationToken cancellationToken)
    {
        var etapa = await _etapaTemplateRepository.GetAsync(request.Key);

        var etapaAtualizada = etapa.AtualizarInfos(request.Nome, request.Descricao, request.NomeArquivo)
            .NotificarFalhas(_notificationContext)
            .IsSuccess;

        if (etapaAtualizada)
        {
            _etapaTemplateRepository.Update(etapa);
            await _unitOfWork.CommitAsync(cancellationToken);
        }
    }
}