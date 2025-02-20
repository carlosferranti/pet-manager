using Anima.Inscricao.Application._Shared.Commands;
using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.TiposFormacao;

namespace Anima.Inscricao.Application.UseCases.TiposFormacao.RemoverTipoFormacao;

public class RemoverTipoFormacaoCommandHandler : ICommandHandler<RemoverTipoFormacaoCommand>
{
    public readonly INotificationContext _notificationContext;
    public readonly ITipoFormacaoRepository _tipoFormacaoRepository;
    public readonly IUnitOfWork _unitOfWork;

    public RemoverTipoFormacaoCommandHandler(
        INotificationContext notificationContext,
        ITipoFormacaoRepository tipoFormacaoRepository,
        IUnitOfWork unitOfWork)
    {
        _notificationContext = notificationContext;
        _tipoFormacaoRepository = tipoFormacaoRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task Handle(RemoverTipoFormacaoCommand request, CancellationToken cancellationToken)
    {
        var tipoFormacao = await _tipoFormacaoRepository.GetAsync(request.Key);

        var tipoFormacaoRemovido = tipoFormacao.Remover()
            .NotificarFalhas(_notificationContext)
            .IsSuccess;

        if (tipoFormacaoRemovido)
        {
            _tipoFormacaoRepository.Delete(tipoFormacao);
            await _unitOfWork.CommitAsync(cancellationToken);
        }
    }
}
