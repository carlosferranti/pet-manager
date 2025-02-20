using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain.TiposFormacao.Entities;

namespace Anima.Inscricao.Domain.Concursos.Entities;

public class ConcursoTipoFormacao : Entity<ConcursoTipoFormacaoId>
{
    protected ConcursoTipoFormacao()
    {
        TipoFormacaoId = 0;
    }

    public ConcursoTipoFormacao(TipoFormacaoId tipoFormacaoId)
        : base()
    {
        TipoFormacaoId = tipoFormacaoId;
    }

    public TipoFormacaoId TipoFormacaoId { get; protected set; }
}