using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain.IntegracaoSistemas.Entities;

namespace Anima.Inscricao.Domain.Ofertas.Entities;

public class IntegracaoOferta : Entity<IntegracaoOfertaId>
{
    protected IntegracaoOferta()
    {
        IntegracaoSistemaId = 0;
        CodigoOrigem = string.Empty;
    }

    public IntegracaoOferta(IntegracaoSistemaId integracaoSistemaId, string codigoOrigem)
    {
        IntegracaoSistemaId = integracaoSistemaId;
        CodigoOrigem = codigoOrigem;
    }

        public IntegracaoSistemaId IntegracaoSistemaId { get; protected set; }

        public string CodigoOrigem { get; protected set; }
}