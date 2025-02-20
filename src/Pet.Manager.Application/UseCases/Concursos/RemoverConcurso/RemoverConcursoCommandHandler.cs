using Anima.Inscricao.Application._Shared.Commands;
using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Concursos;

namespace Anima.Inscricao.Application.UseCases.Concursos.RemoverConcurso;

public class RemoverConcursoCommandHandler : ICommandHandler<RemoverConcursoCommand>
{
    public readonly INotificationContext _notificationContext;
    public readonly IConcursoRepository _concursoRepository;
    public readonly IUnitOfWork _unitOfWork;

    public RemoverConcursoCommandHandler(
        INotificationContext notificationContext,
        IConcursoRepository concursoRepository,
        IUnitOfWork unitOfWork)
    {
        _notificationContext = notificationContext;
        _concursoRepository = concursoRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task Handle(RemoverConcursoCommand request, CancellationToken cancellationToken)
    {
        var concurso = await _concursoRepository.GetAsync(request.Key);

        var concursoRemovido = concurso.Remover()
            .NotificarFalhas(_notificationContext)
            .IsSuccess;

        if (concursoRemovido)
        {
            _concursoRepository.Delete(concurso);
            await _unitOfWork.CommitAsync(cancellationToken);
        }
    }
}