using Anima.Inscricao.Application.DTOs.SistemasIntegracao;

namespace Anima.Inscricao.Application.DTOs.Instituicao;

public class InstituicaoDto
{
    public Guid Key { get; init; }

    public string Nome { get; init; } = string.Empty;

    public string Sigla { get; init; } = string.Empty;

    public Guid MarcaKey { get; init;}

    public List<SistemaIntegracaoDto>? Integracoes { get; set; } = new();
}
