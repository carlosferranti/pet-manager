using Anima.Inscricao.Application._Shared.Commands;
using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.TiposFormacao;

namespace Anima.Inscricao.Application.UseCases.TiposFormacao.AtualizarTipoFormacao;

public class AtualizarTipoFormacaoCommandHandler : ICommandHandler<AtualizarTipoFormacaoCommand>
{
    private readonly INotificationContext _notificationContext;
    private readonly ITipoFormacaoRepository _tipoFormacaoRepository;
    private readonly IUnitOfWork _unitOfWork;

    public AtualizarTipoFormacaoCommandHandler(
        INotificationContext notificationContext,
        ITipoFormacaoRepository tipoFormacaoRepository,
        IUnitOfWork unitOfWork)
    {
        _notificationContext = notificationContext;
        _tipoFormacaoRepository = tipoFormacaoRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task Handle(AtualizarTipoFormacaoCommand request, CancellationToken cancellationToken)
    {
        var tipoFormacao = await _tipoFormacaoRepository.GetAsync(request.Key);

        var tipoFormacaoAtualizado = tipoFormacao.AtualizarInfos(request.Nome)
            .NotificarFalhas(_notificationContext)
            .IsSuccess;

        if (tipoFormacaoAtualizado)
        {
            _tipoFormacaoRepository.Update(tipoFormacao);
            await _unitOfWork.CommitAsync(cancellationToken);
        }
    }
}
