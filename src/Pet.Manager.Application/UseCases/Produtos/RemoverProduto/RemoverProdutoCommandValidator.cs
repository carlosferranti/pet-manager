using Anima.Inscricao.Application._Shared.Validations;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Produtos;

using FluentValidation;

namespace Anima.Inscricao.Application.UseCases.Produtos.RemoverProduto;

public class RemoverProdutoCommandValidator : ApplicationRequestValidator<RemoverProdutoCommand>
{
    private readonly IProdutoRepository _produtoRepository;

    public RemoverProdutoCommandValidator(
        IProdutoRepository produtoRepository, 
        INotificationContext notificationContext) : base(notificationContext)
    {
        _produtoRepository = produtoRepository;

        RuleFor(x => x.Key)
            .NotEmpty().WithMessage("A chave do produto é obrigatória.")
            .MustAsync(ValidarProdutoExistenteAsync).WithMessage("A chave do produto não foi encontrada.");
    }

    private async Task<bool> ValidarProdutoExistenteAsync(Guid key, CancellationToken token = default)
    {
        return await _produtoRepository.ExistsAsync(key, token);
    }
}
