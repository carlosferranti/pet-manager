using Anima.Inscricao.Application.Enums;
using Anima.Inscricao.Domain.Matriculas.Entities;

namespace Anima.Inscricao.Test._Shared.Constants;

public static class MatriculaConstants
{
    public static readonly Matricula MatriculaTrancada =
        Matricula.Criar("1", "001-01", StatusMatricula.Trancado)
        .ObterRetorno() ?? throw new ArgumentException("Erro ao criar MatriculaTrancada");
}