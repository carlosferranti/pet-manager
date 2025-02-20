using Anima.Inscricao.Application.Enums;
using Anima.Inscricao.Domain.Concursos.Entities;
using Anima.Inscricao.Domain.Cupons.Entities;

namespace Anima.Inscricao.Test._Shared.Constants;

public static class CupomConstants
{
    public static readonly Cupom CupomPablo100 =
        Cupom.Criar(new ConcursoId(1), "PABLO100", "Chame o PH no teams para ganhar 100% de desconto.", 100, (int)TipoDesconto.Porcentagem, DateTime.Now)
        .ObterRetorno() ?? throw new ArgumentException("Erro ao criar o cupom Pablo100");

    public static readonly Cupom CupomPablo50 =
        Cupom.Criar(new ConcursoId(1), "PABLO50", "Chame o PH no teams para ganhar 50% de desconto.", 50, (int)TipoDesconto.Porcentagem, DateTime.Now.AddDays(30))
        .ObterRetorno() ?? throw new ArgumentException("Erro ao criar o cupom Pablo50");

    public static readonly Cupom CupomPablo25 =
       Cupom.Criar(new ConcursoId(2), "PABLO25", "Chame o PH no teams para ganhar 25% de desconto.", 25, (int)TipoDesconto.Porcentagem, DateTime.UtcNow.AddDays(5))
       .ObterRetorno() ?? throw new ArgumentException("Erro ao criar o cupom CupomPablo25");

    public static readonly Cupom CupomPablo10Expirado =
        Cupom.Criar(new ConcursoId(2), "PABLO10", "Chame o PH no teams para ganhar 10% de desconto (expirado).", 10, (int)TipoDesconto.Porcentagem, DateTime.UtcNow.AddDays(-10))
        .ObterRetorno() ?? throw new ArgumentException("Erro ao criar o cupom CupomPablo10Expirado");

    public static Cupom PreencheCupomPablo100()
    {
        CupomPablo100.AdicionarIntegracao(1, "123");

        return CupomPablo100;
    }
}
