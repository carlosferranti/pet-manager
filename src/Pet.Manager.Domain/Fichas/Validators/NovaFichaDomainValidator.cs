using Anima.Inscricao.Domain._Shared.Validations;

namespace Anima.Inscricao.Domain.Fichas.Validators;

public class NovaFichaDomainValidator : DomainValidator
{
    private readonly IFichaRepository _fichaRepository;

    public NovaFichaDomainValidator(IFichaRepository fichaRepository)
    {
        _fichaRepository = fichaRepository;
    }

    public bool Validate(string nome, bool novafichaEhPadrao)
    {
        var fichaExiste = _fichaRepository
            .GetQueryable()
            .Where(f => f.Nome.TrimStart().TrimEnd().ToUpper().Equals(nome.TrimStart().TrimEnd().ToUpper()))
            .Any();

        if (fichaExiste)
        {
            Validations.Add(new InfoValidation("Ficha", "FichaNomeUnico", "O nome da ficha já está sendo utilizado."));
        }

        var existeFichaPadraoAtiva = _fichaRepository
           .GetQueryable()
           .Where(f => f.Padrao && f.Status.Ativo)
           .Any();

        if (existeFichaPadraoAtiva && novafichaEhPadrao)
        {
            Validations.Add(new InfoValidation("Ficha", "FichaPadraoUnica", "Já existe uma ficha padrão no sistema."));
        }

        return !Validations.Any();
    }
}