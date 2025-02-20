using Anima.Inscricao.Application._Shared.Commands;
using Anima.Inscricao.Application._Shared.DTOs;
using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Deficiencias;
using Anima.Inscricao.Domain.Deficiencias.Entities;
using Anima.Inscricao.Domain.IntegracaoSistemas;

namespace Anima.Inscricao.Application.UseCases.Deficiencias.CriarDeficiencia;

public class CriarDeficienciaCommandHandler : ICommandHandler<CriarDeficienciaCommand, EntityKeyDto?>
{
    private readonly INotificationContext _notificationContext;
    private readonly IDeficienciaRepository _deficienciaRepository;
    private readonly IIntegracaoSistemaRepository _sistemasIntegracaoRepository;
    private readonly IUnitOfWork _unitOfWork;

    public CriarDeficienciaCommandHandler(
        INotificationContext notificationContext,
        IDeficienciaRepository deficienciaRepository,
        IIntegracaoSistemaRepository sistemasIntegracaoRepository,
        IUnitOfWork unitOfWork)
    {
        _notificationContext = notificationContext;
        _deficienciaRepository = deficienciaRepository;
        _sistemasIntegracaoRepository = sistemasIntegracaoRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task<EntityKeyDto?> Handle(CriarDeficienciaCommand request, CancellationToken cancellationToken)
    {
        var deficiencia = Deficiencia
            .Criar(request.Nome, request.OrdemExibicao)
            .NotificarFalhas(_notificationContext)
            .ObterRetorno();

        if (deficiencia == null)
        {
            return null;
        }

        if (request.Integracao != null)
        {
            var sistema = await _sistemasIntegracaoRepository.GetAsync(s => s.Nome.ToUpper() == request.Integracao.NomeSistema.ToUpper());
            deficiencia.AdicionarIntegracao(sistema.Id, request.Integracao.CodigoOrigem);
        }

        await _deficienciaRepository.InsertAsync(deficiencia);

        await _unitOfWork.CommitAsync(cancellationToken);

        return new EntityKeyDto(deficiencia.Key);
    }
}
