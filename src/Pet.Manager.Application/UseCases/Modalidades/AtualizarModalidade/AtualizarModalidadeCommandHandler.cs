using Anima.Inscricao.Application._Shared.Commands;
using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Modalidades;

namespace Anima.Inscricao.Application.UseCases.Modalidades.AtualizarModalidade;

public class AtualizarModalidadeCommandHandler : ICommandHandler<AtualizarModalidadeCommand>
{
    private readonly INotificationContext _notificationContext;
    private readonly IModalidadeRepository _modalidadeRepository;
    private readonly IUnitOfWork _unitOfWork;

    public AtualizarModalidadeCommandHandler(
        INotificationContext notificationContext,
        IModalidadeRepository modalidadeRepository,
        IUnitOfWork unitOfWork)
    {
        _notificationContext = notificationContext;
        _modalidadeRepository = modalidadeRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task Handle(AtualizarModalidadeCommand request, CancellationToken cancellationToken)
    {
        var modalidade = await _modalidadeRepository.GetAsync(request.Key);

        var modalidadeAtualizada = modalidade.AtualizarInfos(request.Nome, request.Descricao)
            .NotificarFalhas(_notificationContext)
            .IsSuccess;

        if (modalidadeAtualizada)
        {
            _modalidadeRepository.Update(modalidade);
            await _unitOfWork.CommitAsync(cancellationToken);
        }
    }
}
