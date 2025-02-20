using Anima.Inscricao.Application._Shared.Commands;
using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Campos;

namespace Anima.Inscricao.Application.UseCases.Campos.AtualizarCampo;

public class AtualizarCampoCommandHandler : ICommandHandler<AtualizarCampoCommand>
{
    private readonly INotificationContext _notificationContext;
    private readonly ICampoRepository _campoRepository;
    private readonly IUnitOfWork _unitOfWork;

    public AtualizarCampoCommandHandler(
        INotificationContext notificationContext,
        ICampoRepository campoRepository,
        IUnitOfWork unitOfWork)
    {
        _notificationContext = notificationContext;
        _campoRepository = campoRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task Handle(AtualizarCampoCommand request, CancellationToken cancellationToken)
    {
        var campo = await _campoRepository.GetAsync(request.Key);

        var campoAtualizado = campo
            .AtualizarInfos(request.Nome)
            .NotificarFalhas(_notificationContext)
            .IsSuccess;

        if (campoAtualizado)
        {
            _campoRepository.Update(campo);
            await _unitOfWork.CommitAsync(cancellationToken);
        }
    }
}
