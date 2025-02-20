using System.Text.Json.Serialization;

using Anima.Inscricao.Application.DTOs._Shared;
using Anima.Inscricao.Application.DTOs.Escola;
using Anima.Inscricao.Domain.Inscricoes.Enums;

namespace Anima.Inscricao.Application.DTOs.Inscricoes;

public class InscricaoEscolaridadeDto
{
    public bool InstituicaoEstrangeira { get; set; }

    public int? AnoConclusao { get; set; }

    public EscolaDto? Escola { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? OutraEscola { get; set; }

    public ItemDto? Estado { get; set; }

    public ItemDto? Cidade { get; set; }

    public TipoEscolaridadeInscricao Nivel { get; set; }

    public int CodigoNivel { get; set; }

    public ItemListaIntegracaoDto? Curso { get; set; }
}