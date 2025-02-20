using System.Text.Json.Serialization;

using Anima.Inscricao.Domain._Shared.Entities.Events;
using Anima.Inscricao.Domain._Shared.ValueObjects;
using Anima.Inscricao.Domain.ModalidadesAvaliacao.Entities;

namespace Anima.Inscricao.Domain.Concursos.Events;

public class ConcursoAtualizadoEvent : EventNotification
{
    public ConcursoAtualizadoEvent(Guid key, string nome, string periodoLetivo, Vigencia vigenciaInscricao, DateTimeOffset? inicioProva, DateTimeOffset? terminoProva, DateTime? divulgacaoResultado, ModalidadeAvaliacaoId? modalidadeAvaliacaoId)
    {
        Key = key;
        Nome = nome;
        PeriodoLetivo = periodoLetivo;
        VigenciaInscricao = vigenciaInscricao;
        InicioProva = inicioProva;
        TerminoProva = terminoProva;
        DivulgacaoResultado = divulgacaoResultado;
        ModalidadeAvaliacaoId = modalidadeAvaliacaoId;
    }

    public Guid Key { get; }

    public string Nome { get; }

    public string PeriodoLetivo { get; }

    public Vigencia VigenciaInscricao { get; }

    public DateTimeOffset? InicioProva { get; }

    public DateTimeOffset? TerminoProva { get; }

    public DateTime? DivulgacaoResultado { get; }

    [JsonIgnore]
    public ModalidadeAvaliacaoId? ModalidadeAvaliacaoId { get; }
}
