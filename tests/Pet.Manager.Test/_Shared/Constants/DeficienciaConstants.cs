using Anima.Inscricao.Domain.Deficiencias.Entities;
using Anima.Inscricao.Domain.Acessibilidades.Entities;

namespace Anima.Inscricao.Test._Shared.Constants;

public static class DeficienciaConstants
{
    public static readonly Deficiencia DeficienciaFisica =
       Deficiencia.Criar("Deficiência Física", 1)
       .ObterRetorno() ?? throw new ArgumentException("Erro ao criar a Deficiência Física");

    public static readonly Deficiencia Cegueira = CriarDeficienciaCegueira();

    public static readonly Deficiencia Surdez =
       Deficiencia.Criar("Surdez", 3)
       .ObterRetorno() ?? throw new ArgumentException("Erro ao criar a Deficiência Surdez");

    public static Deficiencia CriarDeficienciaCegueira()
    {
        var cegueira = Deficiencia.Criar("Cegueira", 2)
                       .ObterRetorno() ?? throw new ArgumentException("Erro ao criar a Deficiência Cegueira");

        cegueira.AdicionarAcessibilidade(new AcessibilidadeId(3));
        cegueira.AdicionarAcessibilidade(new AcessibilidadeId(4));

        return cegueira;
    }
}