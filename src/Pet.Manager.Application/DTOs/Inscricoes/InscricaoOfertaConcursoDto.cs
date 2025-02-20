using System.Text.Json.Serialization;

using Anima.Inscricao.Application.DTOs._Shared;
using Anima.Inscricao.Application.DTOs.OfertaConcursos;
using Anima.Inscricao.Application.DTOs.SistemasIntegracao;

namespace Anima.Inscricao.Application.DTOs.Inscricoes;

public class InscricaoOfertaConcursoDto
{
    public Guid? Key { get; set; }

    public string? Nome { get; set; }

    public SistemaIntegracaoDto? Integracao { get; set; }

    public List<SistemaIntegracaoDto>? IntegracaoFormaProva { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public InscricaoConcursoDataProvaDto? Prova { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public List<OpcaoAcessoDto>? OpcaoAcesso { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public ItemDto? Modalidade { get; set; }

    public record InscricaoConcursoDataProvaDto
    {
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public DateTimeOffset? DataInicioProva { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public DateTimeOffset? DataTerminoProva { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? HoraInicioProva { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? HoraTerminoProva { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public DateTime? DivulgacaoResultado { get; set; }
    }

}