using System.Text.Json.Serialization;

using Anima.Inscricao.Domain._Shared.Entities.Events;
using Anima.Inscricao.Domain.Campi.Entities;
using Anima.Inscricao.Domain.Cursos.Entities;
using Anima.Inscricao.Domain.Instituicoes.Entities;
using Anima.Inscricao.Domain.Turnos.Entities;

namespace Anima.Inscricao.Domain.Produtos.Events;

public class ProdutoCriadoEvent : EventNotification
{
    public ProdutoCriadoEvent(Guid key,
    InstituicaoId instituicaoId,
    CampusId campusId,
    CursoId cursoId,
    TurnoId turnoId,
    string sku)
    {
        Key = key;
        InstituicaoId = instituicaoId;
        CampusId = campusId;
        CursoId = cursoId;
        TurnoId = turnoId;
        Sku = sku;
    }

    public Guid Key { get; }

    [JsonIgnore]
    public InstituicaoId InstituicaoId { get; }

    [JsonIgnore]
    public CampusId CampusId { get; }

    [JsonIgnore]
    public CursoId CursoId { get; }

    [JsonIgnore]
    public TurnoId TurnoId { get; }

    [JsonIgnore]
    public string Sku { get; }
}
