using Anima.Inscricao.Application.Cache.Persistence;

namespace Anima.Inscricao.Application.Cache;

public sealed class SemCache<TChave, TValor> : BaseCache<TChave, TValor>
    where TChave : notnull
{
    private readonly Func<TChave, ValueTask<ResultadoBuscaCache<TValor>>> _funcaoBusca;

    public SemCache(
        IList<EventoBuscaCache<TChave>>? eventosCache,
        Func<TChave, ValueTask<ResultadoBuscaCache<TValor>>> funcaoBusca)
        : base(TipoCache.Nenhum, eventosCache)
    {
        _funcaoBusca = funcaoBusca;
    }

    public override ValueTask AdicionarAoCacheAsync(TChave chave, TValor valor)
    {
        return new();
    }

    public override ValueTask RemoverDoCacheAsync(TChave chave)
    {
        return new();
    }

    public override async ValueTask<TValor?> BuscarAsync(TChave chave)
    {
        var resultado = await _funcaoBusca(chave);
        AdicionarChaveBuscadaControle(chave);

        return resultado.Encontrado
            ? resultado.Resultado
            : default;
    }
}
