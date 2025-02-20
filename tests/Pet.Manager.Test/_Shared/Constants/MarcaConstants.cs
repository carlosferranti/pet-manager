using Anima.Inscricao.Domain.IntegracaoSistemas.Entities;
using Anima.Inscricao.Domain.Marcas.Entities;

namespace Anima.Inscricao.Test._Shared.Constants;

public static class MarcaConstants
{
    public static readonly Marca Una = GerarMarcaComIntegracoes("Una", "Una", new List<(int, string)> {(2,"2"), (2,"3")})
        ?? throw new ArgumentException("Erro ao criar a marca Una");

    public static readonly Marca UnaLive =
        Marca.Criar("Una Live", "Una Live")
        .ObterRetorno() ?? throw new ArgumentException("Erro ao criar a marca Una");

    public static readonly Marca Unibh =
        Marca.Criar("UniBH", "UniBH")
        .ObterRetorno() ?? throw new ArgumentException("Erro ao criar a marca UniBH");

    public static readonly Marca Unifg = GerarMarcaComIntegracao("UniFG", "UniFG", 1, "1") 
        ?? throw new ArgumentException("Erro ao criar a marca UniFG");

    private static Marca GerarMarcaComIntegracao(string nome, string sigla, int integracaoSistemaId, string codigo)
    {
        var marca = Marca.Criar(nome, sigla)
            .ObterRetorno() ?? throw new ArgumentException($"Erro ao criar a marca {nome}");

        marca.AdicionarIntegracao(new IntegracaoSistemaId(integracaoSistemaId), $"{codigo}");

        return marca;
    }

    private static Marca GerarMarcaComIntegracoes(string nome, string sigla, List<(int, string)> integracoes)
    {
        var marca = Marca.Criar(nome, sigla)
            .ObterRetorno() ?? throw new ArgumentException($"Erro ao criar a marca {nome}");

        foreach (var integracao in integracoes)
        {
            marca.AdicionarIntegracao(new IntegracaoSistemaId(integracao.Item1), $"{integracao.Item2}");
        }

        return marca;
    }
}
