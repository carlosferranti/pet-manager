namespace Anima.Inscricao.Domain.Concursos.Entities;

public class ConcursoParametros
{
    protected ConcursoParametros()
    {
    }

    public ConcursoParametros(
        bool solicitaAnoInscricaoEnem,
        bool exigeAceiteDeferimento,
        bool recebeDocumentoConclusaoEnsinoSuperior)
    {
        SolicitaAnoInscricaoEnem = solicitaAnoInscricaoEnem;
        ExigeAceiteDeferimento = exigeAceiteDeferimento;
        RecebeDocumentoConclusaoEnsinoSuperior = recebeDocumentoConclusaoEnsinoSuperior;
    }

    public bool SolicitaAnoInscricaoEnem { get; protected set; }

    public bool ExigeAceiteDeferimento { get; protected set; }

    public bool RecebeDocumentoConclusaoEnsinoSuperior { get; protected set; }
}
