namespace Anima.Inscricao.Application.Cache.Persistence;

public interface ICache<in TChave, TValor> : IDisposable
    where TChave : notnull
{
    ValueTask AdicionarAoCacheAsync(TChave chave, TValor valor);

    ValueTask RemoverDoCacheAsync(TChave chave);

    ValueTask<TValor?> BuscarAsync(TChave chave);
}
