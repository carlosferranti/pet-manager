using Anima.Inscricao.Domain._Shared.Entities;

namespace Anima.Inscricao.Domain.Concursos.Entities;

public record IntegracaoConcursoFormaProvaId : EntityId
{
    public IntegracaoConcursoFormaProvaId(int integracaoConcursoFormaProvaId)
        : base(integracaoConcursoFormaProvaId) { }

    public static implicit operator IntegracaoConcursoFormaProvaId(int id)
    {
        return new IntegracaoConcursoFormaProvaId(id);
    }
    public static implicit operator int(IntegracaoConcursoFormaProvaId integracaoConcursoFormaProvaId)
    {
        return integracaoConcursoFormaProvaId.Id;
    }
}
