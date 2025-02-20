using Anima.Inscricao.Application._Shared.Commands;
using Anima.Inscricao.Application._Shared.DTOs;
using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.IntegracaoSistemas;
using Anima.Inscricao.Domain.TiposFormacao;
using Anima.Inscricao.Domain.TiposFormacao.Entities;

namespace Anima.Inscricao.Application.UseCases.TiposFormacao.CriarTipoFormacao;

public class CriarTipoFormacaoCommandHandler : ICommandHandler<CriarTipoFormacaoCommand, EntityKeyDto?>
{
    private readonly INotificationContext _notificationContext;
    private readonly ITipoFormacaoRepository _tipoFormacaoRepository;
    private readonly IIntegracaoSistemaRepository _sistemasIntegracaoRepository;
    private readonly IUnitOfWork _unitOfWork;

    public CriarTipoFormacaoCommandHandler(
        INotificationContext notificationContext,
        ITipoFormacaoRepository tipoFormacaoRepository,
        IIntegracaoSistemaRepository integracaoSistemaRepository,
        IUnitOfWork unitOfWork)
    {
        _notificationContext = notificationContext;
        _tipoFormacaoRepository = tipoFormacaoRepository;
        _sistemasIntegracaoRepository = integracaoSistemaRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task<EntityKeyDto?> Handle(CriarTipoFormacaoCommand request, CancellationToken cancellationToken)
    {
        var tipoFormacao = TipoFormacao
            .Criar(request.Nome)
            .NotificarFalhas(_notificationContext)
            .ObterRetorno();

        if (tipoFormacao == null)
        {
            return null;
        }

        if (request.Integracao != null)
        {
            var sistema = await _sistemasIntegracaoRepository.GetAsync(s => s.Nome.ToUpper() == request.Integracao.NomeSistema.ToUpper());
            tipoFormacao.AdicionarIntegracao(sistema.Id, request.Integracao.CodigoOrigem);
        }

        await _tipoFormacaoRepository.InsertAsync(tipoFormacao);

        await _unitOfWork.CommitAsync(cancellationToken);

        return new EntityKeyDto(tipoFormacao.Key);
    }
}