using Anima.Inscricao.Application._Shared.Commands;
using Anima.Inscricao.Application._Shared.DTOs;
using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Campos;
using Anima.Inscricao.Domain.Campos.Entities;

namespace Anima.Inscricao.Application.UseCases.Campos.CriarCampo;

public class CriarCampoCommandHandler : ICommandHandler<CriarCampoCommand, EntityKeyDto?>
{
    private readonly INotificationContext _notificationContext;
    private readonly ICampoRepository _campoRepository;
    private readonly IUnitOfWork _unitOfWork;

    public CriarCampoCommandHandler(
        INotificationContext notificationContext,
        ICampoRepository campoRepository,
        IUnitOfWork unitOfWork)
    {
        _notificationContext = notificationContext;
        _campoRepository = campoRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task<EntityKeyDto?> Handle(CriarCampoCommand request, CancellationToken cancellationToken)
    {
        var campo = Campo
            .Criar(request.Nome)
            .NotificarFalhas(_notificationContext)
            .ObterRetorno();

        if (campo == null)
        {
            return null;
        }

        await _campoRepository.InsertAsync(campo);

        await _unitOfWork.CommitAsync(cancellationToken);

        return new EntityKeyDto(campo.Key);
    }
}
