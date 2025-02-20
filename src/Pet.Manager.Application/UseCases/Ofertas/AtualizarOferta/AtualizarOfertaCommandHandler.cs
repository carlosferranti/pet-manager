using Anima.Inscricao.Application._Shared.Commands;
using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Intakes;
using Anima.Inscricao.Domain.Ofertas;
using Anima.Inscricao.Domain.Produtos;

namespace Anima.Inscricao.Application.UseCases.Ofertas.AtualizarOferta;

public class AtualizarOfertaCommandHandler : ICommandHandler<AtualizarOfertaCommand>
{
    private readonly INotificationContext _notificationContext;
    private readonly IOfertaRepository _ofertaRepository;
    private readonly IProdutoRepository _produtoRepository;
    private readonly IIntakeRepository _intakeRepository;
    private readonly IUnitOfWork _unitOfWork;

    public AtualizarOfertaCommandHandler(
        INotificationContext notificationContext, 
        IOfertaRepository ofertaRepository, 
        IProdutoRepository produtoRepository, 
        IIntakeRepository intakeRepository, 
        IUnitOfWork unitOfWork)
    {
        _notificationContext = notificationContext;
        _ofertaRepository = ofertaRepository;
        _produtoRepository = produtoRepository;
        _intakeRepository = intakeRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task Handle(AtualizarOfertaCommand request, CancellationToken cancellationToken)
    {
        var produto = await _produtoRepository.GetAsync(request.ProdutoKey);

        var intake = await _intakeRepository.GetAsync(request.IntakeKey);

        var oferta = await _ofertaRepository.GetAsync(request.Key);

        var ofertaAtualizada = oferta.AtualizarInfos(produto.Id, intake.Id)
            .NotificarFalhas(_notificationContext)
            .IsSuccess;

        if (ofertaAtualizada)
        {
            _ofertaRepository.Update(oferta);
            await _unitOfWork.CommitAsync(cancellationToken);
        }

    }
}
