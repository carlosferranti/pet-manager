using Anima.Inscricao.Application._Shared.Commands;
using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Configuracoes;

namespace Anima.Inscricao.Application.UseCases.Configuracoes.RemoverConfiguracao;

public class RemoverConfiguracaoCommandHandler : ICommandHandler<RemoverConfiguracaoCommand>
{
    private readonly INotificationContext _notificationContext;
    private readonly IConfiguracaoRepository _configuracaoRepository;
    private readonly IUnitOfWork _unitOfWork;

    public RemoverConfiguracaoCommandHandler(
        INotificationContext notificationContext, 
        IConfiguracaoRepository configuracaoRepository, 
        IUnitOfWork unitOfWork)
    {
        _notificationContext = notificationContext;
        _configuracaoRepository = configuracaoRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task Handle(RemoverConfiguracaoCommand request, CancellationToken cancellationToken)
    {
        var configuracao = await _configuracaoRepository.GetAsync(request.Key);

        var configuracaoRemovida = configuracao.Remover()
            .NotificarFalhas(_notificationContext)
            .IsSuccess;

        if (configuracaoRemovida)
        {
            _configuracaoRepository.Delete(configuracao);
            await _unitOfWork.CommitAsync(cancellationToken);
        }
    }
}
