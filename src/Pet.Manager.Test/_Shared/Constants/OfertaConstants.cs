using Anima.Inscricao.Domain.Intakes.Entities;
using Anima.Inscricao.Domain.Ofertas.Entities;
using Anima.Inscricao.Domain.Produtos.Entities;


namespace Anima.Inscricao.Test._Shared.Constants;

public static class OfertaConstants
{
    public static readonly Oferta OfertaTeste1 =
       Oferta.Criar(new ProdutoId(1), new IntakeId(1))
       .ObterRetorno() ?? throw new ArgumentException("Erro ao criar a oferta Teste1");

    public static readonly Oferta OfertaTeste2 =
       Oferta.Criar(new ProdutoId(2), new IntakeId(2))
       .ObterRetorno() ?? throw new ArgumentException("Erro ao criar a oferta Teste2");
}
