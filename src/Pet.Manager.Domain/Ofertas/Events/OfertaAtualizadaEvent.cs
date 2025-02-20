using System.Text.Json.Serialization;

using Anima.Inscricao.Domain._Shared.Entities.Events;
using Anima.Inscricao.Domain.Intakes.Entities;
using Anima.Inscricao.Domain.Produtos.Entities;

namespace Anima.Inscricao.Domain.Ofertas.Events;

public class OfertaAtualizadaEvent : EventNotification
{
    public OfertaAtualizadaEvent(Guid key, ProdutoId produtoId, IntakeId intakeId)
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
