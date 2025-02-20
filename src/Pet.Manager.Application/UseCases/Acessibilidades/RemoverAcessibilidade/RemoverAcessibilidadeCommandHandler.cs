using Anima.Inscricao.Application._Shared.Commands;
using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Acessibilidades;

namespace Anima.Inscricao.Application.UseCases.Acessibilidades.RemoverAcessibilidade;

public class RemoverAcessibilidadeCommandHandler : ICommandHandler<RemoverAcessibilidadeCommand>
{
    private readonly IAcessibilidadeRepository _acessibilidadeRepository;
    private readonly INotificationContext _notificationContext;
    private readonly IUnitOfWork _unitOfWork;

    public RemoverAcessibilidadeCommandHandler(
        IUnitOfWork unitOfWork,
        INotificationContext notificationContext,
        IAcessibilidadeRepository acessibilidadeRepository)
    {
        _acessibilidadeRepository = acessibilidadeRepository;
        _notificationContext = notificationContext;
        _unitOfWork = unitOfWork;
    }

    public async Task Handle(RemoverAcessibilidadeCommand request, CancellationToken cancellationToken)
    {
        var acessibilidade = await _acessibilidadeRepository.GetAsync(request.Key);

        var acessibilidadeRemovida = acessibilidade.Remover()
            .NotificarFalhas(_notificationContext)
            .IsSuccess;
        
        if(acessibilidadeRemovida)
        {
            _acessibilidadeRepository.Delete(acessibilidade);
            await _unitOfWork.CommitAsync(cancellationToken);
        }
    }
}
