using Anima.Inscricao.Domain._Shared.Validations;
using Anima.Inscricao.Domain.Intakes.Entities;
using Anima.Inscricao.Domain.Ofertas.Entities;
using Anima.Inscricao.Domain.Produtos.Entities;

namespace Anima.Inscricao.Domain.Ofertas.Validators;

public class AtualizacaoOfertaDomainValidator : DomainValidator
{
    private readonly IOfertaRepository _ofertaRepository;

    public AtualizacaoOfertaDomainValidator(IOfertaRepository ofertaRepository)
    {
        _ofertaRepository = ofertaRepository;
    }

    public bool Validate(OfertaId ofertaId, ProdutoId produtoId, IntakeId intakeId)
    {
        var ofertaExiste = _ofertaRepository
            .GetQueryable()
            .Where(c => c.ProdutoId == produtoId &&
            c.IntakeId == intakeId &&
            c.Id != ofertaId)
            .Any();

        if(ofertaExiste)
        {
            Validations.Add(new InfoValidation("Nome", "OfertaUnico", "Uma oferta com as mesmas informações já foi salva."));
        }

        return !Validations.Any();
    }
}
