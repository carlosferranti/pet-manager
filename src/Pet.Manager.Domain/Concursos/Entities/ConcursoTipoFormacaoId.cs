using Anima.Inscricao.Domain._Shared.Entities;

namespace Anima.Inscricao.Domain.Concursos.Entities;

public record ConcursoTipoFormacaoId : EntityId
{
    public ConcursoTipoFormacaoId(int concursoTipoFormacaoId)
        : base(concursoTipoFormacaoId) { }

    public static implicit operator ConcursoTipoFormacaoId(int id)
    {
        return new ConcursoTipoFormacaoId(id);
    }
    public static implicit operator int(ConcursoTipoFormacaoId concursoTipoFormacaoId)
    {
        return concursoTipoFormacaoId.Id;
    }
}
