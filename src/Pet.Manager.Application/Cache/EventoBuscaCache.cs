using Anima.Inscricao.Application.Cache.Persistence;

namespace Anima.Inscricao.Application.Cache;

public sealed class EventoBuscaCache<TChave>
    where TChave : notnull
{
    internal EventoBuscaCache(TipoCache tipoCache, string evento, TChave chave, int nivel = 1)
    {
        TipoCache = tipoCache;
        Evento = evento;
        Chave = chave;
        NivelCache = nivel;
    }

    public TipoCache TipoCache { get; init; }

    public string Evento { get; init; }

    public TChave Chave { get; init; }

    public int NivelCache { get; init; }
}