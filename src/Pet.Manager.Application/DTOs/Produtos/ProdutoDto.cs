namespace Anima.Inscricao.Application.DTOs.Produtos;

public class ProdutoDto
{

    public Guid Key { get; set; }

    public Guid InstituicaoKey { get; set; }

    public Guid CampusKey { get; set; }

    public Guid CursoKey { get; set; }

    public Guid TurnoKey { get; set; }

    public string Sku { get; set;} = string.Empty;
}
