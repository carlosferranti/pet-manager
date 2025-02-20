using Anima.Inscricao.Application._Shared.Commands;
using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Enderecos;

namespace Anima.Inscricao.Application.UseCases.Enderecos.AtualizarPais;

public class AtualizarPaisCommandHandler : ICommandHandler<AtualizarPaisCommand>
{
    private readonly INotificationContext _notificationContext;
    private readonly IPaisRepository _paisRepository;
    private readonly IUnitOfWork _unitOfWork;

    public AtualizarPaisCommandHandler(
        INotificationContext notificationContext,
        IPaisRepository paisRepository,
        IUnitOfWork unitOfWork)
    {
        _notificationContext = notificationContext;
        _paisRepository = paisRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task Handle(AtualizarPaisCommand request, CancellationToken cancellationToken)
    {
        var pais = await _paisRepository.GetAsync(request.Key);

        var paisAtualizado = pais
            .AtualizarInfos(request.Nome, request.Sigla, request.SiglaAbreviada, request.Tipo)
            .NotificarFalhas(_notificationContext)
            .IsSuccess;

        if (paisAtualizado)
        {
            _paisRepository.Update(pais);
            await _unitOfWork.CommitAsync(cancellationToken);
        }
    }
}
