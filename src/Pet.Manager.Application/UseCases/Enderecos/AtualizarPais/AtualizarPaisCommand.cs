using System.Text.Json.Serialization;

using Anima.Inscricao.Application._Shared.Commands;

namespace Anima.Inscricao.Application.UseCases.Enderecos.AtualizarPais;

public class AtualizarPaisCommand : ICommand
{
    [JsonIgnore]
    public Guid Key { get; set; }

    public string Nome { get; set; } = string.Empty;

    public string Sigla { get; set; } = string.Empty;

    public string SiglaAbreviada { get; set; } = string.Empty;

    public string? Tipo { get; set; }
}