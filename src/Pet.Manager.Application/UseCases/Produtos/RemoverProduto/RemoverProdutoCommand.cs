using System.Text.Json.Serialization;

using Anima.Inscricao.Application._Shared.Commands;

namespace Anima.Inscricao.Application.UseCases.Produtos.RemoverProduto;

public class RemoverProdutoCommand : ICommand
{
    [JsonIgnore]
    public Guid Key { get; set; }
}
