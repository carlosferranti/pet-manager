using Anima.Inscricao.Application.Enums;
using Anima.Inscricao.Application.Extensions;

namespace Anima.Inscricao.Application.DTOs.Candidatos;

public class CandidatoVinculoDto
{
    public string? Ra { get; set; }

    public string? NomeCurso { get; set; }

    public string? CodigoAluno { get; set; }

    public string? NomeAluno { get; set; }

    public string? NomeUnidade { get; set; }

    public string? NomeTurno { get; set; }

    public string? CodigoFormaIngresso { get; set; }

    public string? NomeFormaIngresso { get; set; }

    public StatusMatricula CodigoStatusAluno { get; set; }

    public string? Status
    { 
        get 
        { 
            return CodigoStatusAluno.Description(); 
        } 
    }

    public long CodigoInstituicao { get; set; }

    public DateTime? DataEntrada { get; set; }

    public string? CodigoConcurso { get; set; }

    public string? IndicadorDigitalLive { get; set; }

    public long? CodigoCampusSiaf { get; set; }

    public long? CodigoStatusFinanceiro { get; set; }

    public long CodigoMarca { get; set; }
}