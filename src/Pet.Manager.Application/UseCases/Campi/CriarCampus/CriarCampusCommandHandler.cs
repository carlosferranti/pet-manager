using Anima.Inscricao.Application._Shared.Commands;
using Anima.Inscricao.Application._Shared.DTOs;
using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Campi;
using Anima.Inscricao.Domain.Campi.Entities;
using Anima.Inscricao.Domain.IntegracaoSistemas;

namespace Anima.Inscricao.Application.UseCases.Campi.CriarCampus;

public class CriarCampusCommandHandler : ICommandHandler<CriarCampusCommand, EntityKeyDto?>
{
    private readonly INotificationContext _notificationContext;
    private readonly ICampusRepository _campusRepository;
    private readonly IIntegracaoSistemaRepository _sistemasIntegracaoRepository;
    private readonly IUnitOfWork _unitOfWork;

    public CriarCampusCommandHandler(
        INotificationContext notificationContext, 
        ICampusRepository campusRepository, 
        IIntegracaoSistemaRepository sistemasIntegracaoRepository, 
        IUnitOfWork unitOfWork)
    {
        _notificationContext = notificationContext;
        _campusRepository = campusRepository;
        _sistemasIntegracaoRepository = sistemasIntegracaoRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task<EntityKeyDto?> Handle(CriarCampusCommand request, CancellationToken cancellationToken)
    {
        IntegracaoCampus? integracaoCampus = null;
        if (request.Integracao != null)
        {
            var sistema = await _sistemasIntegracaoRepository.GetAsync(s => s.Nome.ToUpper() == request.Integracao.NomeSistema.ToUpper());
            integracaoCampus = new IntegracaoCampus(sistema.Id, request.Integracao.CodigoOrigem);
        }

        var campus = Campus
            .Criar(request.Nome, request.NomeComercial, integracaoCampus)
            .NotificarFalhas(_notificationContext)
            .ObterRetorno();

        if (campus == null)
        {
            return null;
        }

        await _campusRepository.InsertAsync(campus);

        await _unitOfWork.CommitAsync(cancellationToken);

        return new EntityKeyDto(campus.Key);
    }
}
