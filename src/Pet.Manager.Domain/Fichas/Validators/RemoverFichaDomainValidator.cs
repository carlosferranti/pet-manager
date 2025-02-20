using Anima.Inscricao.Domain._Shared.Validations;
using Anima.Inscricao.Domain.Fichas.Entities;

namespace Anima.Inscricao.Domain.Fichas.Validators;

public class RemoverFichaDomainValidator : DomainValidator
{
    public bool Validate(FichaId fichaId)
    {
        //TODO: Implementar validações de dominio para remoção da ficha.
        return true;
    }
}

