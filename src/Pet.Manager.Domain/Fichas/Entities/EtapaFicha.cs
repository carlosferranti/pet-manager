using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain.Etapas.Entities;

namespace Anima.Inscricao.Domain.Fichas.Entities;

public class EtapaFicha : Entity<EtapaFichaId>
{
    public EtapaFicha(EtapaTemplateId etapaTemplateId, int sequencia)
    {
        EtapaTemplateId = etapaTemplateId;
        Sequencia = sequencia;
    }

    protected EtapaFicha()
    {
        EtapaTemplateId = 0;
    }

    public EtapaTemplateId EtapaTemplateId { get; protected set; }

    public int Sequencia { get; protected set; }
}
