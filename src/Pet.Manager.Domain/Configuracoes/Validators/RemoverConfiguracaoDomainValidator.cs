using Anima.Inscricao.Domain._Shared.Validations;
using Anima.Inscricao.Domain.Configuracoes.Entities;

namespace Anima.Inscricao.Domain.Configuracoes.Validators;

public class RemoverConfiguracaoDomainValidator : DomainValidator
{
    public bool Validate(ConfiguracaoId configuracaoId)
    {
        //TODO: Implementar validações de domínio para remoção de campus
        return true;
    }
}
