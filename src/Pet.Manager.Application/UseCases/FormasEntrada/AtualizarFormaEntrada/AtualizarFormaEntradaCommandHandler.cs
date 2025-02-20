using Anima.Inscricao.Application._Shared.Commands;
using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.FormasEntrada;
using Anima.Inscricao.Domain.FormasEntrada.Entities;

namespace Anima.Inscricao.Application.UseCases.FormasEntrada.AtualizarFormaEntrada;

public class AtualizarFormaEntradaCommandHandler : ICommandHandler<AtualizarFormaEntradaCommand>
{
    private readonly INotificationContext _notificationContext;
    private readonly IFormaEntradaRepository _formaEntradaRepository;
    private readonly IUnitOfWork _unitOfWork;

    public AtualizarFormaEntradaCommandHandler(
        INotificationContext notificationContext,
        IFormaEntradaRepository formaEntradaRepository,
        IUnitOfWork unitOfWork)
    {
        _notificationContext = notificationContext;
        _formaEntradaRepository = formaEntradaRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task Handle(AtualizarFormaEntradaCommand request, CancellationToken cancellationToken)
    {
        var formaEntrada = await _formaEntradaRepository.GetAsync(request.Key);

        FormaEntrada? formaEntradaPai = null;

        if (request.FormaEntradaPaiKey.HasValue)
        {
            formaEntradaPai = await _formaEntradaRepository.GetAsync(request.FormaEntradaPaiKey.Value);
        }

        var formaEntradaAtualizada = formaEntrada
            .AtualizarInfos(request.Nome, request.Descricao, request.OrdemExibicao, request.ExibeCard!.Value, formaEntradaPai?.Id, request.UltimoNivel)
            .NotificarFalhas(_notificationContext)
            .IsSuccess;

        if (formaEntradaAtualizada)
        {
            _formaEntradaRepository.Update(formaEntrada);
            await _unitOfWork.CommitAsync(cancellationToken);
        }
    }
}