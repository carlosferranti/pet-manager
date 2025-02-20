using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Anima.Inscricao.Domain._Shared.Entities;

namespace Anima.Inscricao.Domain.Concursos.Entities;

public record ConcursoModalidadeId : EntityId
{
    public ConcursoModalidadeId(int concursoModalidadeId)
        : base(concursoModalidadeId) { }

    public static implicit operator ConcursoModalidadeId(int id)
    {
        return new ConcursoModalidadeId(id);
    }
    public static implicit operator int(ConcursoModalidadeId concursoModalidadeId)
    {
        return concursoModalidadeId.Id;
    }
}