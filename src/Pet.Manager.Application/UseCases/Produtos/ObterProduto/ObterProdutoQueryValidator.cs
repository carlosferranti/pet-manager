using Anima.Inscricao.Application._Shared.Validations;
using Anima.Inscricao.Application.DTOs.Produtos;
using Anima.Inscricao.Domain._Shared.Notifications;
using Anima.Inscricao.Domain.Produtos;

using FluentValidation;

namespace Anima.Inscricao.Application.UseCases.Produtos.ObterProduto;

public class ObterProdutoQueryValidator : ApplicationRequestValidator<ObterProdutoQuery, ProdutoDto>
{
    private readonly IProdutoRepository _produtoRepository;

    public ObterProdutoQueryValidator(
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
