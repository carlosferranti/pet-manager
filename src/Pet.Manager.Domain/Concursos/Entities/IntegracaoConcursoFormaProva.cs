using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain.IntegracaoSistemas.Entities;

namespace Anima.Inscricao.Domain.Concursos.Entities;

public class IntegracaoConcursoFormaProva : Entity<IntegracaoConcursoFormaProvaId>
{
    protected IntegracaoConcursoFormaProva()
    {
        IntegracaoSistemaId = 0;
        CodigoOrigem = string.Empty;
    }

    public IntegracaoConcursoFormaProva(IntegracaoSistemaId integracaoSistemaId, string codigoOrigem)
        : base()
    {
        IntegracaoSistemaId = integracaoSistemaId;
        CodigoOrigem = codigoOrigem;
    }

    public IntegracaoSistemaId IntegracaoSistemaId { get; protected set; }

    public string CodigoOrigem { get; protected set; }
}
