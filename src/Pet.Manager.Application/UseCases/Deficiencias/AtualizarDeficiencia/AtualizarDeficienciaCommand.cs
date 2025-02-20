using System.Text.Json.Serialization;

using Anima.Inscricao.Application._Shared.Commands;

namespace Anima.Inscricao.Application.UseCases.Deficiencias.AtualizarDeficiencia;

public class AtualizarDeficienciaCommand : ICommand
{
    [JsonIgnore]
    public Guid Key { get; set; }

    public string Nome { get; set; } = string.Empty;

    public int? OrdemExibicao { get; set; }
}
