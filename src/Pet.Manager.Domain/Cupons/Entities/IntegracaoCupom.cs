using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain.IntegracaoSistemas.Entities;

namespace Anima.Inscricao.Domain.Cupons.Entities;

public class IntegracaoCupom : Entity<IntegracamCupomId>
{
    protected IntegracaoCupom()
    {
        IntegracaoSistemaId = 0;
        CodigoOrigem = string.Empty;
    }

    public IntegracaoCupom(IntegracaoSistemaId integracaoSistemaId, string codigo)
    {
        IntegracaoSistemaId = integracaoSistemaId;
        CodigoOrigem = codigo;
    }

    public IntegracaoSistemaId IntegracaoSistemaId { get; protected set; }

    public string CodigoOrigem { get; protected set; }
}
