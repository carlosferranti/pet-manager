using Anima.Inscricao.Domain._Shared.Entities;

namespace Anima.Inscricao.Domain.Etapas.Entities;

public record EtapaTemplateId : EntityId
{
    public EtapaTemplateId(int etapaTemplateId)
        : base(etapaTemplateId) { }

    public static implicit operator EtapaTemplateId(int id)
    {
        return new EtapaTemplateId(id);
    }
    public static implicit operator int(EtapaTemplateId etapaTemplateId)
    {
        return etapaTemplateId.Id;
    }
}
