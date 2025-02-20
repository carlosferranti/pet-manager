using Anima.Inscricao.Application.Cache.Persistence;

using FluentAssertions;

namespace Anima.Inscricao.Test.Cache;

public class NomeChaveCacheTest : BaseCacheTest
{
    [Fact]
    public async Task DeveBuscarItemFuncaoChaveStringAsync()
    {
        await ExecutarComSemaforoAsync(async () =>
        {
            var cache = CriarMemoriaCache<string>(BuscarItemAsync, true);

            await cache.AdicionarAoCacheAsync(_existente, _existente);
            var resultado = await cache.BuscarAsync(_existente);

            var itemCache = cache.ObterNumeroItensEncontradosCache(_existente).FirstOrDefault();
            var itemBusca = cache.ObterNumeroBuscas(_existente).FirstOrDefault();

            resultado.Should().Be(_existente);
            itemCache.Should().NotBeNull();
            itemBusca.Should().NotBeNull();
            itemCache.Value.Should().BeGreaterThan(0);
            itemBusca.Value.Should().Be(0);
        });
    }

    [Fact]
    public async Task DeveBuscarItemFuncaoChaveObjetoAsync()
    {
        await ExecutarComSemaforoAsync(async () =>
        {
            var cache = CriarMemoriaCache<ChaveTeste>(BuscarItemAsync, true);
            var chave = new ChaveTeste() { Nome = _existente };

            await cache.AdicionarAoCacheAsync(chave, _existente);
            var resultado = await cache.BuscarAsync(chave);

            var itemCache = cache.ObterNumeroItensEncontradosCache(chave).FirstOrDefault();
            var itemBusca = cache.ObterNumeroBuscas(chave).FirstOrDefault();

            resultado.Should().Be(_existente);
            itemCache.Should().NotBeNull();
            itemBusca.Should().NotBeNull();
            itemCache.Value.Should().BeGreaterThan(0);
            itemBusca.Value.Should().Be(0);
        });
    }

    private static ValueTask<ResultadoBuscaCache<string>> BuscarItemAsync(string chave)
    {
        var encontrado = chave == _existente;
        return new(new ResultadoBuscaCache<string>(encontrado, chave));
    }

    private static ValueTask<ResultadoBuscaCache<string>> BuscarItemAsync(ChaveTeste chave)
    {
        var encontrado = chave.Nome == _existente;
        return new(new ResultadoBuscaCache<string>(encontrado, chave.Nome));
    }

    private class ChaveTeste
    {
        public string Nome { get; set; }
    }
}

