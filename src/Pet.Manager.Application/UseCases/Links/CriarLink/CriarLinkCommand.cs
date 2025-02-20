using Anima.Inscricao.Application._Shared.Commands;
using Anima.Inscricao.Application._Shared.DTOs;

namespace Anima.Inscricao.Application.UseCases.Links.CriarLink;

public class CriarLinkCommand : ICommand<EntityKeyDto?>
{
    public string Nome { get; set; } = string.Empty;

    public List<EntityKeyDto>? FormasEntrada { get; set; }
}
