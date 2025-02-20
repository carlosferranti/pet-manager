using Anima.Inscricao.Domain.Enderecos.Entities;

namespace Anima.Inscricao.Test._Shared.Constants;

public static class EnderecoConstants
{
    public static readonly Pais PaisBrasil =
        Pais.Criar("Brasil", "BRA", "BR", null)
        .ObterRetorno() ?? throw new ArgumentException("Erro ao criar o país Brasil");

    public static readonly Pais PaisArgentina =
        Pais.Criar("Argentina", "ARG", "AR", null)
        .ObterRetorno() ?? throw new ArgumentException("Erro ao criar o país Argentina");

    public static readonly Estado EstadoSP =
          Estado.Criar("São Paulo", "SP", new PaisId(1))
          .ObterRetorno() ?? throw new ArgumentException("Erro ao criar o estado SP");

    public static readonly Estado EstadoRJ =
          Estado.Criar("Rio de Janeiro", "RJ", new PaisId(1))
          .ObterRetorno() ?? throw new ArgumentException("Erro ao criar o estado RJ");

    public static readonly Estado EstadoRS =
        Estado.Criar("Rio Grande do Sul", "RS", new PaisId(1))
        .ObterRetorno() ?? throw new ArgumentException("Erro ao criar o estado RS");

    public static readonly Cidade CidadeSaoPaulo =
          Cidade.Criar("São Paulo", new EstadoId(1), 11, null)
          .ObterRetorno() ?? throw new ArgumentException("Erro ao criar a cidade São Paulo");
    
    public static readonly Cidade CidadeCampinas =
         Cidade.Criar("Campinas", new EstadoId(1), 11, null)
         .ObterRetorno() ?? throw new ArgumentException("Erro ao criar a cidade Campinas");
}
