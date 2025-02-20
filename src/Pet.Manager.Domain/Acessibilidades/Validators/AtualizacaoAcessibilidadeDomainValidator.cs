using Anima.Inscricao.Domain._Shared.Validations;
using Anima.Inscricao.Domain.Acessibilidades.Entities;

namespace Anima.Inscricao.Domain.Acessibilidades.Validators;

public class AtualizacaoAcessibilidadeDomainValidator : DomainValidator
{
    private readonly IAcessibilidadeRepository _acessibilidadeRepository;

    public AtualizacaoAcessibilidadeDomainValidator(IAcessibilidadeRepository acessibilidadeRepository)
    {
        _acessibilidadeRepository = acessibilidadeRepository;
    }

    public bool Validate(AcessibilidadeId id, string nome)
    {
        var nomeExiste = _acessibilidadeRepository
            .GetQueryable()
            .Where(o => o.Id != id &&
                   o.Nome.Trim().ToUpper().Equals(nome.Trim().ToUpper()))
            .Any();

        if (nomeExiste)
        {
            Validations.Add(new InfoValidation("Nome", "AcessibilidadeNomeUnico", "O nome da acessibilidade já está sendo utilizado."));
        }

        return !Validations.Any();
    }
}
