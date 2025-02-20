using Anima.Inscricao.Domain._Shared.Entities;

namespace Anima.Inscricao.Domain.Concursos.Entities;

public record ConcursoFormaEntradaId : EntityId
{
    public ConcursoFormaEntradaId(int concursoFormaEntradaId)
        : base(concursoFormaEntradaId) { }

    public static implicit operator ConcursoFormaEntradaId(int id)
    {
        return new ConcursoFormaEntradaId(id);
    }
    public static implicit operator int(ConcursoFormaEntradaId concursoFormaEntradaId)
    {
        return concursoFormaEntradaId.Id;
    }
}