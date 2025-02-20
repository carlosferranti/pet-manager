using Anima.Inscricao.Application._Shared.Commands;

namespace Anima.Inscricao.Application.UseCases.Cupons.AtualizarCupom;

public class AtualizarCupomCommand : ICommand
{
    public Guid Key { get; set; }

    public Guid ConcursoKey { get; set; }

    public string Codigo { get; set; } = string.Empty;

    public string Descricao { get; set; } = string.Empty;

    public float ValorDesconto { get; set; }

    public int TipoDesconto { get; set; }

    public DateTime? DataValidade { get; set; }
}
