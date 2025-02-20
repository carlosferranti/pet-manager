using Anima.Inscricao.Application._Shared.Commands;
using Anima.Inscricao.Application._Shared.DTOs;
using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.FormasEntrada;
using Anima.Inscricao.Domain.Links;
using Anima.Inscricao.Domain.Links.Entities;

namespace Anima.Inscricao.Application.UseCases.Links.CriarLink;

public class CriarLinkCommandHandler : ICommandHandler<CriarLinkCommand, EntityKeyDto?>
{
    private readonly INotificationContext _notificationContext;
    private readonly ILinkRepository _linkRepository;
    private readonly IFormaEntradaRepository _formaEntradaRepository;
    private readonly IUnitOfWork _unitOfWork;

    public CriarLinkCommandHandler(
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

    public async Task<EntityKeyDto?> Handle(CriarLinkCommand request, CancellationToken cancellationToken)
    {
        var link = Link
            .Criar(request.Nome)
            .NotificarFalhas(_notificationContext)
            .ObterRetorno();

        if (link == null)
        {
            return null;
        }

        if(request.FormasEntrada != null)
        {
            foreach (var formaEntradaRequest in request.FormasEntrada)
            {
                var formaEntrada = await _formaEntradaRepository.GetAsync(formaEntradaRequest.Key);
                link.AdicionarFormaEntrada(formaEntrada.Id);
            }
        }
        
        await _linkRepository.InsertAsync(link);

        await _unitOfWork.CommitAsync(cancellationToken);

        return new EntityKeyDto(link.Key);
    }
}