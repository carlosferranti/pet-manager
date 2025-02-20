using Anima.Inscricao.Application._Shared.Commands;
using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Marcas;

namespace Anima.Inscricao.Application.UseCases.Marcas.AtualizarMarca;

public class AtualizarMarcaCommandHandler :  ICommandHandler<AtualizarMarcaCommand>
{
    private readonly INotificationContext _notificationContext;
    private readonly IMarcaRepository _marcaRepository;
    private readonly IUnitOfWork _unitOfWork;

    public AtualizarMarcaCommandHandler(
        INotificationContext notificationContext, 
        IMarcaRepository marcaRepository, 
        IUnitOfWork unitOfWork)
    {
        _notificationContext = notificationContext;
        _marcaRepository = marcaRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task Handle(AtualizarMarcaCommand request, CancellationToken cancellationToken)
    {
        var marca = await _marcaRepository.GetAsync(request.Key);

        var marcaAtualizada = marca
            .AtualizarInfos(request.Nome, request.Sigla)
            .NotificarFalhas(_notificationContext)
            .IsSuccess;

        if (marcaAtualizada)
        {
            _marcaRepository.Update(marca);
            await _unitOfWork.CommitAsync(cancellationToken);
        }
    }
}
