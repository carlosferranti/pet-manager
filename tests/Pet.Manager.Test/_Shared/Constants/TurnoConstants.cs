using Anima.Inscricao.Domain.Turnos.Entities;

namespace Anima.Inscricao.Test._Shared.Constants;

public static class TurnoConstants
{
    public static readonly Turno TurnoManha =
        Turno.Criar("Manhã")
        .ObterRetorno() ?? throw new ArgumentException("Erro ao criar o turno Manhã");

    public static readonly Turno TurnoTarde =
          Turno.Criar("Tarde")
          .ObterRetorno() ?? throw new ArgumentException("Erro ao criar o turno Tarde");

    public static readonly Turno TurnoIntegral =
          Turno.Criar("TurnoIntegral")
          .ObterRetorno() ?? throw new ArgumentException("Erro ao criar o turno Integral");
}
