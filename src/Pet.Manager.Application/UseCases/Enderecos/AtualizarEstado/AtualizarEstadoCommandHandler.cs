using Anima.Inscricao.Application._Shared.Commands;
using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Enderecos;

namespace Anima.Inscricao.Application.UseCases.Enderecos.AtualizarEstado;

public class AtualizarEstadoCommandHandler : ICommandHandler<AtualizarEstadoCommand>
{
    private readonly INotificationContext _notificationContext;
    private readonly IPaisRepository _paisRepository;
    private readonly IEstadoRepository _estadoRepository;
    private readonly IUnitOfWork _unitOfWork;

    public AtualizarEstadoCommandHandler(
        INotificationContext notificationContext,
        IPaisRepository paisRepository,
        IEstadoRepository estadoRepository,
        IUnitOfWork unitOfWork)
    {
        _notificationContext = notificationContext;
        _paisRepository = paisRepository;
        _estadoRepository = estadoRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task Handle(AtualizarEstadoCommand request, CancellationToken cancellationToken)
    {
        var pais = await _paisRepository.GetAsync(request.PaisKey);

        var estado = await _estadoRepository.GetAsync(request.Key);

        var estadoAtualizado = estado
            .AtualizarInfos(request.Nome, request.Sigla, pais.Id)
            .NotificarFalhas(_notificationContext)
            .IsSuccess;

        if (estadoAtualizado)
        {
            _estadoRepository.Update(estado);
            await _unitOfWork.CommitAsync(cancellationToken);
        }
    }
}

