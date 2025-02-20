namespace Anima.Inscricao.Domain._Shared.Entities;

public class Audit
{
    public Audit()
    {
        CriadoEm = DateTime.UtcNow;
        AlteradoEm = DateTime.UtcNow;
    }

    public DateTimeOffset? CriadoEm { get; protected set; }
    public DateTimeOffset? AlteradoEm { get; protected set; }

    public void AtualizarAuditoria()
    {
        AlteradoEm = DateTime.UtcNow;
    }
}


