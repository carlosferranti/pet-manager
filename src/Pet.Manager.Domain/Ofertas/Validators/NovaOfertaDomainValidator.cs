using Anima.Inscricao.Domain._Shared.Validations;
using Anima.Inscricao.Domain.Intakes.Entities;
using Anima.Inscricao.Domain.Produtos.Entities;

namespace Anima.Inscricao.Domain.Ofertas.Validators;

public class NovaOfertaDomainValidator : DomainValidator
{
    private readonly IOfertaRepository _ofertaRepository;

    public NovaOfertaDomainValidator(IOfertaRepository ofertaRepository)
    {
        _ofertaRepository = ofertaRepository;
    }

    public bool Validate(ProdutoId produtoId, IntakeId intakeId)
    {
        var ofertaExiste = _ofertaRepository
            .GetQueryable()
            .Where(c => c.ProdutoId == produtoId &&
            c.IntakeId == intakeId)
            .Any();

        if (ofertaExiste)
        {
            Validations.Add(new InfoValidation("Nome", "OfertaUnico", "Uma oferta com as mesmas informações já foi cadastrada."));
        }

        return !Validations.Any();
    }
}
