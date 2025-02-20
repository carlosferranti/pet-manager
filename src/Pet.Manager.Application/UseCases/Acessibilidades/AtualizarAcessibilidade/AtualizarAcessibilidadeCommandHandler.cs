using Anima.Inscricao.Application._Shared.Commands;
using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Acessibilidades;

namespace Anima.Inscricao.Application.UseCases.Acessibilidades.AtualizarAcessibilidade;

public class AtualizarAcessibilidadeCommandHandler : ICommandHandler<AtualizarAcessibilidadeCommand>
{
    private readonly INotificationContext _notificationContext;
    private readonly IAcessibilidadeRepository _acessibilidadeRepository;
    private readonly IUnitOfWork _unitOfWork;

    public AtualizarAcessibilidadeCommandHandler(INotificationContext notificationContext, IAcessibilidadeRepository acessibilidadeRepository, IUnitOfWork unitOfWork)
    {
        _notificationContext = notificationContext;
        _acessibilidadeRepository = acessibilidadeRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task Handle(AtualizarAcessibilidadeCommand request, CancellationToken cancellationToken)
    {
        var acessibilidade = await _acessibilidadeRepository.GetAsync(request.Key);

        var acessibilidadeAtualizada = acessibilidade
            .AtualizarInfos(request.Nome)
            .NotificarFalhas(_notificationContext)
            .IsSuccess;

        if (acessibilidadeAtualizada)
        {
            _acessibilidadeRepository.Update(acessibilidade);
            await _unitOfWork.CommitAsync(cancellationToken);
        }
    }
}
