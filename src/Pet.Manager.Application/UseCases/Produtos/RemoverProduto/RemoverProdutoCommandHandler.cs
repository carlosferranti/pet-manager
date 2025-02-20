using Anima.Inscricao.Application._Shared.Commands;
using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Produtos;

namespace Anima.Inscricao.Application.UseCases.Produtos.RemoverProduto;

public class RemoverProdutoCommandHandler : ICommandHandler<RemoverProdutoCommand>
{
    public readonly INotificationContext _notificationContext;
    public readonly IProdutoRepository _produtoRepository;
    public readonly IUnitOfWork _unitOfWork;

    public RemoverProdutoCommandHandler(
        INotificationContext notificationContext, 
        IProdutoRepository produtoRepository, 
        IUnitOfWork unitOfWork)
    {
        _notificationContext = notificationContext;
        _produtoRepository = produtoRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task Handle(RemoverProdutoCommand request, CancellationToken cancellationToken)
    {
        var produto = await _produtoRepository.GetAsync(request.Key);

        var produtoRemovido = produto.Remover()
            .NotificarFalhas(_notificationContext)
            .IsSuccess;
        if (produtoRemovido)
        {
            _produtoRepository.Delete(produto);
            await _unitOfWork.CommitAsync(cancellationToken);
        }
    }
}
