using Anima.Inscricao.Domain._Shared.Validations;
using Anima.Inscricao.Domain.Concursos.Entities;

namespace Anima.Inscricao.Domain.Cupons.Validators;

public class NovoCupomDomainValidator : DomainValidator
{
    private readonly ICupomRepository _cupomRepository;

    public NovoCupomDomainValidator(ICupomRepository cupomRepository)
    {
        _cupomRepository = cupomRepository;
    }

    public bool Validate(string codigo, ConcursoId concursoId)
    {
        var cupomExiste = _cupomRepository
            .GetQueryable()
            .Where(o => o.Codigo.Trim().ToUpper().Equals(codigo.Trim().ToUpper()) && 
                   o.ConcursoId == concursoId &&
                   (!o.DataValidade.HasValue || o.DataValidade > DateTime.UtcNow))
            .Any();

        if (cupomExiste)
        {
            Validations.Add(new InfoValidation("Codigo/ConcursoId/DataValidade",
                                                "CupomUnico",
                                                "O cupom já está sendo utilizado."));
        }

        return !Validations.Any();
    }
}
