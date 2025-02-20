using System.Text.Json.Serialization;

using Anima.Inscricao.Application.DTOs.SistemasIntegracao;
using Anima.Inscricao.Domain.Escolas.Enums;

namespace Anima.Inscricao.Application.DTOs.Escola;

public class EscolaDto
{
    public Guid? Key { get; set; }

    public string? Nome { get; set; } = string.Empty;

    public int? CodigoInep { get; set; }

    public Guid? CidadeKey { get; set; }

    public TipoCategoriaEscola TipoCategoria { get; set; }

    public Guid? InstituicaoKey { get; set; }

    public SistemaIntegracaoDto? Integracao { get; set; }
}
