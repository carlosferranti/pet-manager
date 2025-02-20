using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.Caching.Memory;
using Moq;

namespace Anima.Inscricao.Test.Builder;

internal sealed class CacheDistribuidoBuilder : IDisposable
{
    private readonly IMemoryCache _cache;
    private readonly Mock<IDistributedCache> _mock = new();
    private bool _cacheConfigurado;

    public CacheDistribuidoBuilder()
    {
        _cache = new CacheMemoriaBuilder()
            .ComCacheFuncional()
            .Build();
    }

    public CacheDistribuidoBuilder ComCacheFuncional()
    {
        if (_cacheConfigurado)
        {
            return this;
        }

        _cacheConfigurado = true;

        _mock
            .Setup(m => m.GetAsync(It.IsAny<string>(), It.IsAny<CancellationToken>()))
            .ReturnsAsync<string, CancellationToken, IDistributedCache, byte[]>((k, token) =>
            {
                _ = _cache.Get<byte[]>(k);
                return _cache.Get<byte[]>(k)!;
            });

        _mock
            .Setup(m => m.RemoveAsync(It.IsAny<string>(), It.IsAny<CancellationToken>()))
            .Callback<string, CancellationToken>((k, token) => _cache.Remove(k))
            .Returns(Task.CompletedTask);

        _mock
            .Setup(m => m.SetAsync(It.IsAny<string>(), It.IsAny<byte[]>(), It.IsAny<DistributedCacheEntryOptions>(), It.IsAny<CancellationToken>()))
            .Callback<string, byte[], DistributedCacheEntryOptions, CancellationToken>((k, v, options, token) => _cache.Set(k, v, options.AbsoluteExpirationRelativeToNow!.Value))
            .Returns(Task.CompletedTask);

        return this;
    }

    public IDistributedCache Build()
    {
        if (!_cacheConfigurado)
        {
            _cacheConfigurado = true;

            _mock
                .Setup(m => m.GetAsync(It.IsAny<string>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(Array.Empty<byte>);

            _mock
                .Setup(m => m.RemoveAsync(It.IsAny<string>(), It.IsAny<CancellationToken>()))
                .Returns(Task.CompletedTask);

            _mock
                .Setup(m => m.SetAsync(It.IsAny<string>(), It.IsAny<byte[]>(), It.IsAny<DistributedCacheEntryOptions>(), It.IsAny<CancellationToken>()))
                .Returns(Task.CompletedTask);
        }

        return _mock.Object;
    }

    public void Dispose()
    {
        _cache.Dispose();
    }
}
