using Anima.Inscricao.Application.Cache.Persistence;
using Anima.Inscricao.Application.Config;

using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;

namespace Anima.Inscricao.Application.Cache;

public sealed class MemoriaCache<TChave, TValor> : BaseCache<TChave, TValor>
    where TChave : notnull
{
    private readonly SemaphoreSlim _lock = new(1, 1);

    private readonly Func<TChave, ValueTask<ResultadoBuscaCache<TValor>>> _funcaoBusca;
    private readonly IMemoryCache _memoryCache;
    private readonly string _formatoChaveJob;
    private readonly int _tempoExpiracaoEmSegundos;

    public MemoriaCache(
        IList<EventoBuscaCache<TChave>>? eventosCache,
        Func<TChave, ValueTask<ResultadoBuscaCache<TValor>>> funcaoBusca,
        IMemoryCache cache,
        CacheConfig config,
        string cacheId,
        int tempoExpiracaoEmSegundos)
        : base(TipoCache.Memoria, eventosCache)
    {
        var formatoNomeChaveItem = cacheId + "_{0}";

        _formatoChaveJob = string.Format(config.Chave!, formatoNomeChaveItem);
        _funcaoBusca = funcaoBusca;
        _tempoExpiracaoEmSegundos = tempoExpiracaoEmSegundos;
        _memoryCache = cache;
    }

    public override async ValueTask AdicionarAoCacheAsync(TChave chave, TValor valor)
    {
        var nomeChave = ObterChaveParaCache(_formatoChaveJob, chave);

        try
        {
            await _lock.WaitAsync();
            _memoryCache.Set(nomeChave, valor, ObterOpcoesItemCache());
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
            _memoryCache.Remove(nomeChave);
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

            item = _memoryCache.Get<TValor?>(nomeChave);

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
            _memoryCache.Dispose();
        }
    }

    private MemoryCacheEntryOptions ObterOpcoesItemCache() =>
        new()
        {
            AbsoluteExpirationRelativeToNow = TimeSpan.FromSeconds(_tempoExpiracaoEmSegundos),
        };
}
