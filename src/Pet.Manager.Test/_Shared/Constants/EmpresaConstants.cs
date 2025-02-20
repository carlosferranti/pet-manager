using Anima.Inscricao.Domain.Empresas.Entities;

namespace Anima.Inscricao.Test._Shared.Constants;

public static class EmpresaConstants
{
    public static readonly Empresa Anima =
       Empresa.Criar("17.165.118/0001-72", "Ânima", "Ânima")
       .ObterRetorno() ?? throw new ArgumentException("Erro ao criar a empresa Ânima");

    public static readonly Empresa Compass =
        Empresa.Criar("50.062.015/0001-52", "Compass", "Compass UOL")
        .ObterRetorno() ?? throw new ArgumentException("Erro ao criar a empresa Compass");

    public static readonly Empresa Oracle =
        Empresa.Criar("97.485.390/0001-79", "Oracle", "Oracle")
        .ObterRetorno() ?? throw new ArgumentException("Erro ao criar a empresa Oracle");
}