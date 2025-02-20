using Anima.Inscricao.Application._Shared.Commands;
using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Enderecos;

namespace Anima.Inscricao.Application.UseCases.Enderecos.AtualizarCidade;

public class AtualizarCidadeCommandHandler : ICommandHandler<AtualizarCidadeCommand>
{
    private readonly INotificationContext _notificationContext;
    private readonly ICidadeRepository _cidadeRepository;
    private readonly IEstadoRepository _estadoRepository;
    private readonly IUnitOfWork _unitOfWork;

    public AtualizarCidadeCommandHandler(
        INotificationContext notificationContext,
        ICidadeRepository cidadeRepository,
        IEstadoRepository estadoRepository,
        IUnitOfWork unitOfWork)
    {
        _notificationContext = notificationContext;
        _cidadeRepository = cidadeRepository;
        _estadoRepository = estadoRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task Handle(AtualizarCidadeCommand request, CancellationToken cancellationToken)
    {
        var estado = await _estadoRepository.GetAsync(request.EstadoKey);

        var cidade = await _cidadeRepository.GetAsync(request.Key);

        var cidadeAtualizada = cidade
            .AtualizarInfos(request.Nome, estado.Id, request.Ddd, request.CodigoMunicipio)
            .NotificarFalhas(_notificationContext)
            .IsSuccess;

        if (cidadeAtualizada)
        {
            _cidadeRepository.Update(cidade);
            await _unitOfWork.CommitAsync(cancellationToken);
        }
    }
}