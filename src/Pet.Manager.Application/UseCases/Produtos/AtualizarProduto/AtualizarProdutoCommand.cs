using System.Text.Json.Serialization;

using Anima.Inscricao.Application._Shared.Commands;

namespace Anima.Inscricao.Application.UseCases.Produtos.AtualizarProduto;

public class AtualizarProdutoCommand : ICommand
{
    [JsonIgnore]
    public Guid Key { get; set; }

    public Guid InstituicaoKey { get; set; }

    public Guid CampusKey { get; set; }

    public Guid CursoKey { get; set; }

    public Guid TurnoKey { get; set; }

    public string Sku { get; set; } = string.Empty;
}
