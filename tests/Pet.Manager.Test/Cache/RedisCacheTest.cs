using Anima.Inscricao.Application.Cache.Persistence;

using FluentAssertions;

namespace Anima.Inscricao.Test.Cache;

public class RedisCacheTest : BaseCacheTest
{
    [Fact]
    public async Task DeveBuscarItemCacheEEncontrarAsync()
    {
        await ExecutarComSemaforoAsync(async () =>
        {
            var cache = CriarRedisCache<string>(BuscarItemAsync, true);

            cache.LimparEventosCache();
            await cache.AdicionarAoCacheAsync(_existente, _existente);

            var item = await cache.BuscarAsync(_existente);

            item.Should().Be(_existente);
            cache.ObterNumeroBuscas(_existente).Should().BeEmpty();
        });
    }

    [Fact]
    public async Task DeveBuscarItemFuncaoENaoEncontrarAsync()
    {
        await ExecutarComSemaforoAsync(async () =>
        {
            var cache = CriarRedisCache<string>(BuscarItemAsync, true);

            cache.LimparEventosCache();

            var item = await cache.BuscarAsync(_naoExistente);

            item.Should().BeNull();
            cache.ObterNumeroBuscas(_naoExistente).Values.Sum().Should().BeGreaterThan(0);
        });
    }

    [Fact]
    public async Task DeveObterObjetosDeMesmoIdEmCachesDiferentesAsync()
    {
        await ExecutarComSemaforoAsync(async () =>
        {
            var cache1 = CriarRedisCache<string>(BuscarItemAsync, true, id: "1");
            var cache2 = CriarRedisCache<string>(BuscarItemAsync, true, id: "1");

            cache1.LimparEventosCache();
            cache2.LimparEventosCache();

            await cache1.AdicionarAoCacheAsync(_existente, _existente);

            var item = await cache2.BuscarAsync(_existente);

            item.Should().NotBeNull();
            item.Should().Be(_existente);
            cache2.ObterNumeroBuscas(_existente).Should().BeEmpty();
        });
    }

    [Fact]
    public async Task DeveBuscarItemRemovidoBancoAsync()
    {
        await ExecutarComSemaforoAsync(async () =>
        {
            var cache = CriarRedisCache<string>(BuscarItemAsync, true);

            cache.LimparEventosCache();

            await cache.AdicionarAoCacheAsync(_existente, _existente);
            var item1 = await cache.BuscarAsync(_existente);
            cache.ObterNumeroBuscas(_existente).Values.Sum().Should().Be(0);
            cache.ObterNumeroItensEncontradosCache(_existente).Values.Sum().Should().Be(1);

            await cache.RemoverDoCacheAsync(_existente);
            var item2 = await cache.BuscarAsync(_existente);

            item1.Should().Be(_existente);
            item2.Should().Be(_existente);
            cache.ObterNumeroBuscas(_existente).Values.Sum().Should().Be(1);
            cache.ObterNumeroItensEncontradosCache(_existente).Values.Sum().Should().Be(1);
        });
    }

    [Fact]
    public async Task DeveAdicionarERemoverItemDoCacheAsync()
    {
        await ExecutarComSemaforoAsync(async () =>
        {
            string cacheId = Guid.NewGuid().ToString();

            var cache = CriarRedisCache<string>(BuscarItemAsync, true, id: cacheId);

            await cache.AdicionarAoCacheAsync(_existente, _existente);

            var item = await cache.BuscarAsync(_existente);

            item.Should().Be(_existente);

            cache.ObterNumeroBuscas(_existente).Values.Sum().Should().Be(0);

            var cacheParaRemover = CriarRedisCacheParaRemover<string>(true, id: cacheId);

            await cacheParaRemover.RemoverDoCacheAsync(_existente);

            var itemDepoisDaRemocao = await cache.BuscarAsync(_existente);

            itemDepoisDaRemocao.Should().Be(_existente);

            cache.ObterNumeroBuscas(_existente).Values.Sum().Should().Be(1);
        });
    }

    private static ValueTask<ResultadoBuscaCache<string>> BuscarItemAsync(string chave)
    {
        var encontrado = chave == _existente;
        return new(new ResultadoBuscaCache<string>(encontrado, chave));
    }
}
