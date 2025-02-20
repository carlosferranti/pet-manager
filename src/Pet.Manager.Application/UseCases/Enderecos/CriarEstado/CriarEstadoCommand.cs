using Anima.Inscricao.Application._Shared.Commands;
using Anima.Inscricao.Application._Shared.DTOs;
using Anima.Inscricao.Application.DTOs.SistemasIntegracao;

namespace Anima.Inscricao.Application.UseCases.Enderecos.CriarEstado;

public class CriarEstadoCommand : ICommand<EntityKeyDto?>
{
    public string Nome { get; set; } = string.Empty;

    public string Sigla { get; set; } = string.Empty;

    public Guid PaisKey { get; set; }

    public SistemaIntegracaoDto? Integracao { get; set; }
}
