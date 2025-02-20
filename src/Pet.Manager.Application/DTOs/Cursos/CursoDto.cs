using Anima.Inscricao.Application.DTOs.SistemasIntegracao;

namespace Anima.Inscricao.Application.DTOs.Cursos;

public class CursoDto
{
    public Guid Key { get; set; }

    public string Nome { get; set; } = string.Empty;

    public string? NomeComercial { get; set; }

    public Guid ModalidadeKey { get; set; }

    public Guid TipoFormacaoKey { get; set; }

    public Guid NivelFormacaoKey { get; set; }

    public Guid InstituicaoKey { get; set; }

    public SistemaIntegracaoDto? Integracao { get; set; }
}
