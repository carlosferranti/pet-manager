using Anima.Inscricao.Domain._Shared.Validations;
using Anima.Inscricao.Domain.Produtos.Entities;

namespace Anima.Inscricao.Domain.Produtos.Validators;

public class RemoverProdutoDomainValidator : DomainValidator
{
    public bool Validate(ProdutoId produtoId)
    {
        //TODO: Implementar validações de dominio para remoção do produto
        return true;
    }
}
