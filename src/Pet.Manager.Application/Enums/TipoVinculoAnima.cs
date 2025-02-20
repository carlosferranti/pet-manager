using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anima.Inscricao.Application.Enums;

public enum TipoVinculoAnima
{
    [Description("Ativo")]
    Ativo = 1,

    [Description("Abandono")]
    Abandono = 2,

    [Description("Trancado")]
    Trancado = 3,

    [Description("Concluido")]
    Concluido = 4,

    [Description("Não Vinculado")]
    NaoVinculado = 5,
}
