using Anima.Inscricao.Application.DTOs.Acessibilidades;

namespace Anima.Inscricao.Application.DTOs.Deficiencias;

public class DeficienciaAcessibilidadeDto
{
    public Guid Key { get; set; }

    public string Nome { get; set; }

    public List<AcessibilidadeDto> Acessibilidades { get; set; }
}
