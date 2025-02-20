using Anima.Inscricao.Application.DTOs.SistemasIntegracao;

namespace Anima.Inscricao.Application.DTOs.Inscricoes;

public class InscricaoMarcaDto
{
    public Guid Key { get; init; }

    public string Nome { get; init; } = string.Empty;

    public string Sigla { get; init; } = string.Empty;

    public List<SistemaIntegracaoDto>? Integracoes { get; set; }
}
