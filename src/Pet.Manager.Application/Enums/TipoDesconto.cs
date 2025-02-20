using System.ComponentModel;

namespace Anima.Inscricao.Application.Enums;

public enum TipoDesconto
{
    [Description("Porcentagem")]
    Porcentagem = 1,

    [Description("Valor")]
    Valor = 2
}
