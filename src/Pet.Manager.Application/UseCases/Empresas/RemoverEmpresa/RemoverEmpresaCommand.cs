using System.Text.Json.Serialization;

using Anima.Inscricao.Application._Shared.Commands;

namespace Anima.Inscricao.Application.UseCases.Empresas.RemoverEmpresa;

public class RemoverEmpresaCommand : ICommand
{
    [JsonIgnore]
    public Guid Key { get; set; }
}
