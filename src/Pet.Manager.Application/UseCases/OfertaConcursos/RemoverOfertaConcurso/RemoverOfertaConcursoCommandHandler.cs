using Anima.Inscricao.Application._Shared.Commands;
using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.OfertaConcursos;

namespace Anima.Inscricao.Application.UseCases.OfertaConcursos.RemoverOfertaConcurso;

public class RemoverOfertaConcursoCommandHandler : ICommandHandler<RemoverOfertaConcursoCommand>
{
    public readonly INotificationContext _notificationContext;
    public readonly IOfertaConcursoRepository _ofertaConcursoRepository;
    public readonly IUnitOfWork _unitOfWork;

    public RemoverOfertaConcursoCommandHandler(
        INotificationContext notificationContext, 
        IOfertaConcursoRepository ofertaConcursoRepository, 
        IUnitOfWork unitOfWork)
    {
        _notificationContext = notificationContext;
        _ofertaConcursoRepository = ofertaConcursoRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task Handle(RemoverOfertaConcursoCommand request, CancellationToken cancellationToken)
    {
        var ofertaConcurso = await _ofertaConcursoRepository.GetAsync(request.Key);

        var ofertaConcursoRemovida = ofertaConcurso.Remover()
            .NotificarFalhas(_notificationContext)
            .IsSuccess;
        if (ofertaConcursoRemovida)
        {
            _ofertaConcursoRepository.Delete(ofertaConcurso);
            await _unitOfWork.CommitAsync(cancellationToken);
        }
    }
}
