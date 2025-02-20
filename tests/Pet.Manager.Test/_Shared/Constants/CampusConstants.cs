using Anima.Inscricao.Domain.Campi.Entities;

namespace Anima.Inscricao.Test._Shared.Constants;

public static class CampusConstants
{
    public static readonly Campus CampusRecife =
        Campus.Criar("Campus Recife", "Marco Zero", null)
        .ObterRetorno() ?? throw new ArgumentException("Erro ao criar o campus Recife");

    public static readonly Campus CampusOlinda =
        Campus.Criar("Campus Olinda","Alto da Sé", null)
        .ObterRetorno() ?? throw new ArgumentException("Erro ao criar o campus Olinda");

    public static readonly Campus CampusMooca =
    Campus.Criar("Campus Mooca", "Mooca", null)
    .ObterRetorno() ?? throw new ArgumentException("Erro ao criar o campus Mooca");
}
