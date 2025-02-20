using Anima.Inscricao.Domain._Shared.Validations;

namespace Anima.Inscricao.Domain.Links.Validators;

public class NovoLinkDomainValidator : DomainValidator
{
    private readonly ILinkRepository _linkRepository;

    public NovoLinkDomainValidator(ILinkRepository linkRepository)
    {
        _linkRepository = linkRepository;
    }

    public bool Validate(string nome)
    {
        var linkExiste = _linkRepository
            .GetQueryable()
            .Where(l => l.Nome.Trim().ToUpper() == nome.Trim().ToUpper())
            .Any();

        if (linkExiste)
        {
            Validations.Add(new InfoValidation("Link", "LinkUnico", "Já existe um link com o mesmo nome."));
        }

        return !Validations.Any();
    }
}