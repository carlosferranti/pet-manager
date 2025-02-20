using Anima.Inscricao.Application._Shared.Commands;
using Anima.Inscricao.Application._Shared.DTOs;

namespace Anima.Inscricao.Application.UseCases.Campos.CriarCampo;

public class CriarCampoCommand : ICommand<EntityKeyDto?>
{
    public string Nome { get; set; } = string.Empty;
}