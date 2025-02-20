using Anima.Inscricao.Application.Cache.Persistence;

using FluentAssertions;

namespace Anima.Inscricao.Test.Cache;

public class SemCacheTest : BaseCacheTest
{
    [Fact]
    public async Task DeveBuscarItemFuncaoEEncontrarAsync()
    {
        await ExecutarComSemaforoAsync(async () =>
        {
            var cache = CriarSemCache<string>(BuscarItemAsync);

            cache.LimparEventosCache();

            var item = await cache.BuscarAsync(_existente);

            item.Should().Be(_existente);
            cache.ObterNumeroBuscas(_existente).Values.Sum().Should().BeGreaterThan(0);
        });
    }

    [Fact]
    public async Task DeveTentarBuscarItemCacheEUsarFuncaoAsync()
    {
        await ExecutarComSemaforoAsync(async () =>
        {
            var cache = CriarSemCache<string>(BuscarItemAsync);

            cache.LimparEventosCache();
            await cache.AdicionarAoCacheAsync(_existente, _existente);

            var item = await cache.BuscarAsync(_existente);

            item.Should().Be(_existente);
            cache.ObterNumeroBuscas(_existente).Values.Sum().Should().BeGreaterThan(0);
        });
    }

    [Fact]
    public async Task DeveBuscarItemFuncaoENaoEncontrarAsync()
    {
        await ExecutarComSemaforoAsync(async () =>
        {
            var cache = CriarSemCache<string>(BuscarItemAsync);

            cache.LimparEventosCache();

            var item = await cache.BuscarAsync(_naoExistente);

            item.Should().BeNull();
            cache.ObterNumeroBuscas(_existente).Values.Sum().Should().Be(0);
        });
    }

    [Fact]
    public async Task DeveBuscarItemRemovidoBancoAsync()
    {
        await ExecutarComSemaforoAsync(async () =>
        {
            var cache = CriarSemCache<string>(BuscarItemAsync);

            cache.LimparEventosCache();

            await cache.AdicionarAoCacheAsync(_existente, _existente);
            var item1 = await cache.BuscarAsync(_existente);
            cache.ObterNumeroBuscas(_existente).Values.Sum().Should().Be(1);

            await cache.RemoverDoCacheAsync(_existente);
            var item2 = await cache.BuscarAsync(_existente);

            item1.Should().Be(_existente);
            item2.Should().Be(_existente);
            cache.ObterNumeroBuscas(_existente).Values.Sum().Should().Be(2);
        });
    }

    private static ValueTask<ResultadoBuscaCache<string>> BuscarItemAsync(string chave)
    {
        var encontrado = chave == _existente;
        return new(new ResultadoBuscaCache<string>(encontrado, chave));
    }
}