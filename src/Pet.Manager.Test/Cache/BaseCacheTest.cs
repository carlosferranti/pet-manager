using Anima.Inscricao.Application.Cache;
using Anima.Inscricao.Application.Cache.Persistence;
using Anima.Inscricao.Application.Config;
using Anima.Inscricao.Test.Builder;

using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Options;

namespace Anima.Inscricao.Test.Cache;

public abstract class BaseCacheTest
{
    private protected static readonly string _existente = nameof(_existente);
    private protected static readonly string _naoExistente = nameof(_naoExistente);
    private protected static readonly SemaphoreSlim _semaforo = new(1, 1);

    protected BaseCacheTest()
    {
    }

    protected static async ValueTask ExecutarComSemaforoAsync(Func<ValueTask> acao)
    {
        try
        {
            await _semaforo.WaitAsync();
            await acao();
        }
        finally
        {
            _semaforo.Release();
        }
    }

    private protected static BaseCache<T, string> CriarSemCache<T>(
        Func<T, ValueTask<ResultadoBuscaCache<string>>> funcaoBusca,
        string? id = null)
        where T : notnull
    {
        var builder = new SemCacheBuilder<T, string>();
        return PrepararECriarCache(builder, funcaoBusca, 0, id);
    }

    private protected static BaseCache<T, string> CriarMemoriaCache<T>(
        Func<T, ValueTask<ResultadoBuscaCache<string>>> funcaoBusca,
        bool cacheFuncional,
        int ttlEmSegundos = 10,
        string? id = null)
        where T : notnull
    {
        var config = new CacheConfig() { Chave = "teste_{0}" };

        var builder = new CacheBuilder<T, string>(
                null,
                CriarCacheMemoriaMock(cacheFuncional),
                Options.Create(config))
            .ComTipoCache(TipoCache.Memoria);

        return PrepararECriarCache(builder, funcaoBusca, ttlEmSegundos, id);
    }

    private protected static BaseCache<T, string> CriarMemoriaCacheParaRemover<T>(
       bool cacheFuncional,
       string? id = null)
       where T : notnull
    {
        var config = new CacheConfig() { Chave = "teste_{0}" };

        var builder = new CacheBuilder<T, string>(
                null,
                CriarCacheMemoriaMock(cacheFuncional),
                Options.Create(config))
            .ComTipoCache(TipoCache.Memoria);

        return PrepararECriarCacheParaRemover(builder, id);
    }

    private protected static BaseCache<T, string> CriarRedisCache<T>(
        Func<T, ValueTask<ResultadoBuscaCache<string>>> funcaoBusca,
        bool cacheFuncional,
        int ttlEmSegundos = 10,
        string? id = null)
        where T : notnull
    {
        var config = new CacheConfig() { Chave = "teste_{0}" };

        var builder = new CacheBuilder<T, string>(
                CriarCacheDistribuidoMock(cacheFuncional),
                null,
                Options.Create(config))
            .ComTipoCache(TipoCache.Redis);

        return PrepararECriarCache(builder, funcaoBusca, ttlEmSegundos, id);
    }

    private protected static BaseCache<T, string> CriarRedisCacheParaRemover<T>(
        bool cacheFuncional,
        string? id = null)
        where T : notnull
    {
        var config = new CacheConfig() { Chave = "teste_{0}" };

        var builder = new CacheBuilder<T, string>(
                CriarCacheDistribuidoMock(cacheFuncional),
                null,
                Options.Create(config))
            .ComTipoCache(TipoCache.Redis);

        return PrepararECriarCacheParaRemover(builder, id);
    }

    private protected static BaseCache<T, string> CriarDoisNiveisCache<T>(
        Func<T, ValueTask<ResultadoBuscaCache<string>>> funcaoBusca,
        bool cacheFuncional,
        int ttlEmSegundos = 10,
        string? id = null)
        where T : notnull
    {
        var config = new CacheConfig() { Chave = "teste_{0}" };

        var builder = new CacheBuilder<T, string>(
                CriarCacheDistribuidoMock(cacheFuncional),
                null,
                Options.Create(config))
            .ComTipoCache(TipoCache.DoisNiveis);

        return PrepararECriarCache(builder, funcaoBusca, ttlEmSegundos, id);
    }

    private protected static BaseCache<T, string> CriarDoisNiveisCacheParaRemover<T>(
        bool cacheFuncional,
        string? id = null)
        where T : notnull
    {
        var config = new CacheConfig() { Chave = "teste_{0}" };

        var builder = new CacheBuilder<T, string>(
                CriarCacheDistribuidoMock(cacheFuncional),
                null,
                Options.Create(config))
            .ComTipoCache(TipoCache.DoisNiveis);

        return PrepararECriarCacheParaRemover(builder, id);
    }

    private static BaseCache<T, string> PrepararECriarCache<T>(
        ICacheBuilder<T, string> builder,
        Func<T, ValueTask<ResultadoBuscaCache<string>>> funcaoBusca,
        int ttlEmSegundos,
        string? id)
        where T : notnull
    {
        if (string.IsNullOrWhiteSpace(id))
        {
            id = Guid.NewGuid().ToString();
        }

        ((CacheBuilder<T, string>)builder).ComIdentificadorCache(id);
        ((CacheBuilder<T, string>)builder).ComTempoDeExpiracaoEmSegundos(ttlEmSegundos);
        ((CacheBuilder<T, string>)builder).ComEstatisticas();

        builder.ComFuncaoDeBusca(funcaoBusca);

        return (BaseCache<T, string>)builder.Build();
    }

    private static IDistributedCache CriarCacheDistribuidoMock(bool cacheFuncional)
    {
        var cacheDistribuidoBuilder = new CacheDistribuidoBuilder();

        if (cacheFuncional)
        {
            cacheDistribuidoBuilder = cacheDistribuidoBuilder.ComCacheFuncional();
        }

        return cacheDistribuidoBuilder.Build();
    }

    private static IMemoryCache CriarCacheMemoriaMock(bool cacheFuncional)
    {
        var cacheMemoriaBuilder = new CacheMemoriaBuilder();

        if (cacheFuncional)
        {
            cacheMemoriaBuilder = cacheMemoriaBuilder.ComCacheFuncional();
        }

        return cacheMemoriaBuilder.Build();
    }

    private static BaseCache<T, string> PrepararECriarCacheParaRemover<T>(
        ICacheBuilder<T, string> builder,
        string? id)
        where T : notnull
    {
        if (string.IsNullOrWhiteSpace(id))
        {
            id = Guid.NewGuid().ToString();
        }

        ((CacheBuilder<T, string>)builder).ComIdentificadorCache(id);
        ((CacheBuilder<T, string>)builder).ComEstatisticas();

        return (BaseCache<T, string>)builder.BuildForRemove();
    }
}
