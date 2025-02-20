using Anima.Inscricao.Domain._Shared.Validations;

namespace Anima.Inscricao.Domain.Configuracoes.Validators;

public class NovaConfiguracaoDomainValidator : DomainValidator
{
    private readonly IConfiguracaoRepository _configuracaoRepository;

    public NovaConfiguracaoDomainValidator(IConfiguracaoRepository configuracaoRepository)
    {
        _configuracaoRepository = configuracaoRepository;
    }

    public bool Validate(string chaveGenerica)
    {
        var chaveExiste = _configuracaoRepository
            .GetQueryable()
            .Where(o => o.ChaveGenerica.Trim().ToUpper().Equals(chaveGenerica.Trim().ToUpper()))
            .Any();

        if (chaveExiste)
        {
            Validations.Add(new InfoValidation("ChaveGenerica", "ConfiguracaoChaveGenericaUnica", "A chaveGenerica da configuração já está sendo utilizada."));
        }

        return !Validations.Any();
    }
}
