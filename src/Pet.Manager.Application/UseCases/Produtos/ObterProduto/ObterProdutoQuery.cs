using System.Text.Json.Serialization;

using Anima.Inscricao.Application._Shared.Queries;
using Anima.Inscricao.Application.DTOs.Produtos;

namespace Anima.Inscricao.Application.UseCases.Produtos.ObterProduto;

public class ObterProdutoQuery : IQuery<ProdutoDto>
{
    [JsonIgnore]
    public Guid Key { get; set; }
}
