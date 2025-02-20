using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain.IntegracaoSistemas.Entities;

namespace Anima.Inscricao.Domain.Concursos.Entities;

public class IntegracaoConcurso : Entity<IntegracaoConcursoId>
{
    protected IntegracaoConcurso()
    {
        IntegracaoSistemaId = 0;
        CodigoOrigem = string.Empty;
    }

    public IntegracaoConcurso(IntegracaoSistemaId integracaoSistemaId, string codigoOrigem)
        : base()
    {
        IntegracaoSistemaId = integracaoSistemaId;
        CodigoOrigem = codigoOrigem;
    }

    public IntegracaoSistemaId IntegracaoSistemaId { get; protected set; }

    public string CodigoOrigem { get; protected set; }
}
