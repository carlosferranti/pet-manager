using Anima.Inscricao.Application._Shared.Commands;
using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Configuracoes;

using MediatR;

namespace Anima.Inscricao.Application.UseCases.Configuracoes.AtualizarConfiguracao;

public class AtualizarConfiguracaoCommandHandler : ICommandHandler<AtualizarConfiguracaoCommand>
{
    private readonly INotificationContext _notificationContext;
    private readonly IConfiguracaoRepository _configuracaoRepository;
    private readonly IUnitOfWork _unitOfWork;

    public AtualizarConfiguracaoCommandHandler(
        INotificationContext notificationContext, 
        IConfiguracaoRepository configuracaoRepository, 
        IUnitOfWork unitOfWork)
    {
        _notificationContext = notificationContext;
        _configuracaoRepository = configuracaoRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task Handle(AtualizarConfiguracaoCommand request, CancellationToken cancellationToken)
    {
        var configuracao = await _configuracaoRepository.GetAsync(request.Key);

        var configuracaoAtualizada = configuracao
            .AtualizarInfos(request.ChaveGenerica, request.Valor)
            .NotificarFalhas(_notificationContext)
            .IsSuccess;

        if (configuracaoAtualizada)
        {
            _configuracaoRepository.Update(configuracao);
            await _unitOfWork.CommitAsync(cancellationToken);
        }
    }
}
