using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anima.Inscricao.Application.DTOs.Inscricoes;

public class ValidacaoCoiDto
{
    public bool InstituicaoIgual { get; set; }

    public bool CursoIgual { get; set; }

    public bool CampusIgual { get; set; }

    public bool TurnoIgual { get; set; }

    public bool ModalidadeIgual { get; set; }

}
