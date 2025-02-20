using Anima.Inscricao.Application.Enums;

namespace Anima.Inscricao.Application.DTOs.Candidatos;

public class DiarioClasseCandidatoDto
{
    public string? CodigoAluno { get; set; }

    public string? NomeAluno { get; set; }

    public string? CpfAluno { get; set; }

    public string? CodigoFormaIngresso { get; set; }

    public StatusMatricula CodigoStatusAluno { get; set; }

    public long CodigoInstituicao { get; set; }

    public DateTime InicioPeriodoLetivo { get; set; }

    public DateTime TerminoPeriodoLetivo { get; set; }

    public TipoStatusDiarioClasse CodigoStatusDiario { get; set; }

    public string StatusDiario { get; set; } = string.Empty;
}