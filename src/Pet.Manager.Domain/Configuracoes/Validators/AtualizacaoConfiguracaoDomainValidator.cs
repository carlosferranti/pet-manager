using Anima.Inscricao.Domain._Shared.Validations;
using Anima.Inscricao.Domain.Configuracoes.Entities;

namespace Anima.Inscricao.Domain.Configuracoes.Validators;

public class AtualizacaoConfiguracaoDomainValidator : DomainValidator
{
    private readonly IConfiguracaoRepository _configuracaoRepository;

    public AtualizacaoConfiguracaoDomainValidator(IConfiguracaoRepository configuracaoRepository)
    {
        _configuracaoRepository = configuracaoRepository;
    }

    public bool Validate(ConfiguracaoId configuracaoId, string chaveGenerica)
    {
        var chaveNaoEhUnica = _configuracaoRepository
            .GetQueryable()
            .Where(o => o.Id != configuracaoId &&
                o.ChaveGenerica.Trim().ToUpper().Equals(chaveGenerica.Trim().ToUpper()))
            .Any()!;

        if (chaveNaoEhUnica)
        {
            Validations.Add(new InfoValidation("ChaveGenerica", "ChaveGenericaUnica", "A chaveGenerica da configuração já está sendo utilizada."));
        }

        return !Validations.Any();
    }
}
