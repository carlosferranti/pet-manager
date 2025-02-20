using Anima.Inscricao.Application._Shared.Commands;
using Anima.Inscricao.Application._Shared.DTOs;
using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Etapas;
using Anima.Inscricao.Domain.Etapas.Entities;

namespace Anima.Inscricao.Application.UseCases.Etapas.CriarEtapa;

public class CriarEtapaTemplateCommandHandler : ICommandHandler<CriarEtapaTemplateCommand, EntityKeyDto?>
{
    private readonly INotificationContext _notificationContext;
    private readonly IEtapaTemplateRepository _etapaTemplateRepository;
    private readonly IUnitOfWork _unitOfWork;

    public CriarEtapaTemplateCommandHandler(
        INotificationContext notificationContext,
        IEtapaTemplateRepository etapaTemplateRepository,
        IUnitOfWork unitOfWork)
    {
        _notificationContext = notificationContext;
        _etapaTemplateRepository = etapaTemplateRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task<EntityKeyDto?> Handle(CriarEtapaTemplateCommand request, CancellationToken cancellationToken)
    {
        var etapa = EtapaTemplate
            .Criar(request.Nome, request.Descricao, request.NomeArquivo)
            .NotificarFalhas(_notificationContext)
            .ObterRetorno();

        if (etapa == null)
        {
            return null;
        }

        await _etapaTemplateRepository.InsertAsync(etapa);

        await _unitOfWork.CommitAsync(cancellationToken);

        return new EntityKeyDto(etapa.Key);
    }
}
