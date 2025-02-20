using Anima.Inscricao.Domain._Shared.Entities.Events;

namespace Anima.Inscricao.Domain.Produtos.Events
{
    public class ProdutoRemovidoEvent : EventNotification
    {
        public ProdutoRemovidoEvent(Guid key)
        {
            Key = key;
        }

        public Guid Key { get; }
    }
}
