using Anima.Inscricao.Domain._Shared.Entities;

namespace Anima.Inscricao.Domain.Configuracoes.Entities;

public record ConfiguracaoId : EntityId
{
    public ConfiguracaoId(int configuracaoId)
        : base(configuracaoId) { }

    public static implicit operator ConfiguracaoId(int id)
    {
        return new ConfiguracaoId(id);
    }
    public static implicit operator int(ConfiguracaoId configuracaoId)
    {
        return configuracaoId.Id;
    }
}
