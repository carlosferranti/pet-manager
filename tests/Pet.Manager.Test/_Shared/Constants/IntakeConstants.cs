using Anima.Inscricao.Domain._Shared.ValueObjects;
using Anima.Inscricao.Domain.Intakes.Entities;

namespace Anima.Inscricao.Test._Shared.Constants;

public static class IntakeConstants
{
    public static readonly Intake IntakePrimeiroSemestre =
        Intake.Criar("1º semestre", new Vigencia(new DateTime(2024, 01, 01, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 06, 30, 0, 0, 0, DateTimeKind.Local)))
        .ObterRetorno() ?? throw new ArgumentException("Erro ao criar o intake 1º semestre");
    
    public static readonly Intake IntakeSegundoSemestre =
         Intake.Criar("2º semestre", new Vigencia(new DateTime(2024, 07, 01, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 12, 31, 0, 0, 0, DateTimeKind.Local)))
         .ObterRetorno() ?? throw new ArgumentException("Erro ao criar o intake 2º semestre");
}