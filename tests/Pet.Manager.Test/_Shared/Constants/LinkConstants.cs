using Anima.Inscricao.Domain.FormasEntrada.Entities;
using Anima.Inscricao.Domain.Links.Entities;

namespace Anima.Inscricao.Test._Shared.Constants;

public static class LinkConstants
{
    public static readonly Link LinkPadrao = CriarLinkPadrao();

    public static readonly Link LinkEscola = CriarLinkEscola();

    public static readonly Link LinkEmpresa = CriarLinkEmpresa();

    private static Link CriarLinkPadrao()
    {
        var link = Link.Criar("Link padrão")
        .ObterRetorno() ?? throw new ArgumentException("Erro ao criar o Link padrão");

        link.AdicionarFormaEntrada(new FormaEntradaId(1));
        link.AdicionarFormaEntrada(new FormaEntradaId(2));
        link.AdicionarFormaEntrada(new FormaEntradaId(3));
        link.AdicionarFormaEntrada(new FormaEntradaId(4));
        link.AdicionarFormaEntrada(new FormaEntradaId(5));
        link.AdicionarFormaEntrada(new FormaEntradaId(6));

        return link;
    }

    private static Link CriarLinkEscola()
    {
        var link = Link.Criar("Link escola")
        .ObterRetorno() ?? throw new ArgumentException("Erro ao criar o Link escola");

        link.AdicionarFormaEntrada(new FormaEntradaId(7));

        return link;
    }

    private static Link CriarLinkEmpresa()
    {
        var link = Link.Criar("Link empresa")
        .ObterRetorno() ?? throw new ArgumentException("Erro ao criar o Link empresa");

        link.AdicionarFormaEntrada(new FormaEntradaId(8));

        return link;
    }
}