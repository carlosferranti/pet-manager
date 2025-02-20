using Anima.Inscricao.Application._Shared.Commands;
using Anima.Inscricao.Application._Shared.DTOs;
using Anima.Inscricao.Application.DTOs.SistemasIntegracao;
using Anima.Inscricao.Domain.Escolas.Enums;

namespace Anima.Inscricao.Application.UseCases.Escolas.CriarEscola;

public class CriarEscolaCommand : ICommand<EntityKeyDto?>
{
    public string Nome { get; set; } = string.Empty;

    public int? CodigoInep { get; set; }

    public Guid? CidadeKey { get; set; }

    public SistemaIntegracaoDto? Integracao { get; set; }

    public TipoCategoriaEscola TipoCategoria { get; set; }
}