using Anima.Inscricao.Application._Shared.Commands;
using Anima.Inscricao.Application._Shared.DTOs;
using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Configuracoes;
using Anima.Inscricao.Domain.Configuracoes.Entities;

namespace Anima.Inscricao.Application.UseCases.Configuracoes.CriarConfiguracao;

public class CriarConfiguracaoCommandHandler : ICommandHandler<CriarConfiguracaoCommand, EntityKeyDto?>
{
    private readonly INotificationContext _notificationContext;
    private readonly IConfiguracaoRepository _configuracaoRepository;
    private readonly IUnitOfWork _unitOfWork;

    public CriarConfiguracaoCommandHandler(
        INotificationContext notificationContext,
        IConfiguracaoRepository configuracaoRepository,
        IUnitOfWork unitOfWork)
    {
        _notificationContext = notificationContext;
        _configuracaoRepository = configuracaoRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task<EntityKeyDto?> Handle(CriarConfiguracaoCommand request, CancellationToken cancellationToken)
    {
        var configuracao = Configuracao
            .Criar(request.ChaveGenerica, request.Valor)
            .NotificarFalhas(_notificationContext)
            .ObterRetorno();

        if (configuracao == null)
        {
            return null;
        }

        await _configuracaoRepository.InsertAsync(configuracao);

        await _unitOfWork.CommitAsync(cancellationToken);

        return new EntityKeyDto(configuracao.Key);
    }
}
