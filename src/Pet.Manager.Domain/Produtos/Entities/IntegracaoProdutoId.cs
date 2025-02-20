using Anima.Inscricao.Domain._Shared.Entities;

namespace Anima.Inscricao.Domain.Produtos.Entities
{
    public record IntegracaoProdutoId : EntityId
    {
        public IntegracaoProdutoId(int integracaoProdutoId)
            : base(integracaoProdutoId) { }

        public static implicit operator IntegracaoProdutoId(int id)
        {
            return new IntegracaoProdutoId(id);
        }

        public static implicit operator int(IntegracaoProdutoId integracaoProdutoId)
        {
            return integracaoProdutoId.Id;
        }
    }
}
