using Anima.Inscricao.Application._Shared.Commands;
using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.NiveisCurso;

namespace Anima.Inscricao.Application.UseCases.NiveisCurso.AtualizarNivelCurso;

public class AtualizarNivelCursoCommandHandler : ICommandHandler<AtualizarNivelCursoCommand>
{
    private readonly INotificationContext _notificationContext;
    private readonly INivelCursoRepository _nivelCursoRepository;
    private readonly IUnitOfWork _unitOfWork;

    public AtualizarNivelCursoCommandHandler(
        INotificationContext notificationContext,
        INivelCursoRepository nivelCursoRepository, 
        IUnitOfWork unitOfWork)
    {
        _notificationContext = notificationContext;
        _nivelCursoRepository = nivelCursoRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task Handle(AtualizarNivelCursoCommand request, CancellationToken cancellationToken)
    {
        var nivelCurso = await _nivelCursoRepository.GetAsync(request.Key);

        var nivelCursoAtualizado = nivelCurso
            .AtualizarInfos(request.Nome)
            .NotificarFalhas(_notificationContext)
            .IsSuccess;

        if (nivelCursoAtualizado)
        {
            _nivelCursoRepository.Update(nivelCurso);
            await _unitOfWork.CommitAsync(cancellationToken);
        }
    }
}
