using Anima.Inscricao.Application.DTOs.FormasEntrada;
using Anima.Inscricao.Application.DTOs.Modalidades;
using Anima.Inscricao.Application.DTOs.ModalidadesAvaliacao;
using Anima.Inscricao.Application.DTOs.SistemasIntegracao;
using Anima.Inscricao.Application.DTOs.TiposFormacao;

namespace Anima.Inscricao.Application.DTOs.Concursos;

public class ConcursoDto
{
    public Guid Key { get; set; }

    public string Nome { get; set; } = string.Empty;

    public string PeriodoLetivo { get; set; } = string.Empty;

    public DateTime InicioInscricao { get; set; }

    public DateTime TerminoInscricao { get; set; }

    public DateTimeOffset? InicioProva { get; set; }

    public DateTimeOffset? TerminoProva { get; set; }

    public DateTime? DivulgacaoResultado { get; set; }

    public TipoFormacaoDto TipoFormacao { get; set; } = new();

    public List<FormaEntradaDto> FormasEntrada { get; set; } = new();

    public ModalidadeDto Modalidade { get; set; } = new();

    public ConcursoParametrosDto? Parametros { get; set; }

    public SistemaIntegracaoDto? Integracao { get; set; }

    public List<SistemaIntegracaoDto>? IntegracaoFormaProva { get; set; }

    public ModalidadeAvaliacaoDto? ModalidadeAvaliacao { get; set; }
}