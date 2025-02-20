using Anima.Inscricao.Application._Shared.Commands;

namespace Anima.Inscricao.Application.UseCases.Cupons.RemoverCupom;

public class RemoverCupomCommand : ICommand
{
    public Guid Key { get; set; }
}
