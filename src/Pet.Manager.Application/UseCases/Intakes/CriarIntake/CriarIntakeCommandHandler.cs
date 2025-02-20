using Anima.Inscricao.Application._Shared.Commands;
using Anima.Inscricao.Application._Shared.DTOs;
using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain._Shared.ValueObjects;
using Anima.Inscricao.Domain.Intakes;
using Anima.Inscricao.Domain.Intakes.Entities;
using Anima.Inscricao.Domain.IntegracaoSistemas;

namespace Anima.Inscricao.Application.UseCases.Intakes.CriarIntake;

public class CriarIntakeCommandHandler : ICommandHandler<CriarIntakeCommand, EntityKeyDto?>
{
    private readonly INotificationContext _notificationContext;
    private readonly IIntakeRepository _intakeRepository;
    private readonly IIntegracaoSistemaRepository _sistemasIntegracaoRepository;
    private readonly IUnitOfWork _unitOfWork;

    public CriarIntakeCommandHandler(
        INotificationContext notificationContext,
        IIntakeRepository intakeRepository,
        IIntegracaoSistemaRepository sistemasIntegracaoRepository,
        IUnitOfWork unitOfWork)
    {
        _notificationContext = notificationContext;
        _intakeRepository = intakeRepository;
        _sistemasIntegracaoRepository = sistemasIntegracaoRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task<EntityKeyDto?> Handle(CriarIntakeCommand request, CancellationToken cancellationToken)
    {
        var intake = Intake
            .Criar(request.Nome, new Vigencia(request.VigenciaInicio, request.VigenciaTermino))
            .NotificarFalhas(_notificationContext)
            .ObterRetorno();

        if (intake == null)
        {
            return null;
        }

        if (request.Integracao != null)
        {
            var sistema = await _sistemasIntegracaoRepository.GetAsync(s => s.Nome.ToUpper() == request.Integracao.NomeSistema.ToUpper());
            intake.AdicionarIntegracao(sistema.Id, request.Integracao.CodigoOrigem);
        }

        await _intakeRepository.InsertAsync(intake);

        await _unitOfWork.CommitAsync(cancellationToken);

        return new EntityKeyDto(intake.Key);
    }
}