using Anima.Inscricao.Domain._Shared.Validations;
using Anima.Inscricao.Domain.Concursos.Entities;

namespace Anima.Inscricao.Domain.Concursos.Validators;

public class RemoverConcursoDomainValidator : DomainValidator
{
    public bool Validate(ConcursoId concursoId)
    {
        //TODO: Implementar validações de dominio para remoção do concurso.
        return true;
    }
}