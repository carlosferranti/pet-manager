using Anima.Inscricao.Application.DTOs.SistemasIntegracao;

namespace Anima.Inscricao.Application.DTOs._Shared;

public class ItemListaIntegracaoDto
{
    public Guid? Key { get; set; }

    public string? Nome { get; set; }

    public List<SistemaIntegracaoDto>? Integracoes { get; set; }
}
