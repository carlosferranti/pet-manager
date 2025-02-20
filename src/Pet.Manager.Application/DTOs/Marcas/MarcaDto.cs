using Anima.Inscricao.Application.DTOs.SistemasIntegracao;

namespace Anima.Inscricao.Application.DTOs.Marcas;

public class MarcaDto
{
    public Guid Key { get; init; }

    public string Nome { get; init; } = string.Empty;

    public string Sigla { get; init; } = string.Empty;

    public List<SistemaIntegracaoDto>? IntegracaoSistema { get; set; }
}
