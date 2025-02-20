using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain.FormasEntrada.Entities;

namespace Anima.Inscricao.Domain.Links.Entities;

public class LinkFormaEntrada: AggregateEntity<LinkFormaEntradaId>, ISoftDelete
{
    protected LinkFormaEntrada()
    {
        FormaEntradaId = null!;
        Status = new Status();
    }

    public LinkFormaEntrada(FormaEntradaId formaEntradaId)
    {
        FormaEntradaId = formaEntradaId;
        Status = new Status();
    }

    public FormaEntradaId FormaEntradaId { get; protected set; }

    public Status Status { get; protected set; }

    public Audit Auditoria { get; protected set; } = new Audit();
}