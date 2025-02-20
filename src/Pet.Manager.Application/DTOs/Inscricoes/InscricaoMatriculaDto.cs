using Anima.Inscricao.Application.Enums;

namespace Anima.Inscricao.Application.DTOs.Inscricoes;

public class InscricaoMatriculaDto
{
    public string? CodigoAluno { get; set; }

    public string? Ra { get; set; }

    public Guid Key { get; set; }

    public StatusMatricula StatusMatricula { get;  set; }
}
