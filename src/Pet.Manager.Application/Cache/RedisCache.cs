using Anima.Componente.CustomDistributedCache.Extensions;
using Anima.Inscricao.Application.Cache.Persistence;
using Anima.Inscricao.Application.Config;

using Microsoft.Extensions.Caching.Distributed;

namespace Anima.Inscricao.Application.Cache;

public sealed class RedisCache<TChave, TValor> : BaseCache<TChave, TValor>
    where TChave : notnull
{
    private readonly SemaphoreSlim _lock = new(1, 1);

    private readonly Func<TChave, ValueTask<ResultadoBuscaCache<TValor>>> _funcaoBusca;
    private readonly IDistributedCache _cache;
    private readonly string _formatoChaveJob;
    private readonly int _tempoExpiracaoEmSegundos;

    public RedisCache(
        IList<EventoBuscaCache<TChave>>? eventosCache,
        Func<TChave, ValueTask<ResultadoBuscaCache<TValor>>> funcaoBusca,
        IDistributedCache distributedCache,
        CacheConfig config,
        string cacheId,
        int tempoExpiracaoEmSegundos)
        : base(TipoCache.Redis, eventosCache)
    {
        var formatoNomeChaveItem = cacheId + "_{0}";

        _formatoChaveJob = string.Format(config.Chave!, formatoNomeChaveItem);
        _funcaoBusca = funcaoBusca;
        _tempoExpiracaoEmSegundos = tempoExpiracaoEmSegundos;
        _cache = distributedCache;
    }

    public override async ValueTask AdicionarAoCacheAsync(TChave chave, TValor valor)
    {
        var nomeChave = ObterChaveParaCache(_formatoChaveJob, chave);

        try
        {
            await _lock.WaitAsync();
            await _cache.SetAsync(nomeChave, valor, ObterOpcoesItemCache());
        }
        finally
        {
            _lock.Release();
        }
    }

    public override async ValueTask RemoverDoCacheAsync(TChave chave)
    {
        var nomeChave = ObterChaveParaCache(_formatoChaveJob, chave);

        try
        {
            await _lock.WaitAsync();
            await _cache.RemoveAsync(nomeChave);
        }
        finally
        {
            _lock.Release();
        }
    }

    public override async ValueTask<TValor?> BuscarAsync(TChave chave)
    {
        var nomeChave = ObterChaveParaCache(_formatoChaveJob, chave);

        TValor? item;

        try
        {
            await _lock.WaitAsync();

            item = await _cache.GetAsync<TValor?>(nomeChave);

            if (item != null)
            {
                AdicionarRetornoCacheControle(chave);
                return item;
            }
        }
        finally
        {
            _lock.Release();
        }

        var busca = await _funcaoBusca(chave);
        AdicionarChaveBuscadaControle(chave);

        if (busca.Encontrado)
        {
            item = busca.Resultado!;
            await AdicionarAoCacheAsync(chave, item);
        }

        return item;
    }

    protected override void Dispose(bool disposing)
    {
        if (IsDisposed)
        {
            return;
        }

        base.Dispose(disposing);

        if (disposing)
        {
            _lock.Dispose();
        }
    }

    private DistributedCacheEntryOptions ObterOpcoesItemCache() =>
        new()
        {
            AbsoluteExpirationRelativeToNow = TimeSpan.FromSeconds(_tempoExpiracaoEmSegundos),
        };
}
