using Anima.Inscricao.Domain._Shared.Validations;
using Anima.Inscricao.Domain.Links.Entities;

namespace Anima.Inscricao.Domain.Links.Validators;

public class RemoverLinkDomainValidator : DomainValidator
{
    public bool Validate(LinkId linkId)
    {
        //TODO: Implementar validações de dominio para remoção do link.
        return true;
    }
}