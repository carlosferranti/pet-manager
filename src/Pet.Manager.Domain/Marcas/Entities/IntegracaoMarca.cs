using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain.IntegracaoSistemas.Entities;

namespace Anima.Inscricao.Domain.Marcas.Entities;

public class IntegracaoMarca : Entity<IntegracaoMarcaId>
{

    protected IntegracaoMarca()
    {
        IntegracaoSistemaId = 0;
        CodigoOrigem = string.Empty;
    }

    public IntegracaoMarca(IntegracaoSistemaId integracaoSistemaId, string codigo)
    {
        IntegracaoSistemaId = integracaoSistemaId;
        CodigoOrigem = codigo;
    }

    public IntegracaoSistemaId IntegracaoSistemaId { get; protected set; }

    public string CodigoOrigem { get; protected set; }
}
