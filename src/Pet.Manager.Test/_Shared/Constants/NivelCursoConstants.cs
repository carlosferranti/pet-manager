using Anima.Inscricao.Domain.NiveisCurso.Entities;

namespace Anima.Inscricao.Test._Shared.Constants;

public static class NivelCursoConstants
{
    public static readonly NivelCurso Bacharelado =
        NivelCurso.Criar("Bacharelado")
        .ObterRetorno() ?? throw new ArgumentException("Erro ao criar o nível de curso Graduação");

    public static readonly NivelCurso Licenciatura =
        NivelCurso.Criar("Licenciatura")
        .ObterRetorno() ?? throw new ArgumentException("Erro ao criar o nível de curso Licenciatura");

    public static readonly NivelCurso Tecnico =
        NivelCurso.Criar("Técnico")
        .ObterRetorno() ?? throw new ArgumentException("Erro ao criar o nível de curso Técnico");
}
