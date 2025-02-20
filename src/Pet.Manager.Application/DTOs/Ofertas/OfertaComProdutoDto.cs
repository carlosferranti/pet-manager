using Anima.Inscricao.Application.DTOs.Instituicao;
using Anima.Inscricao.Application.DTOs.Intakes;
using Anima.Inscricao.Application.DTOs.Marcas;
using Anima.Inscricao.Application.DTOs.Modalidades;

namespace Anima.Inscricao.Application.DTOs.Ofertas;

public class OfertaComProdutoDto
{
    public Guid Key { get; set; }

    public Guid ProdutoKey { get; set; }

    public Guid IntakeKey { get; set; }

    public MarcaDto Marca { get; set; } = null!;

    public InstituicaoDto Instituicao { get; set; } = null!;

    public IntakeDto Intake { get; set; } = null!;

    public ModalidadeDto? Modalidade { get; set; }
}