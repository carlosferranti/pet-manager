using System.Text.Json.Serialization;

using Anima.Inscricao.Application._Shared.Commands;
using Anima.Inscricao.Application._Shared.DTOs;
using Anima.Inscricao.Application.DTOs.Concursos;
using Anima.Inscricao.Application.DTOs.SistemasIntegracao;

namespace Anima.Inscricao.Application.UseCases.Concursos.AtualizarConcurso;

public class AtualizarConcursoCommand : ICommand
{
    [JsonIgnore]
    public Guid Key { get; set; }

    public string Nome { get; set; } = string.Empty;

    public string PeriodoLetivo { get; set; } = string.Empty;

    public DateTime InicioInscricao { get; set; }

    public DateTime TerminoInscricao { get; set; }

    public DateTime? InicioProva { get; set; }

    public DateTime? TerminoProva { get; set; }

    public DateTime? DivulgacaoResultado { get; set; }

    public Guid TipoFormacaoKey { get; set; }

    public List<EntityKeyDto> FormasEntrada { get; set; } = new();

    public Guid ModalidadeKey { get; set; }

    public ConcursoParametrosDto? Parametros { get; set; }

    public List<SistemaIntegracaoDto>? IntegracaoFormaProva { get; set; }

    public Guid? ModalidadeAvaliacaoKey { get; set; }
}
