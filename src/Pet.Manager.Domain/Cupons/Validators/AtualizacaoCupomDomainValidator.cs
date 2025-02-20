using Anima.Inscricao.Domain._Shared.Validations;
using Anima.Inscricao.Domain.Concursos.Entities;
using Anima.Inscricao.Domain.Cupons.Entities;

namespace Anima.Inscricao.Domain.Cupons.Validators;

public class AtualizacaoCupomDomainValidator : DomainValidator
{
    private readonly ICupomRepository _cupomRepository;

    public AtualizacaoCupomDomainValidator(ICupomRepository cupomRepository)
    {
        _cupomRepository = cupomRepository;
    }

    public bool Validate(CupomId cupomId, ConcursoId concursoId, string codigo)
    {
        var cupomNaoEhUnico = _cupomRepository
            .GetQueryable()
            .Where(o => o.Id != cupomId &&
             o.Codigo.Trim().ToUpper().Equals(codigo.Trim().ToUpper()) &&
             o.ConcursoId == concursoId &&
            (!o.DataValidade.HasValue || o.DataValidade > DateTime.UtcNow))
            .Any()!;

        if (cupomNaoEhUnico)
        {
            Validations.Add(new InfoValidation("Codigo/ConcursoId/DataValidade", 
                                                "CupomUnico", 
                                                "O cupom já está sendo utilizado."));
        }

        return !Validations.Any();
    }
}
