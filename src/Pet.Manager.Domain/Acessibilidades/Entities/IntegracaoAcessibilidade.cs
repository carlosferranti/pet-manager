using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain.IntegracaoSistemas.Entities;

namespace Anima.Inscricao.Domain.Acessibilidades.Entities;

public class IntegracaoAcessibilidade : AggregateEntity<EntityId>
{
    protected IntegracaoAcessibilidade()
    {
        IntegracaoSistemaId = 0;
        CodigoOrigem = string.Empty;
    }

    public IntegracaoAcessibilidade(IntegracaoSistemaId integracaoSistemaId, string codigo)
    {
        IntegracaoSistemaId = integracaoSistemaId;
        CodigoOrigem = codigo;
    }

    public IntegracaoSistemaId IntegracaoSistemaId { get; protected set; }

    public string CodigoOrigem { get; protected set; }
}
