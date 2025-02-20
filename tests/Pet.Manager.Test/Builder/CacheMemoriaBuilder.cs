using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.DependencyInjection;

using Moq;

namespace Anima.Inscricao.Test.Builder;

internal sealed class CacheMemoriaBuilder : IDisposable
{
    private static readonly IServiceProvider _services =
        new ServiceCollection().AddMemoryCache().BuildServiceProvider();

    private IMemoryCache? _cache;
    private bool _cacheConfigurado;

    public CacheMemoriaBuilder ComCacheFuncional()
    {
        if (_cacheConfigurado)
        {
            return this;
        }

        _cacheConfigurado = true;
        _cache = _services.GetService<IMemoryCache>();

        return this;
    }

    public IMemoryCache Build()
    {
        if (!_cacheConfigurado)
        {
            _cacheConfigurado = true;

            var mock = new Mock<IMemoryCache>();
            object? valor;

            mock.Setup(m => m.TryGetValue(It.IsAny<object>(), out valor))
                .Returns(false);

            mock.Setup(m => m.Remove(It.IsAny<object>()));

            mock.Setup(m => m.CreateEntry(It.IsAny<object>()))
                .Returns(Mock.Of<ICacheEntry>());

            _cache = mock.Object;
        }

        return _cache!;
    }

    public void Dispose()
    {
        _cache?.Dispose();
    }
}
