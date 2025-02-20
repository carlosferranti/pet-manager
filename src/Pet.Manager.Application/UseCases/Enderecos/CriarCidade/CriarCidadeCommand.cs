using Anima.Inscricao.Application._Shared.Commands;
using Anima.Inscricao.Application._Shared.DTOs;
using Anima.Inscricao.Application.DTOs.SistemasIntegracao;

namespace Anima.Inscricao.Application.UseCases.Enderecos.CriarCidade;

public class CriarCidadeCommand : ICommand<EntityKeyDto?>
{
    public string Nome { get; set; } = string.Empty;

    public Guid EstadoKey { get; set; }

    public int? CodigoMunicipio { get; set; }

    public int? Ddd { get; set; }

    public SistemaIntegracaoDto? Integracao { get; set; }
}