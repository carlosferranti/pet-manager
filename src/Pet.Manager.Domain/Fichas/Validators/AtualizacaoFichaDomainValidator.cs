using Anima.Inscricao.Domain._Shared.Validations;
using Anima.Inscricao.Domain.Fichas.Entities;

namespace Anima.Inscricao.Domain.Fichas.Validators;

public class AtualizacaoFichaDomainValidator : DomainValidator
{
    private readonly IFichaRepository _fichaRepository;

    public AtualizacaoFichaDomainValidator(IFichaRepository fichaRepository)
    {
        _fichaRepository = fichaRepository;
    }

    public bool Validate(FichaId fichaId, string nome, bool novafichaEhPadrao)
    {
        var fichaExiste = _fichaRepository
            .GetQueryable()
            .Where(f => f.Nome.TrimStart().TrimEnd().ToUpper().Equals(nome.TrimStart().TrimEnd().ToUpper()) &&
                        f.Id != fichaId)
        .Any();

        if (fichaExiste)
        {
            Validations.Add(new InfoValidation("Ficha", "FichaNomeUnico", "O nome da ficha já está sendo utilizado."));
        }

        var existeFichaPadraoAtiva = _fichaRepository
            .GetQueryable()
            .Where(f => f.Padrao && f.Status.Ativo && f.Id != fichaId)
            .Any();

        if (existeFichaPadraoAtiva && novafichaEhPadrao)
        {
            Validations.Add(new InfoValidation("Ficha", "FichaPadraoUnica", "Já existe uma ficha padrão no sistema."));
        }

        return !Validations.Any();
    }
}