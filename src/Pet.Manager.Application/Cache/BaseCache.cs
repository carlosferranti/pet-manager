using Anima.Inscricao.Application.Cache.Persistence;

namespace Anima.Inscricao.Application.Cache;

public abstract class BaseCache<TChave, TValor> : ICache<TChave, TValor>
    where TChave : notnull
{
    private readonly TipoCache _tipoCache;
    private bool _isDisposed;

    protected BaseCache(
        TipoCache tipoCache,
        IList<EventoBuscaCache<TChave>>? eventosCache)
    {
        EventosCache = eventosCache;
        _tipoCache = tipoCache;
    }

    ~BaseCache()
    {
        Dispose(false);
    }

    internal IList<EventoBuscaCache<TChave>>? EventosCache { get; set; }

    protected bool IsDisposed => _isDisposed;

    public abstract ValueTask AdicionarAoCacheAsync(TChave chave, TValor valor);

    public abstract ValueTask RemoverDoCacheAsync(TChave chave);

    public abstract ValueTask<TValor?> BuscarAsync(TChave chave);

    public void LimparEventosCache()
    {
        EventosCache?.Clear();
    }

    public IDictionary<TipoCache, int> ObterNumeroBuscas(TChave chave, int nivel = 1) =>
        ObterEstatisticasCache(chave, "Busca", nivel);

    public IDictionary<TipoCache, int> ObterNumeroItensEncontradosCache(TChave chave, int nivel = 1) =>
        ObterEstatisticasCache(chave, "Cache", nivel);

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    protected virtual void Dispose(bool disposing)
    {
        if (_isDisposed)
        {
            return;
        }

        _isDisposed = true;
    }

    protected void AdicionarChaveBuscadaControle(TChave chave, int nivel = 1) =>
        AdicionarEventoControle(new(_tipoCache, "Busca", chave, nivel));

    protected void AdicionarRetornoCacheControle(TChave chave, int nivel = 1) =>
        AdicionarEventoControle(new(_tipoCache, "Cache", chave, nivel));

    protected string ObterChaveParaCache(string formatoChave, TChave chave)
    {
        if (VerificarItemPrimitivo(chave.GetType()))
        {
            return string.Format(formatoChave, chave.ToString());
        }

        return string.Format(formatoChave, ConverterObjetoParaChave(chave, 1));
    }

    private static bool VerificarItemPrimitivo(Type tipo) => tipo.IsPrimitive
        || tipo == typeof(string)
        || tipo == typeof(DateTime)
        || tipo.IsEnum
        || tipo.IsValueType
        || (tipo.IsGenericType && tipo == typeof(Nullable<>));

    private void AdicionarEventoControle(EventoBuscaCache<TChave> evento)
    {
        if (EventosCache is null)
        {
            return;
        }

        EventosCache.Add(evento);
    }

    private IDictionary<TipoCache, int> ObterEstatisticasCache(TChave chave, string evento, int nivel)
    {
        if (EventosCache is null || !EventosCache.Any(k => k.Evento == evento && k.Chave.Equals(chave)))
        {
            return new Dictionary<TipoCache, int>();
        }

        return EventosCache
            .Where(i => i.Evento == evento && i.Chave.Equals(chave) && i.NivelCache == nivel)
            .Select(i => i.TipoCache)
            .GroupBy(i => i)
            .ToDictionary(g => g.Key, g => g.Count());
    }

    private string ConverterObjetoParaChave(object objeto, int nivel)
    {
        const int nivelMaximo = 2;

        if (objeto is null || nivel > nivelMaximo)
        {
            return string.Empty;
        }

        var listaValores = new List<string>();
        var propriedades = objeto.GetType().GetProperties().OrderBy(p => p.Name);

        foreach (var propriedade in propriedades)
        {
            if (!propriedade.CanRead)
            {
                continue;
            }

            var valor = propriedade.GetValue(objeto);

            if (valor is not null && !VerificarItemPrimitivo(propriedade.PropertyType))
            {
                valor = ConverterObjetoParaChave(valor, nivel + 1);
            }

            listaValores.Add(propriedade.Name + ":" + valor);
        }

        return string.Join("_", listaValores);
    }
}

