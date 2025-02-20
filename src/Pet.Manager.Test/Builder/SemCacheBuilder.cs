using Anima.Inscricao.Application.Cache;
using Anima.Inscricao.Application.Cache.Persistence;

namespace Anima.Inscricao.Test.Builder;

internal sealed class SemCacheBuilder<TChave, TValor> : CacheBuilder<TChave, TValor>
    where TChave : notnull
{
    public SemCacheBuilder()
        : base(null, null, null)
    {
        ComTipoCache(TipoCache.Nenhum);
    }

    public override ICacheBuilder<TChave, TValor> ComTipoCache(TipoCache? tipoCache)
    {
        return this;
    }
}

