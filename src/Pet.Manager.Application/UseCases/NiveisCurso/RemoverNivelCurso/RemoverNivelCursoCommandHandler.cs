using Anima.Inscricao.Application._Shared.Commands;
using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.NiveisCurso;

namespace Anima.Inscricao.Application.UseCases.NiveisCurso.RemoverNivelCurso;

public class RemoverNivelCursoCommandHandler : ICommandHandler<RemoverNivelCursoCommand>
{
    private readonly INotificationContext _notificationContext;
    private readonly INivelCursoRepository _nivelCursoRepository;
    private readonly IUnitOfWork _unitOfWork;

    public RemoverNivelCursoCommandHandler(
        INotificationContext notificationContext, 
        INivelCursoRepository nivelCursoRepository, 
        IUnitOfWork unitOfWork)
    {
        _notificationContext = notificationContext;
        _nivelCursoRepository = nivelCursoRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task Handle(RemoverNivelCursoCommand request, CancellationToken cancellationToken)
    {
        var nivelCurso = await _nivelCursoRepository.GetAsync(request.Key);

        var nivelCursoRemovido = nivelCurso.Remover()
            .NotificarFalhas(_notificationContext)
            .IsSuccess;

        if (nivelCursoRemovido)
        {
            _nivelCursoRepository.Delete(nivelCurso);
            await _unitOfWork.CommitAsync(cancellationToken);
        }
    }
}
