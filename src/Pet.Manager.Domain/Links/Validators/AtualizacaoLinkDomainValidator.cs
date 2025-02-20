using Anima.Inscricao.Domain._Shared.Validations;
using Anima.Inscricao.Domain.Links.Entities;

namespace Anima.Inscricao.Domain.Links.Validators;

public class AtualizacaoLinkDomainValidator : DomainValidator
{
    private readonly ILinkRepository _linkRepository;

    public AtualizacaoLinkDomainValidator(ILinkRepository linkRepository)
    {
        _linkRepository = linkRepository;
    }

    public bool Validate(LinkId linkId, string nome)
    {
        var linkExiste = _linkRepository
            .GetQueryable()
            .Where(l => l.Id != linkId &&
                l.Nome.Trim().ToUpper() == nome.Trim().ToUpper())
            .Any();

        if (linkExiste)
        {
            Validations.Add(new InfoValidation("Link", "LinkUnico", "Já existe um link com o mesmo nome."));
        }

        return !Validations.Any();
    }
}