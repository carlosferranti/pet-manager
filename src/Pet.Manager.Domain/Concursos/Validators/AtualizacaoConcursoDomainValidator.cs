using Anima.Inscricao.Domain._Shared.Validations;
using Anima.Inscricao.Domain.Concursos.Entities;

namespace Anima.Inscricao.Domain.Concursos.Validators;

public class AtualizacaoConcursoDomainValidator : DomainValidator
{
    private readonly IConcursoRepository _concursoRepository;

    public AtualizacaoConcursoDomainValidator(IConcursoRepository concursoRepository)
    {
        _concursoRepository = concursoRepository;
    }

    public bool Validate(ConcursoId concursoId, string nome, string periodoLetivo)
    {
        return !Validations.Any();
    }
}
