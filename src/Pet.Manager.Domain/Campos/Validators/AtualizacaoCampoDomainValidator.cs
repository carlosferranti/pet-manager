using Anima.Inscricao.Domain._Shared.Validations;
using Anima.Inscricao.Domain.Campos.Entities;

namespace Anima.Inscricao.Domain.Campos.Validators;

public class AtualizacaoCampoDomainValidator : DomainValidator
{
    private readonly ICampoRepository _campoRepository;

    public AtualizacaoCampoDomainValidator(ICampoRepository campoRepository)
    {
        _campoRepository = campoRepository;
    }

    public bool Validate(CampoId campoId, string nome)
    {
        var nomeNaoEhUnico = _campoRepository
            .GetQueryable()
            .Where(o => o.Id != campoId &&
             o.Nome.TrimStart().TrimEnd().ToUpper().Equals(nome.TrimStart().TrimEnd().ToUpper()))
        .Any()!;

        if (nomeNaoEhUnico)
        {
            Validations.Add(new InfoValidation("Nome", "CampoUnico", "O nome do campo já está sendo utilizado."));
        }

        return !Validations.Any();
    }
}
