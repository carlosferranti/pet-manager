using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain.FormasEntrada.Entities;

namespace Anima.Inscricao.Domain.Concursos.Entities;

public class ConcursoFormaEntrada : Entity<ConcursoFormaEntradaId>
{
    protected ConcursoFormaEntrada()
    {
        FormaEntradaId = 0;
    }

    public ConcursoFormaEntrada(FormaEntradaId formaEntradaId)
        : base()
    {
        FormaEntradaId = formaEntradaId;
    }

    public FormaEntradaId FormaEntradaId { get; protected set; }
}