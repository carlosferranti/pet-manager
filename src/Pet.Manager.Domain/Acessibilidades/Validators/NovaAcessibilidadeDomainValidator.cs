using Anima.Inscricao.Domain._Shared.Validations;

namespace Anima.Inscricao.Domain.Acessibilidades.Validators;

public class NovaAcessibilidadeDomainValidator : DomainValidator
{
    private readonly IAcessibilidadeRepository _acessibilidadeRepository;

    public NovaAcessibilidadeDomainValidator(IAcessibilidadeRepository acessibilidadeRepository)
    {
        _acessibilidadeRepository = acessibilidadeRepository;
    }

    public bool Validate(string nome)
    {
        var nomeExiste = _acessibilidadeRepository
            .GetQueryable()
            .Where(o => o.Nome.Trim().ToUpper().Equals(nome.Trim().ToUpper()))
            .Any();

        if (nomeExiste)
        {
            Validations.Add(new InfoValidation("Nome", "AcessibilidadeNomeUnico", "O nome da acessibilidade já está sendo utilizado."));
        }

        return !Validations.Any();
    }
}
