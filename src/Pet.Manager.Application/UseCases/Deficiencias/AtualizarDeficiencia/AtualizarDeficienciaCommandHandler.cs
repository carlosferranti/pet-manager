using Anima.Inscricao.Application._Shared.Commands;
using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Deficiencias;

namespace Anima.Inscricao.Application.UseCases.Deficiencias.AtualizarDeficiencia;

public class AtualizarDeficienciaCommandHandler : ICommandHandler<AtualizarDeficienciaCommand>
{
    private readonly INotificationContext _notificationContext;
    private readonly IDeficienciaRepository _deficienciaRepository;
    private readonly IUnitOfWork _unitOfWork;

    public AtualizarDeficienciaCommandHandler(
        INotificationContext notificationContext,
        IDeficienciaRepository deficienciaRepository,
        IUnitOfWork unitOfWork)
    {
        _notificationContext = notificationContext;
        _deficienciaRepository = deficienciaRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task Handle(AtualizarDeficienciaCommand request, CancellationToken cancellationToken)
    {
        var deficiencia = await _deficienciaRepository.GetAsync(request.Key);

        var deficienciaAtualizada = deficiencia
            .AtualizarInfos(request.Nome, request.OrdemExibicao)
            .NotificarFalhas(_notificationContext)
            .IsSuccess;

        if (deficienciaAtualizada)
        {
            _deficienciaRepository.Update(deficiencia);
            await _unitOfWork.CommitAsync(cancellationToken);
        }
    }
}
