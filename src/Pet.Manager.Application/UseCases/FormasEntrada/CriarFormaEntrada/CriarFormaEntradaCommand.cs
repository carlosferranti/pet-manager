using Anima.Inscricao.Application._Shared.Commands;
using Anima.Inscricao.Application._Shared.DTOs;
using Anima.Inscricao.Application.DTOs.SistemasIntegracao;

namespace Anima.Inscricao.Application.UseCases.FormasEntrada.CriarFormaEntrada;

public class CriarFormaEntradaCommand : ICommand<EntityKeyDto?>
{
    public string Nome { get; set; } = string.Empty;

    public string? Descricao { get; set; }

    public int OrdemExibicao { get; set; }

    public bool? ExibeCard { get; set; }

    public Guid? FormaEntradaPaiKey { get; set; }

    public bool? UltimoNivel { get; set; }

    public List<SistemaIntegracaoDto>? Integracao { get; set; }
}
