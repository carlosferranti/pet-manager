using Anima.Inscricao.Application._Shared.Commands;
using Anima.Inscricao.Application._Shared.DTOs;
using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.IntegracaoSistemas;
using Anima.Inscricoes.Domain.Inscricoes;

namespace Anima.Inscricao.Application.UseCases.Inscricoes.CriarIntegracaoInscricaoCandidato;

public class CriarIntegracaoInscricaoCandidatoCommandHandler : ICommandHandler<CriarIntegracaoInscricaoCandidatoCommand, EntityKeyDto?>
{
    private readonly INotificationContext _notificationContext;
    private readonly IInscricaoRepository _inscricaoRepository;
    private readonly IIntegracaoSistemaRepository _integracaoSistemasRepository;
    private readonly IUnitOfWork _unitOfWork;

    public CriarIntegracaoInscricaoCandidatoCommandHandler(
        INotificationContext notificationContext,
        IInscricaoRepository inscricaoRepository,
        IIntegracaoSistemaRepository integracaoSistemasRepository,
        IUnitOfWork unitOfWork)
    {
        _notificationContext = notificationContext;
        _inscricaoRepository = inscricaoRepository;
        _integracaoSistemasRepository = integracaoSistemasRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task<EntityKeyDto?> Handle(CriarIntegracaoInscricaoCandidatoCommand request, CancellationToken cancellationToken)
    {
        var inscricao = await _inscricaoRepository.GetAsync(request.InscricaoCandidatoKey);

        var sistema = await _integracaoSistemasRepository.GetAsync(s => s.Nome.ToUpper() == request.Integracao.NomeSistema.ToUpper());

        var integracaoInserida = inscricao
            .AdicionarIntegracao(sistema.Id, request.Integracao.CodigoOrigem)
            .NotificarFalhas(_notificationContext)
            .IsSuccess;

        if (integracaoInserida)
        {
            _inscricaoRepository.Update(inscricao);
            await _unitOfWork.CommitAsync(cancellationToken);

            return new EntityKeyDto(inscricao.Key);
        }

        return null;
    }
}