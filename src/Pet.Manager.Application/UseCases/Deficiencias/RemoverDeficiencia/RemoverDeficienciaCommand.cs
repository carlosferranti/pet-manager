using System.Text.Json.Serialization;

using Anima.Inscricao.Application._Shared.Commands;

namespace Anima.Inscricao.Application.UseCases.Deficiencias.RemoverDeficiencia;

public class RemoverDeficienciaCommand : ICommand
{
    [JsonIgnore]
    public Guid Key { get; set; }
}