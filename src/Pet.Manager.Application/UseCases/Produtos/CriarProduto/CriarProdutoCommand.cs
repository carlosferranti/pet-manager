using Anima.Inscricao.Application._Shared.Commands;
using Anima.Inscricao.Application._Shared.DTOs;
using Anima.Inscricao.Application.DTOs.SistemasIntegracao;

namespace Anima.Inscricao.Application.UseCases.Produtos.CriarProduto;

public class CriarProdutoCommand : ICommand<EntityKeyDto?>
{
    public Guid InstituicaoKey { get; set; }

    public Guid CampusKey { get; set; }

    public Guid CursoKey { get; set; }

    public Guid TurnoKey { get; set; }

    public string Sku { get; set; } = string.Empty;

    public SistemaIntegracaoDto? Integracao { get; set; }
}
