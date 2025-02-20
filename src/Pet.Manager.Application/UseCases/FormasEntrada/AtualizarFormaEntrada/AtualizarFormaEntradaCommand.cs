using System.Text.Json.Serialization;

using Anima.Inscricao.Application._Shared.Commands;

namespace Anima.Inscricao.Application.UseCases.FormasEntrada.AtualizarFormaEntrada;

public class AtualizarFormaEntradaCommand : ICommand
{
    [JsonIgnore]
    public Guid Key { get; set; }

    public string Nome { get; set; } = string.Empty;

    public string? Descricao { get; set; }

    public int OrdemExibicao { get; set; }

    public bool? ExibeCard { get; set; }

    public Guid? FormaEntradaPaiKey { get; set; }

    public bool? UltimoNivel { get; set; }

}
