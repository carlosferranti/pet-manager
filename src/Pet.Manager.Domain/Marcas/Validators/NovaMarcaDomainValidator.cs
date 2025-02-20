using Anima.Inscricao.Domain._Shared.Validations;
using Anima.Inscricao.Domain.Marcas.Entities;

namespace Anima.Inscricao.Domain.Marcas.Validators;

public class NovaMarcaDomainValidator : DomainValidator
{
    private readonly IMarcaRepository _marcaRepository;

    public NovaMarcaDomainValidator(IMarcaRepository marcaRepository)
    {
        _marcaRepository = marcaRepository;
    }

    public bool Validate(string nome, string sigla)
    {
        var nomeNaoEhUnico = _marcaRepository.GetQueryable()
            .Where(m => m.Nome.Trim().ToUpper().Equals(nome.Trim().ToUpper()) &&
                m.Sigla.Trim().ToUpper().Equals(sigla.Trim().ToUpper()))
            .Any();

        if (nomeNaoEhUnico)
        {
            Validations.Add(new InfoValidation("Nome", "MarcaNomeUnico", "O nome da marca já está sendo utilizado."));
        }

        return !Validations.Any();
    }
}
