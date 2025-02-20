using Anima.Inscricao.Application._Shared.Commands;
using Anima.Inscricao.Application._Shared.DTOs;
using Anima.Inscricao.Application.DTOs.SistemasIntegracao;

namespace Anima.Inscricao.Application.UseCases.Marcas.CriarMarca;

public class CriarMarcaCommand : ICommand<EntityKeyDto?>
{
    public string Nome { get; set; } = string.Empty;

    public string Sigla { get; set; } = string.Empty;

    public SistemaIntegracaoDto? Integracao { get; set; }
}
