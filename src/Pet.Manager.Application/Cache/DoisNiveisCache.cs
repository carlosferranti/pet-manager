using Anima.Componente.CustomDistributedCache.Extensions;
using Anima.Inscricao.Application.Cache.Persistence;
using Anima.Inscricao.Application.Config;

using Microsoft.Extensions.Caching.Distributed;

namespace Anima.Inscricao.Application.Cache;

public sealed class DoisNiveisCache<TChave, TValor> : BaseCache<TChave, TValor>
    where TChave : notnull
{
    private readonly SemaphoreSlim _lock = new(1, 1);

    private readonly Func<TChave, ValueTask<ResultadoBuscaCache<TValor>>> _funcaoBusca;
    private readonly IDistributedCache _cache;
    private readonly string _formatoChaveJobNivel1;
    private readonly string _formatoChaveJobNivel2;
    private readonly int _tempoExpiracaoEmSegundosNivel1;
    private readonly int _tempoExpiracaoEmSegundosNivel2;

    public DoisNiveisCache(
        IList<EventoBuscaCache<TChave>>? eventosCache,
        Func<TChave, ValueTask<ResultadoBuscaCache<TValor>>> funcaoBusca,
        IDistributedCache distributedCache,
        CacheConfig config,
        string cacheId,
        int tempoExpiracaoEmSegundos)
        : base(TipoCache.Redis, eventosCache)
    {
        const int FatorTempoExpiracaoEmSegundosN2 = 86400;
        var formatoNomeChaveItemNivel1 = cacheId + "_Nivel1_{0}";
        var formatoNomeChaveItemNivel2 = cacheId + "_Nivel2_{0}";

        _formatoChaveJobNivel1 = string.Format(config.Chave!, formatoNomeChaveItemNivel1);
        _formatoChaveJobNivel2 = string.Format(config.Chave!, formatoNomeChaveItemNivel2);
        _funcaoBusca = funcaoBusca;
        _tempoExpiracaoEmSegundosNivel1 = tempoExpiracaoEmSegundos;
        _tempoExpiracaoEmSegundosNivel2 = _tempoExpiracaoEmSegundosNivel1 + FatorTempoExpiracaoEmSegundosN2;
        _cache = distributedCache;
    }

    public override async ValueTask AdicionarAoCacheAsync(TChave chave, TValor valor)
    {
        var nomeChaveNivel1 = ObterChaveParaCache(_formatoChaveJobNivel1, chave);
        var nomeChaveNivel2 = ObterChaveParaCache(_formatoChaveJobNivel2, chave);

        try
        {
            await _lock.WaitAsync();
            await _cache.SetAsync(nomeChaveNivel1, valor, ObterOpcoesItemCacheNivel1());
            await _cache.SetAsync(nomeChaveNivel2, valor, ObterOpcoesItemCacheNivel2());
        }
        finally
        {
            _lock.Release();
        }
    }

    public override async ValueTask RemoverDoCacheAsync(TChave chave)
    {
        var nomeChaveNivel1 = ObterChaveParaCache(_formatoChaveJobNivel1, chave);
        var nomeChaveNivel2 = ObterChaveParaCache(_formatoChaveJobNivel2, chave);

        try
        {
            await _lock.WaitAsync();
            await _cache.RemoveAsync(nomeChaveNivel1);
            await _cache.RemoveAsync(nomeChaveNivel2);
        }
        finally
        {
            _lock.Release();
        }
    }

    public override async ValueTask<TValor?> BuscarAsync(TChave chave)
    {
        var nomeChave = ObterChaveParaCache(_formatoChaveJobNivel1, chave);

        TValor? item;

        try
        {
            await _lock.WaitAsync();

            item = await _cache.GetAsync<TValor?>(nomeChave);

            if (item != null)
            {
                const int nivel1 = 1;
                AdicionarRetornoCacheControle(chave, nivel1);

                return item;
            }
        }
        finally
        {
            _lock.Release();
        }

        nomeChave = ObterChaveParaCache(_formatoChaveJobNivel2, chave);

        item = await _cache.GetAsync<TValor?>(nomeChave);

        if (item != null)
        {
            const int nivel2 = 2;
            AdicionarRetornoCacheControle(chave, nivel2);

            var resultadoNivel2Atualizado = await BuscarItemBancoAsync(chave);

            return resultadoNivel2Atualizado.Resultado!;
        }

        var busca = await BuscarItemBancoAsync(chave);

        if (busca.Encontrado)
        {
            item = busca.Resultado!;
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

    private async Task<ResultadoBuscaCache<TValor>> BuscarItemBancoAsync(TChave chave)
    {
        var busca = await _funcaoBusca(chave);
        AdicionarChaveBuscadaControle(chave);

        if (busca.Encontrado)
        {
            await AdicionarAoCacheAsync(chave, busca.Resultado!);
        }

        return busca;
    }

    private DistributedCacheEntryOptions ObterOpcoesItemCacheNivel1() =>
        new()
        {
            AbsoluteExpirationRelativeToNow = TimeSpan.FromSeconds(_tempoExpiracaoEmSegundosNivel1),
        };

    private DistributedCacheEntryOptions ObterOpcoesItemCacheNivel2() =>
        new()
        {
            AbsoluteExpirationRelativeToNow = TimeSpan.FromSeconds(_tempoExpiracaoEmSegundosNivel2),
        };
}
