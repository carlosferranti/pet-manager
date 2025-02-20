using Anima.Inscricao.Domain._Shared.Entities;

namespace Anima.Inscricao.Domain.Concursos.Entities;

public record ConcursoId : EntityId
{
    protected ConcursoId() { }

    public ConcursoId(int concursoId)
        : base(concursoId) { }

    public static implicit operator ConcursoId(int id)
    {
        return new ConcursoId(id);
    }
    public static implicit operator int(ConcursoId concursoId)
    {
        return concursoId.Id;
    }
}
