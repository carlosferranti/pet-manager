using Anima.Inscricao.Domain._Shared.Entities.Events;
using Anima.Inscricao.Domain.Concursos.Entities;

namespace Anima.Inscricao.Domain.Cupons.Events;

public class CupomAtualizadoEvent : EventNotification
{
    public CupomAtualizadoEvent(Guid key, ConcursoId concursoId, string codigo, string descricao, int tipoDesconto, float valorDesconto, DateTime? dataValidade)
    {
        Key = key;
        ConcursoId = concursoId;
        Codigo = codigo;
        Descricao = descricao;
        TipoDesconto = tipoDesconto;
        ValorDesconto = valorDesconto;
        DataValidade = dataValidade;
    }

    public Guid Key { get; set; }

    public string Codigo { get; set; }

    public string Descricao { get; set; }

    public int TipoDesconto { get; set; }

    public float ValorDesconto { get; set; }

    public DateTime? DataValidade { get; set; }

    public ConcursoId ConcursoId { get; set; }
}
