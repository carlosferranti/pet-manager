using Anima.Inscricao.Application.Enums;

namespace Anima.Inscricao.Application.Cache.Persistence;

public interface ICacheBuilder<TChave, TValor>
    where TChave : notnull
{
    ICacheBuilder<TChave, TValor> ComTipoCache(TipoCache? tipoCache);

    ICacheBuilder<TChave, TValor> ComIdentificadorCache(IdentificadorCache id);

    ICacheBuilder<TChave, TValor> ComTempoDeExpiracaoEmSegundos(Func<int?, int> tempoExpiracaoEmSegundos);

    ICacheBuilder<TChave, TValor> ComFuncaoDeBusca(Func<TChave, ValueTask<ResultadoBuscaCache<TValor>>> funcao);

    ICache<TChave, TValor> Build();

    ICache<TChave, TValor> BuildForRemove();
}

public class ResultadoBuscaCache<T>
{
    public ResultadoBuscaCache(bool encontrado, T? resultado)
    {
        Encontrado = encontrado;
        Resultado = resultado;
    }

    public bool Encontrado { get; }

    public T? Resultado { get; }
}
