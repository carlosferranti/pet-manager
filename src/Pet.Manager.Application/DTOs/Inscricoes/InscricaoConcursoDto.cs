using System.Text.Json.Serialization;

using Anima.Inscricao.Application.DTOs.Intakes;
using Anima.Inscricao.Application.DTOs.Modalidades;
using Anima.Inscricao.Application.DTOs.OfertaConcursos;
using Anima.Inscricao.Application.DTOs.SistemasIntegracao;

namespace Anima.Inscricao.Application.DTOs.Inscricoes;

public class InscricaoConcursoDto
{
    public Guid? Key { get; set; }

    public string? Nome { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public SistemaIntegracaoDto? Integracao { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public IntakeDto? Intake { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public ModalidadeDto? Modalidade { get; set; }

}