using Anima.Inscricao.Application._Shared.Commands;
using Anima.Inscricao.Application._Shared.DTOs;
using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.IntegracaoSistemas;
using Anima.Inscricao.Domain.Turnos;
using Anima.Inscricao.Domain.Turnos.Entities;

namespace Anima.Inscricao.Application.UseCases.Turnos.CriarTurno;

public class CriarTurnoCommandHandler : ICommandHandler<CriarTurnoCommand, EntityKeyDto?>
{
    private readonly INotificationContext _notificationContext;
    private readonly ITurnoRepository _turnoRepository;
    private readonly IIntegracaoSistemaRepository _integracaoSistemaRepository;
    private readonly IUnitOfWork _unitOfWork;

    public CriarTurnoCommandHandler(
        INotificationContext notificationContext, 
        ITurnoRepository turnoRepository,
        IIntegracaoSistemaRepository integracaoSistemaRepository,
        IUnitOfWork unitOfWork)
    {
        _notificationContext = notificationContext;
        _turnoRepository = turnoRepository;
        _integracaoSistemaRepository = integracaoSistemaRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task<EntityKeyDto?> Handle(CriarTurnoCommand request, CancellationToken cancellationToken)
    {
        var turno = Turno
            .Criar(request.Nome)
            .NotificarFalhas(_notificationContext)
            .ObterRetorno();

        if (turno == null)
        {
            return null;
        }

        if (request.Integracao != null)
        {
            var sistema = await _integracaoSistemaRepository.GetAsync(s => s.Nome.ToUpper() == request.Integracao.NomeSistema.ToUpper());
            turno.AdicionarIntegracao(sistema.Id, request.Integracao.CodigoOrigem);
        }

        await _turnoRepository.InsertAsync(turno);

        await _unitOfWork.CommitAsync(cancellationToken);

        return new EntityKeyDto(turno.Key);
    }
}
