using Anima.Inscricao.Application.DTOs.SistemasIntegracao;

namespace Anima.Inscricao.Application.DTOs.Modalidades;

public class ModalidadeDto
{
    public Guid Key { get; init; }

    public string Nome { get; init; } = string.Empty;

    public string? Descricao { get; set; }

    public SistemaIntegracaoDto? Integracao { get; set; }
}
