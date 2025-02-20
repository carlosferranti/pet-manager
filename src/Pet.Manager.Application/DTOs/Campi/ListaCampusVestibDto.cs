using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anima.Inscricao.Application.DTOs.Inscricoes;

public class CampusVestibDto
{
    [Column("CODCAM")] public string CodigoCampus { get; set; } = null!;
    [Column("COD_CAMPUS_SIAF")] public string? CodigoCampusSiaf { get; set; }
    [Column("DSC_AGRUPAMENTO")] public string? NomeCampusAgrupamento { get; set; }
}
