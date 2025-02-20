using Anima.Inscricao.Domain._Shared.Validations;

namespace Anima.Inscricao.Domain.Concursos.Validators;

public class NovoConcursoDomainValidator : DomainValidator
{
    private readonly IConcursoRepository _concursoRepository;

    public NovoConcursoDomainValidator(IConcursoRepository concursoRepository)
    {
        _concursoRepository = concursoRepository;
    }

    public bool Validate(string nome, string periodoLetivo)
    {
        return !Validations.Any();
    }
}