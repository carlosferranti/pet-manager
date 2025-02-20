using Anima.Inscricao.Application._Shared.DTOs;

namespace Anima.Inscricao.Application.DTOs.Links;

public class LinkDto
{
    public Guid Key { get; set; }

    public string Nome { get; set; } = string.Empty;

    public List<EntityKeyDto> FormasEntrada { get; set; } = new();
}