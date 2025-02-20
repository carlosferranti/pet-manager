using Anima.Inscricao.Domain.Instituicoes.Entities;
using Anima.Inscricao.Domain.Marcas.Entities;
using Anima.Inscricao.Domain.TiposFormacao.Entities;

namespace Anima.Inscricao.Test._Shared.Constants;

public static class InstituicaoConstants
{
    public static readonly Instituicao Una =
        Instituicao.Criar("Centro Universitário Una", "Una", new MarcaId(1))
        .ObterRetorno() ?? throw new ArgumentException("Erro ao criar a instituicao Una");

    public static readonly Instituicao UnaLive =
        Instituicao.Criar("Centro Universitário Una", "Una Live", new MarcaId(2))
        .ObterRetorno() ?? throw new ArgumentException("Erro ao criar a instituicao Una");

    public static readonly Instituicao Unibh =
        Instituicao.Criar("Centro Universitário de Belo Horizonte", "UniBH", new MarcaId(3))
        .ObterRetorno() ?? throw new ArgumentException("Erro ao criar a instituicao UniBH");
}
