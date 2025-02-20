using Anima.Inscricao.Domain._Shared.Entities.Events;
using Anima.Inscricao.Domain.Intakes.Entities;
using Anima.Inscricao.Domain.Produtos.Entities;
using System.Text.Json.Serialization;

namespace Anima.Inscricao.Domain.Ofertas.Events;

public class OfertaCriadaEvent : EventNotification
{
    public OfertaCriadaEvent(Guid key, ProdutoId produtoId, IntakeId intakeId)
    {
        Key = key;
        ProdutoId = produtoId;
        IntakeId = intakeId;
    }

    public Guid Key { get; }

    [JsonIgnore]
    public ProdutoId ProdutoId { get; }

    [JsonIgnore]
    public IntakeId IntakeId { get; }
}
