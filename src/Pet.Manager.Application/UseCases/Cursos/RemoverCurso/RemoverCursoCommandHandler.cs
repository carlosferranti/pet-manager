using Anima.Inscricao.Application._Shared.Commands;
using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Cursos;

namespace Anima.Inscricao.Application.UseCases.Cursos.RemoverCurso;

public class RemoverCursoCommandHandler : ICommandHandler<RemoverCursoCommand>
{
    public readonly INotificationContext _notificationContext;
    public readonly ICursoRepository _cursoRepository;
    public readonly IUnitOfWork _unitOfWork;

    public RemoverCursoCommandHandler(
        INotificationContext notificationContext,
        ICursoRepository cursoRepository,
        IUnitOfWork unitOfWork)
    {
        _notificationContext = notificationContext;
        _cursoRepository = cursoRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task Handle(RemoverCursoCommand request, CancellationToken cancellationToken)
    {
        var curso = await _cursoRepository.GetAsync(request.Key);

        var cursoRemovido = curso.Remover()
            .NotificarFalhas(_notificationContext)
            .IsSuccess;

        if (cursoRemovido)
        {
            _cursoRepository.Delete(curso);
            await _unitOfWork.CommitAsync(cancellationToken);
        }
    }
}
