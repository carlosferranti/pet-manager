using Anima.Inscricao.Application._Shared.Commands;
using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.FormasEntrada;
using Anima.Inscricao.Domain.Links;

namespace Anima.Inscricao.Application.UseCases.Links.AtualizarLink;

public class AtualizarLinkCommandHandler : ICommandHandler<AtualizarLinkCommand>
{
    private readonly INotificationContext _notificationContext;
    private readonly ILinkRepository _linkRepository;
    private readonly IFormaEntradaRepository _formaEntradaRepository;
    private readonly IUnitOfWork _unitOfWork;

    public AtualizarLinkCommandHandler(
        INotificationContext notificationContext,
        ILinkRepository linkRepository,
        IFormaEntradaRepository formaEntradaRepository,
        IUnitOfWork unitOfWork)
    {
        _notificationContext = notificationContext;
        _linkRepository = linkRepository;
        _formaEntradaRepository = formaEntradaRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task Handle(AtualizarLinkCommand request, CancellationToken cancellationToken)
    {
        var link = await _linkRepository.GetAsync(request.Key);

        var linkAtualizado = link.AtualizarInfos(request.Nome)
           .NotificarFalhas(_notificationContext)
           .IsSuccess;

        if (!linkAtualizado)
        {
            return;
        }
        
        if(request.FormasEntrada != null)
        {
            var formasEntradaPersistida = link.FormasEntrada.Select(f => f.FormaEntradaId).ToList();
            foreach (var formaEntradaId in formasEntradaPersistida)
            {
                var formaEntrada = await _formaEntradaRepository.GetAsync(formaEntradaId);
                if (request.FormasEntrada?.Exists(x => x.Key == formaEntrada.Key) == true)
                {
                    link.RemoverFormaEntrada(formaEntradaId);
                }
            }

            foreach (var formaEntradaRequest in request.FormasEntrada)
            {
                var formaEntrada = await _formaEntradaRepository.GetAsync(formaEntradaRequest.Key);
                if (!link.FormasEntrada.Any(x => x.FormaEntradaId == formaEntrada.Id))
                {
                    link.AdicionarFormaEntrada(formaEntrada.Id);
                }
            }
        }

        _linkRepository.Update(link);

        await _unitOfWork.CommitAsync(cancellationToken);
    }
}