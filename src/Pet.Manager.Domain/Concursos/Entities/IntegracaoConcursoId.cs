using Anima.Inscricao.Domain._Shared.Entities;

namespace Anima.Inscricao.Domain.Concursos.Entities;

public record IntegracaoConcursoId : EntityId
{
    public IntegracaoConcursoId(int integracaoConcursoId)
        : base(integracaoConcursoId) { }

    public static implicit operator IntegracaoConcursoId(int id)
    {
        return new IntegracaoConcursoId(id);
    }
    public static implicit operator int(IntegracaoConcursoId integracaoConcursoId)
    {
        return integracaoConcursoId.Id;
    }
}