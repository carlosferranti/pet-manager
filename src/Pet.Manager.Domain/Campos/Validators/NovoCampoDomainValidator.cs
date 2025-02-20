using Anima.Inscricao.Domain._Shared.Validations;

namespace Anima.Inscricao.Domain.Campos.Validators;

public class NovoCampoDomainValidator : DomainValidator
{
    private readonly ICampoRepository _campoRepository;

    public NovoCampoDomainValidator(ICampoRepository campoRepository)
    {
        _campoRepository = campoRepository;
    }

    public bool Validate(string nome)
    {
        var nomeExiste = _campoRepository
            .GetQueryable()
        .Where(o => o.Nome.TrimStart().TrimEnd().ToUpper().Equals(nome.TrimStart().TrimEnd().ToUpper()))
        .Any();

        if (nomeExiste)
        {
            Validations.Add(new InfoValidation("Nome", "CampoUnico", "O nome do campo já está sendo utilizado."));
        }

        return !Validations.Any();
    }
}
