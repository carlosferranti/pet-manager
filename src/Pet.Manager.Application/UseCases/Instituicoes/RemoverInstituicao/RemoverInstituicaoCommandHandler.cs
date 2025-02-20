using Anima.Inscricao.Application._Shared.Commands;
using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Instituicoes;

namespace Anima.Inscricao.Application.UseCases.Instituicoes.RemoverInstituicao;

public class RemoverInstituicaoCommandHandler : ICommandHandler<RemoverInstituicaoCommand>
{
    private readonly INotificationContext _notificationContext;
    private readonly IInstituicaoRepository _instituicaoRepository;
    private readonly IUnitOfWork _unitOfWork;

    public RemoverInstituicaoCommandHandler(
        INotificationContext notificationContext, 
        IInstituicaoRepository instituicaoRepository, 
        IUnitOfWork unitOfWork)
    {
        _notificationContext = notificationContext;
        _instituicaoRepository = instituicaoRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task Handle(RemoverInstituicaoCommand request, CancellationToken cancellationToken)
    {
        var instituicao = await _instituicaoRepository.GetAsync(request.Key);

        var instituicaoRemovida = instituicao.Remover()
            .NotificarFalhas(_notificationContext)
            .IsSuccess;

        if (instituicaoRemovida)
        {
            _instituicaoRepository.Delete(instituicao);
            await _unitOfWork.CommitAsync(cancellationToken);
        }
    }
}
