using Anima.Inscricao.Application.Cache.Persistence;
using Anima.Inscricao.Application.Config;
using Anima.Inscricao.Application.Enums;

using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Options;

namespace Anima.Inscricao.Application.Cache;

public class CacheBuilder<TChave, TValor> : ICacheBuilder<TChave, TValor>
    where TChave : notnull
{
    private readonly IDistributedCache? _distributedCache;
    private readonly IMemoryCache? _memoryCache;
    private readonly CacheConfig? _configuration;
    private readonly TipoCache _tipoCachePadrao;

    private string? _id;
    private Func<TChave, ValueTask<ResultadoBuscaCache<TValor>>>? _funcaoBusca;
    private int? _tempoExpiracaoEmSegundos;
    private TipoCache? _tipoCache;

    public CacheBuilder(
        IDistributedCache? distributedCache,
        IMemoryCache? memoryCache,
        IOptions<CacheConfig>? configuration)
    {
        _distributedCache = distributedCache;
        _memoryCache = memoryCache;
        _configuration = configuration?.Value;

        _tipoCachePadrao = _configuration != null
            && Enum.TryParse<TipoCache>(_configuration.Tipo, true, out var t)
                ? t
                : TipoCache.Nenhum;
    }

    public string? Id => _id;

    internal int? TempoExpiracaoEmSegundos => _tempoExpiracaoEmSegundos;

    internal IList<EventoBuscaCache<TChave>>? EventosCache { get; set; }

    public virtual ICacheBuilder<TChave, TValor> ComTipoCache(TipoCache? tipoCache)
    {
        _tipoCache = tipoCache;
        return this;
    }

    public virtual ICacheBuilder<TChave, TValor> ComIdentificadorCache(IdentificadorCache id) =>
        ComIdentificadorCache(id.ToString());

    public virtual ICacheBuilder<TChave, TValor> ComTempoDeExpiracaoEmSegundos(Func<int?, int> tempoExpiracaoEmSegundos) =>
        ComTempoDeExpiracaoEmSegundos(tempoExpiracaoEmSegundos(_configuration?.TtlEmSegundos));

    public virtual ICacheBuilder<TChave, TValor> ComFuncaoDeBusca(Func<TChave, ValueTask<ResultadoBuscaCache<TValor>>> funcao)
    {
        _funcaoBusca = funcao;
        return this;
    }

    public virtual ICacheBuilder<TChave, TValor> ComEstatisticas()
    {
        EventosCache ??= new List<EventoBuscaCache<TChave>>();
        return this;
    }

    public ICache<TChave, TValor> Build()
    {
        if (string.IsNullOrWhiteSpace(_id))
        {
            throw new InvalidOperationException("Identificador do cache deve ser definido.");
        }

        if (_funcaoBusca is null)
        {
            throw new InvalidOperationException("Função de busca deve ser definida.");
        }

        if (_tempoExpiracaoEmSegundos is null)
        {
            throw new InvalidOperationException("Tempo de expiração do cache deve ser definido.");
        }

        return CriarCache(_funcaoBusca, _tempoExpiracaoEmSegundos.Value);
    }

    public ICache<TChave, TValor> BuildForRemove()
    {
        if (string.IsNullOrWhiteSpace(_id))
        {
            throw new InvalidOperationException("Identificador do cache deve ser definido.");
        }

        return CriarCache(FuncaoDeBuscaVaziaAsync, 0);
    }

    internal virtual ICacheBuilder<TChave, TValor> ComIdentificadorCache(string id)
    {
        _id = id;
        return this;
    }

    internal virtual ICacheBuilder<TChave, TValor> ComTempoDeExpiracaoEmSegundos(int tempoExpiracaoEmSegundos)
    {
        _tempoExpiracaoEmSegundos = tempoExpiracaoEmSegundos;
        return this;
    }

    private BaseCache<TChave, TValor> CriarCache(
        Func<TChave, ValueTask<ResultadoBuscaCache<TValor>>> funcaoBusca,
        int tempoExpiracaoEmSegundos)
    {
        return (_tipoCache ?? _tipoCachePadrao) switch
        {
            TipoCache.Redis => CriarCacheRedis(funcaoBusca, tempoExpiracaoEmSegundos),
            TipoCache.Memoria => CriarCacheMemoria(funcaoBusca, tempoExpiracaoEmSegundos),
            TipoCache.DoisNiveis => CriarCacheDoisNiveis(funcaoBusca, tempoExpiracaoEmSegundos),
            _ => CriarSemCache(funcaoBusca),
        };
    }

    private BaseCache<TChave, TValor> CriarCacheRedis(
        Func<TChave, ValueTask<ResultadoBuscaCache<TValor>>> funcaoBusca,
        int tempoExpiracaoEmSegundos) =>
            new RedisCache<TChave, TValor>(
                EventosCache,
                funcaoBusca,
                _distributedCache!,
                _configuration!,
                Id!,
                tempoExpiracaoEmSegundos);

    private BaseCache<TChave, TValor> CriarCacheMemoria(
        Func<TChave, ValueTask<ResultadoBuscaCache<TValor>>> funcaoBusca,
        int tempoExpiracaoEmSegundos) =>
            new MemoriaCache<TChave, TValor>(
                EventosCache,
                funcaoBusca,
                _memoryCache!,
                _configuration!,
                Id!,
                tempoExpiracaoEmSegundos);

    private BaseCache<TChave, TValor> CriarCacheDoisNiveis(
        Func<TChave, ValueTask<ResultadoBuscaCache<TValor>>> funcaoBusca,
        int tempoExpiracaoEmSegundos) =>
            new DoisNiveisCache<TChave, TValor>(
                EventosCache,
                funcaoBusca,
                _distributedCache!,
                _configuration!,
                Id!,
                tempoExpiracaoEmSegundos);

    private BaseCache<TChave, TValor> CriarSemCache(
        Func<TChave, ValueTask<ResultadoBuscaCache<TValor>>> funcaoBusca) =>
            new SemCache<TChave, TValor>(
                EventosCache,
                funcaoBusca);

    private ValueTask<ResultadoBuscaCache<TValor>> FuncaoDeBuscaVaziaAsync(TChave chave)
    {
        return new(new ResultadoBuscaCache<TValor>(chave == null, default));
    }
}
