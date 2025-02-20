using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain.IntegracaoSistemas.Entities;

namespace Anima.Inscricao.Domain.Produtos.Entities
{
    public class IntegracaoProduto : Entity<IntegracaoProdutoId>
    {
        public IntegracaoProduto()
        {
            IntegracaoSistemaId = 0;
            CodigoOrigem = string.Empty;
        }

        public IntegracaoProduto(IntegracaoSistemaId integracaoSistemaId, string codigoOrigem)
            : base()
        {
            IntegracaoSistemaId = integracaoSistemaId;
            CodigoOrigem = codigoOrigem;
        }

        public IntegracaoSistemaId IntegracaoSistemaId { get; protected set; }

        public string CodigoOrigem { get; protected set; }
    }
}
