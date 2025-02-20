using Anima.Inscricao.Domain._Shared.Entities;
using Anima.Inscricao.Domain.Modalidades.Entities;

namespace Anima.Inscricao.Domain.Concursos.Entities;

public class ConcursoModalidade : Entity<ConcursoModalidadeId>
{
    protected ConcursoModalidade()
    {
        ModalidadeId = 0;
    }

    public ConcursoModalidade(ModalidadeId modalidadeId)
        : base()
    {
        ModalidadeId = modalidadeId;
    }

    public ModalidadeId ModalidadeId { get; protected set; }
}