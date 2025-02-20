using System.Text.Json.Serialization;

using Anima.Inscricao.Application._Shared.Commands;

namespace Anima.Inscricao.Application.UseCases.Enderecos.AtualizarCidade;

public class AtualizarCidadeCommand : ICommand
{
    [JsonIgnore]
    public Guid Key { get; set; }

    public string Nome { get; set; } = string.Empty;

    public Guid EstadoKey { get; set; }

    public int? CodigoMunicipio { get; set; }

    public int? Ddd { get; set; }
}