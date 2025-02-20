using Anima.Inscricao.Application._Shared.Commands;
using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Enderecos;

namespace Anima.Inscricao.Application.UseCases.Enderecos.RemoverCidade;

public class RemoverCidadeCommandHandler : ICommandHandler<RemoverCidadeCommand>
{
    public readonly INotificationContext _notificationContext;
    public readonly ICidadeRepository _cidadeRepository;
    public readonly IUnitOfWork _unitOfWork;

    public RemoverCidadeCommandHandler(
        INotificationContext notificationContext,
        ICidadeRepository cidadeRepository,
        IUnitOfWork unitOfWork)
    {
        _notificationContext = notificationContext;
        _cidadeRepository = cidadeRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task Handle(RemoverCidadeCommand request, CancellationToken cancellationToken)
    {
        var cidade = await _cidadeRepository.GetAsync(request.Key);

        var cidadeRemovida = cidade.Remover()
            .NotificarFalhas(_notificationContext)
            .IsSuccess;

        if (cidadeRemovida)
        {
            _cidadeRepository.Delete(cidade);
            await _unitOfWork.CommitAsync(cancellationToken);
        }
    }
}
